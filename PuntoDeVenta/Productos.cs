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
		public string eliminado {get;set;}
		public string condicion {get;set;}
		
		public Productos()
		{
		}
		
		public void FiltrarProductos(string nombre, DataGridView dgv)
		{
			string sql = "SELECT codigo_barras AS 'Codigo de barras', nombre_producto AS 'Producto',costo_producto AS 'Costo',stock_minimo AS 'Stock Minimo',stock_maximo AS 'Stock Maximo',existencia AS 'Existencia' " + 
				"FROM productos WHERE eliminado = 0;";
			dgv.DataSource = FrameBD.SQLSEL(sql);
			dgv.DataMember="Datos";
		}
		
		public void Agregar()
		{
			string sql =string.Format("INSERT INTO productos VALUES('{0}','{1}',{2},{3},{4},{5},'0')",codigo,nombre,costo,minimo,maximo,existencia);
			FrameBD.SQLIDU(sql);
		}
		
		public void Update()
		{
			string sql = string.Format("UPDATE productos SET eliminado = '1' WHERE codigo_barras = '{0}'",codigo);
			FrameBD.SQLIDU(sql);
		}
	}
}
