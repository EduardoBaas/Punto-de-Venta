/*
 * Created by SharpDevelop.
 * User: pumas
 * Date: 30/07/2018
 * Time: 10:35 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using Herramientas;

namespace PuntoDeVenta
{
	/// <summary>
	/// Description of frmTipoUsuario.
	/// </summary>
	public partial class frmTipoUsuario : Form
	{
		TipoUsuario ClassTipo = new TipoUsuario();
		public frmTipoUsuario()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void SetValores()
		{
			ClassTipo.TipoUser = txtTipo.Text;
			ClassTipo.permisos = txtPermiso.Text;
		}
		
		void Limpiar()
		{
			txtTipo.Clear();
			txtPermiso.Clear();
		}
		void FrmTipoUsuarioLoad(object sender, EventArgs e)
		{
			ClassTipo.Filtrartipo(dgvTipos);
			ClassTipo.FiltrartipoD(dgvTipoD);
			btnGuardarUp.Enabled = false;
			if (dgvTipoD.RowCount >= 1) 
			{
				btnRestore.Enabled = true;
			}else
			{
				btnRestore.Enabled = false;
			}
		}
		void BtnSaveClick(object sender, EventArgs e)
		{
			if (MessageBox.Show("¿Está seguro de que quiere agregar este tipo de usuario?","Advertencia",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.Yes)
			{
				SetValores();
				ClassTipo.InsertTipo();
				ClassTipo.Filtrartipo(dgvTipos);
				Limpiar();
			}
		}
		void DgvTiposKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete) 
			{
				if (MessageBox.Show("¿Está seguro de eliminar este tipo de usuarios?","Advertencia",MessageBoxButtons.YesNo,MessageBoxIcon.Asterisk) == DialogResult.Yes)
				{
					string id = dgvTipos[0,dgvTipos.CurrentCellAddress.Y].Value.ToString();
					ClassTipo.idUser = int.Parse(id);
					ClassTipo.Deletetipo();
					ClassTipo.Filtrartipo(dgvTipos);
					ClassTipo.FiltrartipoD(dgvTipoD);
				}
			}
		}
		void BtnRestoreClick(object sender, EventArgs e)
		{
			if (MessageBox.Show("¿Está seguro de restaurar este tipo de usuarios?","Advertencia",MessageBoxButtons.YesNo,MessageBoxIcon.Asterisk) == DialogResult.Yes) 
			{
				ClassTipo.RestaurarTipo();
				ClassTipo.Filtrartipo(dgvTipos);
				ClassTipo.FiltrartipoD(dgvTipoD);
				if (dgvTipoD.RowCount < 1) 
				{
					btnRestore.Enabled = false;
				}
			}
		}
		void BtnEditarClick(object sender, EventArgs e)
		{
			txtTipo.Text = dgvTipos[1,dgvTipos.CurrentCellAddress.Y].Value.ToString();
			txtPermiso.Text = dgvTipos[2,dgvTipos.CurrentCellAddress.Y].Value.ToString();
			btnGuardarUp.Enabled = true;
		}
		void BtnGuardarUpClick(object sender, EventArgs e)
		{
			if (MessageBox.Show("¿Está seguro de actualizar los datos de este tipo de usuario?","Advertencia",MessageBoxButtons.YesNo,MessageBoxIcon.Asterisk) == DialogResult.Yes) 
			{
				string id = dgvTipos[0,dgvTipos.CurrentCellAddress.Y].Value.ToString();
				ClassTipo.idUser = int.Parse(id);
				SetValores();
				ClassTipo.UpdateTipo();
				btnGuardarUp.Enabled = false;
				Limpiar();
			}
		}
		void BtnCancelarClick(object sender, EventArgs e)
		{
			Limpiar();
		}
		void DgvTipoDRowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			btnRestore.Enabled = true;
		}
		void DgvTipoDRowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			if (dgvTipos.RowCount < 1) 
			{
				btnRestore.Enabled = false;
			}
		}
		void TxtTipoKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Validaciones.valida("T",e.KeyChar);
		}
		void TxtPermisoKeyPress(object sender, KeyPressEventArgs e)
		{
			e.KeyChar = Validaciones.valida("U",e.KeyChar);
		}	
	}
}
