/*
 * Creado por SharpDevelop.
 * Usuario: Pepe
 * Fecha: 10/03/2011
 * Hora: 06:20 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace CZServer
{
	partial class frmConsola
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
			this.txtConsola = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txtConsola
			// 
			this.txtConsola.BackColor = System.Drawing.Color.Black;
			this.txtConsola.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtConsola.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.txtConsola.Location = new System.Drawing.Point(1, -1);
			this.txtConsola.Multiline = true;
			this.txtConsola.Name = "txtConsola";
			this.txtConsola.Size = new System.Drawing.Size(291, 273);
			this.txtConsola.TabIndex = 0;
			// 
			// frmConsola
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.ControlBox = false;
			this.Controls.Add(this.txtConsola);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "frmConsola";
			this.Text = "SktConsole";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtConsola;
	}
}
