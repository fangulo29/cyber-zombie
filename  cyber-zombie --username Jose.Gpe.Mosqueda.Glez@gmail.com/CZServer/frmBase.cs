/*
 * Creado por SharpDevelop.
 * Usuario: Pepe
 * Fecha: 02/03/2011
 * Hora: 04:35 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CZServer
{
	/// <summary>
	/// Description of frmBase.
	/// </summary>
	public partial class frmBase : Form
	{
		public frmBase()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private void ConfigurarBotonesInicial()
		{
			cmdCancelar.Enabled = false;
			cmdEditar.Enabled = false;
			cmdEliminar.Enabled = false;
			cmdGuardar.Enabled = false;
			gbPrincipal.Enabled = false;
		}
		
		void CmdNuevoClick(object sender, EventArgs e)
		{
			cmdGuardar.Enabled = true;
			cmdCancelar.Enabled = true;
			gbPrincipal.Enabled = true;
		}
		
		void CmdBuscarClick(object sender, EventArgs e)
		{
			cmdEditar.Enabled = true;			
			cmdEliminar.Enabled = true;
			cmdCancelar.Enabled = true;
		}
		
		void CmdEditarClick(object sender, EventArgs e)
		{
			cmdGuardar.Enabled = true;
			gbPrincipal.Enabled = true;
		}
		
		void CmdGuardarClick(object sender, EventArgs e)
		{
			ConfigurarBotonesInicial();
		}
		
		void CmdEliminarClick(object sender, EventArgs e)
		{
			ConfigurarBotonesInicial();
		}
		
		void CmdCancelarClick(object sender, EventArgs e)
		{
			ConfigurarBotonesInicial();
		}
	}
}
