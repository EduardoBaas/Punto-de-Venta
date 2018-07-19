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
		private System.Windows.Forms.TextBox txtExistencia;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtMaximo;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtMinimo;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataGridView dgvProductos;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtBuscar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.Button btnGuardar;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.txtProducto = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCosto = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtExistencia = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtMaximo = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtMinimo = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.dgvProductos = new System.Windows.Forms.DataGridView();
			this.label8 = new System.Windows.Forms.Label();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
			this.label1.Location = new System.Drawing.Point(16, 10);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(463, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "Catálogo de prroductos en existencia";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
			this.label2.Location = new System.Drawing.Point(33, 58);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(133, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "Código de barras";
			// 
			// txtCodigo
			// 
			this.txtCodigo.Location = new System.Drawing.Point(33, 86);
			this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(228, 22);
			this.txtCodigo.TabIndex = 2;
			// 
			// txtProducto
			// 
			this.txtProducto.Location = new System.Drawing.Point(33, 153);
			this.txtProducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtProducto.Name = "txtProducto";
			this.txtProducto.Size = new System.Drawing.Size(228, 22);
			this.txtProducto.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
			this.label3.Location = new System.Drawing.Point(33, 125);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(154, 25);
			this.label3.TabIndex = 3;
			this.label3.Text = "Nombre del producto";
			// 
			// txtCosto
			// 
			this.txtCosto.Location = new System.Drawing.Point(33, 220);
			this.txtCosto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtCosto.Name = "txtCosto";
			this.txtCosto.Size = new System.Drawing.Size(228, 22);
			this.txtCosto.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
			this.label4.Location = new System.Drawing.Point(33, 192);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(133, 25);
			this.label4.TabIndex = 5;
			this.label4.Text = "Costo";
			// 
			// txtExistencia
			// 
			this.txtExistencia.Location = new System.Drawing.Point(33, 429);
			this.txtExistencia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtExistencia.Name = "txtExistencia";
			this.txtExistencia.Size = new System.Drawing.Size(228, 22);
			this.txtExistencia.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
			this.label5.Location = new System.Drawing.Point(33, 401);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(154, 25);
			this.label5.TabIndex = 7;
			this.label5.Text = "Cantidad a ingresar";
			// 
			// txtMaximo
			// 
			this.txtMaximo.Location = new System.Drawing.Point(33, 355);
			this.txtMaximo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtMaximo.Name = "txtMaximo";
			this.txtMaximo.Size = new System.Drawing.Size(228, 22);
			this.txtMaximo.TabIndex = 10;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.DodgerBlue;
			this.label6.Location = new System.Drawing.Point(33, 327);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(133, 25);
			this.label6.TabIndex = 9;
			this.label6.Text = "Stock máximo";
			// 
			// txtMinimo
			// 
			this.txtMinimo.Location = new System.Drawing.Point(33, 286);
			this.txtMinimo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtMinimo.Name = "txtMinimo";
			this.txtMinimo.Size = new System.Drawing.Size(228, 22);
			this.txtMinimo.TabIndex = 12;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.DodgerBlue;
			this.label7.Location = new System.Drawing.Point(33, 258);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(133, 25);
			this.label7.TabIndex = 11;
			this.label7.Text = "Stock mínimo";
			// 
			// dgvProductos
			// 
			this.dgvProductos.AllowUserToAddRows = false;
			this.dgvProductos.AllowUserToDeleteRows = false;
			this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProductos.GridColor = System.Drawing.SystemColors.ActiveBorder;
			this.dgvProductos.Location = new System.Drawing.Point(332, 86);
			this.dgvProductos.Name = "dgvProductos";
			this.dgvProductos.ReadOnly = true;
			this.dgvProductos.RowHeadersVisible = false;
			this.dgvProductos.RowHeadersWidth = 120;
			this.dgvProductos.Size = new System.Drawing.Size(790, 365);
			this.dgvProductos.TabIndex = 13;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.DodgerBlue;
			this.label8.Location = new System.Drawing.Point(332, 58);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(133, 25);
			this.label8.TabIndex = 14;
			this.label8.Text = "Buscar";
			// 
			// txtBuscar
			// 
			this.txtBuscar.Location = new System.Drawing.Point(404, 55);
			this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.Size = new System.Drawing.Size(718, 22);
			this.txtBuscar.TabIndex = 15;
			// 
			// btnEliminar
			// 
			this.btnEliminar.ForeColor = System.Drawing.Color.Crimson;
			this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
			this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEliminar.Location = new System.Drawing.Point(257, 469);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(107, 37);
			this.btnEliminar.TabIndex = 18;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// btnActualizar
			// 
			this.btnActualizar.ForeColor = System.Drawing.Color.MediumBlue;
			this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
			this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnActualizar.Location = new System.Drawing.Point(144, 469);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(107, 37);
			this.btnActualizar.TabIndex = 19;
			this.btnActualizar.Text = "Editar P.";
			this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnActualizar.UseVisualStyleBackColor = true;
			// 
			// btnGuardar
			// 
			this.btnGuardar.ForeColor = System.Drawing.Color.MediumBlue;
			this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
			this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnGuardar.Location = new System.Drawing.Point(31, 469);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(107, 37);
			this.btnGuardar.TabIndex = 20;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// frmProductos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1168, 538);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.txtBuscar);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.dgvProductos);
			this.Controls.Add(this.txtMinimo);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtMaximo);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtExistencia);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtCosto);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtProducto);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.DodgerBlue;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MaximizeBox = false;
			this.Name = "frmProductos";
			this.Text = "Catálogo de productos";
			this.Load += new System.EventHandler(this.FrmProductosLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
