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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
		//Entradas ClassEntradas = new Entradas();
=======
		Entradas ClassEntradas = new Entradas();
>>>>>>> parent of fa4952e... erroes encontrados
		Productos ClassProduct = new Productos();
=======
>>>>>>> parent of c033f2b... Formulario entradas
=======
		Entradas ClassEntradas = new Entradas();
		Productos ClassProduct = new Productos();
		public string id = "";
		public int cont = 0;
<<<<<<< HEAD
>>>>>>> parent of 16d107e... Merge branch 'master' of https://github.com/EduardoBaas/Punto-de-Venta
=======
=======
>>>>>>> d8f56f83cc8d777de045aa9b1944f723117b7e30
>>>>>>> parent of fa4952e... erroes encontrados
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
<<<<<<< HEAD
<<<<<<< HEAD
	
=======
=======
>>>>>>> parent of fa4952e... erroes encontrados
			ClassEntradas.GetProveedor(cmbProveedor);
			id = cmbProveedor.SelectedValue.ToString();
			cont++;
			
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
			id = cmbProveedor.SelectedValue.ToString();
			ClassEntradas.idProveedor = int.Parse(id);
			ClassProduct.codigo = txtCodigo.Text;
			ClassProduct.nombre = txtProducto.Text;
			ClassProduct.costo = Double.Parse(txtPrecioV.Text);
			ClassProduct.minimo = 10;
			ClassProduct.maximo = 80;
			ClassProduct.existencia = int.Parse(txtCantidad.Text);
=======
	
>>>>>>> d8f56f83cc8d777de045aa9b1944f723117b7e30
		}
		void CmbProveedorSelectedIndexChanged(object sender, EventArgs e)
		{
			
>>>>>>> parent of 16d107e... Merge branch 'master' of https://github.com/EduardoBaas/Punto-de-Venta
		}
	}
}
