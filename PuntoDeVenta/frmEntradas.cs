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
using AccesoADatos;

namespace PuntoDeVenta
{
	/// <summary>
	/// Description of frmEntradas.
	/// </summary>
	public partial class frmEntradas : Form
	{
		Entradas ClassEntradas = new Entradas();
		Productos ClassProduct = new Productos();
		public string id;
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
			ClassEntradas.filtrarProEntr(txtProducto.Text,dgvBuscar);
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
		}
		void CmbProveedorSelectedIndexChanged(object sender, EventArgs e)
		{
			SelectProv(lblRfc,lblTelefono);
		}
		
		public void SelectProv(Label lbl, Label lbl2)
		{
			string[] datos =FrameBD.ObtieneCampos("proveedores","id_proveedor = '"+cmbProveedor.SelectedValue+"'","rfc,telefono");
			
			if (datos.Length>1)
			{
				lbl.Text = datos[0];
				lbl2.Text = datos[1];
			}
		}
		void TxtCodigoTextChanged(object sender, EventArgs e)
		{
			
			
		}
		void TxtProductoTextChanged(object sender, EventArgs e)
		{
			if (txtProducto.Text != "") 
			{
				ClassEntradas.filtrarProEntr(txtProducto.Text,dgvBuscar);
			}
		}
		void DgvBuscarCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
		void DgvBuscarMouseClick(object sender, MouseEventArgs e)
		{
			txtCodigo.Text = dgvBuscar[0,dgvBuscar.CurrentCellAddress.Y].Value.ToString();
			txtProducto.Text = dgvBuscar[1,dgvBuscar.CurrentCellAddress.Y].Value.ToString();
			txtPrecioV.Text = dgvBuscar[2,dgvBuscar.CurrentCellAddress.Y].Value.ToString();
		}

	}
}
