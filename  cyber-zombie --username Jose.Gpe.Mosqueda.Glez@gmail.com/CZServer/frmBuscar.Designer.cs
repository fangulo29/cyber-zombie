/*
 * Creado por SharpDevelop.
 * Usuario: Pepe
 * Fecha: 03/03/2011
 * Hora: 11:54 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace CZServer
{
	partial class frmBuscar
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
			this.cmdSalir = new System.Windows.Forms.Button();
			this.cmdBuscar = new System.Windows.Forms.Button();
			this.cmdSeleccionar = new System.Windows.Forms.Button();
			this.pbBuscar = new System.Windows.Forms.PictureBox();
			this.dgvContenido = new System.Windows.Forms.DataGridView();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.dgvBusqueda = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvContenido)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).BeginInit();
			this.SuspendLayout();
			// 
			// cmdSalir
			// 
			this.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdSalir.Location = new System.Drawing.Point(347, 12);
			this.cmdSalir.Name = "cmdSalir";
			this.cmdSalir.Size = new System.Drawing.Size(35, 35);
			this.cmdSalir.TabIndex = 8;
			this.cmdSalir.Text = "Salir";
			this.cmdSalir.UseVisualStyleBackColor = true;
			this.cmdSalir.Click += new System.EventHandler(this.CmdSalirClick);
			// 
			// cmdBuscar
			// 
			this.cmdBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdBuscar.Location = new System.Drawing.Point(-128, 12);
			this.cmdBuscar.Name = "cmdBuscar";
			this.cmdBuscar.Size = new System.Drawing.Size(35, 35);
			this.cmdBuscar.TabIndex = 7;
			this.cmdBuscar.Text = "Buscar";
			this.cmdBuscar.UseVisualStyleBackColor = true;
			// 
			// cmdSeleccionar
			// 
			this.cmdSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdSeleccionar.Location = new System.Drawing.Point(306, 12);
			this.cmdSeleccionar.Name = "cmdSeleccionar";
			this.cmdSeleccionar.Size = new System.Drawing.Size(35, 35);
			this.cmdSeleccionar.TabIndex = 9;
			this.cmdSeleccionar.Text = "Seleccionar";
			this.cmdSeleccionar.UseVisualStyleBackColor = true;
			// 
			// pbBuscar
			// 
			this.pbBuscar.Location = new System.Drawing.Point(12, 12);
			this.pbBuscar.Name = "pbBuscar";
			this.pbBuscar.Size = new System.Drawing.Size(35, 35);
			this.pbBuscar.TabIndex = 11;
			this.pbBuscar.TabStop = false;
			// 
			// dgvContenido
			// 
			this.dgvContenido.AllowUserToAddRows = false;
			this.dgvContenido.AllowUserToDeleteRows = false;
			this.dgvContenido.BackgroundColor = System.Drawing.Color.White;
			this.dgvContenido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvContenido.GridColor = System.Drawing.Color.White;
			this.dgvContenido.Location = new System.Drawing.Point(12, 53);
			this.dgvContenido.MultiSelect = false;
			this.dgvContenido.Name = "dgvContenido";
			this.dgvContenido.ReadOnly = true;
			this.dgvContenido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvContenido.Size = new System.Drawing.Size(370, 210);
			this.dgvContenido.TabIndex = 12;
			this.dgvContenido.Visible = false;
			// 
			// txtBuscar
			// 
			this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtBuscar.Location = new System.Drawing.Point(71, 21);
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.Size = new System.Drawing.Size(214, 20);
			this.txtBuscar.TabIndex = 13;
			this.txtBuscar.TextChanged += new System.EventHandler(this.TxtBuscarTextChanged);
			// 
			// dgvBusqueda
			// 
			this.dgvBusqueda.AllowUserToAddRows = false;
			this.dgvBusqueda.AllowUserToDeleteRows = false;
			this.dgvBusqueda.BackgroundColor = System.Drawing.Color.White;
			this.dgvBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBusqueda.GridColor = System.Drawing.Color.White;
			this.dgvBusqueda.Location = new System.Drawing.Point(12, 53);
			this.dgvBusqueda.MultiSelect = false;
			this.dgvBusqueda.Name = "dgvBusqueda";
			this.dgvBusqueda.ReadOnly = true;
			this.dgvBusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvBusqueda.Size = new System.Drawing.Size(370, 210);
			this.dgvBusqueda.TabIndex = 14;
			// 
			// frmBuscar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(394, 275);
			this.ControlBox = false;
			this.Controls.Add(this.dgvBusqueda);
			this.Controls.Add(this.txtBuscar);
			this.Controls.Add(this.dgvContenido);
			this.Controls.Add(this.pbBuscar);
			this.Controls.Add(this.cmdSeleccionar);
			this.Controls.Add(this.cmdSalir);
			this.Controls.Add(this.cmdBuscar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "frmBuscar";
			this.Text = "Buscar";
			((System.ComponentModel.ISupportInitialize)(this.pbBuscar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvContenido)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvBusqueda)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		public System.Windows.Forms.DataGridView dgvBusqueda;
		private System.Windows.Forms.DataGridView dgvContenido;
		private System.Windows.Forms.TextBox txtBuscar;
		private System.Windows.Forms.PictureBox pbBuscar;
		public System.Windows.Forms.Button cmdSeleccionar;
		public System.Windows.Forms.Button cmdBuscar;
		public System.Windows.Forms.Button cmdSalir;
	}
}
