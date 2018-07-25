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
		private System.Windows.Forms.DataGridView dgvproveedor;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.TextBox txtBuscar;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox txtProducto;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btneliminar;
		private System.Windows.Forms.Button btnmodificar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnagregar;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txttelefono;
		private System.Windows.Forms.TextBox txtcorreo;
		private System.Windows.Forms.TextBox txtciudad;
		private System.Windows.Forms.TextBox txtdireccion;
		private System.Windows.Forms.TextBox txtduenio;
		private System.Windows.Forms.TextBox txtrfc;
		private System.Windows.Forms.TextBox txtnombre;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		
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
			this.dgvproveedor = new System.Windows.Forms.DataGridView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label10 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.txtProducto = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label12 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btneliminar = new System.Windows.Forms.Button();
			this.btnmodificar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnagregar = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txttelefono = new System.Windows.Forms.TextBox();
			this.txtcorreo = new System.Windows.Forms.TextBox();
			this.txtciudad = new System.Windows.Forms.TextBox();
			this.txtdireccion = new System.Windows.Forms.TextBox();
			this.txtduenio = new System.Windows.Forms.TextBox();
			this.txtrfc = new System.Windows.Forms.TextBox();
			this.txtnombre = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvproveedor)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvproveedor
			// 
			this.dgvproveedor.Location = new System.Drawing.Point(310, 56);
			this.dgvproveedor.Name = "dgvproveedor";
			this.dgvproveedor.Size = new System.Drawing.Size(1044, 413);
			this.dgvproveedor.TabIndex = 40;
			this.dgvproveedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvprovedorCellContentClick);
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
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1354, 50);
			this.panel2.TabIndex = 39;
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
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.groupBox1.Controls.Add(this.btnGuardar);
			this.groupBox1.Controls.Add(this.textBox6);
			this.groupBox1.Controls.Add(this.textBox5);
			this.groupBox1.Controls.Add(this.textBox4);
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.txtProducto);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.AliceBlue;
			this.groupBox1.Location = new System.Drawing.Point(0, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(292, 530);
			this.groupBox1.TabIndex = 38;
			this.groupBox1.TabStop = false;
			// 
			// btnGuardar
			// 
			this.btnGuardar.BackColor = System.Drawing.Color.White;
			this.btnGuardar.ForeColor = System.Drawing.Color.MediumBlue;
			this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
			this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardar.Location = new System.Drawing.Point(90, 459);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(96, 37);
			this.btnGuardar.TabIndex = 37;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGuardar.UseVisualStyleBackColor = false;
			// 
			// textBox6
			// 
			this.textBox6.BackColor = System.Drawing.Color.LightSteelBlue;
			this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox6.Location = new System.Drawing.Point(7, 277);
			this.textBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(265, 26);
			this.textBox6.TabIndex = 36;
			// 
			// textBox5
			// 
			this.textBox5.BackColor = System.Drawing.Color.LightSteelBlue;
			this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox5.Location = new System.Drawing.Point(7, 215);
			this.textBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(265, 26);
			this.textBox5.TabIndex = 35;
			// 
			// textBox4
			// 
			this.textBox4.BackColor = System.Drawing.Color.LightSteelBlue;
			this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox4.Location = new System.Drawing.Point(7, 96);
			this.textBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(265, 26);
			this.textBox4.TabIndex = 34;
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.Color.LightSteelBlue;
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox3.Location = new System.Drawing.Point(7, 159);
			this.textBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(265, 26);
			this.textBox3.TabIndex = 33;
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.Color.LightSteelBlue;
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(7, 415);
			this.textBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(265, 26);
			this.textBox2.TabIndex = 32;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(7, 343);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(265, 26);
			this.textBox1.TabIndex = 31;
			// 
			// txtProducto
			// 
			this.txtProducto.BackColor = System.Drawing.Color.LightSteelBlue;
			this.txtProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtProducto.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProducto.Location = new System.Drawing.Point(7, 41);
			this.txtProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtProducto.Name = "txtProducto";
			this.txtProducto.Size = new System.Drawing.Size(265, 26);
			this.txtProducto.TabIndex = 30;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(7, 80);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(91, 23);
			this.label4.TabIndex = 22;
			this.label4.Text = "Ciudad:";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(7, 262);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(91, 23);
			this.label7.TabIndex = 28;
			this.label7.Text = "Telefono:";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(7, 19);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(104, 23);
			this.label9.TabIndex = 16;
			this.label9.Text = "Nombre Provedor:";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(7, 398);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(91, 23);
			this.label6.TabIndex = 26;
			this.label6.Text = "Dueño:";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(7, 199);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(91, 23);
			this.label8.TabIndex = 18;
			this.label8.Text = "Correo:";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(6, 327);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(91, 23);
			this.label5.TabIndex = 24;
			this.label5.Text = "RFC:";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(7, 142);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(91, 23);
			this.label3.TabIndex = 20;
			this.label3.Tag = "";
			this.label3.Text = "Dirección:";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel3.Controls.Add(this.label12);
			this.panel3.ForeColor = System.Drawing.Color.DodgerBlue;
			this.panel3.Location = new System.Drawing.Point(654, 475);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(700, 70);
			this.panel3.TabIndex = 37;
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
			this.panel1.Location = new System.Drawing.Point(310, 475);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(346, 70);
			this.panel1.TabIndex = 36;
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
			this.btneliminar.UseVisualStyleBackColor = true;
			// 
			// btnmodificar
			// 
			this.btnmodificar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnmodificar.Image = ((System.Drawing.Image)(resources.GetObject("btnmodificar.Image")));
			this.btnmodificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnmodificar.Location = new System.Drawing.Point(14, 25);
			this.btnmodificar.Name = "btnmodificar";
			this.btnmodificar.Size = new System.Drawing.Size(98, 40);
			this.btnmodificar.TabIndex = 26;
			this.btnmodificar.Text = "Modificar";
			this.btnmodificar.UseVisualStyleBackColor = true;
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
			// btnagregar
			// 
			this.btnagregar.ForeColor = System.Drawing.Color.DodgerBlue;
			this.btnagregar.Image = ((System.Drawing.Image)(resources.GetObject("btnagregar.Image")));
			this.btnagregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnagregar.Location = new System.Drawing.Point(90, 444);
			this.btnagregar.Name = "btnagregar";
			this.btnagregar.Size = new System.Drawing.Size(98, 41);
			this.btnagregar.TabIndex = 28;
			this.btnagregar.Text = "Agregar";
			this.btnagregar.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.groupBox2.Controls.Add(this.btnagregar);
			this.groupBox2.Controls.Add(this.txttelefono);
			this.groupBox2.Controls.Add(this.txtcorreo);
			this.groupBox2.Controls.Add(this.txtciudad);
			this.groupBox2.Controls.Add(this.txtdireccion);
			this.groupBox2.Controls.Add(this.txtduenio);
			this.groupBox2.Controls.Add(this.txtrfc);
			this.groupBox2.Controls.Add(this.txtnombre);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.label14);
			this.groupBox2.Controls.Add(this.label15);
			this.groupBox2.Controls.Add(this.label16);
			this.groupBox2.Controls.Add(this.label17);
			this.groupBox2.Controls.Add(this.label18);
			this.groupBox2.Controls.Add(this.label19);
			this.groupBox2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.ForeColor = System.Drawing.Color.AliceBlue;
			this.groupBox2.Location = new System.Drawing.Point(6, 56);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(300, 530);
			this.groupBox2.TabIndex = 41;
			this.groupBox2.TabStop = false;
			// 
			// txttelefono
			// 
			this.txttelefono.BackColor = System.Drawing.Color.LightSteelBlue;
			this.txttelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txttelefono.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txttelefono.Location = new System.Drawing.Point(7, 277);
			this.txttelefono.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txttelefono.Name = "txttelefono";
			this.txttelefono.Size = new System.Drawing.Size(265, 26);
			this.txttelefono.TabIndex = 36;
			// 
			// txtcorreo
			// 
			this.txtcorreo.BackColor = System.Drawing.Color.LightSteelBlue;
			this.txtcorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtcorreo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtcorreo.Location = new System.Drawing.Point(7, 215);
			this.txtcorreo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtcorreo.Name = "txtcorreo";
			this.txtcorreo.Size = new System.Drawing.Size(265, 26);
			this.txtcorreo.TabIndex = 35;
			// 
			// txtciudad
			// 
			this.txtciudad.BackColor = System.Drawing.Color.LightSteelBlue;
			this.txtciudad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtciudad.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtciudad.Location = new System.Drawing.Point(7, 96);
			this.txtciudad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtciudad.Name = "txtciudad";
			this.txtciudad.Size = new System.Drawing.Size(265, 26);
			this.txtciudad.TabIndex = 34;
			// 
			// txtdireccion
			// 
			this.txtdireccion.BackColor = System.Drawing.Color.LightSteelBlue;
			this.txtdireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtdireccion.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtdireccion.Location = new System.Drawing.Point(7, 159);
			this.txtdireccion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtdireccion.Name = "txtdireccion";
			this.txtdireccion.Size = new System.Drawing.Size(265, 26);
			this.txtdireccion.TabIndex = 33;
			// 
			// txtduenio
			// 
			this.txtduenio.BackColor = System.Drawing.Color.LightSteelBlue;
			this.txtduenio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtduenio.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtduenio.Location = new System.Drawing.Point(7, 415);
			this.txtduenio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtduenio.Name = "txtduenio";
			this.txtduenio.Size = new System.Drawing.Size(265, 26);
			this.txtduenio.TabIndex = 32;
			// 
			// txtrfc
			// 
			this.txtrfc.BackColor = System.Drawing.Color.LightSteelBlue;
			this.txtrfc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtrfc.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtrfc.Location = new System.Drawing.Point(7, 343);
			this.txtrfc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtrfc.Name = "txtrfc";
			this.txtrfc.Size = new System.Drawing.Size(265, 26);
			this.txtrfc.TabIndex = 31;
			// 
			// txtnombre
			// 
			this.txtnombre.BackColor = System.Drawing.Color.LightSteelBlue;
			this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtnombre.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtnombre.Location = new System.Drawing.Point(7, 41);
			this.txtnombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtnombre.Name = "txtnombre";
			this.txtnombre.Size = new System.Drawing.Size(265, 26);
			this.txtnombre.TabIndex = 30;
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(7, 80);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(91, 23);
			this.label13.TabIndex = 22;
			this.label13.Text = "Ciudad:";
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(7, 262);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(91, 23);
			this.label14.TabIndex = 28;
			this.label14.Text = "Telefono:";
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(7, 19);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(104, 23);
			this.label15.TabIndex = 16;
			this.label15.Text = "Nombre Provedor:";
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(7, 398);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(91, 23);
			this.label16.TabIndex = 26;
			this.label16.Text = "Dueño:";
			// 
			// label17
			// 
			this.label17.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(7, 199);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(91, 23);
			this.label17.TabIndex = 18;
			this.label17.Text = "Correo:";
			// 
			// label18
			// 
			this.label18.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.Location = new System.Drawing.Point(6, 327);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(91, 23);
			this.label18.TabIndex = 24;
			this.label18.Text = "RFC:";
			// 
			// label19
			// 
			this.label19.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.Location = new System.Drawing.Point(7, 142);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(91, 23);
			this.label19.TabIndex = 20;
			this.label19.Tag = "";
			this.label19.Text = "Dirección:";
			// 
			// frmProveedores
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1354, 542);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.dgvproveedor);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmProveedores";
			this.Text = "PROVEEDORES:";
			this.Load += new System.EventHandler(this.FrmProveedoresLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgvproveedor)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
