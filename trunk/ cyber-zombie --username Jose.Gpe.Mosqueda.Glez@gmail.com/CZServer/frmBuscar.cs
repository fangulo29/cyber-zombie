/*
 * Creado por SharpDevelop.
 * Usuario: Pepe
 * Fecha: 03/03/2011
 * Hora: 11:54 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using System.Security;
using System.Net;

namespace CZServer
{
	//Formulario de busqueda para los catalogos
	//obtendra el tipo de catalogo a buscar, se adecuaran las busquedas filtradas
	//dependiendo de la tabla a consultar
	public partial class frmBuscar : Form
	{		
		private List<Tipos> lstTipos;
		private List<Equipos> lstEquipos;		
	 
		public frmBuscar(string Catalogo)
		{			
			InitializeComponent();			
			ConfigurarTabla(Catalogo);
		}
		
		private void ConfigurarTabla(string strCatalogo)
		{
			int i;			
			DataGridViewColumn Columna;
			Columna = new DataGridViewColumn(new DataGridViewTextBoxCell());
                        Columna.HeaderText = "ID";
                        dgvContenido.Columns.Add(Columna);
                        Columna = new DataGridViewColumn(new DataGridViewTextBoxCell());
                        Columna.HeaderText = "ID";
                        dgvBusqueda.Columns.Add(Columna);
			Columna = new DataGridViewColumn(new DataGridViewTextBoxCell());
                        Columna.HeaderText = "Descripción";
                        dgvContenido.Columns.Add(Columna);
                        Columna = new DataGridViewColumn(new DataGridViewTextBoxCell());
                        Columna.HeaderText = "Descripción";
                        dgvBusqueda.Columns.Add(Columna);
                        
                        switch(strCatalogo)
                        {
                        	case "Tipos":
                        		lstTipos = new Tipos().Mostrar();
                        		for(i=0;i<lstTipos.Count;i++)
                        		{
                        			dgvContenido.Rows.Add(lstTipos[i].ID_TIPO,lstTipos[i].NOMBRE_TIPO);						
                        		}
                        		break;
                        	case "Equipos":
                        		lstEquipos = new Equipos().Mostrar();
                        		for(i=0;i<lstTipos.Count;i++)
                        		{
                        			dgvContenido.Rows.Add(lstTipos[i].ID_TIPO,lstTipos[i].NOMBRE_TIPO);						
                        		}
                        		break;
                        	case "EquiposRed":                          		
                        		((ListBox)frmPrincipal.ActiveForm.Controls["lstConsola"]).TextChanged += new EventHandler(OrdenConsola);
                        		((frmPrincipal)frmPrincipal.ActiveForm).EnviarDatos("CLIENTES","[LE]");
	                       		break;
                        	default:
                        		break;
                        }
                        dgvBusqueda.Rows.Clear();
                        for(int j=0;j<dgvContenido.Rows.Count;j++)
                        {
                        	dgvBusqueda.Rows.Add(dgvContenido.Rows[j].Cells[0].Value.ToString(),dgvContenido.Rows[j].Cells[1].Value.ToString());
                        }
		}
			
		void CmdSalirClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void TxtBuscarTextChanged(object sender, EventArgs e)
		{
			dgvBusqueda.Rows.Clear();
			for(int i=0;i<dgvContenido.Rows.Count;i++)
			{
				if(Regex.IsMatch(dgvContenido.Rows[i].Cells[0].Value.ToString(),txtBuscar.Text,RegexOptions.IgnoreCase) || Regex.IsMatch(dgvContenido.Rows[i].Cells[1].Value.ToString(),txtBuscar.Text,RegexOptions.IgnoreCase))
				{
					dgvBusqueda.Rows.Add(dgvContenido.Rows[i].Cells[0].Value.ToString(),dgvContenido.Rows[i].Cells[1].Value.ToString());
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
			
			ListBox lst = (ListBox)(sender);
			strCadena = lst.Items[lst.Items.Count-1].ToString();
			strIPOrigen = strCadena.Split('>')[0].ToString().Replace("[",string.Empty).Replace("]",string.Empty);
			strIPDestino = strCadena.Split('>')[1].ToString().Replace("[",string.Empty).Replace("]",string.Empty);
			strTipo = strCadena.Split('>')[2].ToString().Replace("[",string.Empty).Replace("]",string.Empty);
			strNombre	 = strCadena.Split('>')[3].ToString().Replace("[",string.Empty).Replace("]",string.Empty);
			
			if(strIPDestino.CompareTo("SERVER")== 0 && strTipo.CompareTo("CP")==0)
			{
				if(!Repetidos(strIPOrigen))
					dgvBusqueda.Rows.Add(strIPOrigen,strNombre);
			}
		}
		
		private bool Repetidos(string str)
		{
			bool repetido = false;
			for (int i=0;i<dgvBusqueda.Rows.Count;i++)
			{
				if(dgvBusqueda.Rows[i].Cells[0].Value.ToString().CompareTo(str)== 0) repetido=true;
			}
			return repetido;
		}
	}
}
