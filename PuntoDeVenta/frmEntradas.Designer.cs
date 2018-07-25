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
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.TextBox txtFolio;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox gpbDatosCompra;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntradas));
			this.tbgentradas = new System.Windows.Forms.TabControl();
			this.tpgIngresar = new System.Windows.Forms.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.gpbDatosCompra = new System.Windows.Forms.GroupBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtFolio = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.tbpHistorial = new System.Windows.Forms.TabPage();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.tbgentradas.SuspendLayout();
			this.tpgIngresar.SuspendLayout();
			this.panel1.SuspendLayout();
			this.gpbDatosCompra.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
			this.tbpHistorial.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// tbgentradas
			// 
			this.tbgentradas.Controls.Add(this.tpgIngresar);
			this.tbgentradas.Controls.Add(this.tbpHistorial);
			this.tbgentradas.Location = new System.Drawing.Point(0, 0);
			this.tbgentradas.Name = "tbgentradas";
			this.tbgentradas.SelectedIndex = 0;
			this.tbgentradas.Size = new System.Drawing.Size(1361, 571);
			this.tbgentradas.TabIndex = 0;
			// 
			// tpgIngresar
			// 
			this.tpgIngresar.Controls.Add(this.panel1);
			this.tpgIngresar.Controls.Add(this.panel3);
			this.tpgIngresar.Location = new System.Drawing.Point(4, 22);
			this.tpgIngresar.Name = "tpgIngresar";
			this.tpgIngresar.Padding = new System.Windows.Forms.Padding(3);
			this.tpgIngresar.Size = new System.Drawing.Size(1353, 545);
			this.tpgIngresar.TabIndex = 0;
			this.tpgIngresar.Text = "Ingresar Produtos";
			this.tpgIngresar.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Lavender;
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.gpbDatosCompra);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(3, 53);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1347, 154);
			this.panel1.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(569, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(540, 148);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Datos del proveedor";
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
			// gpbDatosCompra
			// 
			this.gpbDatosCompra.Controls.Add(this.dateTimePicker1);
			this.gpbDatosCompra.Controls.Add(this.pictureBox3);
			this.gpbDatosCompra.Controls.Add(this.pictureBox2);
			this.gpbDatosCompra.Controls.Add(this.label5);
			this.gpbDatosCompra.Controls.Add(this.txtFolio);
			this.gpbDatosCompra.Controls.Add(this.textBox1);
			this.gpbDatosCompra.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gpbDatosCompra.Location = new System.Drawing.Point(5, 3);
			this.gpbDatosCompra.Name = "gpbDatosCompra";
			this.gpbDatosCompra.Size = new System.Drawing.Size(540, 148);
			this.gpbDatosCompra.TabIndex = 7;
			this.gpbDatosCompra.TabStop = false;
			this.gpbDatosCompra.Text = "Datos de la compra";
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
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Lavender;
			this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(62, 89);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(138, 23);
			this.label5.TabIndex = 5;
			this.label5.Text = "Observaciones";
			// 
			// txtFolio
			// 
			this.txtFolio.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFolio.Location = new System.Drawing.Point(295, 48);
			this.txtFolio.Name = "txtFolio";
			this.txtFolio.Size = new System.Drawing.Size(165, 23);
			this.txtFolio.TabIndex = 4;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(206, 89);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(326, 44);
			this.textBox1.TabIndex = 6;
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
			this.tbpHistorial.Controls.Add(this.panel2);
			this.tbpHistorial.Location = new System.Drawing.Point(4, 22);
			this.tbpHistorial.Name = "tbpHistorial";
			this.tbpHistorial.Padding = new System.Windows.Forms.Padding(3);
			this.tbpHistorial.Size = new System.Drawing.Size(1353, 545);
			this.tbpHistorial.TabIndex = 1;
			this.tbpHistorial.Text = "Historial";
			this.tbpHistorial.UseVisualStyleBackColor = true;
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
			// dateTimePicker1
			// 
			this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(45, 46);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(155, 22);
			this.dateTimePicker1.TabIndex = 8;
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
			// frmEntradas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(1360, 570);
			this.Controls.Add(this.tbgentradas);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmEntradas";
			this.Text = "frmEntradas";
			this.Load += new System.EventHandler(this.FrmEntradasLoad);
			this.tbgentradas.ResumeLayout(false);
			this.tpgIngresar.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.gpbDatosCompra.ResumeLayout(false);
			this.gpbDatosCompra.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
			this.tbpHistorial.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
