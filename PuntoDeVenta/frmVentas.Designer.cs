/*
 * Created by SharpDevelop.
 * User: pumas
 * Date: 11/07/2018
 * Time: 02:24 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PuntoDeVenta
{
	partial class frmVentas
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox gpbDatosGenerales;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dtpFecha;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblDireccion;
		private System.Windows.Forms.Label lblNomCliente;
		private System.Windows.Forms.Label lblBuscar;
		private System.Windows.Forms.Label lblTelefono;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.GroupBox gpbDetalleVenta;
		private System.Windows.Forms.Label lblNoVenta;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label lblPrecio;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.DataGridView dgvVentas;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.DataGridViewTextBoxColumn productoDataGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGrid;
		private System.Windows.Forms.Label lblProductosTotales;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label lblProductoImg;
		private System.Windows.Forms.GroupBox gpbTotales;
		private System.Windows.Forms.Label lblTotalT;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label lblSubtotalT;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.GroupBox gpbPago;
		private System.Windows.Forms.TextBox txtEfectivo;
		private System.Windows.Forms.Label lblCambio;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.Label label37;
		private System.Windows.Forms.Button btnCobrar;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.ComboBox cmbTipoVenta;
		private System.Windows.Forms.Label label40;
		private System.Windows.Forms.Label label39;
		private System.Windows.Forms.Label lblUsuarioImg;
		private System.Windows.Forms.Label lblTelfUsuario;
		private System.Windows.Forms.Label lblUsuario;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cmbCliente;
		private System.Windows.Forms.ComboBox cmbProducto;
		private System.Windows.Forms.GroupBox gpbDatosCliente;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.gpbDatosGenerales = new System.Windows.Forms.GroupBox();
			this.cmbTipoVenta = new System.Windows.Forms.ComboBox();
			this.label40 = new System.Windows.Forms.Label();
			this.label39 = new System.Windows.Forms.Label();
			this.lblUsuarioImg = new System.Windows.Forms.Label();
			this.lblTelfUsuario = new System.Windows.Forms.Label();
			this.lblUsuario = new System.Windows.Forms.Label();
			this.label35 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblNoVenta = new System.Windows.Forms.Label();
			this.dtpFecha = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.gpbDatosCliente = new System.Windows.Forms.GroupBox();
			this.cmbCliente = new System.Windows.Forms.ComboBox();
			this.lblTelefono = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.lblDireccion = new System.Windows.Forms.Label();
			this.lblNomCliente = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lblBuscar = new System.Windows.Forms.Label();
			this.gpbDetalleVenta = new System.Windows.Forms.GroupBox();
			this.lblTotal = new System.Windows.Forms.Label();
			this.cmbProducto = new System.Windows.Forms.ComboBox();
			this.lblProductosTotales = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.lblProductoImg = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.dgvVentas = new System.Windows.Forms.DataGridView();
			this.productoDataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.precioDataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cantidadDataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.totalDataGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.lblPrecio = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btnCobrar = new System.Windows.Forms.Button();
			this.gpbPago = new System.Windows.Forms.GroupBox();
			this.txtEfectivo = new System.Windows.Forms.TextBox();
			this.lblCambio = new System.Windows.Forms.Label();
			this.label36 = new System.Windows.Forms.Label();
			this.label37 = new System.Windows.Forms.Label();
			this.gpbTotales = new System.Windows.Forms.GroupBox();
			this.lblTotalT = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.lblSubtotalT = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.gpbDatosGenerales.SuspendLayout();
			this.gpbDatosCliente.SuspendLayout();
			this.gpbDetalleVenta.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
			this.panel3.SuspendLayout();
			this.gpbPago.SuspendLayout();
			this.gpbTotales.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DarkBlue;
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel1.ForeColor = System.Drawing.SystemColors.GrayText;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(984, 48);
			this.panel1.TabIndex = 0;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label10.Location = new System.Drawing.Point(204, 9);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(123, 36);
			this.label10.TabIndex = 1;
			this.label10.Text = "Systems";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label9.Location = new System.Drawing.Point(88, 9);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(124, 36);
			this.label9.TabIndex = 0;
			this.label9.Text = "Absolute";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
			this.panel2.Controls.Add(this.gpbDatosGenerales);
			this.panel2.Controls.Add(this.gpbDatosCliente);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel2.Location = new System.Drawing.Point(0, 48);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(984, 198);
			this.panel2.TabIndex = 1;
			// 
			// gpbDatosGenerales
			// 
			this.gpbDatosGenerales.BackColor = System.Drawing.Color.LightSteelBlue;
			this.gpbDatosGenerales.Controls.Add(this.cmbTipoVenta);
			this.gpbDatosGenerales.Controls.Add(this.label40);
			this.gpbDatosGenerales.Controls.Add(this.label39);
			this.gpbDatosGenerales.Controls.Add(this.lblUsuarioImg);
			this.gpbDatosGenerales.Controls.Add(this.lblTelfUsuario);
			this.gpbDatosGenerales.Controls.Add(this.lblUsuario);
			this.gpbDatosGenerales.Controls.Add(this.label35);
			this.gpbDatosGenerales.Controls.Add(this.label3);
			this.gpbDatosGenerales.Controls.Add(this.lblNoVenta);
			this.gpbDatosGenerales.Controls.Add(this.dtpFecha);
			this.gpbDatosGenerales.Controls.Add(this.label2);
			this.gpbDatosGenerales.Controls.Add(this.label1);
			this.gpbDatosGenerales.Cursor = System.Windows.Forms.Cursors.Default;
			this.gpbDatosGenerales.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gpbDatosGenerales.Location = new System.Drawing.Point(16, 14);
			this.gpbDatosGenerales.Name = "gpbDatosGenerales";
			this.gpbDatosGenerales.Size = new System.Drawing.Size(536, 167);
			this.gpbDatosGenerales.TabIndex = 6;
			this.gpbDatosGenerales.TabStop = false;
			this.gpbDatosGenerales.Text = "Datos Generales";
			// 
			// cmbTipoVenta
			// 
			this.cmbTipoVenta.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmbTipoVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTipoVenta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbTipoVenta.FormattingEnabled = true;
			this.cmbTipoVenta.Items.AddRange(new object[] {
			"Normal",
			"A crédito"});
			this.cmbTipoVenta.Location = new System.Drawing.Point(233, 132);
			this.cmbTipoVenta.Name = "cmbTipoVenta";
			this.cmbTipoVenta.Size = new System.Drawing.Size(102, 26);
			this.cmbTipoVenta.TabIndex = 42;
			// 
			// label40
			// 
			this.label40.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label40.Location = new System.Drawing.Point(233, 111);
			this.label40.Name = "label40";
			this.label40.Size = new System.Drawing.Size(77, 23);
			this.label40.TabIndex = 41;
			this.label40.Text = "Tipo";
			// 
			// label39
			// 
			this.label39.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label39.Location = new System.Drawing.Point(346, 12);
			this.label39.Name = "label39";
			this.label39.Size = new System.Drawing.Size(95, 23);
			this.label39.TabIndex = 40;
			this.label39.Text = "Operador:";
			// 
			// lblUsuarioImg
			// 
			this.lblUsuarioImg.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsuarioImg.Image = ((System.Drawing.Image)(resources.GetObject("lblUsuarioImg.Image")));
			this.lblUsuarioImg.Location = new System.Drawing.Point(346, 35);
			this.lblUsuarioImg.Name = "lblUsuarioImg";
			this.lblUsuarioImg.Size = new System.Drawing.Size(179, 124);
			this.lblUsuarioImg.TabIndex = 40;
			// 
			// lblTelfUsuario
			// 
			this.lblTelfUsuario.BackColor = System.Drawing.Color.Lavender;
			this.lblTelfUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblTelfUsuario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTelfUsuario.Location = new System.Drawing.Point(54, 71);
			this.lblTelfUsuario.Name = "lblTelfUsuario";
			this.lblTelfUsuario.Size = new System.Drawing.Size(281, 23);
			this.lblTelfUsuario.TabIndex = 22;
			// 
			// lblUsuario
			// 
			this.lblUsuario.BackColor = System.Drawing.Color.Lavender;
			this.lblUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblUsuario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblUsuario.Location = new System.Drawing.Point(55, 37);
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(280, 23);
			this.lblUsuario.TabIndex = 22;
			// 
			// label35
			// 
			this.label35.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label35.Image = ((System.Drawing.Image)(resources.GetObject("label35.Image")));
			this.label35.Location = new System.Drawing.Point(5, 62);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(53, 40);
			this.label35.TabIndex = 23;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
			this.label3.Location = new System.Drawing.Point(6, 27);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 37);
			this.label3.TabIndex = 22;
			// 
			// lblNoVenta
			// 
			this.lblNoVenta.BackColor = System.Drawing.Color.Lavender;
			this.lblNoVenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblNoVenta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNoVenta.Location = new System.Drawing.Point(121, 133);
			this.lblNoVenta.Name = "lblNoVenta";
			this.lblNoVenta.Size = new System.Drawing.Size(100, 23);
			this.lblNoVenta.TabIndex = 13;
			// 
			// dtpFecha
			// 
			this.dtpFecha.Enabled = false;
			this.dtpFecha.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFecha.Location = new System.Drawing.Point(13, 134);
			this.dtpFecha.Name = "dtpFecha";
			this.dtpFecha.Size = new System.Drawing.Size(98, 23);
			this.dtpFecha.TabIndex = 12;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(119, 111);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 23);
			this.label2.TabIndex = 8;
			this.label2.Text = "Venta";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 111);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 23);
			this.label1.TabIndex = 6;
			this.label1.Text = "Fecha";
			// 
			// gpbDatosCliente
			// 
			this.gpbDatosCliente.BackColor = System.Drawing.Color.LightSteelBlue;
			this.gpbDatosCliente.Controls.Add(this.cmbCliente);
			this.gpbDatosCliente.Controls.Add(this.lblTelefono);
			this.gpbDatosCliente.Controls.Add(this.label8);
			this.gpbDatosCliente.Controls.Add(this.lblDireccion);
			this.gpbDatosCliente.Controls.Add(this.lblNomCliente);
			this.gpbDatosCliente.Controls.Add(this.label4);
			this.gpbDatosCliente.Controls.Add(this.label6);
			this.gpbDatosCliente.Controls.Add(this.lblBuscar);
			this.gpbDatosCliente.Cursor = System.Windows.Forms.Cursors.Default;
			this.gpbDatosCliente.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gpbDatosCliente.Location = new System.Drawing.Point(568, 14);
			this.gpbDatosCliente.Name = "gpbDatosCliente";
			this.gpbDatosCliente.Size = new System.Drawing.Size(400, 167);
			this.gpbDatosCliente.TabIndex = 7;
			this.gpbDatosCliente.TabStop = false;
			this.gpbDatosCliente.Text = "Datos del cliente";
			// 
			// cmbCliente
			// 
			this.cmbCliente.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmbCliente.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbCliente.FormattingEnabled = true;
			this.cmbCliente.Location = new System.Drawing.Point(55, 32);
			this.cmbCliente.Name = "cmbCliente";
			this.cmbCliente.Size = new System.Drawing.Size(285, 26);
			this.cmbCliente.TabIndex = 42;
			this.cmbCliente.SelectedValueChanged += new System.EventHandler(this.CmbClienteSelectedValueChanged);
			// 
			// lblTelefono
			// 
			this.lblTelefono.BackColor = System.Drawing.Color.Lavender;
			this.lblTelefono.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblTelefono.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTelefono.Location = new System.Drawing.Point(55, 133);
			this.lblTelefono.Name = "lblTelefono";
			this.lblTelefono.Size = new System.Drawing.Size(326, 23);
			this.lblTelefono.TabIndex = 20;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
			this.label8.Location = new System.Drawing.Point(3, 127);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(54, 36);
			this.label8.TabIndex = 21;
			// 
			// lblDireccion
			// 
			this.lblDireccion.BackColor = System.Drawing.Color.Lavender;
			this.lblDireccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblDireccion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDireccion.Location = new System.Drawing.Point(55, 99);
			this.lblDireccion.Name = "lblDireccion";
			this.lblDireccion.Size = new System.Drawing.Size(326, 23);
			this.lblDireccion.TabIndex = 18;
			// 
			// lblNomCliente
			// 
			this.lblNomCliente.BackColor = System.Drawing.Color.Lavender;
			this.lblNomCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblNomCliente.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNomCliente.Location = new System.Drawing.Point(55, 66);
			this.lblNomCliente.Name = "lblNomCliente";
			this.lblNomCliente.Size = new System.Drawing.Size(326, 23);
			this.lblNomCliente.TabIndex = 17;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
			this.label4.Location = new System.Drawing.Point(1, 67);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 23);
			this.label4.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
			this.label6.Location = new System.Drawing.Point(1, 99);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(54, 23);
			this.label6.TabIndex = 19;
			// 
			// lblBuscar
			// 
			this.lblBuscar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBuscar.Image = ((System.Drawing.Image)(resources.GetObject("lblBuscar.Image")));
			this.lblBuscar.Location = new System.Drawing.Point(344, 26);
			this.lblBuscar.Name = "lblBuscar";
			this.lblBuscar.Size = new System.Drawing.Size(34, 35);
			this.lblBuscar.TabIndex = 16;
			// 
			// gpbDetalleVenta
			// 
			this.gpbDetalleVenta.BackColor = System.Drawing.Color.LightSteelBlue;
			this.gpbDetalleVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.gpbDetalleVenta.Controls.Add(this.lblTotal);
			this.gpbDetalleVenta.Controls.Add(this.cmbProducto);
			this.gpbDetalleVenta.Controls.Add(this.lblProductosTotales);
			this.gpbDetalleVenta.Controls.Add(this.label24);
			this.gpbDetalleVenta.Controls.Add(this.lblProductoImg);
			this.gpbDetalleVenta.Controls.Add(this.label22);
			this.gpbDetalleVenta.Controls.Add(this.dgvVentas);
			this.gpbDetalleVenta.Controls.Add(this.btnEliminar);
			this.gpbDetalleVenta.Controls.Add(this.btnAgregar);
			this.gpbDetalleVenta.Controls.Add(this.txtCantidad);
			this.gpbDetalleVenta.Controls.Add(this.label19);
			this.gpbDetalleVenta.Controls.Add(this.lblPrecio);
			this.gpbDetalleVenta.Controls.Add(this.label14);
			this.gpbDetalleVenta.Controls.Add(this.label13);
			this.gpbDetalleVenta.Controls.Add(this.label11);
			this.gpbDetalleVenta.Controls.Add(this.label5);
			this.gpbDetalleVenta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gpbDetalleVenta.Location = new System.Drawing.Point(16, 244);
			this.gpbDetalleVenta.Name = "gpbDetalleVenta";
			this.gpbDetalleVenta.Size = new System.Drawing.Size(952, 261);
			this.gpbDetalleVenta.TabIndex = 2;
			this.gpbDetalleVenta.TabStop = false;
			this.gpbDetalleVenta.Text = "Detalle Venta";
			// 
			// lblTotal
			// 
			this.lblTotal.BackColor = System.Drawing.Color.Lavender;
			this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblTotal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotal.Location = new System.Drawing.Point(672, 48);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(79, 20);
			this.lblTotal.TabIndex = 42;
			// 
			// cmbProducto
			// 
			this.cmbProducto.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmbProducto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbProducto.FormattingEnabled = true;
			this.cmbProducto.Location = new System.Drawing.Point(11, 45);
			this.cmbProducto.Name = "cmbProducto";
			this.cmbProducto.Size = new System.Drawing.Size(219, 26);
			this.cmbProducto.TabIndex = 41;
			this.cmbProducto.SelectedValueChanged += new System.EventHandler(this.CmbProductoSelectedValueChanged);
			// 
			// lblProductosTotales
			// 
			this.lblProductosTotales.BackColor = System.Drawing.Color.Lavender;
			this.lblProductosTotales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblProductosTotales.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblProductosTotales.Location = new System.Drawing.Point(161, 230);
			this.lblProductosTotales.Name = "lblProductosTotales";
			this.lblProductosTotales.Size = new System.Drawing.Size(79, 20);
			this.lblProductosTotales.TabIndex = 39;
			// 
			// label24
			// 
			this.label24.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label24.Location = new System.Drawing.Point(6, 231);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(162, 23);
			this.label24.TabIndex = 38;
			this.label24.Text = "Productos totales";
			// 
			// lblProductoImg
			// 
			this.lblProductoImg.Image = ((System.Drawing.Image)(resources.GetObject("lblProductoImg.Image")));
			this.lblProductoImg.Location = new System.Drawing.Point(783, 52);
			this.lblProductoImg.Name = "lblProductoImg";
			this.lblProductoImg.Size = new System.Drawing.Size(150, 174);
			this.lblProductoImg.TabIndex = 37;
			// 
			// label22
			// 
			this.label22.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label22.Location = new System.Drawing.Point(786, 23);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(95, 23);
			this.label22.TabIndex = 36;
			this.label22.Text = "Producto";
			// 
			// dgvVentas
			// 
			this.dgvVentas.AllowUserToAddRows = false;
			this.dgvVentas.BackgroundColor = System.Drawing.Color.Lavender;
			this.dgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.productoDataGrid,
			this.precioDataGrid,
			this.cantidadDataGrid,
			this.totalDataGrid});
			this.dgvVentas.Cursor = System.Windows.Forms.Cursors.Hand;
			this.dgvVentas.GridColor = System.Drawing.SystemColors.ActiveBorder;
			this.dgvVentas.Location = new System.Drawing.Point(9, 76);
			this.dgvVentas.Name = "dgvVentas";
			this.dgvVentas.Size = new System.Drawing.Size(762, 150);
			this.dgvVentas.TabIndex = 35;
			this.dgvVentas.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DgvVentasRowsAdded);
			this.dgvVentas.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.DgvVentasRowStateChanged);
			// 
			// productoDataGrid
			// 
			this.productoDataGrid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.productoDataGrid.HeaderText = "Producto";
			this.productoDataGrid.Name = "productoDataGrid";
			this.productoDataGrid.ReadOnly = true;
			this.productoDataGrid.Width = 113;
			// 
			// precioDataGrid
			// 
			this.precioDataGrid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.precioDataGrid.HeaderText = "Precio";
			this.precioDataGrid.Name = "precioDataGrid";
			this.precioDataGrid.ReadOnly = true;
			this.precioDataGrid.Width = 88;
			// 
			// cantidadDataGrid
			// 
			this.cantidadDataGrid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.cantidadDataGrid.HeaderText = "Cantidad";
			this.cantidadDataGrid.Name = "cantidadDataGrid";
			this.cantidadDataGrid.ReadOnly = true;
			this.cantidadDataGrid.Width = 111;
			// 
			// totalDataGrid
			// 
			this.totalDataGrid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.totalDataGrid.HeaderText = "Total";
			this.totalDataGrid.Name = "totalDataGrid";
			this.totalDataGrid.ReadOnly = true;
			this.totalDataGrid.Width = 78;
			// 
			// btnEliminar
			// 
			this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEliminar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
			this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEliminar.Location = new System.Drawing.Point(373, 44);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(95, 27);
			this.btnEliminar.TabIndex = 32;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEliminar.UseVisualStyleBackColor = true;
			// 
			// btnAgregar
			// 
			this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAgregar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
			this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAgregar.Location = new System.Drawing.Point(275, 44);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(92, 27);
			this.btnAgregar.TabIndex = 31;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// txtCantidad
			// 
			this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtCantidad.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCantidad.Location = new System.Drawing.Point(583, 48);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(81, 20);
			this.txtCantidad.TabIndex = 30;
			this.txtCantidad.TextChanged += new System.EventHandler(this.TxtCantidadTextChanged);
			// 
			// label19
			// 
			this.label19.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.Location = new System.Drawing.Point(672, 23);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(95, 23);
			this.label19.TabIndex = 28;
			this.label19.Text = "Total";
			// 
			// lblPrecio
			// 
			this.lblPrecio.BackColor = System.Drawing.Color.Lavender;
			this.lblPrecio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblPrecio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPrecio.Location = new System.Drawing.Point(496, 48);
			this.lblPrecio.Name = "lblPrecio";
			this.lblPrecio.Size = new System.Drawing.Size(79, 20);
			this.lblPrecio.TabIndex = 14;
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(581, 23);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(85, 23);
			this.label14.TabIndex = 24;
			this.label14.Text = "Cantidad";
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(496, 23);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(60, 23);
			this.label13.TabIndex = 23;
			this.label13.Text = "Precio";
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(9, 23);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(95, 23);
			this.label11.TabIndex = 13;
			this.label11.Text = "Producto";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
			this.label5.Location = new System.Drawing.Point(223, 43);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 35);
			this.label5.TabIndex = 40;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
			this.panel3.Controls.Add(this.btnCobrar);
			this.panel3.Controls.Add(this.gpbPago);
			this.panel3.Controls.Add(this.gpbTotales);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 512);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(984, 107);
			this.panel3.TabIndex = 3;
			// 
			// btnCobrar
			// 
			this.btnCobrar.AutoSize = true;
			this.btnCobrar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCobrar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCobrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCobrar.Image")));
			this.btnCobrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCobrar.Location = new System.Drawing.Point(699, 41);
			this.btnCobrar.Name = "btnCobrar";
			this.btnCobrar.Size = new System.Drawing.Size(100, 43);
			this.btnCobrar.TabIndex = 47;
			this.btnCobrar.Text = "Cobrar";
			this.btnCobrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnCobrar.UseVisualStyleBackColor = true;
			this.btnCobrar.Click += new System.EventHandler(this.BtnCobrarClick);
			// 
			// gpbPago
			// 
			this.gpbPago.BackColor = System.Drawing.Color.LightSteelBlue;
			this.gpbPago.Controls.Add(this.txtEfectivo);
			this.gpbPago.Controls.Add(this.lblCambio);
			this.gpbPago.Controls.Add(this.label36);
			this.gpbPago.Controls.Add(this.label37);
			this.gpbPago.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gpbPago.Location = new System.Drawing.Point(238, 7);
			this.gpbPago.Name = "gpbPago";
			this.gpbPago.Size = new System.Drawing.Size(204, 89);
			this.gpbPago.TabIndex = 48;
			this.gpbPago.TabStop = false;
			this.gpbPago.Text = "Pago";
			// 
			// txtEfectivo
			// 
			this.txtEfectivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtEfectivo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEfectivo.Location = new System.Drawing.Point(13, 53);
			this.txtEfectivo.Name = "txtEfectivo";
			this.txtEfectivo.Size = new System.Drawing.Size(81, 20);
			this.txtEfectivo.TabIndex = 43;
			this.txtEfectivo.TextChanged += new System.EventHandler(this.TxtEfectivoTextChanged);
			// 
			// lblCambio
			// 
			this.lblCambio.BackColor = System.Drawing.Color.Lavender;
			this.lblCambio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblCambio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCambio.Location = new System.Drawing.Point(109, 53);
			this.lblCambio.Name = "lblCambio";
			this.lblCambio.Size = new System.Drawing.Size(79, 20);
			this.lblCambio.TabIndex = 42;
			// 
			// label36
			// 
			this.label36.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label36.Location = new System.Drawing.Point(109, 30);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(95, 23);
			this.label36.TabIndex = 41;
			this.label36.Text = "Cambio";
			// 
			// label37
			// 
			this.label37.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label37.Location = new System.Drawing.Point(13, 30);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(85, 23);
			this.label37.TabIndex = 40;
			this.label37.Text = "Efectivo";
			// 
			// gpbTotales
			// 
			this.gpbTotales.BackColor = System.Drawing.Color.LightSteelBlue;
			this.gpbTotales.Controls.Add(this.lblTotalT);
			this.gpbTotales.Controls.Add(this.label30);
			this.gpbTotales.Controls.Add(this.lblSubtotalT);
			this.gpbTotales.Controls.Add(this.label26);
			this.gpbTotales.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gpbTotales.Location = new System.Drawing.Point(18, 7);
			this.gpbTotales.Name = "gpbTotales";
			this.gpbTotales.Size = new System.Drawing.Size(205, 89);
			this.gpbTotales.TabIndex = 46;
			this.gpbTotales.TabStop = false;
			this.gpbTotales.Text = "Totales";
			// 
			// lblTotalT
			// 
			this.lblTotalT.BackColor = System.Drawing.Color.Lavender;
			this.lblTotalT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblTotalT.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalT.Location = new System.Drawing.Point(108, 53);
			this.lblTotalT.Name = "lblTotalT";
			this.lblTotalT.Size = new System.Drawing.Size(79, 20);
			this.lblTotalT.TabIndex = 44;
			// 
			// label30
			// 
			this.label30.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label30.Location = new System.Drawing.Point(102, 30);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(85, 23);
			this.label30.TabIndex = 43;
			this.label30.Text = "Total";
			// 
			// lblSubtotalT
			// 
			this.lblSubtotalT.BackColor = System.Drawing.Color.Lavender;
			this.lblSubtotalT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblSubtotalT.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubtotalT.Location = new System.Drawing.Point(17, 53);
			this.lblSubtotalT.Name = "lblSubtotalT";
			this.lblSubtotalT.Size = new System.Drawing.Size(79, 20);
			this.lblSubtotalT.TabIndex = 40;
			// 
			// label26
			// 
			this.label26.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label26.Location = new System.Drawing.Point(17, 30);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(85, 23);
			this.label26.TabIndex = 40;
			this.label26.Text = "Subtotal";
			// 
			// frmVentas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CornflowerBlue;
			this.ClientSize = new System.Drawing.Size(984, 619);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.gpbDetalleVenta);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmVentas";
			this.Text = "Catálogo de Ventas";
			this.Load += new System.EventHandler(this.FrmVentasLoad);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.gpbDatosGenerales.ResumeLayout(false);
			this.gpbDatosCliente.ResumeLayout(false);
			this.gpbDetalleVenta.ResumeLayout(false);
			this.gpbDetalleVenta.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.gpbPago.ResumeLayout(false);
			this.gpbPago.PerformLayout();
			this.gpbTotales.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
