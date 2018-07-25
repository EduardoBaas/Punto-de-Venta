/*
 * Created by SharpDevelop.
 * User: pumas
 * Date: 11/07/2018
 * Time: 07:52 p. m.
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
	/// Description of frmLogin.
	/// </summary>
	public partial class frmLogin : Form
	{
		public string User;
		public frmLogin()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void FrmLoginLoad(object sender, EventArgs e)
		{
//			Size desktopsize = System.Windows.Forms.SystemInformation.PrimaryMonitorSize;
//			Int32 alto = (desktopsize.Height-200)/2;
//			Int32 ancho = (desktopsize.Width - 500)/2;
//			panel1.Location = new Point (ancho,alto);
			
			
			//fecha y hora
			lblHora.Text = DateTime.Now.ToLongTimeString();
			lblFecha.Text = DateTime.Now.ToLongDateString();
			tmrFechaHora.Start();
		}
		void PtxIngresarMouseHover(object sender, EventArgs e)
		{
			ptxIngresar.Size = new Size(90,82);
		}
		void PtxIngresarMouseLeave(object sender, EventArgs e)
		{
			ptxIngresar.Size = new Size(80,75);
		}
		void TmrFechaHoraTick(object sender, EventArgs e)
		{
			
			lblHora.Text = DateTime.Now.ToLongTimeString();
		}
		void BtnMinimizarClick(object sender, EventArgs e)
		{
			this.WindowState= FormWindowState.Minimized;
		}
		void BtnCerrarClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void PtxIngresarClick(object sender, EventArgs e)
		{
			string tabla = "Usuarios";
			string condicion = "usuario = '"+txtUsuario.Text+"'";
			string campos = "usuario,contrasenia,nombre,apellidoP";
			User = txtUsuario.Text;
			
			string [] datos = FrameBD.ObtieneCampos(tabla,condicion,campos);
			if (datos.Length > 1)
			{
				if (datos[1] == txtContra.Text)
				{
					this.Hide();
					MainForm frmMain =new MainForm();
					frmMain.ShowDialog();
					this.Close();
				}else
				{
					MessageBox.Show("La contraseña es incorrecta","Acceson denegado",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				}
			}else
			{
				MessageBox.Show("El usuario no existe","Información",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
			
		}
	}
}
