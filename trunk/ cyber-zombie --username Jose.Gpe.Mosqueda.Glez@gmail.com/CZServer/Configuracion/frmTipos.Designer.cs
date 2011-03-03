/*
 * Creado por SharpDevelop.
 * Usuario: Pepe
 * Fecha: 02/03/2011
 * Hora: 04:33 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace CZServer.Configuracion
{
	partial class frmTipos
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.SuspendLayout();
			// 
			// gbPrincipal
			// 
			this.gbPrincipal.Size = new System.Drawing.Size(570, 297);
			// 
			// cmdSalir
			// 
			this.cmdSalir.Location = new System.Drawing.Point(547, 325);
			// 
			// cmdCancelar
			// 
			this.cmdCancelar.Location = new System.Drawing.Point(506, 325);
			// 
			// cmdEliminar
			// 
			this.cmdEliminar.Location = new System.Drawing.Point(311, 325);
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.Location = new System.Drawing.Point(270, 325);
			// 
			// cmdEditar
			// 
			this.cmdEditar.Location = new System.Drawing.Point(229, 325);
			// 
			// cmdBuscar
			// 
			this.cmdBuscar.Location = new System.Drawing.Point(53, 325);
			// 
			// cmdNuevo
			// 
			this.cmdNuevo.Location = new System.Drawing.Point(12, 325);
			// 
			// frmTipos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(594, 372);
			this.Name = "frmTipos";
			this.Text = "Tipos de Equipo";
			this.ResumeLayout(false);
		}
	}
}
