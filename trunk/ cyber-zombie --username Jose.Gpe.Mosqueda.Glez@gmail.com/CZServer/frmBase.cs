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
	//Formulario base para los formulario catálogo.
	public partial class frmBase : Form
	{
		public string strEstatus="";
		public frmBase()
		{
			InitializeComponent();
			ConfigurarBotonesInicial();
			strEstatus = "Inactivo";
		}
		//Función que configura los botones inicialmente
		//desactivando los que no son necesarios al inicio del proceso
		protected void ConfigurarBotonesInicial()
		{
			cmdCancelar.Enabled = false;
			cmdEditar.Enabled = false;
			cmdEliminar.Enabled = false;
			cmdGuardar.Enabled = false;
			gbPrincipal.Enabled = false;
			Limpiar(gbPrincipal);
		}
		//Función que obtiene los controles tipo textbox y los deja vacios
		protected void Limpiar(GroupBox gb)
		{
			foreach(Control control in gb.Controls)
			{
				if(control.GetType() == typeof(TextBox)) control.Text = string.Empty;
			}
		}
		//Función que obtiene los controles tipo textbox y valida que no vengan vaciós
		//si vienen vaciós el color de fondo de los textbox se torna amarillo indicando que campos son requeridos
		//devuelve true si todos los campos están llenos, y false si alguno de ellos vienen vacío
		protected bool ValidarVacio(GroupBox gb,bool conID)
		{			
			bool correcto = true;
			foreach(Control control in gb.Controls)
			{
				if(conID)
				{
					if(control.GetType() == typeof(TextBox) && control.Text.Length==0)
					{
						control.BackColor = Color.LightYellow;
						correcto = false;
					}
				}
				else
				{
					if(control.GetType() == typeof(TextBox) && control.Text.Length==0 && control.Name != "txtID")
					{
						control.BackColor = Color.LightYellow;
						correcto = false;
					}
				}
			}
			return correcto;
		}
		//Eventos Click de los botones
		//realizan operaciones como desactivar y activar ciertos botones dependiendo del proceso a realizar,
		//limpian los textbox dependiendo del proceso.
		void CmdNuevoClick(object sender, EventArgs e)
		{
			cmdGuardar.Enabled = true;
			cmdCancelar.Enabled = true;
			gbPrincipal.Enabled = true;
			Limpiar(gbPrincipal);
			strEstatus = "Nuevo";
		}
		
		void CmdBuscarClick(object sender, EventArgs e)
		{
			cmdEditar.Enabled = true;			
			cmdEliminar.Enabled = true;
			cmdCancelar.Enabled = true;
			strEstatus = "Buscar";
		}
		
		void CmdEditarClick(object sender, EventArgs e)
		{
			cmdGuardar.Enabled = true;
			gbPrincipal.Enabled = true;
			strEstatus = "Editar";
		}
				
		void CmdSalirClick(object sender, EventArgs e)
		{	
			ConfigurarBotonesInicial();
			this.Hide();
			strEstatus = "Inactivo";
		}		
		
		void CmdCancelarClick(object sender, EventArgs e)
		{
			ConfigurarBotonesInicial();
			strEstatus = "Inactivo";
		}
		
		void CmdEliminarClick(object sender, EventArgs e)
		{
			strEstatus = "Inactivo";
		}
	}
}
