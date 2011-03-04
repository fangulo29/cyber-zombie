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
	/// <summary>
	/// Description of frmEquipos.
	/// </summary>
	public partial class frmEquipos : frmBase
	{
		private frmBuscar objBuscarEnRed;
		private frmBuscar objBuscarTipos;
		
		public frmEquipos()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void CmdRedClick(object sender, EventArgs e)
		{
			if(objBuscarEnRed == null)
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
				txtIP.Text = objBuscarEnRed.dgvBusqueda.SelectedRows[0].Cells[0].Value.ToString();
				txtNombre.Text = objBuscarEnRed.dgvBusqueda.SelectedRows[0].Cells[1].Value.ToString();
				objBuscarEnRed.Close();
				objBuscarEnRed = null;
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
				txtTipo.Tag = objBuscarTipos.dgvBusqueda.SelectedRows[0].Cells[0].Value.ToString();
				txtTipo.Text = objBuscarTipos.dgvBusqueda.SelectedRows[0].Cells[1].Value.ToString();
			}
		}
	}
}
