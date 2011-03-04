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
	partial class frmEquipos
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
			this.lblID = new System.Windows.Forms.Label();
			this.lblTipo = new System.Windows.Forms.Label();
			this.lblIP = new System.Windows.Forms.Label();
			this.lblNombre = new System.Windows.Forms.Label();
			this.lblCaracteristicas = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.txtTipo = new System.Windows.Forms.TextBox();
			this.txtIP = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtCaracteristicas = new System.Windows.Forms.TextBox();
			this.cmdTipos = new System.Windows.Forms.Button();
			this.cmdRed = new System.Windows.Forms.Button();
			this.gbPrincipal.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbPrincipal
			// 
			this.gbPrincipal.Controls.Add(this.cmdRed);
			this.gbPrincipal.Controls.Add(this.cmdTipos);
			this.gbPrincipal.Controls.Add(this.txtCaracteristicas);
			this.gbPrincipal.Controls.Add(this.txtNombre);
			this.gbPrincipal.Controls.Add(this.txtIP);
			this.gbPrincipal.Controls.Add(this.txtTipo);
			this.gbPrincipal.Controls.Add(this.txtID);
			this.gbPrincipal.Controls.Add(this.lblCaracteristicas);
			this.gbPrincipal.Controls.Add(this.lblNombre);
			this.gbPrincipal.Controls.Add(this.lblIP);
			this.gbPrincipal.Controls.Add(this.lblTipo);
			this.gbPrincipal.Controls.Add(this.lblID);
			this.gbPrincipal.Size = new System.Drawing.Size(281, 297);
			// 
			// cmdSalir
			// 
			this.cmdSalir.Location = new System.Drawing.Point(258, 315);
			// 
			// cmdCancelar
			// 
			this.cmdCancelar.Location = new System.Drawing.Point(217, 315);
			// 
			// cmdEliminar
			// 
			this.cmdEliminar.Location = new System.Drawing.Point(176, 315);
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.Location = new System.Drawing.Point(135, 315);
			// 
			// cmdEditar
			// 
			this.cmdEditar.Location = new System.Drawing.Point(94, 315);
			// 
			// lblID
			// 
			this.lblID.Location = new System.Drawing.Point(62, 16);
			this.lblID.Name = "lblID";
			this.lblID.Size = new System.Drawing.Size(22, 23);
			this.lblID.TabIndex = 0;
			this.lblID.Text = "Id :";
			// 
			// lblTipo
			// 
			this.lblTipo.Location = new System.Drawing.Point(53, 42);
			this.lblTipo.Name = "lblTipo";
			this.lblTipo.Size = new System.Drawing.Size(35, 23);
			this.lblTipo.TabIndex = 1;
			this.lblTipo.Text = "Tipo :";
			// 
			// lblIP
			// 
			this.lblIP.Location = new System.Drawing.Point(62, 68);
			this.lblIP.Name = "lblIP";
			this.lblIP.Size = new System.Drawing.Size(26, 23);
			this.lblIP.TabIndex = 2;
			this.lblIP.Text = "IP :";
			// 
			// lblNombre
			// 
			this.lblNombre.Location = new System.Drawing.Point(38, 94);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(50, 23);
			this.lblNombre.TabIndex = 3;
			this.lblNombre.Text = "Nombre :";
			// 
			// lblCaracteristicas
			// 
			this.lblCaracteristicas.Location = new System.Drawing.Point(6, 120);
			this.lblCaracteristicas.Name = "lblCaracteristicas";
			this.lblCaracteristicas.Size = new System.Drawing.Size(82, 23);
			this.lblCaracteristicas.TabIndex = 4;
			this.lblCaracteristicas.Text = "Caracteristicas :";
			// 
			// txtID
			// 
			this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtID.Location = new System.Drawing.Point(90, 14);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(41, 20);
			this.txtID.TabIndex = 5;
			// 
			// txtTipo
			// 
			this.txtTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTipo.Location = new System.Drawing.Point(90, 40);
			this.txtTipo.MaxLength = 40;
			this.txtTipo.Name = "txtTipo";
			this.txtTipo.Size = new System.Drawing.Size(121, 20);
			this.txtTipo.TabIndex = 6;
			// 
			// txtIP
			// 
			this.txtIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtIP.Location = new System.Drawing.Point(90, 66);
			this.txtIP.Name = "txtIP";
			this.txtIP.Size = new System.Drawing.Size(121, 20);
			this.txtIP.TabIndex = 7;
			// 
			// txtNombre
			// 
			this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNombre.Location = new System.Drawing.Point(90, 92);
			this.txtNombre.MaxLength = 20;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(121, 20);
			this.txtNombre.TabIndex = 8;
			// 
			// txtCaracteristicas
			// 
			this.txtCaracteristicas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCaracteristicas.Location = new System.Drawing.Point(90, 120);
			this.txtCaracteristicas.MaxLength = 300;
			this.txtCaracteristicas.Multiline = true;
			this.txtCaracteristicas.Name = "txtCaracteristicas";
			this.txtCaracteristicas.Size = new System.Drawing.Size(180, 133);
			this.txtCaracteristicas.TabIndex = 9;
			// 
			// cmdTipos
			// 
			this.cmdTipos.Location = new System.Drawing.Point(217, 37);
			this.cmdTipos.Name = "cmdTipos";
			this.cmdTipos.Size = new System.Drawing.Size(35, 23);
			this.cmdTipos.TabIndex = 10;
			this.cmdTipos.Text = "...";
			this.cmdTipos.UseVisualStyleBackColor = true;
			this.cmdTipos.Click += new System.EventHandler(this.CmdTiposClick);
			// 
			// cmdRed
			// 
			this.cmdRed.Location = new System.Drawing.Point(217, 63);
			this.cmdRed.Name = "cmdRed";
			this.cmdRed.Size = new System.Drawing.Size(35, 23);
			this.cmdRed.TabIndex = 11;
			this.cmdRed.Text = "...";
			this.cmdRed.UseVisualStyleBackColor = true;
			this.cmdRed.Click += new System.EventHandler(this.CmdRedClick);
			// 
			// frmEquipos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(304, 359);
			this.Name = "frmEquipos";
			this.Text = "frmEquipos";
			this.gbPrincipal.ResumeLayout(false);
			this.gbPrincipal.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button cmdRed;
		private System.Windows.Forms.Button cmdTipos;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.TextBox txtTipo;
		private System.Windows.Forms.TextBox txtIP;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtCaracteristicas;
		private System.Windows.Forms.Label lblTipo;
		private System.Windows.Forms.Label lblIP;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Label lblCaracteristicas;
		private System.Windows.Forms.Label lblID;
	}
}
