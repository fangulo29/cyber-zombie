/*
 * Creado por SharpDevelop.
 * Usuario: Pepe
 * Fecha: 29/03/2011
 * Hora: 10:53 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace CZServer.Sesion
{
	partial class frmVisor
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
			this.dgvSesiones = new System.Windows.Forms.DataGridView();
			this.cmdSesionInd = new System.Windows.Forms.Button();
			this.cmdSesionTmp = new System.Windows.Forms.Button();
			this.cmdSesionPausa = new System.Windows.Forms.Button();
			this.cmdCerrar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvSesiones)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvSesiones
			// 
			this.dgvSesiones.AllowUserToAddRows = false;
			this.dgvSesiones.AllowUserToDeleteRows = false;
			this.dgvSesiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSesiones.Location = new System.Drawing.Point(12, 50);
			this.dgvSesiones.MultiSelect = false;
			this.dgvSesiones.Name = "dgvSesiones";
			this.dgvSesiones.ReadOnly = true;
			this.dgvSesiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvSesiones.Size = new System.Drawing.Size(568, 311);
			this.dgvSesiones.TabIndex = 0;
			// 
			// cmdSesionInd
			// 
			this.cmdSesionInd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdSesionInd.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdSesionInd.Location = new System.Drawing.Point(12, 12);
			this.cmdSesionInd.Name = "cmdSesionInd";
			this.cmdSesionInd.Size = new System.Drawing.Size(32, 32);
			this.cmdSesionInd.TabIndex = 1;
			this.cmdSesionInd.Text = "SI";
			this.cmdSesionInd.UseVisualStyleBackColor = true;
			// 
			// cmdSesionTmp
			// 
			this.cmdSesionTmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdSesionTmp.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdSesionTmp.Location = new System.Drawing.Point(50, 12);
			this.cmdSesionTmp.Name = "cmdSesionTmp";
			this.cmdSesionTmp.Size = new System.Drawing.Size(32, 32);
			this.cmdSesionTmp.TabIndex = 2;
			this.cmdSesionTmp.Text = "ST";
			this.cmdSesionTmp.UseVisualStyleBackColor = true;
			// 
			// cmdSesionPausa
			// 
			this.cmdSesionPausa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdSesionPausa.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdSesionPausa.Location = new System.Drawing.Point(88, 12);
			this.cmdSesionPausa.Name = "cmdSesionPausa";
			this.cmdSesionPausa.Size = new System.Drawing.Size(32, 32);
			this.cmdSesionPausa.TabIndex = 3;
			this.cmdSesionPausa.Text = "SP";
			this.cmdSesionPausa.UseVisualStyleBackColor = true;
			// 
			// cmdCerrar
			// 
			this.cmdCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdCerrar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdCerrar.Location = new System.Drawing.Point(548, 12);
			this.cmdCerrar.Name = "cmdCerrar";
			this.cmdCerrar.Size = new System.Drawing.Size(32, 32);
			this.cmdCerrar.TabIndex = 4;
			this.cmdCerrar.Text = "Cerrar";
			this.cmdCerrar.UseVisualStyleBackColor = true;
			this.cmdCerrar.Click += new System.EventHandler(this.CmdCerrarClick);
			// 
			// frmVisor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(592, 373);
			this.ControlBox = false;
			this.Controls.Add(this.cmdCerrar);
			this.Controls.Add(this.cmdSesionPausa);
			this.Controls.Add(this.cmdSesionTmp);
			this.Controls.Add(this.cmdSesionInd);
			this.Controls.Add(this.dgvSesiones);
			this.Name = "frmVisor";
			this.Text = "Visor de Sesiones";
			((System.ComponentModel.ISupportInitialize)(this.dgvSesiones)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button cmdCerrar;
		private System.Windows.Forms.Button cmdSesionPausa;
		private System.Windows.Forms.Button cmdSesionTmp;
		private System.Windows.Forms.Button cmdSesionInd;
		private System.Windows.Forms.DataGridView dgvSesiones;
	}
}
