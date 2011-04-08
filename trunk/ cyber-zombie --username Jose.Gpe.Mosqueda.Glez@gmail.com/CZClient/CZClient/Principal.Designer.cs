/*
 * Creado por SharpDevelop.
 * Usuario: Pepe
 * Fecha: 29/03/2011
 * Hora: 05:49 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace CZClient
{
	partial class frmPrincipal
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
			this.lstConsola = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// lstConsola
			// 
			this.lstConsola.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lstConsola.FormattingEnabled = true;
			this.lstConsola.Location = new System.Drawing.Point(-1, 24);
			this.lstConsola.Name = "lstConsola";
			this.lstConsola.Size = new System.Drawing.Size(193, 249);
			this.lstConsola.TabIndex = 0;
			this.lstConsola.SelectedIndexChanged += new System.EventHandler(this.LstConsolaSelectedIndexChanged);
			// 
			// frmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(192, 273);
			this.Controls.Add(this.lstConsola);
			this.Name = "frmPrincipal";
			this.Text = "Principal";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ListBox lstConsola;
	}
}
