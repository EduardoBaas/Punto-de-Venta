/*
 * Created by SharpDevelop.
 * User: Toño
 * Date: 23/07/2018
 * Time: 08:48 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using AccesoADatos;// Permite el acceso a datos.
using System.Windows.Forms; // Permite el acceso a los componentes de la vista.

namespace PuntoDeVenta
{
	/// <summary>
	/// Description of Ventas.
	/// </summary>
	public class Ventas
	{
		public string codigo{ get; set;}
		public string nombre{ get; set;}
		public double costo{ get; set;}
		public int minimo{ get; set;}
		public int maximo{ get; set;}
		public double eliminado{ get; set;}
		
		public Ventas()
		{
		}
		
//		public string buscar_producto(string txtproducto, DataGridView dgv_ventas)
//		{
//			string sql ="SELECT nombre_producto FROM productos"+
//						" WHERE nombre_producto LIKE'"+ txtproducto +"%'";
//			dgv_ventas.DataSource=FrameBD.SQLSEL(sql)=Convert.ChangeType(txtproducto, DataGridView txtproducto);
//			dgv_ventas.DataMember="datos";
//		}
	}
}
