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
		public frmConsola objConsola;
		public frmPrincipal()
		{
			InitializeComponent();			
		}
		
		void TiposToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(objTipos == null || objTipos.IsDisposed)
			{
				objTipos = new CZServer.Configuracion.frmTipos();				
			}
			objTipos.MdiParent = this;
			objTipos.Show();
		}
		
		void EquiposToolStripMenuItemClick(object sender, EventArgs e)
		{
			if(objEquipos == null || objEquipos.IsDisposed)
			{
				objEquipos = new CZServer.Configuracion.frmEquipos();
			}
			objEquipos.MdiParent = this;
			objEquipos.Show();
		}
		
		void IniciarToolStripMenuItemClick(object sender, EventArgs e)
		{			
			if(objConsola == null || objConsola.IsDisposed){
				objConsola = new frmConsola();								
			}
			objConsola.MdiParent = this;
			objConsola.Show();
		}
	}
}
