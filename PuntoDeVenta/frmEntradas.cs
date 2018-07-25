/*
 * Created by SharpDevelop.
 * User: pumas
 * Date: 11/07/2018
 * Time: 02:24 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PuntoDeVenta
{
	/// <summary>
	/// Description of frmEntradas.
	/// </summary>
	public partial class frmEntradas : Form
	{
		//Entradas ClassEntradas = new Entradas();
		Productos ClassProduct = new Productos();
		public frmEntradas()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void FrmEntradasLoad(object sender, EventArgs e)
		{
			ClassEntradas.GetProveedor(cmbProveedor);
		}
		void BtnAgregarClick(object sender, EventArgs e)
		{
			dgvEntradas.Rows.Add(txtCodigo.Text,txtCantidad.Text,txtCosto.Text,txtPrecioV.Text,txtTotProduct.Text);
		}
		
		void BtnSaveClick(object sender, EventArgs e)
		{
			ValuesInsert();
			ClassEntradas.InsertarEntrada();
			ClassProduct.store();
			ClassEntradas.insertProductEntra();
		}
		
			public void ValuesInsert()
		{
			ClassEntradas.folioCompra = txtFolio.Text;
			ClassEntradas.codigoProducto = txtCodigo.Text;
			ClassEntradas.costo = Double.Parse(txtCosto.Text);
			ClassEntradas.cantidad = int.Parse(txtCantidad.Text);
			ClassEntradas.totalProducto = Double.Parse(txtTotProduct.Text);
			ClassEntradas.totalEntrada = Double.Parse(txtTotal.Text);
			ClassEntradas.Impuesto = Double.Parse(txtIva.Text);
			ClassEntradas.fechaCompra = dtpEntrada.Value.ToString("yyyy-MM-dd");
			string id = cmbProveedor.SelectedValue.ToString();
			ClassEntradas.idProveedor = int.Parse(id);
			ClassProduct.codigo = txtCodigo.Text;
			ClassProduct.nombre = txtProducto.Text;
			ClassProduct.costo = Double.Parse(txtPrecioV.Text);
			ClassProduct.minimo = 10;
			ClassProduct.maximo = 80;
			ClassProduct.existencia = int.Parse(txtCantidad.Text);
		}
	}
}
