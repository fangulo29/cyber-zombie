/*
 * Creado por SharpDevelop.
 * Usuario: Pepe
 * Fecha: 02/03/2011
 * Hora: 04:35 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace CZServer
{
	partial class frmBase
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
			this.cmdNuevo = new System.Windows.Forms.Button();
			this.cmdBuscar = new System.Windows.Forms.Button();
			this.cmdEditar = new System.Windows.Forms.Button();
			this.cmdGuardar = new System.Windows.Forms.Button();
			this.cmdEliminar = new System.Windows.Forms.Button();
			this.cmdCancelar = new System.Windows.Forms.Button();
			this.cmdSalir = new System.Windows.Forms.Button();
			this.gbPrincipal = new System.Windows.Forms.GroupBox();
			this.SuspendLayout();
			// 
			// cmdNuevo
			// 
			this.cmdNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdNuevo.Location = new System.Drawing.Point(12, 315);
			this.cmdNuevo.Name = "cmdNuevo";
			this.cmdNuevo.Size = new System.Drawing.Size(35, 35);
			this.cmdNuevo.TabIndex = 0;
			this.cmdNuevo.Text = "Nuevo";
			this.cmdNuevo.UseVisualStyleBackColor = true;
			this.cmdNuevo.Click += new System.EventHandler(this.CmdNuevoClick);
			// 
			// cmdBuscar
			// 
			this.cmdBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdBuscar.Location = new System.Drawing.Point(53, 315);
			this.cmdBuscar.Name = "cmdBuscar";
			this.cmdBuscar.Size = new System.Drawing.Size(35, 35);
			this.cmdBuscar.TabIndex = 1;
			this.cmdBuscar.Text = "Buscar";
			this.cmdBuscar.UseVisualStyleBackColor = true;
			this.cmdBuscar.Click += new System.EventHandler(this.CmdBuscarClick);
			// 
			// cmdEditar
			// 
			this.cmdEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdEditar.Location = new System.Drawing.Point(229, 315);
			this.cmdEditar.Name = "cmdEditar";
			this.cmdEditar.Size = new System.Drawing.Size(35, 35);
			this.cmdEditar.TabIndex = 2;
			this.cmdEditar.Text = "Editar";
			this.cmdEditar.UseVisualStyleBackColor = true;
			this.cmdEditar.Click += new System.EventHandler(this.CmdEditarClick);
			// 
			// cmdGuardar
			// 
			this.cmdGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdGuardar.Location = new System.Drawing.Point(270, 315);
			this.cmdGuardar.Name = "cmdGuardar";
			this.cmdGuardar.Size = new System.Drawing.Size(35, 35);
			this.cmdGuardar.TabIndex = 3;
			this.cmdGuardar.Text = "Guardar";
			this.cmdGuardar.UseVisualStyleBackColor = true;
			this.cmdGuardar.Click += new System.EventHandler(this.CmdGuardarClick);
			// 
			// cmdEliminar
			// 
			this.cmdEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdEliminar.Location = new System.Drawing.Point(311, 315);
			this.cmdEliminar.Name = "cmdEliminar";
			this.cmdEliminar.Size = new System.Drawing.Size(35, 35);
			this.cmdEliminar.TabIndex = 4;
			this.cmdEliminar.Text = "Eliminar";
			this.cmdEliminar.UseVisualStyleBackColor = true;
			this.cmdEliminar.Click += new System.EventHandler(this.CmdEliminarClick);
			// 
			// cmdCancelar
			// 
			this.cmdCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdCancelar.Location = new System.Drawing.Point(496, 315);
			this.cmdCancelar.Name = "cmdCancelar";
			this.cmdCancelar.Size = new System.Drawing.Size(35, 35);
			this.cmdCancelar.TabIndex = 5;
			this.cmdCancelar.Text = "Cancelar";
			this.cmdCancelar.UseVisualStyleBackColor = true;
			this.cmdCancelar.Click += new System.EventHandler(this.CmdCancelarClick);
			// 
			// cmdSalir
			// 
			this.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmdSalir.Location = new System.Drawing.Point(537, 315);
			this.cmdSalir.Name = "cmdSalir";
			this.cmdSalir.Size = new System.Drawing.Size(35, 35);
			this.cmdSalir.TabIndex = 6;
			this.cmdSalir.Text = "Salir";
			this.cmdSalir.UseVisualStyleBackColor = true;
			this.cmdSalir.Click += new System.EventHandler(this.CmdSalirClick);
			// 
			// gbPrincipal
			// 
			this.gbPrincipal.Location = new System.Drawing.Point(12, 12);
			this.gbPrincipal.Name = "gbPrincipal";
			this.gbPrincipal.Size = new System.Drawing.Size(560, 297);
			this.gbPrincipal.TabIndex = 7;
			this.gbPrincipal.TabStop = false;
			// 
			// frmBase
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(584, 362);
			this.ControlBox = false;
			this.Controls.Add(this.gbPrincipal);
			this.Controls.Add(this.cmdSalir);
			this.Controls.Add(this.cmdCancelar);
			this.Controls.Add(this.cmdEliminar);
			this.Controls.Add(this.cmdGuardar);
			this.Controls.Add(this.cmdEditar);
			this.Controls.Add(this.cmdBuscar);
			this.Controls.Add(this.cmdNuevo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "frmBase";
			this.Text = "frmBase";
			this.ResumeLayout(false);
		}
		protected System.Windows.Forms.GroupBox gbPrincipal;
		protected System.Windows.Forms.Button cmdSalir;
		protected System.Windows.Forms.Button cmdCancelar;
		protected System.Windows.Forms.Button cmdEliminar;
		protected System.Windows.Forms.Button cmdGuardar;
		protected System.Windows.Forms.Button cmdEditar;
		protected System.Windows.Forms.Button cmdBuscar;
		protected System.Windows.Forms.Button cmdNuevo;
	}
}
