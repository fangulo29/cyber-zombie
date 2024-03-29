﻿/*
 * Creado por SharpDevelop.
 * Usuario: Pepe
 * Fecha: 02/03/2011
 * Hora: 04:33 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CZServer.Configuracion
{	
	public partial class frmEquipos : frmBase
	{
		private Equipos objEquipos;
		private Tipos objTipos;
		private frmBuscar objBuscarEnRed;
		private frmBuscar objBuscarTipos;
		private frmBuscar objBuscarEquipos;		
		
		public frmEquipos()
		{
			InitializeComponent();
			objEquipos = new Equipos();
			objTipos = new Tipos();			
		}
		
		private void ObtenerDatos()
		{
			if(strEstatus=="Edicion") objEquipos.ID_EQUIPO = int.Parse(txtID.Text);
			objEquipos.ID_TIPO = int.Parse(txtTipo.Tag.ToString());
			objEquipos.IP_EQUIPO = txtIP.Text;
			objEquipos.NOMBRE_EQUIPO = txtNombre.Text;
			objEquipos.CARACTERISTICAS_EQUIPO = txtCaracteristicas.Text;
		}
		
		private void MostrarDatos(int ID)
		{			
			objEquipos.Buscar(ID);
			txtID.Text = objEquipos.ID_EQUIPO.ToString();
			objTipos.Buscar(objEquipos.ID_TIPO);
			txtTipo.Tag = objTipos.ID_TIPO;
			txtTipo.Text = objTipos.NOMBRE_TIPO;
			txtIP.Text = objEquipos.IP_EQUIPO;
			txtNombre.Text = objEquipos.NOMBRE_EQUIPO;
			txtCaracteristicas.Text = objEquipos.CARACTERISTICAS_EQUIPO;
		}
		
		void CmdRedClick(object sender, EventArgs e)
		{			
			if(objBuscarEnRed == null || objBuscarEnRed.IsDisposed == true)
			{
				objBuscarEnRed = new frmBuscar("EquiposRed");
				objBuscarEnRed.dgvBusqueda.DoubleClick += new EventHandler(SeleccionarEquiposRed);
				objBuscarEnRed.cmdSeleccionar.Click += new EventHandler(SeleccionarEquiposRed);
			}
			objBuscarEnRed.MdiParent = this.MdiParent;
			objBuscarEnRed.Show();
		}
		
		private void SeleccionarEquiposRed(object sender,EventArgs e)
		{
			if(objBuscarEnRed != null)
			{
				if(objBuscarEnRed.dgvBusqueda.SelectedRows[0].Cells[0].Value.ToString().Length>0)
				{
					((ListBox)frmPrincipal.ActiveForm.Controls["lstConsola"]).TextChanged += new EventHandler(OrdenConsola);					
					((frmPrincipal)frmPrincipal.ActiveForm).EnviarDatos(objBuscarEnRed.dgvBusqueda.SelectedRows[0].Cells[0].Value.ToString(),"[MC]");					
					objBuscarEnRed.Close();
					objBuscarEnRed = null;
				}
			}
		}
		
		void CmdTiposClick(object sender, EventArgs e)
		{
			if(objBuscarTipos == null)
			{
				objBuscarTipos = new frmBuscar("Tipos");
				objBuscarTipos.dgvBusqueda.DoubleClick += new EventHandler(SeleccionarTipos);
				objBuscarTipos.dgvBusqueda.Click += new EventHandler(SeleccionarTipos);
			}
			objBuscarTipos.MdiParent = this.MdiParent;
			objBuscarTipos.Show();
		}
		
		private void SeleccionarTipos(object sender,EventArgs e)
		{
			if(objBuscarTipos != null)
			{
				if(objBuscarTipos.dgvBusqueda.SelectedRows[0].Cells[0].Value.ToString().Length>0)
				{
					txtTipo.Tag = objBuscarTipos.dgvBusqueda.SelectedRows[0].Cells[0].Value.ToString();
					txtTipo.Text = objBuscarTipos.dgvBusqueda.SelectedRows[0].Cells[1].Value.ToString();
					objBuscarTipos.Close();
					objBuscarTipos = null;
				}
			}
		}
		
		void CmdBuscarClick(object sender, EventArgs e)
		{
			if(objBuscarEquipos == null)
			{
				objBuscarEquipos = new frmBuscar("Equipos");
				objBuscarEquipos.dgvBusqueda.DoubleClick += new EventHandler( SeleccionarEquipos);
				objBuscarEquipos.cmdSeleccionar.Click += new EventHandler( SeleccionarEquipos);
			}
			objBuscarEquipos.MdiParent = this.MdiParent;
			objBuscarEquipos.Show();
		}
		
		private void SeleccionarEquipos(object sender,EventArgs e)
		{
			if(objBuscarEquipos != null)
			{
				if(objBuscarEquipos.dgvBusqueda.SelectedRows[0].Cells[0].Value.ToString().Length>0)
				{
					MostrarDatos(int.Parse(objBuscarEquipos.dgvBusqueda.SelectedRows[0].Cells[0].Value.ToString()));
					objBuscarEquipos.Close();
					objBuscarEquipos =null;
				}
			}
		}
		
		void CmdGuardarClick(object sender, EventArgs e)
		{
			if(strEstatus=="Nuevo")
			{
				if(ValidarVacio(gbPrincipal,false))
				{
				   	ObtenerDatos();
				   	if(objEquipos.Insertar()) MessageBox.Show("Se Guardó Correctamente El Registro");
				   	else MessageBox.Show("No Se Guardó el Registro.");
					ConfigurarBotonesInicial();
				}
				else MessageBox.Show("Faltan Campos Por Completar.");
			}
			else if(strEstatus == "Editar")
			{
				if(ValidarVacio(gbPrincipal,true))
				{
					ObtenerDatos();
					if(objEquipos.Actualizar()) MessageBox.Show("Se Actualizó Correctamente el Registro.");
					else MessageBox.Show("No Se Actualizó el Registro.");
					ConfigurarBotonesInicial();
				}
			}	
		}
		
		void CmdEliminarClick(object sender, EventArgs e)
		{
			if(txtID.Text.Length>0)
			{
				if(MessageBox.Show("¿Está Seguro Que Desea Eliminar El Registro?","Confirmación de Eliminación",MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					if(objEquipos.Eliminar(int.Parse(txtID.Text)))
					{
						MessageBox.Show("El Registro Se Eliminó Correctamente.");
						ConfigurarBotonesInicial();
						Limpiar(gbPrincipal);
					}
					else MessageBox.Show("No Se Pudo Eliminar El Registro.");
				}
			}
		}
		
		void OrdenConsola(object sender,EventArgs e)
		{
			string strCadena;
			string strIPOrigen;
			string strIPDestino;
			string strTipo;
			string strNombre;
			string strCaracteristicas;
			
			ListBox lst = (ListBox)(sender);
			strCadena = lst.Items[lst.Items.Count-1].ToString();
			strIPOrigen = strCadena.Split('>')[0].ToString().Replace("[",string.Empty).Replace("]",string.Empty);
			strIPDestino = strCadena.Split('>')[1].ToString().Replace("[",string.Empty).Replace("]",string.Empty);
			strTipo = strCadena.Split('>')[2].ToString().Replace("[",string.Empty).Replace("]",string.Empty);
			strNombre	 = strCadena.Split('>')[3].ToString().Replace("[",string.Empty).Replace("]",string.Empty);
			strCaracteristicas = strCadena.Split('>')[4].ToString().Replace("[",string.Empty).Replace("]",string.Empty);
			
			if(strIPDestino.CompareTo("SERVER")== 0 && strTipo.CompareTo("CP")==0)
			{
				txtIP.Text = strIPOrigen;
				txtNombre.Text = strNombre;
				txtCaracteristicas.Text = strCaracteristicas;
			}
		}
	}
}
