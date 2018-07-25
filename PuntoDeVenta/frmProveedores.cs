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
	/// Description of frmProveedores.
	/// </summary>
	public partial class frmProveedores : Form
	{
		proveedor opro = new proveedor();
		public frmProveedores()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void DgvprovedorCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
	
		}
		void FrmProveedoresLoad(object sender, EventArgs e)
		{
			opro.filtarproveedor(txtBuscar.Text,dgvproveedor);
		}
	}
}
