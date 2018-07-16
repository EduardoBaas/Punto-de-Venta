/*
 * Created by SharpDevelop.
 * User: pumas
 * Date: 11/07/2018
 * Time: 07:52 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PuntoDeVenta
{
	partial class frmLogin
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox ptxIngresar;
		private System.Windows.Forms.Label lblHora;
		private System.Windows.Forms.TextBox txtContra;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Label lblFecha;
		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.Button btnMinimizar;
		private System.Windows.Forms.Timer tmrFechaHora;
		
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnCerrar = new System.Windows.Forms.Button();
			this.btnMinimizar = new System.Windows.Forms.Button();
			this.lblFecha = new System.Windows.Forms.Label();
			this.lblHora = new System.Windows.Forms.Label();
			this.txtContra = new System.Windows.Forms.TextBox();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.ptxIngresar = new System.Windows.Forms.PictureBox();
			this.tmrFechaHora = new System.Windows.Forms.Timer(this.components);
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ptxIngresar)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.Controls.Add(this.btnCerrar);
			this.panel1.Controls.Add(this.btnMinimizar);
			this.panel1.Controls.Add(this.lblFecha);
			this.panel1.Controls.Add(this.lblHora);
			this.panel1.Controls.Add(this.txtContra);
			this.panel1.Controls.Add(this.txtUsuario);
			this.panel1.Controls.Add(this.ptxIngresar);
			this.panel1.Location = new System.Drawing.Point(91, 126);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(500, 224);
			this.panel1.TabIndex = 0;
			// 
			// btnCerrar
			// 
			this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
			this.btnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCerrar.BackgroundImage")));
			this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCerrar.ForeColor = System.Drawing.Color.Transparent;
			this.btnCerrar.Location = new System.Drawing.Point(56, 184);
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.Size = new System.Drawing.Size(30, 29);
			this.btnCerrar.TabIndex = 8;
			this.btnCerrar.UseVisualStyleBackColor = false;
			this.btnCerrar.Click += new System.EventHandler(this.BtnCerrarClick);
			// 
			// btnMinimizar
			// 
			this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
			this.btnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.BackgroundImage")));
			this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnMinimizar.ForeColor = System.Drawing.Color.Transparent;
			this.btnMinimizar.Location = new System.Drawing.Point(14, 184);
			this.btnMinimizar.Name = "btnMinimizar";
			this.btnMinimizar.Size = new System.Drawing.Size(30, 29);
			this.btnMinimizar.TabIndex = 7;
			this.btnMinimizar.UseVisualStyleBackColor = false;
			this.btnMinimizar.Click += new System.EventHandler(this.BtnMinimizarClick);
			// 
			// lblFecha
			// 
			this.lblFecha.BackColor = System.Drawing.Color.Transparent;
			this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFecha.ForeColor = System.Drawing.Color.LightSkyBlue;
			this.lblFecha.Location = new System.Drawing.Point(296, 184);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(188, 27);
			this.lblFecha.TabIndex = 6;
			this.lblFecha.Text = "Fecha";
			// 
			// lblHora
			// 
			this.lblHora.BackColor = System.Drawing.Color.Transparent;
			this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHora.ForeColor = System.Drawing.Color.LightSkyBlue;
			this.lblHora.Location = new System.Drawing.Point(350, 24);
			this.lblHora.Name = "lblHora";
			this.lblHora.Size = new System.Drawing.Size(134, 27);
			this.lblHora.TabIndex = 5;
			this.lblHora.Text = "Hora";
			// 
			// txtContra
			// 
			this.txtContra.BackColor = System.Drawing.Color.SkyBlue;
			this.txtContra.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtContra.ForeColor = System.Drawing.Color.MidnightBlue;
			this.txtContra.Location = new System.Drawing.Point(114, 121);
			this.txtContra.Name = "txtContra";
			this.txtContra.PasswordChar = '*';
			this.txtContra.Size = new System.Drawing.Size(237, 17);
			this.txtContra.TabIndex = 4;
			// 
			// txtUsuario
			// 
			this.txtUsuario.BackColor = System.Drawing.Color.SkyBlue;
			this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsuario.ForeColor = System.Drawing.Color.MidnightBlue;
			this.txtUsuario.Location = new System.Drawing.Point(114, 81);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(237, 17);
			this.txtUsuario.TabIndex = 3;
			// 
			// ptxIngresar
			// 
			this.ptxIngresar.BackColor = System.Drawing.Color.Transparent;
			this.ptxIngresar.Image = ((System.Drawing.Image)(resources.GetObject("ptxIngresar.Image")));
			this.ptxIngresar.InitialImage = ((System.Drawing.Image)(resources.GetObject("ptxIngresar.InitialImage")));
			this.ptxIngresar.Location = new System.Drawing.Point(378, 72);
			this.ptxIngresar.Name = "ptxIngresar";
			this.ptxIngresar.Size = new System.Drawing.Size(80, 75);
			this.ptxIngresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ptxIngresar.TabIndex = 0;
			this.ptxIngresar.TabStop = false;
			this.ptxIngresar.Click += new System.EventHandler(this.PtxIngresarClick);
			this.ptxIngresar.MouseLeave += new System.EventHandler(this.PtxIngresarMouseLeave);
			this.ptxIngresar.MouseHover += new System.EventHandler(this.PtxIngresarMouseHover);
			// 
			// tmrFechaHora
			// 
			this.tmrFechaHora.Interval = 1000;
			this.tmrFechaHora.Tick += new System.EventHandler(this.TmrFechaHoraTick);
			// 
			// frmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(663, 382);
			this.Controls.Add(this.panel1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.Name = "frmLogin";
			this.Text = "frmLogin";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FrmLoginLoad);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ptxIngresar)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
