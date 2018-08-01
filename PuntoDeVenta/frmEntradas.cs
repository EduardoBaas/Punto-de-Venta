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
using Herramientas;

namespace PuntoDeVenta
{
	/// <summary>
	/// Description of frmEntradas.
	/// </summary>
	public partial class frmEntradas : Form
	{
		Entradas ClassEntradas = new Entradas();
		Productos ClassProduct = new Productos();
		RegEntradas ClassRegis = new RegEntradas();
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
			ClassRegis.SelectProv(cmbBuscP);
			ClassRegis.filtInicio(dgvRegistroE);
		}
		void BtnAgregarClick(object sender, EventArgs e)
		{
			if (txtProducto.Text != "" && txtCodigo.Text != "") 
			{
				string tabla = "Productos";
				string condicion = "codigo_barras = '"+txtCodigo.Text+"'";
				string campos = "codigo_barras,"+Convert.ToString("nombre_producto")+Convert.ToString(",costo_producto");
				string[] Datos = FrameBD.ObtieneCampos(tabla,condicion,campos);
				
				if (txtCosto.Text != "" && txtCantidad.Text != "") 
				{
					ClassEntradas.cantidad = int.Parse(txtCantidad.Text);
					ClassEntradas.costo = Double.Parse(txtCosto.Text);
					dgvEntradas.Rows.Add(Datos[0],Datos[1],ClassEntradas.cantidad,ClassEntradas.costo,Datos[2],txtTotProduct.Text);
					dgvEntradas.Columns[0].ReadOnly = true;
					dgvEntradas.Columns[1].ReadOnly = true;
					dgvEntradas.Columns[4].ReadOnly = true;
					dgvEntradas.Columns[5].ReadOnly = true;
				}else
				{
					dgvEntradas.Rows.Add(Datos[0],Datos[1],"1","0",Datos[2],"0");
					dgvEntradas.Columns[0].ReadOnly = true;
					dgvEntradas.Columns[1].ReadOnly = true;
					dgvEntradas.Columns[4].ReadOnly = true;
					dgvEntradas.Columns[5].ReadOnly = true;
				}
				
				txtSubtotal.Text = "0";
				ClassEntradas.Calcsubtot(dgvEntradas,txtSubtotal);
			}else
			{
				MessageBox.Show("Ingrese los valores obligatorios *","Ha ocurrido un error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
			
		}
		
		void BtnSaveClick(object sender, EventArgs e)
		{
			if (txtCodigo.Text == "" && txtCantidad.Text == "" && txtCosto.Text == "" && txtPrecioV.Text == "" && txtTotProduct.Text == "") 
			{
				ValuesInsert();
				txtSubtotal.Text = "0";
				txtIva.Text = "0";
				txtTotal.Text = "0";
				
			}else
			{
				MessageBox.Show("Hay datos que no se han guardado, para continuar guardelos o limpie los cuadros de texto","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		
		public void ValuesInsert()
		{
			if (dgvEntradas.RowCount > 0)
			{
				if (txtFolio.Text != "") 
				{
					ClassEntradas.folioCompra = txtFolio.Text;
					ClassEntradas.totalEntrada = Double.Parse(txtTotal.Text);
					ClassEntradas.Impuesto = Double.Parse(txtIva.Text);
					ClassEntradas.fechaCompra = dtpEntrada.Value.ToString("yyyy-MM-dd");
					id = cmbProveedor.SelectedValue.ToString();
					ClassEntradas.idProveedor = int.Parse(id);
					ClassEntradas.subtotal = Double.Parse(txtSubtotal.Text);
					ClassEntradas.InsertarEntrada();
					
					for (int i = 0; i < dgvEntradas.RowCount; i++) 
					{
						ClassEntradas.codigoProducto = dgvEntradas[0,i].Value.ToString();
						//ClassProduct.nombre = dgvEntradas[1,i].Value.ToString();
						ClassEntradas.cantidad = int.Parse(dgvEntradas[2,i].Value.ToString());
						ClassEntradas.costo = Double.Parse(dgvEntradas[3,i].Value.ToString());
						ClassEntradas.totalProducto = Double.Parse(dgvEntradas[5,i].Value.ToString());
						ClassEntradas.insertProductEntra();
						ClassEntradas.UpdateProductos();
					}
					for (int m = 0; m < dgvEntradas.RowCount; m++) 
					{
						dgvEntradas.Rows.Clear();
					}
					MessageBox.Show("Se han guardado los datos de manera correcta","Buen trabajo",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				}else
				{
					MessageBox.Show("Por favor Ingrese el folio de la compra","Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				}
				
			}else
			{
				MessageBox.Show("No hay registros para guardar","Error al insertar",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
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
			if (txtCodigo.Text != "") 
			{
				ClassEntradas.FiltrarCodigo(txtCodigo.Text,dgvBuscar);
				txtProducto.ReadOnly = true;
			}else
			{
				ClassEntradas.FiltrarCodigo(txtCodigo.Text,dgvBuscar);
				txtProducto.ReadOnly = false;
			}
			
		}
		void TxtProductoTextChanged(object sender, EventArgs e)
		{
			if (txtProducto.Text != "") 
			{
				ClassEntradas.filtrarProEntr(txtProducto.Text,dgvBuscar);
				txtCodigo.ReadOnly = true;
			}else
			{
				ClassEntradas.filtrarProEntr(txtProducto.Text,dgvBuscar);
				ClearBuscar();
				txtCodigo.ReadOnly = false;
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
		
		
		public void ClearBuscar()
		{
			txtCantidad.Clear();
			txtCodigo.Clear();
			txtCosto.Clear();
			txtPrecioV.Clear();
			txtTotProduct.Clear();
		}
		void TxtCantidadTextChanged(object sender, EventArgs e)
		{
			if (txtCosto.Text != ""  && txtCantidad.Text != "") 
			{
				txtProducto.Text = Convert.ToString(Double.Parse(txtCantidad.Text) * Double.Parse(txtCosto.Text));
			}else
			{
				txtTotProduct.Text = "0";
			}
		}
		void TxtCostoTextChanged(object sender, EventArgs e)
		{
			if (txtCantidad.Text != "" && txtCosto.Text != "") 
			{
				txtTotProduct.Text = Convert.ToString(Double.Parse(txtCantidad.Text) * Double.Parse(txtCosto.Text));
			}else
			{
				txtTotProduct.Text = "0";
			}
		}
		void BtnEliminarClick(object sender, EventArgs e)
		{
			txtProducto.Clear();
		}
		void DgvEntradasCellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			
			ClassEntradas.CalculosDGV(dgvEntradas);
			ClassEntradas.Calcsubtot(dgvEntradas,txtSubtotal);
			ClassEntradas.Calculos(txtSubtotal,txtIva,txtTotal);
			
		}
		void DgvEntradasKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Right)
			{
				dgvEntradas[2,dgvEntradas.CurrentCellAddress.Y].Value = Convert.ToString(int.Parse(dgvEntradas[2,dgvEntradas.CurrentCellAddress.Y].Value.ToString()) + 1);
				ClassEntradas.CalculosDGV(dgvEntradas);
			}else
			{
				if (e.KeyCode == Keys.Left) 
				{
					if (Double.Parse(dgvEntradas[2,dgvEntradas.CurrentCellAddress.Y].Value.ToString()) > 1) 
					{
						dgvEntradas[2,dgvEntradas.CurrentCellAddress.Y].Value = Convert.ToString(int.Parse(dgvEntradas[2,dgvEntradas.CurrentCellAddress.Y].Value.ToString()) -1);
						ClassEntradas.CalculosDGV(dgvEntradas);
					}
				}else
				{
					if (e.KeyCode == Keys.Delete) 
					{
						dgvEntradas.Rows.RemoveAt(dgvEntradas.CurrentRow.Index);
					}
				}
			}
			ClassEntradas.Calcsubtot(dgvEntradas,txtSubtotal);
			ClassEntradas.Calculos(txtSubtotal,txtIva,txtTotal);
		}
		void DgvEntradasRowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			ClassEntradas.Calcsubtot(dgvEntradas,txtSubtotal);
			ClassEntradas.Calculos(txtSubtotal,txtIva,txtTotal);
		}
		void DgvEntradasRowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			ClassEntradas.Calcsubtot(dgvEntradas,txtSubtotal);
			ClassEntradas.Calculos(txtSubtotal,txtIva,txtTotal);
		}
		void TxtBuscUsuTextChanged(object sender, EventArgs e)
		{
			if (txtBuscUsu.Text != "") 
			{
				cmbBuscP.Enabled = false;
				dtpFechaR.Enabled = false;
				ClassRegis.field = "UsuarioEntrada";
				ClassRegis.condicion = txtBuscUsu.Text;
			}else
			{
				cmbBuscP.Enabled = true;
				dtpFechaR.Enabled = true;
				ClassRegis.filtrarRegistros(dgvRegistroE,ClassRegis.condicion,ClassRegis.field);
			}
			
		}
		void DtpFechaRValueChanged(object sender, EventArgs e)
		{
			txtBuscUsu.Text = "";
			ClassRegis.field = "fecha_compra";
			ClassRegis.condicion = dtpFechaR.Value.ToString("yyyy-MM-dd");
			ClassRegis.filtrarRegistros(dgvRegistroE,ClassRegis.condicion,ClassRegis.field);
		}
		void CmbBuscPSelectedIndexChanged(object sender, EventArgs e)
		{
			txtBuscUsu.Text = "";
			ClassRegis.field = "nombre_proveedor";
			ClassRegis.condicion = cmbBuscP.SelectedValue.ToString();
		}
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			ClassRegis.filtInicio(dgvRegistroE);
		}
		
		
		//_______Validaciones_____
		
		void TxtFolioKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Validaciones.valida("U",e.KeyChar);
		}
		void TxtProductoKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Validaciones.valida("U",e.KeyChar);
		}
		void TxtCodigoKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Validaciones.valida("N",e.KeyChar);
		}
		void TxtCantidadKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Validaciones.valida("N", e.KeyChar);
		}
		void TxtCostoKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Validaciones.validaReal(txtCosto,e.KeyChar);
		}
		
		
	}
}
