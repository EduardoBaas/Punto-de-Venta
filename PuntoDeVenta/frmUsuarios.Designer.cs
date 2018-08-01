/*
 * Created by SharpDevelop.
 * User: pumas
 * Date: 11/07/2018
 * Time: 02:28 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PuntoDeVenta
{
	partial class frmUsuarios
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tpgUsuarios;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtApellidoM;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.TextBox txtApellidoP;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.TextBox txtCURP;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.ComboBox cmbTipo;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.TextBox txtContrasenia;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.TextBox txtCorreo;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.DataGridView dgvUsuarios;
		private System.Windows.Forms.Button btnGuardarUp;
		private System.Windows.Forms.PictureBox pictureBox11;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.DataGridView dgvUserD;
		private System.Windows.Forms.PictureBox pictureBox12;
		private System.Windows.Forms.TextBox txtBuscD;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Button btnRestore;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Label lblCondicion;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tpgUsuarios = new System.Windows.Forms.TabPage();
			this.lblCondicion = new System.Windows.Forms.Label();
			this.btnGuardarUp = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.dgvUsuarios = new System.Windows.Forms.DataGridView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnEditar = new System.Windows.Forms.Button();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.cmbTipo = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.txtContrasenia = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.txtCorreo = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtApellidoM = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.txtApellidoP = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.txtCURP = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.btnRestore = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label14 = new System.Windows.Forms.Label();
			this.pictureBox12 = new System.Windows.Forms.PictureBox();
			this.txtBuscD = new System.Windows.Forms.TextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.dgvUserD = new System.Windows.Forms.DataGridView();
			this.tabControl1.SuspendLayout();
			this.tpgUsuarios.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvUserD)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tpgUsuarios);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1172, 573);
			this.tabControl1.TabIndex = 0;
			// 
			// tpgUsuarios
			// 
			this.tpgUsuarios.Controls.Add(this.lblCondicion);
			this.tpgUsuarios.Controls.Add(this.btnGuardarUp);
			this.tpgUsuarios.Controls.Add(this.btnCancel);
			this.tpgUsuarios.Controls.Add(this.dgvUsuarios);
			this.tpgUsuarios.Controls.Add(this.panel2);
			this.tpgUsuarios.Controls.Add(this.btnSave);
			this.tpgUsuarios.Controls.Add(this.panel1);
			this.tpgUsuarios.Location = new System.Drawing.Point(4, 22);
			this.tpgUsuarios.Name = "tpgUsuarios";
			this.tpgUsuarios.Padding = new System.Windows.Forms.Padding(3);
			this.tpgUsuarios.Size = new System.Drawing.Size(1164, 547);
			this.tpgUsuarios.TabIndex = 0;
			this.tpgUsuarios.Text = "Datos de usuarios";
			this.tpgUsuarios.UseVisualStyleBackColor = true;
			// 
			// lblCondicion
			// 
			this.lblCondicion.Location = new System.Drawing.Point(8, 517);
			this.lblCondicion.Name = "lblCondicion";
			this.lblCondicion.Size = new System.Drawing.Size(100, 23);
			this.lblCondicion.TabIndex = 56;
			this.lblCondicion.Text = "label15";
			this.lblCondicion.Visible = false;
			// 
			// btnGuardarUp
			// 
			this.btnGuardarUp.BackColor = System.Drawing.Color.White;
			this.btnGuardarUp.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardarUp.ForeColor = System.Drawing.Color.LimeGreen;
			this.btnGuardarUp.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarUp.Image")));
			this.btnGuardarUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardarUp.Location = new System.Drawing.Point(798, 494);
			this.btnGuardarUp.Name = "btnGuardarUp";
			this.btnGuardarUp.Size = new System.Drawing.Size(113, 34);
			this.btnGuardarUp.TabIndex = 55;
			this.btnGuardarUp.Text = "Update";
			this.btnGuardarUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGuardarUp.UseVisualStyleBackColor = false;
			this.btnGuardarUp.Click += new System.EventHandler(this.BtnGuardarUpClick);
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.White;
			this.btnCancel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.ForeColor = System.Drawing.Color.Crimson;
			this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
			this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancel.Location = new System.Drawing.Point(1033, 494);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(107, 34);
			this.btnCancel.TabIndex = 54;
			this.btnCancel.Text = "Cancelar";
			this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
			// 
			// dgvUsuarios
			// 
			this.dgvUsuarios.AllowUserToAddRows = false;
			this.dgvUsuarios.AllowUserToOrderColumns = true;
			this.dgvUsuarios.AllowUserToResizeColumns = false;
			this.dgvUsuarios.AllowUserToResizeRows = false;
			this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvUsuarios.BackgroundColor = System.Drawing.Color.White;
			this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUsuarios.Location = new System.Drawing.Point(12, 214);
			this.dgvUsuarios.Name = "dgvUsuarios";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvUsuarios.RowHeadersVisible = false;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Desktop;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
			this.dgvUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvUsuarios.Size = new System.Drawing.Size(1141, 271);
			this.dgvUsuarios.TabIndex = 37;
			this.dgvUsuarios.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvUsuariosKeyDown);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel2.Controls.Add(this.btnEditar);
			this.panel2.Controls.Add(this.pictureBox11);
			this.panel2.Controls.Add(this.btnEliminar);
			this.panel2.Controls.Add(this.pictureBox10);
			this.panel2.Controls.Add(this.cmbTipo);
			this.panel2.Controls.Add(this.label11);
			this.panel2.Controls.Add(this.pictureBox9);
			this.panel2.Controls.Add(this.txtContrasenia);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.pictureBox7);
			this.panel2.Controls.Add(this.txtCorreo);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.pictureBox6);
			this.panel2.Controls.Add(this.txtTelefono);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.pictureBox5);
			this.panel2.Controls.Add(this.txtUsuario);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.txtApellidoM);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.pictureBox3);
			this.panel2.Controls.Add(this.txtApellidoP);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Controls.Add(this.txtNombre);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.pictureBox2);
			this.panel2.Controls.Add(this.txtCURP);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(3, 53);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1158, 129);
			this.panel2.TabIndex = 36;
			// 
			// btnEditar
			// 
			this.btnEditar.BackColor = System.Drawing.Color.White;
			this.btnEditar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditar.ForeColor = System.Drawing.Color.LimeGreen;
			this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
			this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEditar.Location = new System.Drawing.Point(928, 84);
			this.btnEditar.Name = "btnEditar";
			this.btnEditar.Size = new System.Drawing.Size(107, 34);
			this.btnEditar.TabIndex = 56;
			this.btnEditar.Text = "Editar";
			this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEditar.UseVisualStyleBackColor = false;
			this.btnEditar.Click += new System.EventHandler(this.BtnEditarClick);
			// 
			// pictureBox11
			// 
			this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
			this.pictureBox11.Location = new System.Drawing.Point(704, 25);
			this.pictureBox11.Name = "pictureBox11";
			this.pictureBox11.Size = new System.Drawing.Size(32, 32);
			this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox11.TabIndex = 54;
			this.pictureBox11.TabStop = false;
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.Color.White;
			this.btnEliminar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.ForeColor = System.Drawing.Color.Crimson;
			this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
			this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEliminar.Location = new System.Drawing.Point(1041, 84);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(107, 34);
			this.btnEliminar.TabIndex = 52;
			this.btnEliminar.Text = "Limpiar";
			this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// pictureBox10
			// 
			this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
			this.pictureBox10.Location = new System.Drawing.Point(703, 90);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(32, 32);
			this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox10.TabIndex = 51;
			this.pictureBox10.TabStop = false;
			// 
			// cmbTipo
			// 
			this.cmbTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbTipo.FormattingEnabled = true;
			this.cmbTipo.Location = new System.Drawing.Point(737, 90);
			this.cmbTipo.Name = "cmbTipo";
			this.cmbTipo.Size = new System.Drawing.Size(176, 26);
			this.cmbTipo.TabIndex = 50;
			this.cmbTipo.Click += new System.EventHandler(this.CmbTipoClick);
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label11.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.White;
			this.label11.Location = new System.Drawing.Point(704, 64);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(209, 25);
			this.label11.TabIndex = 49;
			this.label11.Text = "Tipo de usuario *";
			// 
			// pictureBox9
			// 
			this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
			this.pictureBox9.Location = new System.Drawing.Point(473, 90);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(32, 32);
			this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox9.TabIndex = 47;
			this.pictureBox9.TabStop = false;
			// 
			// txtContrasenia
			// 
			this.txtContrasenia.BackColor = System.Drawing.Color.LightSteelBlue;
			this.txtContrasenia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtContrasenia.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtContrasenia.Location = new System.Drawing.Point(507, 92);
			this.txtContrasenia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtContrasenia.Name = "txtContrasenia";
			this.txtContrasenia.Size = new System.Drawing.Size(176, 26);
			this.txtContrasenia.TabIndex = 46;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label8.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(474, 64);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(209, 25);
			this.label8.TabIndex = 48;
			this.label8.Text = "Contraseña *";
			// 
			// pictureBox7
			// 
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(241, 90);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(32, 32);
			this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox7.TabIndex = 44;
			this.pictureBox7.TabStop = false;
			// 
			// txtCorreo
			// 
			this.txtCorreo.BackColor = System.Drawing.Color.LightSteelBlue;
			this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCorreo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCorreo.Location = new System.Drawing.Point(275, 92);
			this.txtCorreo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtCorreo.Name = "txtCorreo";
			this.txtCorreo.Size = new System.Drawing.Size(176, 26);
			this.txtCorreo.TabIndex = 43;
			this.txtCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCorreoKeyPress);
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(242, 64);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(209, 25);
			this.label7.TabIndex = 45;
			this.label7.Text = "Correo";
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(16, 90);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(32, 32);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox6.TabIndex = 41;
			this.pictureBox6.TabStop = false;
			// 
			// txtTelefono
			// 
			this.txtTelefono.BackColor = System.Drawing.Color.LightSteelBlue;
			this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTelefono.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTelefono.Location = new System.Drawing.Point(50, 92);
			this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(176, 26);
			this.txtTelefono.TabIndex = 40;
			this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefonoKeyPress);
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(17, 64);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(209, 25);
			this.label6.TabIndex = 42;
			this.label6.Text = "Teléfono";
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(927, 26);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(32, 32);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox5.TabIndex = 38;
			this.pictureBox5.TabStop = false;
			// 
			// txtUsuario
			// 
			this.txtUsuario.BackColor = System.Drawing.Color.LightSteelBlue;
			this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtUsuario.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtUsuario.Location = new System.Drawing.Point(961, 28);
			this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(176, 26);
			this.txtUsuario.TabIndex = 37;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(928, 0);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(209, 25);
			this.label5.TabIndex = 39;
			this.label5.Text = "Usuario *";
			// 
			// txtApellidoM
			// 
			this.txtApellidoM.BackColor = System.Drawing.Color.LightSteelBlue;
			this.txtApellidoM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtApellidoM.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtApellidoM.Location = new System.Drawing.Point(737, 28);
			this.txtApellidoM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtApellidoM.Name = "txtApellidoM";
			this.txtApellidoM.Size = new System.Drawing.Size(176, 26);
			this.txtApellidoM.TabIndex = 34;
			this.txtApellidoM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellidoMKeyPress);
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(704, 0);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(209, 25);
			this.label4.TabIndex = 36;
			this.label4.Text = "Apellido Materno *";
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(474, 26);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(32, 32);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox3.TabIndex = 32;
			this.pictureBox3.TabStop = false;
			// 
			// txtApellidoP
			// 
			this.txtApellidoP.BackColor = System.Drawing.Color.LightSteelBlue;
			this.txtApellidoP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtApellidoP.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtApellidoP.Location = new System.Drawing.Point(508, 28);
			this.txtApellidoP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtApellidoP.Name = "txtApellidoP";
			this.txtApellidoP.Size = new System.Drawing.Size(176, 26);
			this.txtApellidoP.TabIndex = 31;
			this.txtApellidoP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtApellidoPKeyPress);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(475, 0);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(209, 25);
			this.label3.TabIndex = 33;
			this.label3.Text = "Apellido Paterno *";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(242, 29);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(32, 32);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 29;
			this.pictureBox1.TabStop = false;
			// 
			// txtNombre
			// 
			this.txtNombre.BackColor = System.Drawing.Color.LightSteelBlue;
			this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtNombre.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombre.Location = new System.Drawing.Point(276, 31);
			this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(176, 26);
			this.txtNombre.TabIndex = 28;
			this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNombreKeyPress);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(243, 3);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(209, 25);
			this.label1.TabIndex = 30;
			this.label1.Text = "Nombre *";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(16, 29);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(32, 32);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox2.TabIndex = 26;
			this.pictureBox2.TabStop = false;
			// 
			// txtCURP
			// 
			this.txtCURP.BackColor = System.Drawing.Color.LightSteelBlue;
			this.txtCURP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtCURP.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCURP.Location = new System.Drawing.Point(50, 31);
			this.txtCURP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtCURP.Name = "txtCURP";
			this.txtCURP.Size = new System.Drawing.Size(176, 26);
			this.txtCURP.TabIndex = 25;
			this.txtCURP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCURPKeyPress);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(17, 3);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(209, 25);
			this.label2.TabIndex = 27;
			this.label2.Text = "CURP *";
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.White;
			this.btnSave.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.ForeColor = System.Drawing.Color.RoyalBlue;
			this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.Location = new System.Drawing.Point(919, 494);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(107, 34);
			this.btnSave.TabIndex = 53;
			this.btnSave.Text = "Guardar";
			this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.pictureBox8);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1158, 50);
			this.panel1.TabIndex = 35;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Candara", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.LightSeaGreen;
			this.label10.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label10.Location = new System.Drawing.Point(551, 7);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(124, 40);
			this.label10.TabIndex = 28;
			this.label10.Text = "Ventas";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Candara", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.DodgerBlue;
			this.label9.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label9.Location = new System.Drawing.Point(431, 7);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(124, 40);
			this.label9.TabIndex = 27;
			this.label9.Text = "Absolute";
			// 
			// pictureBox8
			// 
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(341, 1);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(100, 49);
			this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox8.TabIndex = 26;
			this.pictureBox8.TabStop = false;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.btnRestore);
			this.tabPage2.Controls.Add(this.panel4);
			this.tabPage2.Controls.Add(this.panel3);
			this.tabPage2.Controls.Add(this.dgvUserD);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1164, 547);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Usuarios eliminados";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// btnRestore
			// 
			this.btnRestore.BackColor = System.Drawing.Color.White;
			this.btnRestore.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRestore.ForeColor = System.Drawing.Color.YellowGreen;
			this.btnRestore.Image = ((System.Drawing.Image)(resources.GetObject("btnRestore.Image")));
			this.btnRestore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRestore.Location = new System.Drawing.Point(1001, 498);
			this.btnRestore.Name = "btnRestore";
			this.btnRestore.Size = new System.Drawing.Size(136, 39);
			this.btnRestore.TabIndex = 54;
			this.btnRestore.Text = "Restaurar";
			this.btnRestore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnRestore.UseVisualStyleBackColor = false;
			this.btnRestore.Click += new System.EventHandler(this.BtnRestoreClick);
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel4.Controls.Add(this.label14);
			this.panel4.Controls.Add(this.pictureBox12);
			this.panel4.Controls.Add(this.txtBuscD);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(3, 53);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(1158, 77);
			this.panel4.TabIndex = 40;
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label14.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.White;
			this.label14.Location = new System.Drawing.Point(45, 12);
			this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(233, 25);
			this.label14.TabIndex = 32;
			this.label14.Text = "Buscar usuario por nombre";
			// 
			// pictureBox12
			// 
			this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
			this.pictureBox12.Location = new System.Drawing.Point(45, 40);
			this.pictureBox12.Name = "pictureBox12";
			this.pictureBox12.Size = new System.Drawing.Size(32, 32);
			this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox12.TabIndex = 31;
			this.pictureBox12.TabStop = false;
			// 
			// txtBuscD
			// 
			this.txtBuscD.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.txtBuscD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtBuscD.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBuscD.Location = new System.Drawing.Point(79, 42);
			this.txtBuscD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtBuscD.Name = "txtBuscD";
			this.txtBuscD.Size = new System.Drawing.Size(458, 26);
			this.txtBuscD.TabIndex = 30;
			this.txtBuscD.TextChanged += new System.EventHandler(this.TxtBuscDTextChanged);
			this.txtBuscD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscDKeyPress);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.label12);
			this.panel3.Controls.Add(this.label13);
			this.panel3.Controls.Add(this.pictureBox4);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(3, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1158, 50);
			this.panel3.TabIndex = 39;
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Candara", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.LightSeaGreen;
			this.label12.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label12.Location = new System.Drawing.Point(622, 7);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(124, 40);
			this.label12.TabIndex = 31;
			this.label12.Text = "Ventas";
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Candara", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.DodgerBlue;
			this.label13.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label13.Location = new System.Drawing.Point(502, 7);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(124, 40);
			this.label13.TabIndex = 30;
			this.label13.Text = "Absolute";
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(412, 1);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(100, 49);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 29;
			this.pictureBox4.TabStop = false;
			// 
			// dgvUserD
			// 
			this.dgvUserD.AllowUserToAddRows = false;
			this.dgvUserD.AllowUserToOrderColumns = true;
			this.dgvUserD.AllowUserToResizeColumns = false;
			this.dgvUserD.AllowUserToResizeRows = false;
			this.dgvUserD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvUserD.BackgroundColor = System.Drawing.Color.White;
			this.dgvUserD.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvUserD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvUserD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvUserD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUserD.Location = new System.Drawing.Point(8, 136);
			this.dgvUserD.Name = "dgvUserD";
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvUserD.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvUserD.RowHeadersVisible = false;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Desktop;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
			this.dgvUserD.RowsDefaultCellStyle = dataGridViewCellStyle6;
			this.dgvUserD.Size = new System.Drawing.Size(1141, 338);
			this.dgvUserD.TabIndex = 38;
			this.dgvUserD.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DgvUserDRowsAdded);
			// 
			// frmUsuarios
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(1170, 571);
			this.Controls.Add(this.tabControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmUsuarios";
			this.Text = "frmUsuarios";
			this.Load += new System.EventHandler(this.FrmUsuariosLoad);
			this.tabControl1.ResumeLayout(false);
			this.tpgUsuarios.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvUserD)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
