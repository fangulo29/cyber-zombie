﻿/*
 * Creado por SharpDevelop.
 * Usuario: Pepe
 * Fecha: 02/03/2011
 * Hora: 04:27 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace CZServer
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.equiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sesionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.iniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.visorDeSesionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.resumenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consolaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.configuraciónToolStripMenuItem,
									this.sesionesToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(792, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// configuraciónToolStripMenuItem
			// 
			this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.equiposToolStripMenuItem,
									this.tiposToolStripMenuItem});
			this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
			this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
			this.configuraciónToolStripMenuItem.Text = "Configuración";
			// 
			// equiposToolStripMenuItem
			// 
			this.equiposToolStripMenuItem.Name = "equiposToolStripMenuItem";
			this.equiposToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.equiposToolStripMenuItem.Text = "Equipos";
			// 
			// tiposToolStripMenuItem
			// 
			this.tiposToolStripMenuItem.Name = "tiposToolStripMenuItem";
			this.tiposToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.tiposToolStripMenuItem.Text = "Tipos";
			// 
			// sesionesToolStripMenuItem
			// 
			this.sesionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.iniciarToolStripMenuItem,
									this.salirToolStripMenuItem,
									this.visorDeSesionesToolStripMenuItem,
									this.resumenToolStripMenuItem,
									this.consolaToolStripMenuItem});
			this.sesionesToolStripMenuItem.Name = "sesionesToolStripMenuItem";
			this.sesionesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.sesionesToolStripMenuItem.Text = "Sesiones";
			// 
			// iniciarToolStripMenuItem
			// 
			this.iniciarToolStripMenuItem.Name = "iniciarToolStripMenuItem";
			this.iniciarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.iniciarToolStripMenuItem.Text = "Iniciar";
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.salirToolStripMenuItem.Text = "Salir";
			// 
			// visorDeSesionesToolStripMenuItem
			// 
			this.visorDeSesionesToolStripMenuItem.Name = "visorDeSesionesToolStripMenuItem";
			this.visorDeSesionesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.visorDeSesionesToolStripMenuItem.Text = "Visor";
			// 
			// resumenToolStripMenuItem
			// 
			this.resumenToolStripMenuItem.Name = "resumenToolStripMenuItem";
			this.resumenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.resumenToolStripMenuItem.Text = "Resumen";
			// 
			// consolaToolStripMenuItem
			// 
			this.consolaToolStripMenuItem.Name = "consolaToolStripMenuItem";
			this.consolaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.consolaToolStripMenuItem.Text = "Consola";
			// 
			// frmPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(792, 573);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmPrincipal";
			this.Text = "frmPrincipal";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem consolaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem resumenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem visorDeSesionesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem iniciarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sesionesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tiposToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem equiposToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
