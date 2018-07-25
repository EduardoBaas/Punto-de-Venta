/*
 * Created by SharpDevelop.
 * User: pumas
 * Date: 11/07/2018
 * Time: 02:29 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using AccesoADatos;

namespace PuntoDeVenta
{
	/// <summary>
	/// Description of frmProductos.
	/// </summary>
	public partial class frmProductos : Form
	{
		Productos ClassProduct = new Productos();
		public frmProductos()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void FrmProductosLoad(object sender, EventArgs e)
		{
			ClassProduct.FiltrarProductos(txtBuscar.Text,dgvProductos);
			btnGuardar.Enabled = false;
			txtCodigo.Enabled = false;
			txtCosto.Enabled = false;
			txtExistencia.Enabled = false;
			txtMaximo.Enabled = false;
			txtMinimo.Enabled = false;
			txtProducto.Enabled = false;
		}
		
		void BtnEliminarClick(object sender, EventArgs e)
		{
			if(MessageBox.Show("¿Está seguro de eliminar este producto?","Peligro",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{
				ClassProduct.codigo =dgvProductos["Codigo de barras",dgvProductos.CurrentCellAddress.Y].Value.ToString() ;
				ClassProduct.EliminarProducto();
				ClassProduct.FiltrarProductos(txtBuscar.Text,dgvProductos);
			}
		}
		void BtnGuardarClick(object sender, EventArgs e)
		{
			if (txtCodigo.Text != "" && txtCosto.Text != "" && txtExistencia.Text != "" && txtMaximo.Text != "" && txtMinimo.Text != "" && txtProducto.Text != "") 
			{
				Valores();
				Limpiar();
				btnGuardar.Enabled = true;
				btnEliminar.Enabled = true;
				btnGuardar.Enabled = false;
				txtCodigo.Enabled = false;
				txtCosto.Enabled = false;
				txtExistencia.Enabled = false;
				txtMaximo.Enabled = false;
				txtMinimo.Enabled = false;
				txtProducto.Enabled = false;
			}else
			{
				MessageBox.Show("Ingrese todos los campos para guardar","Error al guardar",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		
		public void Valores()
		{
			ClassProduct.codigo = txtCodigo.Text;
			ClassProduct.nombre = txtProducto.Text;
			ClassProduct.costo = Double.Parse(txtCosto.Text);
			ClassProduct.minimo = int.Parse(txtMinimo.Text);
			ClassProduct.maximo = int.Parse(txtMaximo.Text);
			ClassProduct.existencia = int.Parse(txtExistencia.Text);
			ClassProduct.Update();
			ClassProduct.FiltrarProductos(txtBuscar.Text,dgvProductos);
		}
		
		public void Limpiar()
		{
			txtCodigo.Clear();
			txtBuscar.Clear();
			txtProducto.Clear();
			txtCosto.Clear();
			txtMinimo.Clear();
			txtMaximo.Clear();
			txtExistencia.Clear();
			
		}
		void BtnEditarClick(object sender, EventArgs e)
		{
			btnGuardar.Enabled = true;
			txtCodigo.Enabled = true;
			txtCosto.Enabled = true;
			txtExistencia.Enabled = true;
			txtMaximo.Enabled = true;
			txtMinimo.Enabled = true;
			txtProducto.Enabled = true;
			SetValores();
			btnGuardar.Enabled = true;
			btnEliminar.Enabled = false;
			
		}
		
		public void SetValores()
		{
			txtCodigo.Text = dgvProductos["Codigo de barras",dgvProductos.CurrentCellAddress.Y].Value.ToString();
			txtProducto.Text = dgvProductos["Producto",dgvProductos.CurrentCellAddress.Y].Value.ToString();
			txtCosto.Text = dgvProductos["Costo",dgvProductos.CurrentCellAddress.Y].Value.ToString();
			txtMinimo.Text = dgvProductos["Stock Minimo",dgvProductos.CurrentCellAddress.Y].Value.ToString();
			txtMaximo.Text = dgvProductos["Stock Maximo",dgvProductos.CurrentCellAddress.Y].Value.ToString();
			txtExistencia.Text = dgvProductos["Existencia",dgvProductos.CurrentCellAddress.Y].Value.ToString();
			lblBarras.Text = dgvProductos["Codigo de barras",dgvProductos.CurrentCellAddress.Y].Value.ToString();
		}
		void TxtBuscarTextChanged(object sender, EventArgs e)
		{
			ClassProduct.FiltrarProductos(txtBuscar.Text,dgvProductos);
		}
	}
}
