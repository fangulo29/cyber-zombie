/*
 * Creado por SharpDevelop.
 * Usuario: Pepe
 * Fecha: 29/03/2011
 * Hora: 10:53 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;

namespace CZServer.Sesion
{	
	public partial class frmVisor : Form
	{
		private Equipos objEquipos;		
		private List<Equipos> lstEquipos;
		private frmPrincipal Principal;
		
		public frmVisor()
		{			
			objEquipos = new Equipos();
			lstEquipos = new List<Equipos>();
			InitializeComponent();
			ConfigurarTabla();
			Principal = ((frmPrincipal)frmPrincipal.ActiveForm);			
		}
		
		private void ConfigurarTabla()
		{
			DataGridViewColumn Columna;
			
			Columna = new DataGridViewColumn(new DataGridViewTextBoxCell());
                        Columna.HeaderText = "Sesiones";
                        Columna.Visible = false;
                        dgvSesiones.Columns.Add(Columna);       
                        Columna = new DataGridViewColumn(new DataGridViewTextBoxCell());
                        Columna.HeaderText = "Img";
                        dgvSesiones.Columns.Add(Columna);                        
                        Columna = new DataGridViewColumn(new DataGridViewTextBoxCell());
                        Columna.HeaderText = "Estatus";
                        dgvSesiones.Columns.Add(Columna);
                        Columna = new DataGridViewColumn(new DataGridViewTextBoxCell());
                        Columna.HeaderText = "IP";
                        dgvSesiones.Columns.Add(Columna);
                        Columna = new DataGridViewColumn(new DataGridViewTextBoxCell());
                        Columna.HeaderText = "Equipo";
                        dgvSesiones.Columns.Add(Columna);                        
                        Columna = new DataGridViewColumn(new DataGridViewTextBoxCell());
                        Columna.HeaderText = "Fecha";
                        Columna.Visible = false;
                        dgvSesiones.Columns.Add(Columna);
                        Columna = new DataGridViewColumn(new DataGridViewTextBoxCell());
                        Columna.HeaderText = "Hora Inicio";
                        dgvSesiones.Columns.Add(Columna);
                        Columna = new DataGridViewColumn(new DataGridViewTextBoxCell());
                        Columna.HeaderText = "Hora Fin";
                        dgvSesiones.Columns.Add(Columna);
                        Columna = new DataGridViewColumn(new DataGridViewTextBoxCell());
                        Columna.HeaderText = "Total Sesion";
                        dgvSesiones.Columns.Add(Columna);
                        Columna = new DataGridViewColumn(new DataGridViewTextBoxCell());
                        Columna.HeaderText = "Total Imp";
                        dgvSesiones.Columns.Add(Columna);
                        Columna = new DataGridViewColumn(new DataGridViewTextBoxCell());
                        Columna.HeaderText = "Total";
                        dgvSesiones.Columns.Add(Columna);
		}
		
		private void CargarTabla()
		{
			lstEquipos = objEquipos.Mostrar();			
			int i;			
			
			for(i=0;i<lstEquipos.Count;i++)
			{
				dgvSesiones.Rows.Add("0","","Desconectado",lstEquipos[i].IP_EQUIPO,lstEquipos[i].NOMBRE_EQUIPO,"Indefinido","Indefinido","Indefinido","$0.00","$0.00","$0.00");
			}
		}
		
		void CmdCerrarClick(object sender, EventArgs e)
		{			
			Principal.Parar();
			Principal.iniciarToolStripMenuItem.Enabled = true;
			Principal.pararToolStripMenuItem.Enabled = false;
			this.Dispose();
		}
	}
}
