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
			this.lblId = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lblDescripcion = new System.Windows.Forms.Label();
			this.lblPrecio = new System.Windows.Forms.Label();
			this.lblUnidad = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.txtUnidad = new System.Windows.Forms.TextBox();
			this.gbPrincipal.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbPrincipal
			// 
			this.gbPrincipal.Controls.Add(this.txtUnidad);
			this.gbPrincipal.Controls.Add(this.txtPrecio);
			this.gbPrincipal.Controls.Add(this.txtDescripcion);
			this.gbPrincipal.Controls.Add(this.txtNombre);
			this.gbPrincipal.Controls.Add(this.txtID);
			this.gbPrincipal.Controls.Add(this.lblUnidad);
			this.gbPrincipal.Controls.Add(this.lblPrecio);
			this.gbPrincipal.Controls.Add(this.lblDescripcion);
			this.gbPrincipal.Controls.Add(this.label1);
			this.gbPrincipal.Controls.Add(this.lblId);
			this.gbPrincipal.Size = new System.Drawing.Size(281, 149);
			// 
			// cmdSalir
			// 
			this.cmdSalir.Location = new System.Drawing.Point(258, 167);
			// 
			// cmdCancelar
			// 
			this.cmdCancelar.Location = new System.Drawing.Point(217, 167);
			// 
			// cmdEliminar
			// 
			this.cmdEliminar.Location = new System.Drawing.Point(176, 167);
			this.cmdEliminar.Click += new System.EventHandler(this.CmdEliminarClick);
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.Location = new System.Drawing.Point(135, 167);
			this.cmdGuardar.Click += new System.EventHandler(this.CmdGuardarClick);
			// 
			// cmdEditar
			// 
			this.cmdEditar.Location = new System.Drawing.Point(94, 167);
			// 
			// cmdBuscar
			// 
			this.cmdBuscar.Location = new System.Drawing.Point(53, 167);
			this.cmdBuscar.Click += new System.EventHandler(this.CmdBuscarClick);
			// 
			// cmdNuevo
			// 
			this.cmdNuevo.Location = new System.Drawing.Point(12, 167);
			this.cmdNuevo.Click += new System.EventHandler(this.CmdNuevoClick);
			// 
			// lblId
			// 
			this.lblId.Location = new System.Drawing.Point(71, 16);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(22, 23);
			this.lblId.TabIndex = 0;
			this.lblId.Text = "Id :";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(41, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nombre :";
			// 
			// lblDescripcion
			// 
			this.lblDescripcion.Location = new System.Drawing.Point(23, 68);
			this.lblDescripcion.Name = "lblDescripcion";
			this.lblDescripcion.Size = new System.Drawing.Size(70, 23);
			this.lblDescripcion.TabIndex = 2;
			this.lblDescripcion.Text = "Descripción :";
			// 
			// lblPrecio
			// 
			this.lblPrecio.Location = new System.Drawing.Point(11, 94);
			this.lblPrecio.Name = "lblPrecio";
			this.lblPrecio.Size = new System.Drawing.Size(82, 23);
			this.lblPrecio.TabIndex = 3;
			this.lblPrecio.Text = "Precio Unitario :";
			// 
			// lblUnidad
			// 
			this.lblUnidad.Location = new System.Drawing.Point(6, 120);
			this.lblUnidad.Name = "lblUnidad";
			this.lblUnidad.Size = new System.Drawing.Size(87, 23);
			this.lblUnidad.TabIndex = 4;
			this.lblUnidad.Text = "Tipo de Unidad :";
			// 
			// txtID
			// 
			this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtID.Location = new System.Drawing.Point(99, 14);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(42, 20);
			this.txtID.TabIndex = 5;
			// 
			// txtNombre
			// 
			this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNombre.Location = new System.Drawing.Point(99, 40);
			this.txtNombre.MaxLength = 40;
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(153, 20);
			this.txtNombre.TabIndex = 6;
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDescripcion.Location = new System.Drawing.Point(99, 66);
			this.txtDescripcion.MaxLength = 40;
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(153, 20);
			this.txtDescripcion.TabIndex = 7;
			// 
			// txtPrecio
			// 
			this.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPrecio.Location = new System.Drawing.Point(99, 92);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(91, 20);
			this.txtPrecio.TabIndex = 8;
			// 
			// txtUnidad
			// 
			this.txtUnidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtUnidad.Location = new System.Drawing.Point(99, 118);
			this.txtUnidad.MaxLength = 20;
			this.txtUnidad.Name = "txtUnidad";
			this.txtUnidad.Size = new System.Drawing.Size(91, 20);
			this.txtUnidad.TabIndex = 9;
			// 
			// frmTipos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(309, 215);
			this.Name = "frmTipos";
			this.Text = "Tipos de Equipo";
			this.gbPrincipal.ResumeLayout(false);
			this.gbPrincipal.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.TextBox txtUnidad;
		private System.Windows.Forms.Label lblId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblDescripcion;
		private System.Windows.Forms.Label lblPrecio;
		private System.Windows.Forms.Label lblUnidad;
	}
}
