/*
 * Created by SharpDevelop.
 * User: pumas
 * Date: 29/07/2018
 * Time: 11:28 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using AccesoADatos;

namespace PuntoDeVenta
{
	/// <summary>
	/// Description of RegEntradas.
	/// </summary>
	public class RegEntradas
	{
		public string condicion {get; set;}
		public string field {get; set;}
		public RegEntradas()
		{
		}
		
		public void filtrarRegistros(DataGridView dgv,string cond, string campo)
		{
			string sql = string.Format("SELECT folio_facturas AS Factura, subtotal AS Subtotal, iva AS IVA, total_entrada AS Total, fecha_compra AS Fecha, proveedores.nombre_proveedor AS Proveedor, UsuarioEntrada AS Usuario"
			+" FROM entradas INNER JOIN proveedores ON entradas.id_proveedor = proveedores.id_proveedor"
			+" WHERE "+campo+" LIKE '"+cond+"'");
			dgv.DataSource = FrameBD.SQLSEL(sql);
			dgv.DataMember = "Datos";
		}
		
		public void filtInicio(DataGridView dgv)
		{
			string sql = string.Format("SELECT folio_facturas AS Factura, subtotal AS Subtotal, iva AS IVA, total_entrada AS Total, fecha_compra AS Fecha, proveedores.nombre_proveedor AS Proveedor, UsuarioEntrada AS Usuario"
			+" FROM entradas INNER JOIN proveedores ON entradas.id_proveedor = proveedores.id_proveedor");
			FrameBD.SQLSEL(sql);
			dgv.DataSource = FrameBD.SQLSEL(sql);
			dgv.DataMember = "Datos";
		}
		
		public void SelectProv(ComboBox cmb)
		{
			string consulta = "SELECT * FROM proveedores";
			cmb.DataSource = FrameBD.SQLCOMBO(consulta);
			cmb.DisplayMember = "nombre_proveedor";
			cmb.ValueMember = "nombre_proveedor";
		}
		
		public void ProEntra()
		{
			string sql = "SELECT id_productos_entradas AS Entrada, productos_entradas.folio_factura AS 'Folio Compras'," +
			" productos_entradas.codigo_barras AS 'Codigo Producto', productos_entradas.costo_unitario AS 'Costo U', productos_entradas."
			+"cantidad_producto AS 'Cantidad',productos_entradas..total_producto AS Total del Producto";
		}
		
	}
}
