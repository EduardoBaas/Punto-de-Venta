/*
 * Created by SharpDevelop.
 * User: pumas
 * Date: 11/07/2018
 * Time: 02:29 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PuntoDeVenta
{
	partial class frmProductos
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.TextBox txtProducto;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCosto;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtMaximo;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtMinimo;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataGridView dgvProductos;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtBuscar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtExistencia;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblBarras;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.TextBox txtBuscarD;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.DataGridView dgvProductosD;
		private System.Windows.Forms.Button btnRestore;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnInsert;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.label8 = new System.Windows.Forms.Label();
			this.dgvProductos = new System.Windows.Forms.DataGridView();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnInsert = new System.Windows.Forms.Button();
			this.lblBarras = new System.Windows.Forms.Label();
			this.txtExistencia = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.txtMinimo = new System.Windows.Forms.TextBox();
			this.txtMaximo = new System.Windows.Forms.TextBox();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.txtProducto = new System.Windows.Forms.TextBox();
			this.txtCosto = new System.Windows.Forms.TextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.btnRestore = new System.Windows.Forms.Button();
			this.txtBuscarD = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.dgvProductosD = new System.Windows.Forms.DataGridView();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductosD)).BeginInit();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1357, 569);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.Lavender;
			this.tabPage1.Controls.Add(this.txtBuscar);
			this.tabPage1.Controls.Add(this.panel2);
			this.tabPage1.Controls.Add(this.label8);
			this.tabPage1.Controls.Add(this.dgvProductos);
			this.tabPage1.Controls.Add(this.label7);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.panel1);
			this.tabPage1.Location = new System.Drawing.Point(4, 23);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1349, 542);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Agregar productos";
			// 
			// txtBuscar
			// 
			this.txtBuscar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtBuscar.Location = new System.Drawing.Point(675, 59);
			this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.Size = new System.Drawing.Size(551, 22);
			this.txtBuscar.TabIndex = 31;
			this.txtBuscar.TextChanged += new System.EventHandler(this.TxtBuscarTextChanged);
			this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscarKeyPress);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.panel2.Controls.Add(this.label10);
			this.panel2.Controls.Add(this.label9);
			this.panel2.Controls.Add(this.pictureBox8);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(374, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(972, 50);
			this.panel2.TabIndex = 33;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Candara", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.LightSeaGreen;
			this.label10.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label10.Location = new System.Drawing.Point(216, 6);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(124, 40);
			this.label10.TabIndex = 25;
			this.label10.Text = "Ventas";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Candara", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
			this.label9.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label9.Location = new System.Drawing.Point(96, 6);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(124, 40);
			this.label9.TabIndex = 24;
			this.label9.Text = "Absolute";
			// 
			// pictureBox8
			// 
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(6, 0);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(100, 49);
			this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox8.TabIndex = 23;
			this.pictureBox8.TabStop = false;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(601, 61);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(133, 25);
			this.label8.TabIndex = 30;
			this.label8.Text = "Buscar";
			// 
			// dgvProductos
			// 
			this.dgvProductos.AllowUserToAddRows = false;
			this.dgvProductos.AllowUserToDeleteRows = false;
			this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvProductos.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvProductos.ColumnHeadersHeight = 35;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DodgerBlue;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle1;
			this.dgvProductos.GridColor = System.Drawing.Color.Lavender;
			this.dgvProductos.Location = new System.Drawing.Point(395, 92);
			this.dgvProductos.Name = "dgvProductos";
			this.dgvProductos.ReadOnly = true;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvProductos.RowHeadersVisible = false;
			this.dgvProductos.RowHeadersWidth = 120;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.Lavender;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			this.dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvProductos.Size = new System.Drawing.Size(925, 423);
			this.dgvProductos.TabIndex = 29;
			this.dgvProductos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvProductosKeyDown);
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(33, 250);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(209, 25);
			this.label7.TabIndex = 28;
			this.label7.Text = "Stock mínimo";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(33, 317);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(209, 25);
			this.label6.TabIndex = 27;
			this.label6.Text = "Stock máximo";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(33, 184);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(209, 25);
			this.label4.TabIndex = 26;
			this.label4.Text = "Costo";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(33, 116);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(230, 25);
			this.label3.TabIndex = 25;
			this.label3.Text = "Nombre del producto";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(33, 49);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(209, 25);
			this.label2.TabIndex = 24;
			this.label2.Text = "Código de barras";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Controls.Add(this.btnClear);
			this.panel1.Controls.Add(this.btnInsert);
			this.panel1.Controls.Add(this.lblBarras);
			this.panel1.Controls.Add(this.txtExistencia);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.pictureBox6);
			this.panel1.Controls.Add(this.pictureBox5);
			this.panel1.Controls.Add(this.pictureBox4);
			this.panel1.Controls.Add(this.pictureBox3);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.btnGuardar);
			this.panel1.Controls.Add(this.btnEditar);
			this.panel1.Controls.Add(this.btnEliminar);
			this.panel1.Controls.Add(this.txtMinimo);
			this.panel1.Controls.Add(this.txtMaximo);
			this.panel1.Controls.Add(this.txtCodigo);
			this.panel1.Controls.Add(this.txtProducto);
			this.panel1.Controls.Add(this.txtCosto);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(371, 536);
			this.panel1.TabIndex = 32;
			// 
			// btnClear
			// 
			this.btnClear.BackColor = System.Drawing.Color.White;
			this.btnClear.ForeColor = System.Drawing.Color.Orange;
			this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
			this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClear.Location = new System.Drawing.Point(193, 493);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(96, 37);
			this.btnClear.TabIndex = 30;
			this.btnClear.Text = "Limpiar";
			this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnClear.UseVisualStyleBackColor = false;
			this.btnClear.Click += new System.EventHandler(this.BtnClearClick);
			// 
			// btnInsert
			// 
			this.btnInsert.BackColor = System.Drawing.Color.White;
			this.btnInsert.ForeColor = System.Drawing.Color.MediumBlue;
			this.btnInsert.Image = ((System.Drawing.Image)(resources.GetObject("btnInsert.Image")));
			this.btnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnInsert.Location = new System.Drawing.Point(75, 493);
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(96, 37);
			this.btnInsert.TabIndex = 29;
			this.btnInsert.Text = "Guardar";
			this.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnInsert.UseVisualStyleBackColor = false;
			this.btnInsert.Click += new System.EventHandler(this.BtnInsertClick);
			// 
			// lblBarras
			// 
			this.lblBarras.Location = new System.Drawing.Point(0, 513);
			this.lblBarras.Name = "lblBarras";
			this.lblBarras.Size = new System.Drawing.Size(100, 23);
			this.lblBarras.TabIndex = 28;
			this.lblBarras.Text = "label11";
			this.lblBarras.Visible = false;
			// 
			// txtExistencia
			// 
			this.txtExistencia.BackColor = System.Drawing.Color.LightSteelBlue;
			this.txtExistencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtExistencia.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtExistencia.Location = new System.Drawing.Point(66, 410);
			this.txtExistencia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtExistencia.Name = "txtExistencia";
			this.txtExistencia.Size = new System.Drawing.Size(265, 26);
			this.txtExistencia.TabIndex = 27;
			this.txtExistencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtExistenciaKeyPress);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(36, 410);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(32, 32);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 26;
			this.pictureBox1.TabStop = false;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(36, 382);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(209, 25);
			this.label5.TabIndex = 24;
			this.label5.Text = "Existencia";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(36, 9);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(310, 34);
			this.label1.TabIndex = 0;
			this.label1.Text = "Agregar o editar productos";
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(32, 345);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(32, 32);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox6.TabIndex = 25;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(32, 144);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(32, 32);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox5.TabIndex = 24;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(32, 212);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(32, 32);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox4.TabIndex = 23;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(33, 278);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(32, 32);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox3.TabIndex = 22;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(32, 75);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(32, 32);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox2.TabIndex = 21;
			this.pictureBox2.TabStop = false;
			// 
			// btnGuardar
			// 
			this.btnGuardar.BackColor = System.Drawing.Color.White;
			this.btnGuardar.ForeColor = System.Drawing.Color.OliveDrab;
			this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
			this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardar.Location = new System.Drawing.Point(24, 450);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(96, 37);
			this.btnGuardar.TabIndex = 20;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGuardar.UseVisualStyleBackColor = false;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// btnEditar
			// 
			this.btnEditar.BackColor = System.Drawing.Color.White;
			this.btnEditar.ForeColor = System.Drawing.Color.DarkKhaki;
			this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
			this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEditar.Location = new System.Drawing.Point(137, 450);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(96, 37);
			this.btnEditar.TabIndex = 19;
			this.btnEditar.Text = "Editar P.";
			this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEditar.UseVisualStyleBackColor = false;
			this.btnEditar.Click += new System.EventHandler(this.BtnEditarClick);
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.Color.White;
			this.btnEliminar.ForeColor = System.Drawing.Color.Crimson;
			this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
			this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEliminar.Location = new System.Drawing.Point(250, 450);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(96, 37);
			this.btnEliminar.TabIndex = 18;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// txtMinimo
			// 
			this.txtMinimo.BackColor = System.Drawing.Color.LightSteelBlue;
			this.txtMinimo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtMinimo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMinimo.Location = new System.Drawing.Point(66, 278);
			this.txtMinimo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtMinimo.Name = "txtMinimo";
			this.txtMinimo.Size = new System.Drawing.Size(265, 26);
			this.txtMinimo.TabIndex = 12;
			this.txtMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMinimoKeyPress);
			// 
			// txtMaximo
			// 
			this.txtMaximo.BackColor = System.Drawing.Color.LightSteelBlue;
			this.txtMaximo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtMaximo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaximo.Location = new System.Drawing.Point(66, 345);
			this.txtMaximo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtMaximo.Name = "txtMaximo";
			this.txtMaximo.Size = new System.Drawing.Size(265, 26);
			this.txtMaximo.TabIndex = 10;
			this.txtMaximo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMaximoKeyPress);
			// 
			// txtCodigo
			// 
			this.txtCodigo.BackColor = System.Drawing.Color.LightSteelBlue;
			this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCodigo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCodigo.Location = new System.Drawing.Point(66, 77);
			this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(265, 26);
			this.txtCodigo.TabIndex = 2;
			this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigoKeyPress);
			// 
			// txtProducto
			// 
			this.txtProducto.BackColor = System.Drawing.Color.LightSteelBlue;
			this.txtProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtProducto.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProducto.Location = new System.Drawing.Point(66, 144);
			this.txtProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtProducto.Name = "txtProducto";
			this.txtProducto.Size = new System.Drawing.Size(265, 26);
			this.txtProducto.TabIndex = 4;
			this.txtProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtProductoKeyPress);
			// 
			// txtCosto
			// 
			this.txtCosto.BackColor = System.Drawing.Color.LightSteelBlue;
			this.txtCosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCosto.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCosto.Location = new System.Drawing.Point(66, 212);
			this.txtCosto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtCosto.Name = "txtCosto";
			this.txtCosto.Size = new System.Drawing.Size(265, 26);
			this.txtCosto.TabIndex = 6;
			this.txtCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCostoKeyPress);
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.Lavender;
			this.tabPage2.Controls.Add(this.btnRestore);
			this.tabPage2.Controls.Add(this.txtBuscarD);
			this.tabPage2.Controls.Add(this.label13);
			this.tabPage2.Controls.Add(this.dgvProductosD);
			this.tabPage2.Controls.Add(this.panel3);
			this.tabPage2.Location = new System.Drawing.Point(4, 23);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1349, 542);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Productos eliminados";
			// 
			// btnRestore
			// 
			this.btnRestore.BackColor = System.Drawing.Color.White;
			this.btnRestore.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRestore.ForeColor = System.Drawing.Color.YellowGreen;
			this.btnRestore.Image = ((System.Drawing.Image)(resources.GetObject("btnRestore.Image")));
			this.btnRestore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRestore.Location = new System.Drawing.Point(1187, 488);
			this.btnRestore.Name = "btnRestore";
			this.btnRestore.Size = new System.Drawing.Size(136, 39);
			this.btnRestore.TabIndex = 57;
			this.btnRestore.Text = "Restaurar";
			this.btnRestore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnRestore.UseVisualStyleBackColor = false;
			this.btnRestore.Click += new System.EventHandler(this.BtnRestoreClick);
			// 
			// txtBuscarD
			// 
			this.txtBuscarD.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.txtBuscarD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtBuscarD.Location = new System.Drawing.Point(146, 71);
			this.txtBuscarD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtBuscarD.Name = "txtBuscarD";
			this.txtBuscarD.Size = new System.Drawing.Size(551, 22);
			this.txtBuscarD.TabIndex = 37;
			this.txtBuscarD.TextChanged += new System.EventHandler(this.TxtBuscarDTextChanged);
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.Black;
			this.label13.Location = new System.Drawing.Point(72, 72);
			this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(133, 25);
			this.label13.TabIndex = 36;
			this.label13.Text = "Buscar";
			// 
			// dgvProductosD
			// 
			this.dgvProductosD.AllowUserToAddRows = false;
			this.dgvProductosD.AllowUserToDeleteRows = false;
			this.dgvProductosD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvProductosD.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvProductosD.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvProductosD.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvProductosD.ColumnHeadersHeight = 35;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DodgerBlue;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvProductosD.DefaultCellStyle = dataGridViewCellStyle4;
			this.dgvProductosD.GridColor = System.Drawing.Color.Lavender;
			this.dgvProductosD.Location = new System.Drawing.Point(18, 119);
			this.dgvProductosD.Name = "dgvProductosD";
			this.dgvProductosD.ReadOnly = true;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvProductosD.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvProductosD.RowHeadersVisible = false;
			this.dgvProductosD.RowHeadersWidth = 120;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.Lavender;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
			this.dgvProductosD.RowsDefaultCellStyle = dataGridViewCellStyle6;
			this.dgvProductosD.Size = new System.Drawing.Size(1305, 361);
			this.dgvProductosD.TabIndex = 35;
			this.dgvProductosD.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DgvProductosDRowsAdded);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panel3.Controls.Add(this.label11);
			this.panel3.Controls.Add(this.label12);
			this.panel3.Controls.Add(this.pictureBox7);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(3, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1343, 50);
			this.panel3.TabIndex = 34;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Candara", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.LightSeaGreen;
			this.label11.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label11.Location = new System.Drawing.Point(216, 6);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(124, 40);
			this.label11.TabIndex = 25;
			this.label11.Text = "Ventas";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Candara", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.DodgerBlue;
			this.label12.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label12.Location = new System.Drawing.Point(96, 6);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(124, 40);
			this.label12.TabIndex = 24;
			this.label12.Text = "Absolute";
			// 
			// pictureBox7
			// 
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(6, 0);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(100, 49);
			this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox7.TabIndex = 23;
			this.pictureBox7.TabStop = false;
			// 
			// frmProductos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Lavender;
			this.ClientSize = new System.Drawing.Size(1354, 571);
			this.Controls.Add(this.tabControl1);
			this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.DodgerBlue;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MaximizeBox = false;
			this.Name = "frmProductos";
			this.Text = "Catálogo de productos";
			this.Load += new System.EventHandler(this.FrmProductosLoad);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductosD)).EndInit();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
