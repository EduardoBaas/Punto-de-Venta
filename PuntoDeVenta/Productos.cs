/*
 * Created by SharpDevelop.
 * User: pumas
 * Date: 17/07/2018
 * Time: 08:51 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using AccesoADatos;
namespace PuntoDeVenta
{
	/// <summary>
	/// Description of Productos.
	/// </summary>
	public class Productos
	{
		public string codigo {get; set;}
		public string nombre {get; set;}
		public double costo {get;set;}
		public int minimo {get;set;}
		public int maximo {get;set;}
		public int existencia {get;set;}
		public string condicion {get;set;}
		
		public Productos()
		{
		}
		
		public void FiltrarProductos(string barras, DataGridView dgv)
		{
			string sql = "SELECT codigo_barras AS 'Codigo de barras', nombre_producto AS 'Producto',costo_producto AS 'Costo',stock_minimo AS 'Stock Minimo',stock_maximo AS 'Stock Maximo',existencia AS 'Existencia' " +
			                           "FROM productos WHERE eliminado = 0 and codigo_barras LIKE'"+barras+"%'";
			dgv.DataSource = FrameBD.SQLSEL(sql);
			dgv.DataMember="Datos";
		}
		
		public void Update()
		{
			string sql =string.Format("UPDATE productos SET codigo_barras = '{0}',nombre_producto = '{1}',costo_producto = {2},stock_minimo = {3},stock_maximo = {4},existencia = {5},eliminado = '0' WHERE codigo_barras ='{6}'",codigo,nombre,costo,minimo,maximo,existencia,codigo);
			FrameBD.SQLIDU(sql);
		}
		
		public void EliminarProducto()
		{
			string sql = string.Format("CALL EliminarProducto('{0}')",codigo);
			FrameBD.SQLIDU(sql);
		}
	}
}
