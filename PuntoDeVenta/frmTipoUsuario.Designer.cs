/*
 * Created by SharpDevelop.
 * User: pumas
 * Date: 30/07/2018
 * Time: 10:35 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PuntoDeVenta
{
	partial class frmTipoUsuario
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txtPermiso;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTipo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dgvTipos;
		private System.Windows.Forms.DataGridView dgvTipoD;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnRestore;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnGuardarUp;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipoUsuario));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.btnGuardarUp = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.dgvTipos = new System.Windows.Forms.DataGridView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtPermiso = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtTipo = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.btnRestore = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.dgvTipoD = new System.Windows.Forms.DataGridView();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTipos)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvTipoD)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(481, 449);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.btnGuardarUp);
			this.tabPage1.Controls.Add(this.btnEditar);
			this.tabPage1.Controls.Add(this.btnCancelar);
			this.tabPage1.Controls.Add(this.btnSave);
			this.tabPage1.Controls.Add(this.dgvTipos);
			this.tabPage1.Controls.Add(this.panel2);
			this.tabPage1.Controls.Add(this.panel1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(473, 423);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Editar tipos";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// btnGuardarUp
			// 
			this.btnGuardarUp.BackColor = System.Drawing.Color.White;
			this.btnGuardarUp.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardarUp.ForeColor = System.Drawing.Color.LimeGreen;
			this.btnGuardarUp.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarUp.Image")));
			this.btnGuardarUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardarUp.Location = new System.Drawing.Point(121, 383);
			this.btnGuardarUp.Name = "btnGuardarUp";
			this.btnGuardarUp.Size = new System.Drawing.Size(113, 34);
			this.btnGuardarUp.TabIndex = 58;
			this.btnGuardarUp.Text = "Update";
			this.btnGuardarUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGuardarUp.UseVisualStyleBackColor = false;
			this.btnGuardarUp.Click += new System.EventHandler(this.BtnGuardarUpClick);
			// 
			// btnEditar
			// 
			this.btnEditar.BackColor = System.Drawing.Color.White;
			this.btnEditar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditar.ForeColor = System.Drawing.Color.LimeGreen;
			this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
			this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEditar.Location = new System.Drawing.Point(8, 383);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(107, 34);
			this.btnEditar.TabIndex = 57;
			this.btnEditar.Text = "Editar";
			this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEditar.UseVisualStyleBackColor = false;
			this.btnEditar.Click += new System.EventHandler(this.BtnEditarClick);
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackColor = System.Drawing.Color.White;
			this.btnCancelar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.ForeColor = System.Drawing.Color.Crimson;
			this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelar.Location = new System.Drawing.Point(354, 383);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(107, 34);
			this.btnCancelar.TabIndex = 56;
			this.btnCancelar.Text = "Limpiar";
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.White;
			this.btnSave.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.ForeColor = System.Drawing.Color.RoyalBlue;
			this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.Location = new System.Drawing.Point(240, 383);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(107, 34);
			this.btnSave.TabIndex = 55;
			this.btnSave.Text = "Guardar";
			this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
			// 
			// dgvTipos
			// 
			this.dgvTipos.AllowUserToAddRows = false;
			this.dgvTipos.AllowUserToOrderColumns = true;
			this.dgvTipos.AllowUserToResizeColumns = false;
			this.dgvTipos.AllowUserToResizeRows = false;
			this.dgvTipos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvTipos.BackgroundColor = System.Drawing.Color.White;
			this.dgvTipos.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvTipos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvTipos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvTipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTipos.Location = new System.Drawing.Point(20, 143);
			this.dgvTipos.Name = "dgvTipos";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvTipos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvTipos.RowHeadersVisible = false;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Desktop;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
			this.dgvTipos.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvTipos.Size = new System.Drawing.Size(430, 232);
			this.dgvTipos.TabIndex = 38;
			this.dgvTipos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvTiposKeyDown);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel2.Controls.Add(this.pictureBox10);
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Controls.Add(this.txtPermiso);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.txtTipo);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(3, 53);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(467, 84);
			this.panel2.TabIndex = 1;
			// 
			// pictureBox10
			// 
			this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
			this.pictureBox10.Location = new System.Drawing.Point(4, 29);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(32, 32);
			this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox10.TabIndex = 52;
			this.pictureBox10.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(248, 29);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(32, 32);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 32;
			this.pictureBox1.TabStop = false;
			// 
			// txtPermiso
			// 
			this.txtPermiso.BackColor = System.Drawing.Color.LightSteelBlue;
			this.txtPermiso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPermiso.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPermiso.Location = new System.Drawing.Point(282, 31);
			this.txtPermiso.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtPermiso.Name = "txtPermiso";
			this.txtPermiso.Size = new System.Drawing.Size(176, 26);
			this.txtPermiso.TabIndex = 31;
			this.txtPermiso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPermisoKeyPress);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(249, 3);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(209, 25);
			this.label1.TabIndex = 33;
			this.label1.Text = "Permisos *";
			// 
			// txtTipo
			// 
			this.txtTipo.BackColor = System.Drawing.Color.LightSteelBlue;
			this.txtTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTipo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTipo.Location = new System.Drawing.Point(37, 31);
			this.txtTipo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtTipo.Name = "txtTipo";
			this.txtTipo.Size = new System.Drawing.Size(176, 26);
			this.txtTipo.TabIndex = 28;
			this.txtTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTipoKeyPress);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(4, 3);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(209, 25);
			this.label2.TabIndex = 30;
			this.label2.Text = "Tipo de usuario *";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.pictureBox8);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(467, 50);
			this.panel1.TabIndex = 0;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Candara", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.LightSeaGreen;
			this.label10.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label10.Location = new System.Drawing.Point(276, 7);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(124, 40);
			this.label10.TabIndex = 31;
			this.label10.Text = "Ventas";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Candara", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
			this.label9.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label9.Location = new System.Drawing.Point(156, 7);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(124, 40);
			this.label9.TabIndex = 30;
			this.label9.Text = "Absolute";
			// 
			// pictureBox8
			// 
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(66, 1);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(100, 49);
			this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox8.TabIndex = 29;
			this.pictureBox8.TabStop = false;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.btnRestore);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.panel3);
			this.tabPage2.Controls.Add(this.dgvTipoD);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(473, 423);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Restaurar Tipos";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// btnRestore
			// 
			this.btnRestore.BackColor = System.Drawing.Color.White;
			this.btnRestore.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRestore.ForeColor = System.Drawing.Color.YellowGreen;
			this.btnRestore.Image = ((System.Drawing.Image)(resources.GetObject("btnRestore.Image")));
			this.btnRestore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRestore.Location = new System.Drawing.Point(326, 378);
			this.btnRestore.Name = "btnRestore";
			this.btnRestore.Size = new System.Drawing.Size(136, 39);
			this.btnRestore.TabIndex = 55;
			this.btnRestore.Text = "Restaurar";
			this.btnRestore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnRestore.UseVisualStyleBackColor = false;
			this.btnRestore.Click += new System.EventHandler(this.BtnRestoreClick);
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label5.Location = new System.Drawing.Point(121, 70);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(246, 25);
			this.label5.TabIndex = 41;
			this.label5.Text = "Tipos de usuarios eliminados";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.pictureBox3);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(3, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(467, 50);
			this.panel3.TabIndex = 40;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Candara", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.LightSeaGreen;
			this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label3.Location = new System.Drawing.Point(276, 7);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(124, 40);
			this.label3.TabIndex = 34;
			this.label3.Text = "Ventas";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Candara", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
			this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label4.Location = new System.Drawing.Point(156, 7);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(124, 40);
			this.label4.TabIndex = 33;
			this.label4.Text = "Absolute";
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(66, 1);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(100, 49);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 32;
			this.pictureBox3.TabStop = false;
			// 
			// dgvTipoD
			// 
			this.dgvTipoD.AllowUserToAddRows = false;
			this.dgvTipoD.AllowUserToOrderColumns = true;
			this.dgvTipoD.AllowUserToResizeColumns = false;
			this.dgvTipoD.AllowUserToResizeRows = false;
			this.dgvTipoD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvTipoD.BackgroundColor = System.Drawing.Color.White;
			this.dgvTipoD.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvTipoD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvTipoD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvTipoD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTipoD.Location = new System.Drawing.Point(8, 98);
			this.dgvTipoD.Name = "dgvTipoD";
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvTipoD.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvTipoD.RowHeadersVisible = false;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Desktop;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
			this.dgvTipoD.RowsDefaultCellStyle = dataGridViewCellStyle6;
			this.dgvTipoD.Size = new System.Drawing.Size(454, 270);
			this.dgvTipoD.TabIndex = 39;
			this.dgvTipoD.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DgvTipoDRowsAdded);
			this.dgvTipoD.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DgvTipoDRowsRemoved);
			// 
			// frmTipoUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(478, 448);
			this.Controls.Add(this.tabControl1);
			this.MaximizeBox = false;
			this.Name = "frmTipoUsuario";
			this.Text = "frmTipoUsuario";
			this.Load += new System.EventHandler(this.FrmTipoUsuarioLoad);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvTipos)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvTipoD)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
