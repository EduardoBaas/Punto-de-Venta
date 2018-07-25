/*
 * Created by SharpDevelop.
 * User: pumas
 * Date: 24/07/2018
 * Time: 09:04 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using AccesoADatos;
using System.Windows.Forms;

namespace PuntoDeVenta
{
	/// <summary>
	/// Description of Entradas.
	/// </summary>
	public class Entradas
	{
		frmLogin Login = new frmLogin();
		public string folioCompra {get; set;}
		public string codigoProducto {get; set;}
		public string fechaCompra {get; set;}
		public int cantidad {get; set;}
		public double costo {get; set;}
		public double precioVenta {get; set;}
		public double totalProducto {get; set;}
		public int idProveedor {get; set;}
		public double Impuesto {get; set;}
		public double totalEntrada {get; set;}
		public string fecharegistro = DateTime.Now.ToString("yyyy-MM-dd");
		
		public Entradas()
		{
		}
		
		public void GetProveedor(ComboBox cmb)
		{
			string consulta = "SELECT * FROM proveedores";
			cmb.DataSource = FrameBD.SQLCOMBO(consulta);
			cmb.DisplayMember = "nombre_proveedor";
			cmb.ValueMember = "id_proveedor";
		}
		
		public void InsertarEntrada()
		{
			string sql = string.Format("INSERT INTO entradas values('{0}','{1}',{2},{3},{4},{5},{6},'{7}',{8},'{9}')",folioCompra,codigoProducto,costo,cantidad,totalProducto,totalEntrada,Impuesto,fechaCompra,idProveedor,Login.User);
			FrameBD.SQLIDU(sql);
		}
		
		public void insertProductEntra()
		{
			string sql = string.Format("INSERT INTO productos_entradas(folio_facturas,codigo_barras,fecha_registro) VALUES('{0}','{1}','{2}')",folioCompra,codigoProducto,fecharegistro);
			FrameBD.SQLIDU(sql);
		}
		
		public void SelectProv()
		{
			
		}
	}
}
