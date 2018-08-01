/*
 * Created by SharpDevelop.
 * User: pumas
 * Date: 11/07/2018
 * Time: 02:28 p. m.
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
	/// Description of frmUsuarios.
	/// </summary>
	public partial class frmUsuarios : Form
	{
		Usuarios ClassUsuarios = new Usuarios();
		public frmUsuarios()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		//se assignan los valores a las variables de la clase Usuario
		public void Valores()
		{
			ClassUsuarios.Curp = txtCURP.Text;
			ClassUsuarios.nombre = txtNombre.Text;
			ClassUsuarios.ap = txtApellidoP.Text;
			ClassUsuarios.am = txtApellidoM.Text;
			ClassUsuarios.user = txtUsuario.Text;
			ClassUsuarios.telefono = txtTelefono.Text;
			ClassUsuarios.email = txtCorreo.Text;
			ClassUsuarios.pass = txtContrasenia.Text;
			string id = cmbTipo.SelectedValue.ToString();
			ClassUsuarios.tipo = int.Parse(id);
		}
		
		//limpia los textbox para poder ingresar otros datos
		void Limpiar()
		{
			txtNombre.Clear();
			txtApellidoP.Clear();
			txtApellidoM.Clear();
			txtUsuario.Clear();
			txtTelefono.Clear();
			txtCorreo.Clear();
			txtContrasenia.Clear();
			txtCURP.Clear();
		}
		
		//regresa los valores del dgvUsuarios a los textbox
		public void ValoresUpdate()
		{
			txtCURP.Text = dgvUsuarios[0,dgvUsuarios.CurrentCellAddress.Y].Value.ToString();
			txtNombre.Text = dgvUsuarios[1,dgvUsuarios.CurrentCellAddress.Y].Value.ToString();
			txtApellidoP.Text = dgvUsuarios[2,dgvUsuarios.CurrentCellAddress.Y].Value.ToString();
			txtApellidoM.Text = dgvUsuarios[3,dgvUsuarios.CurrentCellAddress.Y].Value.ToString();
			txtUsuario.Text = dgvUsuarios[4,dgvUsuarios.CurrentCellAddress.Y].Value.ToString();
			txtTelefono.Text = dgvUsuarios[5,dgvUsuarios.CurrentCellAddress.Y].Value.ToString();
			txtCorreo.Text = dgvUsuarios[6,dgvUsuarios.CurrentCellAddress.Y].Value.ToString();
			txtContrasenia.Text = dgvUsuarios[7,dgvUsuarios.CurrentCellAddress.Y].Value.ToString();
		}
		
		
		
		//_____Funcionalidades_________
		void FrmUsuariosLoad(object sender, EventArgs e)
		{
			ClassUsuarios.FiltrarUser(dgvUsuarios);
			ClassUsuarios.FiltrarUserD(dgvUserD,txtBuscD.Text);
			btnGuardarUp.Enabled = false;
			if (dgvUserD.RowCount >= 1) 
			{
				btnRestore.Enabled = true;
			}else
			{
				btnRestore.Enabled = false;
			}
		}
		void CmbTipoClick(object sender, EventArgs e)
		{
			ClassUsuarios.GetTipos(cmbTipo);
		}
		
		//_______botones______
		void BtnSaveClick(object sender, EventArgs e)
		{
			if (txtCURP.Text != "" && txtNombre.Text != "" && txtApellidoP.Text != "" && txtApellidoM.Text != "" && txtUsuario.Text != "" && txtContrasenia.Text != "") 
			{
				Valores();
				ClassUsuarios.Insertar();
				ClassUsuarios.FiltrarUser(dgvUsuarios);
			}else
			{
				MessageBox.Show("Por favor ingrese todos los campos obligatorios *","Ha ocurrido un error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		void BtnEliminarClick(object sender, EventArgs e)
		{
			Limpiar();
			btnSave.Enabled = true;
			btnGuardarUp.Enabled = false;
		}
		void DgvUsuariosKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete) 
			{
				if (MessageBox.Show("¿Desea eliminar al usuario de la tabla de usuarios activos?","Advertencia",MessageBoxButtons.YesNo,MessageBoxIcon.Asterisk) == DialogResult.Yes) 
				{
					ClassUsuarios.Curp = dgvUsuarios[0,dgvUsuarios.CurrentCellAddress.Y].Value.ToString();
					ClassUsuarios.DeleteUser();
					ClassUsuarios.FiltrarUser(dgvUsuarios);
					ClassUsuarios.FiltrarUserD(dgvUserD,txtBuscD.Text);
				}
				
			}
		}
		void BtnRestoreClick(object sender, EventArgs e)
		{
			if (MessageBox.Show("¿Desea volver a agregar al usuario a la tabla de usuarios activos?","Advertencia",MessageBoxButtons.YesNo,MessageBoxIcon.Asterisk) == DialogResult.Yes) 
			{
				ClassUsuarios.Curp = dgvUserD[0,dgvUserD.CurrentCellAddress.Y].Value.ToString();
				ClassUsuarios.RestaurarUser();
				ClassUsuarios.FiltrarUser(dgvUsuarios);
				ClassUsuarios.FiltrarUserD(dgvUserD,txtBuscD.Text);
				if (dgvUserD.RowCount < 1) 
				{
					btnRestore.Enabled = false;
				}else
				{
					btnRestore.Enabled = true;
				}
			}
		}
		void BtnEditarClick(object sender, EventArgs e)
		{
			ValoresUpdate();
			btnSave.Enabled = false;
			btnGuardarUp.Enabled = true;
		}
		void BtnGuardarUpClick(object sender, EventArgs e)
		{
			if (MessageBox.Show("¿Está seguro de actualizar los datos del usuario?","Advertencia",MessageBoxButtons.YesNo,MessageBoxIcon.Asterisk) == DialogResult.Yes) 
			{
				Valores();
				lblCondicion.Text = dgvUsuarios[0,dgvUsuarios.CurrentCellAddress.Y].Value.ToString();
				ClassUsuarios.UpdateDatos(lblCondicion.Text);
				ClassUsuarios.FiltrarUser(dgvUsuarios);
				Limpiar();
				btnSave.Enabled = true;
			}
		}
		
		void BtnCancelClick(object sender, EventArgs e)
		{
			Limpiar();
		}
		
		void TxtBuscDTextChanged(object sender, EventArgs e)
		{
			if (txtBuscD.Text != "") 
			{
				ClassUsuarios.FiltrarUserD(dgvUserD,txtBuscD.Text);
			}else
			{
				ClassUsuarios.FiltrarUserD(dgvUserD,txtBuscD.Text);
			}
			
		}
		
		void DgvUserDRowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			btnRestore.Enabled = true;
		}
		
		
		//___________validaciones____________
		void TxtBuscDKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Validaciones.valida("T",e.KeyChar);
		}
		void TxtCURPKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Validaciones.valida("U",e.KeyChar);
		}
		void TxtNombreKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Validaciones.valida("T",e.KeyChar);
		}
		void TxtApellidoPKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Validaciones.valida("T",e.KeyChar);
		}
		void TxtApellidoMKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Validaciones.valida("T",e.KeyChar);
		}
		void TxtTelefonoKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Validaciones.validaReal(txtTelefono,e.KeyChar);
		}
		void TxtCorreoKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Validaciones.validaCorreo(txtCorreo,e.KeyChar);
		}
		
	
	}
}
