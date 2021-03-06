﻿/*
 * Created by SharpDevelop.
 * User: pumas
 * Date: 11/07/2018
 * Time: 02:24 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PuntoDeVenta
{
	partial class frmEntradas
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TabControl tbgentradas;
		private System.Windows.Forms.TabPage tpgIngresar;
		private System.Windows.Forms.TabPage tbpHistorial;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtpEntrada;
		private System.Windows.Forms.TextBox txtFolio;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox gpbDatosGeneral;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label lblTelefono;
		private System.Windows.Forms.Label lblRfc;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.ComboBox cmbProveedor;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.GroupBox gpbDetalleCompra;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label lblCodigo;
		private System.Windows.Forms.TextBox txtTotProduct;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtPrecioV;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtCosto;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.DataGridView dgvEntradas;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txtIva;
		private System.Windows.Forms.TextBox txtSubtotal;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
		private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Venta;
		private System.Windows.Forms.DataGridViewTextBoxColumn TotalProducto;
		private System.Windows.Forms.DataGridView dgvBuscar;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.TextBox txtProducto;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridViewTextBoxColumn NombreProduct;
		private System.Windows.Forms.DataGridView dgvRegistroE;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.PictureBox pictureBox11;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.DataGridView dgvDetalleE;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.ComboBox cmbBuscP;
		private System.Windows.Forms.TextBox txtBuscUsu;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.DateTimePicker dtpFechaR;
		private System.Windows.Forms.Button btnLimpiar;
		
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntradas));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tbgentradas = new System.Windows.Forms.TabControl();
			this.tpgIngresar = new System.Windows.Forms.TabPage();
			this.dgvBuscar = new System.Windows.Forms.DataGridView();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.txtIva = new System.Windows.Forms.TextBox();
			this.txtSubtotal = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.dgvEntradas = new System.Windows.Forms.DataGridView();
			this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NombreProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Precio_Venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TotalProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gpbDetalleCompra = new System.Windows.Forms.GroupBox();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.txtProducto = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.txtTotProduct = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.txtPrecioV = new System.Windows.Forms.TextBox();
			this.lblCodigo = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtCosto = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.lblTelefono = new System.Windows.Forms.Label();
			this.lblRfc = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.cmbProveedor = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.gpbDatosGeneral = new System.Windows.Forms.GroupBox();
			this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.txtFolio = new System.Windows.Forms.TextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.tbpHistorial = new System.Windows.Forms.TabPage();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.label20 = new System.Windows.Forms.Label();
			this.dgvDetalleE = new System.Windows.Forms.DataGridView();
			this.label19 = new System.Windows.Forms.Label();
			this.cmbBuscP = new System.Windows.Forms.ComboBox();
			this.txtBuscUsu = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.dtpFechaR = new System.Windows.Forms.DateTimePicker();
			this.label17 = new System.Windows.Forms.Label();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.label16 = new System.Windows.Forms.Label();
			this.dgvRegistroE = new System.Windows.Forms.DataGridView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tbgentradas.SuspendLayout();
			this.tpgIngresar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).BeginInit();
			this.gpbDetalleCompra.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			this.gpbDatosGeneral.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
			this.tbpHistorial.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDetalleE)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvRegistroE)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// tbgentradas
			// 
			this.tbgentradas.Controls.Add(this.tpgIngresar);
			this.tbgentradas.Controls.Add(this.tbpHistorial);
			this.tbgentradas.Location = new System.Drawing.Point(0, 0);
			this.tbgentradas.Name = "tbgentradas";
			this.tbgentradas.SelectedIndex = 0;
			this.tbgentradas.Size = new System.Drawing.Size(1361, 592);
			this.tbgentradas.TabIndex = 0;
			// 
			// tpgIngresar
			// 
			this.tpgIngresar.Controls.Add(this.dgvBuscar);
			this.tpgIngresar.Controls.Add(this.groupBox2);
			this.tpgIngresar.Controls.Add(this.dgvEntradas);
			this.tpgIngresar.Controls.Add(this.gpbDetalleCompra);
			this.tpgIngresar.Controls.Add(this.panel1);
			this.tpgIngresar.Controls.Add(this.panel3);
			this.tpgIngresar.Location = new System.Drawing.Point(4, 22);
			this.tpgIngresar.Name = "tpgIngresar";
			this.tpgIngresar.Padding = new System.Windows.Forms.Padding(3);
			this.tpgIngresar.Size = new System.Drawing.Size(1353, 566);
			this.tpgIngresar.TabIndex = 0;
			this.tpgIngresar.Text = "Ingresar Produtos";
			this.tpgIngresar.UseVisualStyleBackColor = true;
			// 
			// dgvBuscar
			// 
			this.dgvBuscar.AllowUserToAddRows = false;
			this.dgvBuscar.AllowUserToDeleteRows = false;
			this.dgvBuscar.AllowUserToResizeColumns = false;
			this.dgvBuscar.AllowUserToResizeRows = false;
			this.dgvBuscar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvBuscar.BackgroundColor = System.Drawing.Color.White;
			this.dgvBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvBuscar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBuscar.Location = new System.Drawing.Point(37, 258);
			this.dgvBuscar.MultiSelect = false;
			this.dgvBuscar.Name = "dgvBuscar";
			this.dgvBuscar.ReadOnly = true;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvBuscar.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvBuscar.RowHeadersVisible = false;
			this.dgvBuscar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgvBuscar.Size = new System.Drawing.Size(1256, 74);
			this.dgvBuscar.TabIndex = 10;
			this.dgvBuscar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBuscarCellContentClick);
			this.dgvBuscar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DgvBuscarMouseClick);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnCancelar);
			this.groupBox2.Controls.Add(this.btnSave);
			this.groupBox2.Controls.Add(this.txtTotal);
			this.groupBox2.Controls.Add(this.label15);
			this.groupBox2.Controls.Add(this.label14);
			this.groupBox2.Controls.Add(this.txtIva);
			this.groupBox2.Controls.Add(this.txtSubtotal);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(267, 501);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(830, 60);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Totales";
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackColor = System.Drawing.Color.White;
			this.btnCancelar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.ForeColor = System.Drawing.Color.Crimson;
			this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
			this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelar.Location = new System.Drawing.Point(712, 17);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(107, 37);
			this.btnCancelar.TabIndex = 39;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCancelar.UseVisualStyleBackColor = false;
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.White;
			this.btnSave.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.ForeColor = System.Drawing.Color.RoyalBlue;
			this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSave.Location = new System.Drawing.Point(580, 17);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(107, 37);
			this.btnSave.TabIndex = 38;
			this.btnSave.Text = "Guardar";
			this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
			// 
			// txtTotal
			// 
			this.txtTotal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotal.Location = new System.Drawing.Point(449, 25);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.ReadOnly = true;
			this.txtTotal.Size = new System.Drawing.Size(104, 23);
			this.txtTotal.TabIndex = 37;
			this.txtTotal.Text = "0";
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.White;
			this.label15.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(372, 26);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(81, 23);
			this.label15.TabIndex = 36;
			this.label15.Text = "Total";
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.White;
			this.label14.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(217, 27);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(39, 23);
			this.label14.TabIndex = 35;
			this.label14.Text = "IVA";
			// 
			// txtIva
			// 
			this.txtIva.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIva.Location = new System.Drawing.Point(262, 26);
			this.txtIva.Name = "txtIva";
			this.txtIva.ReadOnly = true;
			this.txtIva.Size = new System.Drawing.Size(81, 23);
			this.txtIva.TabIndex = 34;
			this.txtIva.Text = "0";
			// 
			// txtSubtotal
			// 
			this.txtSubtotal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSubtotal.Location = new System.Drawing.Point(83, 26);
			this.txtSubtotal.Name = "txtSubtotal";
			this.txtSubtotal.ReadOnly = true;
			this.txtSubtotal.Size = new System.Drawing.Size(104, 23);
			this.txtSubtotal.TabIndex = 33;
			this.txtSubtotal.Text = "0";
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.White;
			this.label13.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(6, 27);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(81, 23);
			this.label13.TabIndex = 24;
			this.label13.Text = "Subtotal";
			// 
			// dgvEntradas
			// 
			this.dgvEntradas.AllowUserToAddRows = false;
			this.dgvEntradas.AllowUserToDeleteRows = false;
			this.dgvEntradas.AllowUserToResizeRows = false;
			this.dgvEntradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvEntradas.BackgroundColor = System.Drawing.Color.White;
			this.dgvEntradas.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvEntradas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvEntradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Codigo,
			this.NombreProduct,
			this.Cantidad,
			this.Costo,
			this.Precio_Venta,
			this.TotalProducto});
			this.dgvEntradas.Location = new System.Drawing.Point(37, 338);
			this.dgvEntradas.Name = "dgvEntradas";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvEntradas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvEntradas.RowHeadersVisible = false;
			this.dgvEntradas.Size = new System.Drawing.Size(1257, 157);
			this.dgvEntradas.TabIndex = 4;
			this.dgvEntradas.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEntradasCellEndEdit);
			this.dgvEntradas.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DgvEntradasRowsAdded);
			this.dgvEntradas.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DgvEntradasRowsRemoved);
			this.dgvEntradas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DgvEntradasKeyDown);
			// 
			// Codigo
			// 
			this.Codigo.HeaderText = "Código";
			this.Codigo.Name = "Codigo";
			// 
			// NombreProduct
			// 
			this.NombreProduct.HeaderText = "Producto";
			this.NombreProduct.Name = "NombreProduct";
			// 
			// Cantidad
			// 
			this.Cantidad.HeaderText = "Cantidad";
			this.Cantidad.Name = "Cantidad";
			// 
			// Costo
			// 
			this.Costo.HeaderText = "Costo Unitario";
			this.Costo.Name = "Costo";
			// 
			// Precio_Venta
			// 
			this.Precio_Venta.HeaderText = "Precio de Venta";
			this.Precio_Venta.Name = "Precio_Venta";
			// 
			// TotalProducto
			// 
			this.TotalProducto.HeaderText = "Total del Producto";
			this.TotalProducto.Name = "TotalProducto";
			// 
			// gpbDetalleCompra
			// 
			this.gpbDetalleCompra.Controls.Add(this.pictureBox9);
			this.gpbDetalleCompra.Controls.Add(this.txtProducto);
			this.gpbDetalleCompra.Controls.Add(this.label5);
			this.gpbDetalleCompra.Controls.Add(this.btnEliminar);
			this.gpbDetalleCompra.Controls.Add(this.btnAgregar);
			this.gpbDetalleCompra.Controls.Add(this.txtTotProduct);
			this.gpbDetalleCompra.Controls.Add(this.label12);
			this.gpbDetalleCompra.Controls.Add(this.pictureBox7);
			this.gpbDetalleCompra.Controls.Add(this.txtPrecioV);
			this.gpbDetalleCompra.Controls.Add(this.lblCodigo);
			this.gpbDetalleCompra.Controls.Add(this.txtCodigo);
			this.gpbDetalleCompra.Controls.Add(this.label11);
			this.gpbDetalleCompra.Controls.Add(this.txtCosto);
			this.gpbDetalleCompra.Controls.Add(this.label8);
			this.gpbDetalleCompra.Controls.Add(this.txtCantidad);
			this.gpbDetalleCompra.Controls.Add(this.label7);
			this.gpbDetalleCompra.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gpbDetalleCompra.Location = new System.Drawing.Point(19, 179);
			this.gpbDetalleCompra.Name = "gpbDetalleCompra";
			this.gpbDetalleCompra.Size = new System.Drawing.Size(1293, 79);
			this.gpbDetalleCompra.TabIndex = 3;
			this.gpbDetalleCompra.TabStop = false;
			this.gpbDetalleCompra.Text = "Detalle de compra";
			// 
			// pictureBox9
			// 
			this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
			this.pictureBox9.Location = new System.Drawing.Point(19, 41);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(32, 32);
			this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox9.TabIndex = 35;
			this.pictureBox9.TabStop = false;
			// 
			// txtProducto
			// 
			this.txtProducto.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtProducto.Location = new System.Drawing.Point(54, 48);
			this.txtProducto.Name = "txtProducto";
			this.txtProducto.Size = new System.Drawing.Size(165, 23);
			this.txtProducto.TabIndex = 34;
			this.txtProducto.TextChanged += new System.EventHandler(this.TxtProductoTextChanged);
			this.txtProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtProductoKeyPress);
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.White;
			this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(18, 22);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(181, 23);
			this.label5.TabIndex = 33;
			this.label5.Text = "Buscar Producto *";
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.Color.White;
			this.btnEliminar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.ForeColor = System.Drawing.Color.Crimson;
			this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
			this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEliminar.Location = new System.Drawing.Point(1172, 34);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(103, 37);
			this.btnEliminar.TabIndex = 32;
			this.btnEliminar.Text = "Limpiar";
			this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// btnAgregar
			// 
			this.btnAgregar.BackColor = System.Drawing.Color.White;
			this.btnAgregar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.ForeColor = System.Drawing.Color.Green;
			this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
			this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAgregar.Location = new System.Drawing.Point(1053, 34);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(103, 37);
			this.btnAgregar.TabIndex = 31;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// txtTotProduct
			// 
			this.txtTotProduct.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotProduct.Location = new System.Drawing.Point(872, 48);
			this.txtTotProduct.Name = "txtTotProduct";
			this.txtTotProduct.ReadOnly = true;
			this.txtTotProduct.Size = new System.Drawing.Size(156, 23);
			this.txtTotProduct.TabIndex = 30;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.White;
			this.label12.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(872, 28);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(156, 23);
			this.label12.TabIndex = 29;
			this.label12.Text = "Total del producto";
			// 
			// pictureBox7
			// 
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(266, 41);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(32, 32);
			this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox7.TabIndex = 22;
			this.pictureBox7.TabStop = false;
			// 
			// txtPrecioV
			// 
			this.txtPrecioV.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrecioV.Location = new System.Drawing.Point(705, 48);
			this.txtPrecioV.Name = "txtPrecioV";
			this.txtPrecioV.ReadOnly = true;
			this.txtPrecioV.Size = new System.Drawing.Size(131, 23);
			this.txtPrecioV.TabIndex = 28;
			// 
			// lblCodigo
			// 
			this.lblCodigo.BackColor = System.Drawing.Color.White;
			this.lblCodigo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCodigo.Location = new System.Drawing.Point(265, 22);
			this.lblCodigo.Name = "lblCodigo";
			this.lblCodigo.Size = new System.Drawing.Size(181, 23);
			this.lblCodigo.TabIndex = 6;
			this.lblCodigo.Text = "Código del producto *";
			// 
			// txtCodigo
			// 
			this.txtCodigo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCodigo.Location = new System.Drawing.Point(301, 48);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(165, 23);
			this.txtCodigo.TabIndex = 7;
			this.txtCodigo.TextChanged += new System.EventHandler(this.TxtCodigoTextChanged);
			this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigoKeyPress);
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.White;
			this.label11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(705, 28);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(136, 23);
			this.label11.TabIndex = 27;
			this.label11.Text = "Precio de venta";
			// 
			// txtCosto
			// 
			this.txtCosto.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCosto.Location = new System.Drawing.Point(608, 48);
			this.txtCosto.Name = "txtCosto";
			this.txtCosto.Size = new System.Drawing.Size(81, 23);
			this.txtCosto.TabIndex = 26;
			this.txtCosto.TextChanged += new System.EventHandler(this.TxtCostoTextChanged);
			this.txtCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCostoKeyPress);
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.White;
			this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(608, 28);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(81, 23);
			this.label8.TabIndex = 25;
			this.label8.Text = "Costo";
			// 
			// txtCantidad
			// 
			this.txtCantidad.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCantidad.Location = new System.Drawing.Point(509, 48);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(81, 23);
			this.txtCantidad.TabIndex = 24;
			this.txtCantidad.TextChanged += new System.EventHandler(this.TxtCantidadTextChanged);
			this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantidadKeyPress);
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.White;
			this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(509, 28);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(81, 23);
			this.label7.TabIndex = 23;
			this.label7.Text = "Cantidad";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Lavender;
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.gpbDatosGeneral);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(3, 53);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1347, 120);
			this.panel1.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.pictureBox6);
			this.groupBox1.Controls.Add(this.pictureBox5);
			this.groupBox1.Controls.Add(this.lblTelefono);
			this.groupBox1.Controls.Add(this.lblRfc);
			this.groupBox1.Controls.Add(this.pictureBox4);
			this.groupBox1.Controls.Add(this.cmbProveedor);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(569, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(540, 113);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Datos del proveedor";
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(167, 73);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(32, 32);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox6.TabIndex = 12;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(10, 75);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(32, 32);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox5.TabIndex = 11;
			this.pictureBox5.TabStop = false;
			// 
			// lblTelefono
			// 
			this.lblTelefono.BackColor = System.Drawing.Color.Lavender;
			this.lblTelefono.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTelefono.Location = new System.Drawing.Point(200, 82);
			this.lblTelefono.Name = "lblTelefono";
			this.lblTelefono.Size = new System.Drawing.Size(128, 23);
			this.lblTelefono.TabIndex = 10;
			this.lblTelefono.Text = "Telefono";
			// 
			// lblRfc
			// 
			this.lblRfc.BackColor = System.Drawing.Color.Lavender;
			this.lblRfc.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRfc.Location = new System.Drawing.Point(43, 82);
			this.lblRfc.Name = "lblRfc";
			this.lblRfc.Size = new System.Drawing.Size(260, 23);
			this.lblRfc.TabIndex = 9;
			this.lblRfc.Text = "RFC";
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(10, 43);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(32, 32);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox4.TabIndex = 8;
			this.pictureBox4.TabStop = false;
			// 
			// cmbProveedor
			// 
			this.cmbProveedor.FormattingEnabled = true;
			this.cmbProveedor.Location = new System.Drawing.Point(43, 46);
			this.cmbProveedor.Name = "cmbProveedor";
			this.cmbProveedor.Size = new System.Drawing.Size(285, 26);
			this.cmbProveedor.TabIndex = 5;
			this.cmbProveedor.SelectedIndexChanged += new System.EventHandler(this.CmbProveedorSelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Lavender;
			this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(10, 20);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(189, 23);
			this.label6.TabIndex = 4;
			this.label6.Text = "Nombre del proveedor";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Lavender;
			this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(270, 26);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(138, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Folio de compra";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Lavender;
			this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(24, 26);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(147, 23);
			this.label3.TabIndex = 1;
			this.label3.Text = "Fecha de compra";
			// 
			// gpbDatosGeneral
			// 
			this.gpbDatosGeneral.Controls.Add(this.dtpEntrada);
			this.gpbDatosGeneral.Controls.Add(this.pictureBox3);
			this.gpbDatosGeneral.Controls.Add(this.pictureBox2);
			this.gpbDatosGeneral.Controls.Add(this.txtFolio);
			this.gpbDatosGeneral.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gpbDatosGeneral.Location = new System.Drawing.Point(5, 3);
			this.gpbDatosGeneral.Name = "gpbDatosGeneral";
			this.gpbDatosGeneral.Size = new System.Drawing.Size(540, 113);
			this.gpbDatosGeneral.TabIndex = 7;
			this.gpbDatosGeneral.TabStop = false;
			this.gpbDatosGeneral.Text = "Datos Generales";
			// 
			// dtpEntrada
			// 
			this.dtpEntrada.CalendarFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpEntrada.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpEntrada.Location = new System.Drawing.Point(45, 46);
			this.dtpEntrada.Name = "dtpEntrada";
			this.dtpEntrada.Size = new System.Drawing.Size(155, 22);
			this.dtpEntrada.TabIndex = 8;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(14, 43);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(32, 32);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox3.TabIndex = 9;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(265, 43);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(32, 32);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox2.TabIndex = 7;
			this.pictureBox2.TabStop = false;
			// 
			// txtFolio
			// 
			this.txtFolio.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFolio.Location = new System.Drawing.Point(298, 48);
			this.txtFolio.Name = "txtFolio";
			this.txtFolio.Size = new System.Drawing.Size(165, 23);
			this.txtFolio.TabIndex = 4;
			this.txtFolio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFolioKeyPress);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.White;
			this.panel3.Controls.Add(this.label10);
			this.panel3.Controls.Add(this.label9);
			this.panel3.Controls.Add(this.pictureBox8);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(3, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1347, 50);
			this.panel3.TabIndex = 2;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Candara", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label10.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label10.Location = new System.Drawing.Point(215, 7);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(124, 40);
			this.label10.TabIndex = 31;
			this.label10.Text = "Systems";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Candara", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label9.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label9.Location = new System.Drawing.Point(95, 7);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(124, 40);
			this.label9.TabIndex = 30;
			this.label9.Text = "Absolute";
			// 
			// pictureBox8
			// 
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(5, 1);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(100, 49);
			this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox8.TabIndex = 29;
			this.pictureBox8.TabStop = false;
			// 
			// tbpHistorial
			// 
			this.tbpHistorial.Controls.Add(this.btnLimpiar);
			this.tbpHistorial.Controls.Add(this.pictureBox11);
			this.tbpHistorial.Controls.Add(this.label20);
			this.tbpHistorial.Controls.Add(this.dgvDetalleE);
			this.tbpHistorial.Controls.Add(this.label19);
			this.tbpHistorial.Controls.Add(this.cmbBuscP);
			this.tbpHistorial.Controls.Add(this.txtBuscUsu);
			this.tbpHistorial.Controls.Add(this.label18);
			this.tbpHistorial.Controls.Add(this.dtpFechaR);
			this.tbpHistorial.Controls.Add(this.label17);
			this.tbpHistorial.Controls.Add(this.pictureBox10);
			this.tbpHistorial.Controls.Add(this.label16);
			this.tbpHistorial.Controls.Add(this.dgvRegistroE);
			this.tbpHistorial.Controls.Add(this.panel2);
			this.tbpHistorial.Location = new System.Drawing.Point(4, 22);
			this.tbpHistorial.Name = "tbpHistorial";
			this.tbpHistorial.Padding = new System.Windows.Forms.Padding(3);
			this.tbpHistorial.Size = new System.Drawing.Size(1353, 566);
			this.tbpHistorial.TabIndex = 1;
			this.tbpHistorial.Text = "Historial";
			this.tbpHistorial.UseVisualStyleBackColor = true;
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(1291, 58);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(31, 23);
			this.btnLimpiar.TabIndex = 46;
			this.btnLimpiar.Text = "button1";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
			// 
			// pictureBox11
			// 
			this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
			this.pictureBox11.Location = new System.Drawing.Point(51, 303);
			this.pictureBox11.Name = "pictureBox11";
			this.pictureBox11.Size = new System.Drawing.Size(32, 32);
			this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox11.TabIndex = 45;
			this.pictureBox11.TabStop = false;
			// 
			// label20
			// 
			this.label20.BackColor = System.Drawing.Color.White;
			this.label20.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label20.Location = new System.Drawing.Point(81, 312);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(85, 23);
			this.label20.TabIndex = 44;
			this.label20.Text = "Detalle de entrada";
			// 
			// dgvDetalleE
			// 
			this.dgvDetalleE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvDetalleE.BackgroundColor = System.Drawing.Color.White;
			this.dgvDetalleE.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvDetalleE.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvDetalleE.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvDetalleE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDetalleE.Location = new System.Drawing.Point(51, 338);
			this.dgvDetalleE.Name = "dgvDetalleE";
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Desktop;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Desktop;
			this.dgvDetalleE.RowsDefaultCellStyle = dataGridViewCellStyle6;
			this.dgvDetalleE.Size = new System.Drawing.Size(1234, 210);
			this.dgvDetalleE.TabIndex = 43;
			// 
			// label19
			// 
			this.label19.BackColor = System.Drawing.Color.White;
			this.label19.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.Location = new System.Drawing.Point(932, 59);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(182, 23);
			this.label19.TabIndex = 42;
			this.label19.Text = "Buscar por usuario";
			// 
			// cmbBuscP
			// 
			this.cmbBuscP.FormattingEnabled = true;
			this.cmbBuscP.Location = new System.Drawing.Point(693, 62);
			this.cmbBuscP.Name = "cmbBuscP";
			this.cmbBuscP.Size = new System.Drawing.Size(201, 21);
			this.cmbBuscP.TabIndex = 41;
			this.cmbBuscP.SelectedIndexChanged += new System.EventHandler(this.CmbBuscPSelectedIndexChanged);
			// 
			// txtBuscUsu
			// 
			this.txtBuscUsu.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBuscUsu.Location = new System.Drawing.Point(1120, 59);
			this.txtBuscUsu.Name = "txtBuscUsu";
			this.txtBuscUsu.Size = new System.Drawing.Size(165, 23);
			this.txtBuscUsu.TabIndex = 40;
			this.txtBuscUsu.TextChanged += new System.EventHandler(this.TxtBuscUsuTextChanged);
			// 
			// label18
			// 
			this.label18.BackColor = System.Drawing.Color.White;
			this.label18.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.Location = new System.Drawing.Point(505, 63);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(182, 23);
			this.label18.TabIndex = 39;
			this.label18.Text = "Buscar por proveedor";
			// 
			// dtpFechaR
			// 
			this.dtpFechaR.CalendarFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFechaR.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFechaR.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFechaR.Location = new System.Drawing.Point(335, 61);
			this.dtpFechaR.Name = "dtpFechaR";
			this.dtpFechaR.Size = new System.Drawing.Size(155, 22);
			this.dtpFechaR.TabIndex = 38;
			this.dtpFechaR.ValueChanged += new System.EventHandler(this.DtpFechaRValueChanged);
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.White;
			this.label17.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(189, 63);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(151, 23);
			this.label17.TabIndex = 37;
			this.label17.Text = "Buscar por fecha";
			// 
			// pictureBox10
			// 
			this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
			this.pictureBox10.Location = new System.Drawing.Point(51, 54);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(32, 32);
			this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox10.TabIndex = 36;
			this.pictureBox10.TabStop = false;
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.White;
			this.label16.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(81, 63);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(85, 23);
			this.label16.TabIndex = 34;
			this.label16.Text = "Entradas";
			// 
			// dgvRegistroE
			// 
			this.dgvRegistroE.AllowUserToAddRows = false;
			this.dgvRegistroE.AllowUserToOrderColumns = true;
			this.dgvRegistroE.AllowUserToResizeColumns = false;
			this.dgvRegistroE.AllowUserToResizeRows = false;
			this.dgvRegistroE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvRegistroE.BackgroundColor = System.Drawing.Color.White;
			this.dgvRegistroE.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvRegistroE.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Desktop;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvRegistroE.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dgvRegistroE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvRegistroE.Location = new System.Drawing.Point(51, 89);
			this.dgvRegistroE.Name = "dgvRegistroE";
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.Desktop;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvRegistroE.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.dgvRegistroE.RowHeadersVisible = false;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.Desktop;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.Desktop;
			this.dgvRegistroE.RowsDefaultCellStyle = dataGridViewCellStyle9;
			this.dgvRegistroE.Size = new System.Drawing.Size(1234, 199);
			this.dgvRegistroE.TabIndex = 2;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(3, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1347, 50);
			this.panel2.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Candara", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label1.Location = new System.Drawing.Point(213, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(124, 40);
			this.label1.TabIndex = 28;
			this.label1.Text = "Systems";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Candara", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
			this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label2.Location = new System.Drawing.Point(93, 6);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(124, 40);
			this.label2.TabIndex = 27;
			this.label2.Text = "Absolute";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(3, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 49);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 26;
			this.pictureBox1.TabStop = false;
			// 
			// frmEntradas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(1333, 582);
			this.Controls.Add(this.tbgentradas);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmEntradas";
			this.Text = "frmEntradas";
			this.Load += new System.EventHandler(this.FrmEntradasLoad);
			this.tbgentradas.ResumeLayout(false);
			this.tpgIngresar.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvBuscar)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).EndInit();
			this.gpbDetalleCompra.ResumeLayout(false);
			this.gpbDetalleCompra.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			this.gpbDatosGeneral.ResumeLayout(false);
			this.gpbDatosGeneral.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
			this.tbpHistorial.ResumeLayout(false);
			this.tbpHistorial.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDetalleE)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvRegistroE)).EndInit();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
