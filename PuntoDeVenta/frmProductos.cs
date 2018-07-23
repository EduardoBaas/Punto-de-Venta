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
			Valores();
			Limpiar();
		}
		
		public void Valores()
		{
			ClassProduct.codigo = txtCodigo.Text;
			ClassProduct.nombre = txtProducto.Text;
			ClassProduct.costo = Double.Parse(txtCosto.Text);
			ClassProduct.minimo = int.Parse(txtMinimo.Text);
			ClassProduct.maximo = int.Parse(txtMaximo.Text);
			ClassProduct.existencia = int.Parse(txtExistencia.Text);
			ClassProduct.Agregar();
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
		
	}
}
