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
			txtId.Text = objTipos.ID_TIPO.ToString();
			txtNombre.Text = objTipos.NOMBRE_TIPO;
			txtDescripcion.Text = objTipos.DESCRIPCION_TIPO;
			txtPrecio.Text = objTipos.PRECIO_UNITARIO.ToString();
			txtUnidad.Text = objTipos.UNIDAD_TIPO;
		}
		
		void CmdNuevoClick(object sender, EventArgs e)
		{
			txtId.Enabled = false;
		}
		
		void CmdGuardarClick(object sender, EventArgs e)
		{
			if(ValidarVacio(gbPrincipal))
			{
				ObtenerDatos();
				if(objTipos.Insertar()) MessageBox.Show("Se Guardó Correctamente el Registro.");
				else MessageBox.Show("No Se Guardó el Registro.");
				ConfigurarBotonesInicial();
			}
			else
			{
				MessageBox.Show("Faltan Campos Por Completar.");
			}
		}
	}
}
