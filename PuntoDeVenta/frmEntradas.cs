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

namespace PuntoDeVenta
{
	/// <summary>
	/// Description of frmEntradas.
	/// </summary>
	public partial class frmEntradas : Form
	{
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
	
		}
		void PtxCloseClick(object sender, EventArgs e)
		{
			if(MessageBox.Show("¿Está seguro de que quiere cerrar de este módulo?","Advertencia",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation)==DialogResult.Yes)
			{
				this.Close();
			}
		}
	}
}
