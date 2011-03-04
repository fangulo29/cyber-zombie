/*
 * Creado por SharpDevelop.
 * Usuario: Pepe
 * Fecha: 02/03/2011
 * Hora: 04:27 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CZServer
{	
	public partial class frmPrincipal : Form
	{
		private Configuracion.frmTipos objTipos;
		private Configuracion.frmEquipos objEquipos;
		public frmPrincipal()
		{
			InitializeComponent();
			objTipos = new CZServer.Configuracion.frmTipos();
			objEquipos = new CZServer.Configuracion.frmEquipos();
		}
		
		void TiposToolStripMenuItemClick(object sender, EventArgs e)
		{			
			objTipos.MdiParent = this;
			objTipos.Show();
		}
		
		void EquiposToolStripMenuItemClick(object sender, EventArgs e)
		{
			objEquipos.MdiParent = this;
			objEquipos.Show();
		}
	}
}
