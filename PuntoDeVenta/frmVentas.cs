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
			objVentas.buscarProducto(txtProducto);
			objVentas.buscarCliente(txtCliente);
		}
		
	}
}
