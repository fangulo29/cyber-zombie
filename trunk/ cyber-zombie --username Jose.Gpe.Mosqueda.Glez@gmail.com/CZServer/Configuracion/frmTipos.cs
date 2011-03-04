/*
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
	public partial class frmTipos : frmBase
	{
		private Tipos objTipos;
		private frmBuscar objBuscar;
		
		public frmTipos()
		{
			InitializeComponent();
			objTipos = new Tipos();
		}				
		
		private void ObtenerDatos()
		{			
			objTipos.NOMBRE_TIPO = txtNombre.Text;
			objTipos.DESCRIPCION_TIPO = txtDescripcion.Text;
			objTipos.PRECIO_UNITARIO = decimal.Parse(txtPrecio.Text);
			objTipos.UNIDAD_TIPO = txtUnidad.Text;
		}
		
		private void MostrarDatos(int ID)
		{
			objTipos.Buscar(ID);
			txtID.Text = objTipos.ID_TIPO.ToString();
			txtNombre.Text = objTipos.NOMBRE_TIPO;
			txtDescripcion.Text = objTipos.DESCRIPCION_TIPO;
			txtPrecio.Text = objTipos.PRECIO_UNITARIO.ToString();
			txtUnidad.Text = objTipos.UNIDAD_TIPO;
		}
		
		void CmdNuevoClick(object sender, EventArgs e)
		{
			txtID.Enabled = false;
		}
		
		void CmdGuardarClick(object sender, EventArgs e)
		{
			if(strEstatus == "Nuevo")
			{
				if(ValidarVacio(gbPrincipal,false))
				{
					ObtenerDatos();
					if(objTipos.Insertar()) MessageBox.Show("Se Guardó Correctamente el Registro.");
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
					if(objTipos.Actualizar()) MessageBox.Show("Se Actualizó Correctamente el Registro.");
					else MessageBox.Show("No Se Actualizó el Registro.");
					ConfigurarBotonesInicial();
				}
			}				
		}
		
		void CmdBuscarClick(object sender, EventArgs e)
		{
			if(objBuscar == null)
			{
				objBuscar = new frmBuscar("Tipos");			
				objBuscar.dgvBusqueda.DoubleClick += new EventHandler(SeleccionarTipos);
				objBuscar.cmdSeleccionar.Click += new EventHandler(SeleccionarTipos);
			}
			objBuscar.MdiParent = this.MdiParent;
			objBuscar.Show();
		}
		
		private void SeleccionarTipos(object sender, EventArgs e)
		{
			if(objBuscar != null)
			{
				if(objBuscar.dgvBusqueda.SelectedRows[0].Cells[0].Value.ToString().Length > 0)
				{
					MostrarDatos(int.Parse(objBuscar.dgvBusqueda.SelectedRows[0].Cells[0].Value.ToString()));
					objBuscar.Close();
					objBuscar = null;
				}
			}
		}
		
		void CmdEliminarClick(object sender, EventArgs e)
		{
			if(txtID.Text.Length>0)
			{
				if(MessageBox.Show("¿Está Seguro Que Desea Eliminar El Registro?","Confirmación de Eliminación",MessageBoxButtons.YesNo) == DialogResult.Yes)
				{
					if(objTipos.Eliminar(int.Parse(txtID.Text)))
					{
						MessageBox.Show("El Registro Se Eliminó Correctamente.");
						ConfigurarBotonesInicial();
						Limpiar(gbPrincipal);
					}
					else MessageBox.Show("No Se Pudo Eliminar El Registro.");
				}
			}
		}
	}
}
