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
	partial class frmProveedores
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnagregar;
		private System.Windows.Forms.TextBox txttelefono;
		private System.Windows.Forms.TextBox txtcorreo;
		private System.Windows.Forms.TextBox txtdireccion;
		private System.Windows.Forms.TextBox txtduenio;
		private System.Windows.Forms.TextBox txtrfc;
		private System.Windows.Forms.TextBox txtnombre;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.DataGridView dgvproveedor;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.TextBox txtBuscar;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btneliminar;
		private System.Windows.Forms.Button btnmodificar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtid_proveedor;
		private System.Windows.Forms.Button btnguardar2;
		private System.Windows.Forms.Button btnrestaurar;
		private System.Windows.Forms.DataGridView dgvproveedores_inactivos;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedores));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnguardar2 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txtid_proveedor = new System.Windows.Forms.TextBox();
			this.btnagregar = new System.Windows.Forms.Button();
			this.txttelefono = new System.Windows.Forms.TextBox();
			this.txtcorreo = new System.Windows.Forms.TextBox();
			this.txtdireccion = new System.Windows.Forms.TextBox();
			this.txtduenio = new System.Windows.Forms.TextBox();
			this.txtrfc = new System.Windows.Forms.TextBox();
			this.txtnombre = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.dgvproveedor = new System.Windows.Forms.DataGridView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label10 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label12 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btneliminar = new System.Windows.Forms.Button();
			this.btnmodificar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.btnrestaurar = new System.Windows.Forms.Button();
			this.dgvproveedores_inactivos = new System.Windows.Forms.DataGridView();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvproveedor)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvproveedores_inactivos)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1356, 565);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.groupBox2);
			this.tabPage1.Controls.Add(this.dgvproveedor);
			this.tabPage1.Controls.Add(this.panel2);
			this.tabPage1.Controls.Add(this.panel3);
			this.tabPage1.Controls.Add(this.panel1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1348, 539);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "INSERTAR PROVEEDORES";
			this.tabPage1.UseVisualStyleBackColor = true;
			this.tabPage1.Click += new System.EventHandler(this.TabPage1Click);
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.groupBox2.Controls.Add(this.btnguardar2);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.txtid_proveedor);
			this.groupBox2.Controls.Add(this.btnagregar);
			this.groupBox2.Controls.Add(this.txttelefono);
			this.groupBox2.Controls.Add(this.txtcorreo);
			this.groupBox2.Controls.Add(this.txtdireccion);
			this.groupBox2.Controls.Add(this.txtduenio);
			this.groupBox2.Controls.Add(this.txtrfc);
			this.groupBox2.Controls.Add(this.txtnombre);
			this.groupBox2.Controls.Add(this.label14);
			this.groupBox2.Controls.Add(this.label15);
			this.groupBox2.Controls.Add(this.label16);
			this.groupBox2.Controls.Add(this.label17);
			this.groupBox2.Controls.Add(this.label18);
			this.groupBox2.Controls.Add(this.label19);
			this.groupBox2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.ForeColor = System.Drawing.Color.AliceBlue;
			this.groupBox2.Location = new System.Drawing.Point(4, 50);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(300, 530);
			this.groupBox2.TabIndex = 46;
			this.groupBox2.TabStop = false;
			// 
			// btnguardar2
			// 
			this.btnguardar2.ForeColor = System.Drawing.Color.DodgerBlue;
			this.btnguardar2.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar2.Image")));
			this.btnguardar2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnguardar2.Location = new System.Drawing.Point(78, 423);
			this.btnguardar2.Name = "btnguardar2";
			this.btnguardar2.Size = new System.Drawing.Size(96, 41);
			this.btnguardar2.TabIndex = 39;
			this.btnguardar2.Text = "Guardar";
			this.btnguardar2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnguardar2.UseVisualStyleBackColor = true;
			this.btnguardar2.Click += new System.EventHandler(this.Btnguardar2Click);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(7, 13);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(145, 23);
			this.label3.TabIndex = 38;
			this.label3.Text = "*id proveedor:";
			// 
			// txtid_proveedor
			// 
			this.txtid_proveedor.BackColor = System.Drawing.Color.LightSteelBlue;
			this.txtid_proveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtid_proveedor.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtid_proveedor.Location = new System.Drawing.Point(7, 39);
			this.txtid_proveedor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtid_proveedor.Name = "txtid_proveedor";
			this.txtid_proveedor.ReadOnly = true;
			this.txtid_proveedor.Size = new System.Drawing.Size(265, 26);
			this.txtid_proveedor.TabIndex = 37;
			this.txtid_proveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtid_proveedorKeyPress);
			// 
			// btnagregar
			// 
			this.btnagregar.ForeColor = System.Drawing.Color.DodgerBlue;
			this.btnagregar.Image = ((System.Drawing.Image)(resources.GetObject("btnagregar.Image")));
			this.btnagregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnagregar.Location = new System.Drawing.Point(78, 423);
			this.btnagregar.Name = "btnagregar";
			this.btnagregar.Size = new System.Drawing.Size(96, 41);
			this.btnagregar.TabIndex = 28;
			this.btnagregar.Text = "Guardar";
			this.btnagregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnagregar.UseVisualStyleBackColor = true;
			this.btnagregar.Click += new System.EventHandler(this.BtnagregarClick);
			// 
			// txttelefono
			// 
			this.txttelefono.BackColor = System.Drawing.Color.LightSteelBlue;
			this.txttelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txttelefono.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txttelefono.Location = new System.Drawing.Point(5, 259);
			this.txttelefono.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txttelefono.Name = "txttelefono";
			this.txttelefono.Size = new System.Drawing.Size(265, 26);
			this.txttelefono.TabIndex = 36;
			this.txttelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxttelefonoKeyPress);
			// 
			// txtcorreo
			// 
			this.txtcorreo.BackColor = System.Drawing.Color.LightSteelBlue;
			this.txtcorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtcorreo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtcorreo.Location = new System.Drawing.Point(5, 204);
			this.txtcorreo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtcorreo.Name = "txtcorreo";
			this.txtcorreo.Size = new System.Drawing.Size(265, 26);
			this.txtcorreo.TabIndex = 35;
			this.txtcorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtcorreoKeyPress);
			// 
			// txtdireccion
			// 
			this.txtdireccion.BackColor = System.Drawing.Color.LightSteelBlue;
			this.txtdireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtdireccion.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtdireccion.Location = new System.Drawing.Point(5, 149);
			this.txtdireccion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtdireccion.Name = "txtdireccion";
			this.txtdireccion.Size = new System.Drawing.Size(265, 26);
			this.txtdireccion.TabIndex = 33;
			this.txtdireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtdireccionKeyPress);
			// 
			// txtduenio
			// 
			this.txtduenio.BackColor = System.Drawing.Color.LightSteelBlue;
			this.txtduenio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtduenio.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtduenio.Location = new System.Drawing.Point(4, 369);
			this.txtduenio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtduenio.Name = "txtduenio";
			this.txtduenio.Size = new System.Drawing.Size(265, 26);
			this.txtduenio.TabIndex = 32;
			this.txtduenio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtduenioKeyPress);
			// 
			// txtrfc
			// 
			this.txtrfc.BackColor = System.Drawing.Color.LightSteelBlue;
			this.txtrfc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtrfc.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtrfc.Location = new System.Drawing.Point(5, 314);
			this.txtrfc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtrfc.Name = "txtrfc";
			this.txtrfc.Size = new System.Drawing.Size(265, 26);
			this.txtrfc.TabIndex = 31;
			this.txtrfc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtrfcKeyPress);
			// 
			// txtnombre
			// 
			this.txtnombre.BackColor = System.Drawing.Color.LightSteelBlue;
			this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtnombre.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtnombre.Location = new System.Drawing.Point(7, 94);
			this.txtnombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtnombre.Name = "txtnombre";
			this.txtnombre.Size = new System.Drawing.Size(265, 26);
			this.txtnombre.TabIndex = 30;
			this.txtnombre.TextChanged += new System.EventHandler(this.TxtnombreTextChanged);
			this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtnombreKeyPress);
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(4, 233);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(110, 23);
			this.label14.TabIndex = 28;
			this.label14.Text = "*Telefono:";
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(6, 68);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(188, 23);
			this.label15.TabIndex = 16;
			this.label15.Text = "*Nombre Provedor:";
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(7, 343);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(91, 23);
			this.label16.TabIndex = 26;
			this.label16.Text = "*Dueño:";
			// 
			// label17
			// 
			this.label17.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(5, 178);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(91, 23);
			this.label17.TabIndex = 18;
			this.label17.Text = "*Correo:";
			// 
			// label18
			// 
			this.label18.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.Location = new System.Drawing.Point(7, 288);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(91, 23);
			this.label18.TabIndex = 24;
			this.label18.Text = "*RFC:";
			// 
			// label19
			// 
			this.label19.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.Location = new System.Drawing.Point(7, 123);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(124, 23);
			this.label19.TabIndex = 20;
			this.label19.Tag = "";
			this.label19.Text = "*Dirección:";
			// 
			// dgvproveedor
			// 
			this.dgvproveedor.AllowUserToAddRows = false;
			this.dgvproveedor.AllowUserToDeleteRows = false;
			this.dgvproveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvproveedor.Location = new System.Drawing.Point(332, 50);
			this.dgvproveedor.Name = "dgvproveedor";
			this.dgvproveedor.ReadOnly = true;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			this.dgvproveedor.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvproveedor.Size = new System.Drawing.Size(991, 413);
			this.dgvproveedor.TabIndex = 45;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.panel2.Controls.Add(this.label10);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.pictureBox8);
			this.panel2.Controls.Add(this.txtBuscar);
			this.panel2.Controls.Add(this.label11);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(3, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1342, 50);
			this.panel2.TabIndex = 44;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Candara", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label10.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label10.Location = new System.Drawing.Point(216, 6);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(124, 40);
			this.label10.TabIndex = 25;
			this.label10.Text = "Systems";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Candara", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label2.Location = new System.Drawing.Point(96, 6);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(124, 40);
			this.label2.TabIndex = 24;
			this.label2.Text = "Absolute";
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
			// txtBuscar
			// 
			this.txtBuscar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtBuscar.Location = new System.Drawing.Point(508, 21);
			this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.Size = new System.Drawing.Size(551, 20);
			this.txtBuscar.TabIndex = 33;
			this.txtBuscar.TextChanged += new System.EventHandler(this.TxtBuscarTextChanged);
			this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscarKeyPress);
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.Black;
			this.label11.Location = new System.Drawing.Point(435, 25);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(133, 25);
			this.label11.TabIndex = 32;
			this.label11.Text = "Buscar";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel3.Controls.Add(this.label12);
			this.panel3.ForeColor = System.Drawing.Color.DodgerBlue;
			this.panel3.Location = new System.Drawing.Point(652, 469);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(700, 70);
			this.panel3.TabIndex = 43;
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.White;
			this.label12.Location = new System.Drawing.Point(8, 4);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(100, 23);
			this.label12.TabIndex = 29;
			this.label12.Text = "ESTADO:";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Controls.Add(this.btneliminar);
			this.panel1.Controls.Add(this.btnmodificar);
			this.panel1.Controls.Add(this.label1);
			this.panel1.ForeColor = System.Drawing.Color.DodgerBlue;
			this.panel1.Location = new System.Drawing.Point(308, 469);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(346, 70);
			this.panel1.TabIndex = 42;
			// 
			// btneliminar
			// 
			this.btneliminar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
			this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btneliminar.Location = new System.Drawing.Point(135, 25);
			this.btneliminar.Name = "btneliminar";
			this.btneliminar.Size = new System.Drawing.Size(98, 39);
			this.btneliminar.TabIndex = 27;
			this.btneliminar.Text = "Eliminar";
			this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btneliminar.UseVisualStyleBackColor = true;
			this.btneliminar.Click += new System.EventHandler(this.BtneliminarClick);
			// 
			// btnmodificar
			// 
			this.btnmodificar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnmodificar.Image = ((System.Drawing.Image)(resources.GetObject("btnmodificar.Image")));
			this.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnmodificar.Location = new System.Drawing.Point(14, 25);
			this.btnmodificar.Name = "btnmodificar";
			this.btnmodificar.Size = new System.Drawing.Size(100, 40);
			this.btnmodificar.TabIndex = 26;
			this.btnmodificar.Text = "Modificar";
			this.btnmodificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnmodificar.UseVisualStyleBackColor = true;
			this.btnmodificar.Click += new System.EventHandler(this.BtnmodificarClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(0, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 25;
			this.label1.Text = "OPCIONES:";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.btnrestaurar);
			this.tabPage2.Controls.Add(this.dgvproveedores_inactivos);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1348, 539);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "PROVEEDORES INACTIVOS";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// btnrestaurar
			// 
			this.btnrestaurar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnrestaurar.ForeColor = System.Drawing.Color.DodgerBlue;
			this.btnrestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnrestaurar.Image")));
			this.btnrestaurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnrestaurar.Location = new System.Drawing.Point(340, 475);
			this.btnrestaurar.Name = "btnrestaurar";
			this.btnrestaurar.Size = new System.Drawing.Size(133, 47);
			this.btnrestaurar.TabIndex = 40;
			this.btnrestaurar.Text = "Restaurar";
			this.btnrestaurar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnrestaurar.UseVisualStyleBackColor = true;
			this.btnrestaurar.Click += new System.EventHandler(this.BtnrestaurarClick);
			// 
			// dgvproveedores_inactivos
			// 
			this.dgvproveedores_inactivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvproveedores_inactivos.Location = new System.Drawing.Point(28, 29);
			this.dgvproveedores_inactivos.Name = "dgvproveedores_inactivos";
			this.dgvproveedores_inactivos.Size = new System.Drawing.Size(828, 426);
			this.dgvproveedores_inactivos.TabIndex = 0;
			// 
			// frmProveedores
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1354, 569);
			this.Controls.Add(this.tabControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmProveedores";
			this.Text = "PROVEEDORES:";
			this.Load += new System.EventHandler(this.FrmProveedoresLoad);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvproveedor)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvproveedores_inactivos)).EndInit();
			this.ResumeLayout(false);

		}

		}

		}
	

