/*
 * Created by SharpDevelop.
 * User: pumas
 * Date: 10/07/2018
 * Time: 10:35 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PuntoDeVenta
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuStrip mspPuntoDeVenta;
		private System.Windows.Forms.StatusStrip stpPuntoDeVenta;
		private System.Windows.Forms.ToolStrip tspPuntoDeVenta;
		private System.Windows.Forms.ToolStripButton tsbVentas;
		private System.Windows.Forms.ToolStripButton tsbEntradas;
		private System.Windows.Forms.ToolStripMenuItem transaccionesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmVentas;
		private System.Windows.Forms.ToolStripMenuItem tsmEntradas;
		private System.Windows.Forms.ToolStripMenuItem catálogosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmUsuarios;
		private System.Windows.Forms.ToolStripMenuItem tsmClientes;
		private System.Windows.Forms.ToolStripMenuItem tsmProductos;
		private System.Windows.Forms.ToolStripMenuItem tsmProveedores;
		private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tsmAboutUs;
		private System.Windows.Forms.ToolStripMenuItem tsmHelp;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripButton tsbUsuarios;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.mspPuntoDeVenta = new System.Windows.Forms.MenuStrip();
			this.transaccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmVentas = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmEntradas = new System.Windows.Forms.ToolStripMenuItem();
			this.catálogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmUsuarios = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmClientes = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmProductos = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmProveedores = new System.Windows.Forms.ToolStripMenuItem();
			this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmAboutUs = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.stpPuntoDeVenta = new System.Windows.Forms.StatusStrip();
			this.tspPuntoDeVenta = new System.Windows.Forms.ToolStrip();
			this.tsbVentas = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbEntradas = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbUsuarios = new System.Windows.Forms.ToolStripButton();
			this.mspPuntoDeVenta.SuspendLayout();
			this.tspPuntoDeVenta.SuspendLayout();
			this.SuspendLayout();
			// 
			// mspPuntoDeVenta
			// 
			this.mspPuntoDeVenta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.transaccionesToolStripMenuItem,
			this.catálogosToolStripMenuItem,
			this.ayudaToolStripMenuItem});
			this.mspPuntoDeVenta.Location = new System.Drawing.Point(0, 0);
			this.mspPuntoDeVenta.Name = "mspPuntoDeVenta";
			this.mspPuntoDeVenta.Size = new System.Drawing.Size(891, 24);
			this.mspPuntoDeVenta.TabIndex = 0;
			this.mspPuntoDeVenta.Text = "menuStrip1";
			// 
			// transaccionesToolStripMenuItem
			// 
			this.transaccionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.tsmVentas,
			this.tsmEntradas});
			this.transaccionesToolStripMenuItem.Name = "transaccionesToolStripMenuItem";
			this.transaccionesToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
			this.transaccionesToolStripMenuItem.Text = "Transacciones";
			// 
			// tsmVentas
			// 
			this.tsmVentas.Name = "tsmVentas";
			this.tsmVentas.Size = new System.Drawing.Size(187, 22);
			this.tsmVentas.Text = "Ventas";
			this.tsmVentas.Click += new System.EventHandler(this.TsmVentasClick);
			// 
			// tsmEntradas
			// 
			this.tsmEntradas.Name = "tsmEntradas";
			this.tsmEntradas.Size = new System.Drawing.Size(187, 22);
			this.tsmEntradas.Text = "Entrada de productos";
			this.tsmEntradas.Click += new System.EventHandler(this.TsmEntradasClick);
			// 
			// catálogosToolStripMenuItem
			// 
			this.catálogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.tsmUsuarios,
			this.tsmClientes,
			this.tsmProductos,
			this.tsmProveedores});
			this.catálogosToolStripMenuItem.Name = "catálogosToolStripMenuItem";
			this.catálogosToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
			this.catálogosToolStripMenuItem.Text = "Catálogos";
			// 
			// tsmUsuarios
			// 
			this.tsmUsuarios.Name = "tsmUsuarios";
			this.tsmUsuarios.Size = new System.Drawing.Size(152, 22);
			this.tsmUsuarios.Text = "Usuarios";
			this.tsmUsuarios.Click += new System.EventHandler(this.TsmUsuariosClick);
			// 
			// tsmClientes
			// 
			this.tsmClientes.Name = "tsmClientes";
			this.tsmClientes.Size = new System.Drawing.Size(152, 22);
			this.tsmClientes.Text = "Clientes";
			this.tsmClientes.Click += new System.EventHandler(this.TsmClientesClick);
			// 
			// tsmProductos
			// 
			this.tsmProductos.Name = "tsmProductos";
			this.tsmProductos.Size = new System.Drawing.Size(152, 22);
			this.tsmProductos.Text = "Productos";
			this.tsmProductos.Click += new System.EventHandler(this.TsmProductosClick);
			// 
			// tsmProveedores
			// 
			this.tsmProveedores.Name = "tsmProveedores";
			this.tsmProveedores.Size = new System.Drawing.Size(152, 22);
			this.tsmProveedores.Text = "Proveedores";
			this.tsmProveedores.Click += new System.EventHandler(this.TsmProveedoresClick);
			// 
			// ayudaToolStripMenuItem
			// 
			this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.tsmAboutUs,
			this.tsmHelp});
			this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
			this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
			this.ayudaToolStripMenuItem.Text = "Ayuda";
			// 
			// tsmAboutUs
			// 
			this.tsmAboutUs.Name = "tsmAboutUs";
			this.tsmAboutUs.Size = new System.Drawing.Size(155, 22);
			this.tsmAboutUs.Text = "Sobre Nosotros";
			// 
			// tsmHelp
			// 
			this.tsmHelp.Name = "tsmHelp";
			this.tsmHelp.Size = new System.Drawing.Size(155, 22);
			this.tsmHelp.Text = "Ayuda";
			// 
			// stpPuntoDeVenta
			// 
			this.stpPuntoDeVenta.GripMargin = new System.Windows.Forms.Padding(4);
			this.stpPuntoDeVenta.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.stpPuntoDeVenta.Location = new System.Drawing.Point(0, 344);
			this.stpPuntoDeVenta.Name = "stpPuntoDeVenta";
			this.stpPuntoDeVenta.Size = new System.Drawing.Size(891, 22);
			this.stpPuntoDeVenta.TabIndex = 1;
			this.stpPuntoDeVenta.Text = "statusStrip1";
			// 
			// tspPuntoDeVenta
			// 
			this.tspPuntoDeVenta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.tsbVentas,
			this.toolStripSeparator1,
			this.toolStripSeparator2,
			this.tsbEntradas,
			this.toolStripSeparator3,
			this.toolStripSeparator4,
			this.tsbUsuarios});
			this.tspPuntoDeVenta.Location = new System.Drawing.Point(0, 24);
			this.tspPuntoDeVenta.Name = "tspPuntoDeVenta";
			this.tspPuntoDeVenta.Size = new System.Drawing.Size(891, 25);
			this.tspPuntoDeVenta.TabIndex = 2;
			this.tspPuntoDeVenta.Text = "toolStrip1";
			// 
			// tsbVentas
			// 
			this.tsbVentas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbVentas.Image = ((System.Drawing.Image)(resources.GetObject("tsbVentas.Image")));
			this.tsbVentas.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbVentas.Name = "tsbVentas";
			this.tsbVentas.Size = new System.Drawing.Size(23, 22);
			this.tsbVentas.Text = "Ventas";
			this.tsbVentas.Click += new System.EventHandler(this.TsbVentasClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// tsbEntradas
			// 
			this.tsbEntradas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbEntradas.Image = ((System.Drawing.Image)(resources.GetObject("tsbEntradas.Image")));
			this.tsbEntradas.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbEntradas.Name = "tsbEntradas";
			this.tsbEntradas.Size = new System.Drawing.Size(23, 22);
			this.tsbEntradas.Text = "Entradas";
			this.tsbEntradas.Click += new System.EventHandler(this.TsbEntradasClick);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			// 
			// tsbUsuarios
			// 
			this.tsbUsuarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("tsbUsuarios.Image")));
			this.tsbUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbUsuarios.Name = "tsbUsuarios";
			this.tsbUsuarios.Size = new System.Drawing.Size(23, 22);
			this.tsbUsuarios.Text = "Usuarios";
			this.tsbUsuarios.Click += new System.EventHandler(this.TsbUsuariosClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(891, 366);
			this.Controls.Add(this.tspPuntoDeVenta);
			this.Controls.Add(this.stpPuntoDeVenta);
			this.Controls.Add(this.mspPuntoDeVenta);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.mspPuntoDeVenta;
			this.Name = "MainForm";
			this.Text = "PuntoDeVenta";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.mspPuntoDeVenta.ResumeLayout(false);
			this.mspPuntoDeVenta.PerformLayout();
			this.tspPuntoDeVenta.ResumeLayout(false);
			this.tspPuntoDeVenta.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
