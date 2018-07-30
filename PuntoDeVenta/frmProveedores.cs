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
			btnguardar2.Visible=false;
			opro.filtarinacyivos(dgvproveedores_inactivos);
		}
		void BtnagregarClick(object sender, EventArgs e)
		{
			btnguardar2.Visible=false;
			btnagregar.Visible=true;
			opro.id_proveedor=Convert.ToInt32(txtid_proveedor.Text);
			opro.nombre=txtnombre.Text;
			opro.direccion=txtdireccion.Text;
			opro.correo=txtcorreo.Text;
			opro.telefono=txttelefono.Text;
			opro.rfc=txtrfc.Text;
			opro.duenio=txtduenio.Text;
			opro.guardarproveedor();
			opro.filtarproveedor(txtBuscar.Text,dgvproveedor);
		}
		void BtneliminarClick(object sender, EventArgs e)
		{
			string id_provvedor = dgvproveedor[0,dgvproveedor.CurrentCellAddress.Y].Value.ToString();
			if (MessageBox.Show("Estas seguro de eliminar el proveedor con la id: "+id_provvedor,"Cuidado",MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)== DialogResult.Yes)
			opro.Eliminarproveedor(id_provvedor);
			opro.filtarproveedor(txtBuscar.Text,dgvproveedor);
			opro.filtarinacyivos(dgvproveedores_inactivos);
		}
		void BtnmodificarClick(object sender, EventArgs e)
		{
			btnagregar.Visible=false;
			btnguardar2.Visible=true;
			
			txtid_proveedor.Text=dgvproveedor[0,dgvproveedor.CurrentCellAddress.Y].Value.ToString();
			txtnombre.Text=dgvproveedor[1,dgvproveedor.CurrentCellAddress.Y].Value.ToString();
			txtdireccion.Text=dgvproveedor[2,dgvproveedor.CurrentCellAddress.Y].Value.ToString();
			txtcorreo.Text=dgvproveedor[3,dgvproveedor.CurrentCellAddress.Y].Value.ToString();
			txttelefono.Text=dgvproveedor[4,dgvproveedor.CurrentCellAddress.Y].Value.ToString();
			txtrfc.Text=dgvproveedor[5,dgvproveedor.CurrentCellAddress.Y].Value.ToString();
			txtduenio.Text=dgvproveedor[6,dgvproveedor.CurrentCellAddress.Y].Value.ToString();
			
			txtid_proveedor.ReadOnly=true;
		}
		void TabPage1Click(object sender, EventArgs e)
		{
	
		}
		void TxtBuscarTextChanged(object sender, EventArgs e)
		{
			opro.filtarproveedor(txtBuscar.Text,dgvproveedor);
			
		}
		void Btnguardar2Click(object sender, EventArgs e)
		{
			
			
			opro.actualizarproveedor(txtid_proveedor.Text, txtnombre.Text,txtdireccion.Text,txtcorreo.Text,txttelefono.Text,txtrfc.Text,txtduenio.Text);
			opro.filtarproveedor(txtBuscar.Text,dgvproveedor);
			
			
			limpiar();
			btnguardar2.Visible=false;
			btnagregar.Visible=true;
		}
		void limpiar()
		{
			txtcorreo.Clear();
			txtdireccion.Clear();
			txtduenio.Clear();
			txtid_proveedor.Clear();
			txtnombre.Clear();
			txtrfc.Clear();
			txttelefono.Clear();
		}
		void BtnrestaurarClick(object sender, EventArgs e)
		{
			string id_provvedor = dgvproveedores_inactivos[0,dgvproveedores_inactivos.CurrentCellAddress.Y].Value.ToString();
			if (MessageBox.Show("Estas seguro de restaurar el proveedor con la id: "+id_provvedor,"Cuidado",MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)== DialogResult.Yes)
			opro.restaurar(id_provvedor);
			opro.filtarinacyivos(dgvproveedores_inactivos);
			opro.filtarproveedor(txtBuscar.Text,dgvproveedor);
		}
	}
}
