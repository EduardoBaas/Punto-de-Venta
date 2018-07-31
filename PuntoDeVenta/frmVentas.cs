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
using System.Data;
using MySql.Data.MySqlClient;

namespace PuntoDeVenta
{
	/// <summary>
	/// Description of frmVentas.
	/// </summary>
	public partial class frmVentas : Form
	{
		Ventas objVentas = new Ventas();
		
		public frmVentas()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void FrmVentasLoad(object sender, EventArgs e)
		{
			objVentas.obtenerCliente(cmbCliente);
			objVentas.obtenerProducto(cmbProducto);
			cmbTipoVenta.SelectedIndex=0;
			lblNoVenta.Text=objVentas.nVenta().ToString("0000");
			objVentas.dataUser(lblUsuario,lblTelfUsuario);	
		}
		
		void CmbClienteSelectedValueChanged(object sender, EventArgs e)
		{
			objVentas.dataCliente(cmbCliente,lblNomCliente,lblDireccion,lblTelefono);
		}
		
		void CmbProductoSelectedValueChanged(object sender, EventArgs e)
		{
			objVentas.dataProducto(cmbProducto,lblPrecio);
			txtCantidad.Clear();
		}
		
		void TxtCantidadTextChanged(object sender, EventArgs e)
		{
			if (txtCantidad.Text!="")
			{
				lblTotal.Text=objVentas.calculo(Convert.ToDouble(lblPrecio.Text),Convert.ToInt32(txtCantidad.Text)).ToString();
			}else
			{
				lblTotal.Text="0";
			}
		}
		
		void BtnAgregarClick(object sender, EventArgs e)
		{
			dgvVentas.Rows.Add(cmbProducto.Text,lblPrecio.Text,txtCantidad.Text,lblTotal.Text);
		}
		
		void propiedadesDetalle()
		{
			//Propiedades detalleVenta
			objVentas.idDetalleVentas=objVentas.nDetalle();
			objVentas.costoUnitario=Convert.ToDouble(lblPrecio.Text);
			objVentas.cantidadProducto=Convert.ToInt32(txtCantidad.Text);
			objVentas.totalProducto=Convert.ToDouble(lblTotal.Text);
		}
		
		void propiedadesVentas()
		{
			//Propiedades ventas
			objVentas.idVenta=Convert.ToInt32(lblNoVenta.Text);
			objVentas.total=Convert.ToDouble(lblTotalT.Text);
			objVentas.fechaVenta=dtpFecha.Value.ToString("yyyy-MM-dd");
			objVentas.tipoPago=cmbTipoVenta.Text;
			objVentas.cancelado="0";
		}
		
		void BtnCobrarClick(object sender, EventArgs e)
		{
			lblNoVenta.Text=objVentas.nVenta().ToString("0000");
			propiedadesVentas();
			propiedadesDetalle();
			objVentas.insertarVentas();
			objVentas.insertarDetalle(dgvVentas);
		}
		
		void DgvVentasRowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
		{
			lblProductosTotales.Text=dgvVentas.Rows.Count.ToString("0");
			objVentas.totales(dgvVentas,lblTotalT,lblSubtotalT);
		}
		
		void TxtEfectivoTextChanged(object sender, EventArgs e)
		{
			if (txtEfectivo.Text!="")
			{
				lblCambio.Text=objVentas.pago(Convert.ToDouble(lblTotalT.Text),Convert.ToDouble(txtEfectivo.Text)).ToString();
			}else
			{
				lblCambio.Text="0";
			}
		}
		void DgvVentasRowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			propiedadesDetalle();
		}
		
	}
}
