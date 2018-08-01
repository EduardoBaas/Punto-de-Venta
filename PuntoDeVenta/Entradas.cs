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
		
		public string folioCompra {get; set;}
		public string codigoProducto {get; set;}
		public string fechaCompra {get; set;}
		public string user {get; set;}
		public int cantidad {get; set;}
		public double costo {get; set;}
		public double precioVenta {get; set;}
		public double totalProducto {get; set;}
		public int idProveedor {get; set;}
		public double Impuesto {get; set;}
		public double totalEntrada {get; set;}
		public double subtotal {get; set;}
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
			string sql = string.Format("INSERT INTO entradas values('{0}',{1},{2},{3},'{4}',{5},'{6}')",folioCompra,subtotal,Impuesto,totalEntrada,fechaCompra,idProveedor,user);
			FrameBD.SQLIDU(sql);
		}
		
		public void insertProductEntra()
		{
			string sql = string.Format("INSERT INTO productos_entradas(folio_facturas,codigo_barras,costo_unitario,cantidad_producto,total_producto) VALUES('{0}','{1}',{2},{3},{4})",folioCompra,codigoProducto,costo,cantidad,totalProducto);
			FrameBD.SQLIDU(sql);
		}
		
		public void UpdateProductos()
		{
			string sql =string.Format("UPDATE productos SET existencia = existencia + {0} WHERE codigo_barras = '{1}'" ,cantidad,codigoProducto);
			FrameBD.SQLIDU(sql);
		}
		public void filtrarProEntr(string condicion,DataGridView dgv)
		{
			string sql = "SELECT codigo_barras AS Codigo, nombre_producto  AS Producto, costo_producto AS Precio, existencia AS existencia,stock_maximo AS 'Stock Maximo' FROM productos WHERE nombre_producto LIKE'"+condicion+"%'";
			dgv.DataSource = FrameBD.SQLSEL(sql);
			dgv.DataMember="Datos";
		}
		
		public void Calculos(TextBox subtotal,TextBox iva, TextBox total)
		{
			if (subtotal.Text != "" && iva.Text != "" && total.Text != "") 
			{
				iva.Text = Convert.ToString(Double.Parse(subtotal.Text) * .16);
				total.Text = Convert.ToString(Double.Parse(subtotal.Text) + Double.Parse(iva.Text));
				
			}
		}
		
		public void CalculosDGV(DataGridView dgv)
		{
			if (dgv[2,dgv.CurrentCellAddress.Y].Value.ToString() != "" && dgv[3,dgv.CurrentCellAddress.Y].Value.ToString() != "")
			{
				dgv[5,dgv.CurrentCellAddress.Y].Value = Convert.ToString(Double.Parse(dgv[2,dgv.CurrentCellAddress.Y].Value.ToString()) * Double.Parse(dgv[3,dgv.CurrentCellAddress.Y].Value.ToString()));
			}else
			{
				dgv[5,dgv.CurrentCellAddress.Y].Value = "0";
			}
		}
		
		public void Calcsubtot(DataGridView dgv,TextBox txt)
		{
			double tot = 0;
			foreach (DataGridViewRow row in dgv.Rows)
			{
				tot+= Double.Parse(row.Cells[5].Value.ToString());
				txt.Text = Convert.ToString(tot);
			}
		}
		
		public void FiltrarCodigo(string condicion,DataGridView dgv)
		{
			string sql = "SELECT codigo_barras AS Codigo, nombre_producto  AS Producto, costo_producto AS Precio, existencia AS existencia,stock_maximo AS 'Stock Maximo' FROM productos WHERE codigo_barras LIKE'"+condicion+"%'";
			dgv.DataSource = FrameBD.SQLSEL(sql);
			dgv.DataMember="Datos";
		}
		
	}
}
