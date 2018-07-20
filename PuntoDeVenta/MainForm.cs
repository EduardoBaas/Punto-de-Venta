/*
 * Created by SharpDevelop.
 * User: pumas
 * Date: 10/07/2018
 * Time: 10:35 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using AccesoADatos;

namespace PuntoDeVenta
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void TsbVentasClick(object sender, EventArgs e)
		{
			frmVentas formVentas = new frmVentas();
			formVentas.MdiParent = this;
			formVentas.Show();
		}
		void TsbEntradasClick(object sender, EventArgs e)
		{
			frmEntradas formEntradas = new frmEntradas();
			formEntradas.MdiParent = this;
			formEntradas.Show();
		}
		void TsbUsuariosClick(object sender, EventArgs e)
		{
			frmUsuarios formUsuarios = new frmUsuarios();
			formUsuarios.MdiParent = this;
			formUsuarios.Show();
		}
		void TsmVentasClick(object sender, EventArgs e)
		{
			frmVentas formVentas = new frmVentas();
			formVentas.MdiParent = this;
			formVentas.Show();
		}
		void TsmEntradasClick(object sender, EventArgs e)
		{
			frmEntradas formEntradas = new frmEntradas();
			formEntradas.MdiParent = this;
			formEntradas.Show();
		}
		void TsmUsuariosClick(object sender, EventArgs e)
		{
			frmUsuarios formUsuarios = new frmUsuarios();
			formUsuarios.MdiParent = this;
			formUsuarios.Show();
		}
		void TsmClientesClick(object sender, EventArgs e)
		{
			frmClientes formClientes = new frmClientes();
			formClientes.MdiParent = this;
			formClientes.Show();
		}
		void TsmProductosClick(object sender, EventArgs e)
		{
			frmProductos formProductos = new frmProductos();
			formProductos.MdiParent = this;
			formProductos.Show();
			formProductos.Location = new Point (0,0);
			
		}
		void TsmProveedoresClick(object sender, EventArgs e)
		{
			frmProveedores formProveedores = new frmProveedores();
			formProveedores.MdiParent = this;
			formProveedores.Show();
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			foreach (Control ctl in this.Controls)
{
   try
   {
   		MdiClient ctlMDI;
      // Attempt to cast the control to type MdiClient.
      ctlMDI = (MdiClient) ctl;

      // Set the BackColor of the MdiClient control.
      ctlMDI.BackColor = this.BackColor;
   }
   catch (InvalidCastException exc)
   {
      // Catch and ignore the error if casting failed.
   }         
}
		}
	
	}
}
