/*
 * Created by SharpDevelop.
 * User: Toño
 * Date: 23/07/2018
 * Time: 08:48 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using AccesoADatos;
using System.Data;
using MySql.Data.MySqlClient;

namespace PuntoDeVenta
{
	/// <summary>
	/// Description of Ventas.
	/// </summary>
	public class Ventas
	{
		// Variables para detalle ventas

		public int idDetalleVentas{ get; set;}
		public double costoUnitario{ get; set;}
		public int cantidadProducto{ get; set;}
		public double totalProducto{ get; set;}
		public string codigoBarras{ get; set;}
	
		// Varibles para ventas

		public int idVenta{ get; set;}
		public double total{ get; set;}
		public string fechaVenta{ get; set;}
		public string tipoPago{ get; set;}
		public string cancelado{ get; set;}
		public int idCliente{ get; set;}
		public string CURP{ get; set;}
		
		// Otras variables.
		
		public int venta;
		
		public Ventas()
		{
			
		}
		
		//Autocompleta la busqueda del cliente
		public void obtenerCliente(ComboBox client)
		{
			string sql = "SELECT id_clientes,CONCAT(nombre_cliente,' ',apellidoP_cliente,' ',apellidoM_cliente) as Cliente FROM clientes";
			
			FrameBD.comboComplete(sql,client,"Cliente","id_clientes");
		}
		
		//Autocompleta la busqueda del producto
		public void obtenerProducto(ComboBox prod)
		{
			string sql = "SELECT codigo_barras,nombre_producto FROM productos";
			
			FrameBD.comboComplete(sql,prod,"nombre_producto","codigo_barras");
		}
		
		//Obtienen los datos del clientes a quien se realiza la venta.
		public void dataCliente(ComboBox cli, Label nom, Label direc, Label telf)
		{
			string tabla = "clientes";
			string condicion = "id_clientes='"+cli.SelectedValue+"'";
			string campos = "id_clientes,CONCAT(nombre_cliente,' ',apellidoP_cliente,' ',apellidoM_cliente),direccion,telefono";
			
			string[] datos = FrameBD.ObtieneCampos(tabla,condicion,campos);
			if (datos.Length>1)
			{
				idCliente=Convert.ToInt32(datos[0]);
				nom.Text=datos[1];
				direc.Text=datos[2];
				telf.Text=datos[3];
			}	
		}
		
		//Obtiene los datos básicos del producto seleccionado
		//para realizar las operaciones.
		public void dataProducto(ComboBox prod, Label precio)
		{
			string tabla = "productos";
			string condicion = "codigo_barras='"+prod.SelectedValue+"'";
			string campos = "codigo_barras,costo_producto";
			
			string[] datos = FrameBD.ObtieneCampos(tabla,condicion,campos);
			
			if (datos.Length>1)
			{
				codigoBarras=datos[0];
				precio.Text=datos[1];
			}	
		}
		
		//Obtiene los datos básicos del operador
		public void dataUser(Label usuario, Label telf)
		{
			string tabla = "usuarios";
			string condicion = "usuario='AntonioHau'";
			string campos = "CONCAT(nombre,' ',apellidoP,' ',ApellidoM),telefono,CURP";
			
			string[] datos = FrameBD.ObtieneCampos(tabla,condicion,campos);
			
			if (datos.Length>1)
			{
				usuario.Text=datos[0];
				telf.Text=datos[1];
				CURP=datos[2];
			}	
		}
		
		public double calculo(double precio, int cantidad)
		{
			double total;
			total=cantidad*precio;
			return total;
		}
		
		public double pago(double total, double efectivo)
		{
			double pagar;
			pagar=efectivo-total;
			return pagar;
		}
		
		public int nVenta()
		{
			venta=venta+1;
			return venta;
		}
		
		//Se crea una id_detalle_ventas genérica, por el momento solo por
		//de funcionalidad
		public int nDetalle()
		{
			Random generador =  new Random();
			int num;
			num=generador.Next(1,255);
			return num;
		}
		
		//Suma los totales de la venta de cada producto junto con el subtotal.
		public void totales(DataGridView grid, Label total, Label stotal)
		{
			double sum=0, sub=0;
			
			for (int i = 0; i < grid.RowCount; i++)
			{
				string valor = grid["totalDataGrid",i].Value.ToString();
				sum=sum+Convert.ToDouble(valor);
				sub=sub+Convert.ToDouble((Convert.ToDouble(valor)/100)*16);
			}
			
			total.Text=sum.ToString("");
			stotal.Text=sub.ToString("");
		}
		
		//Inserta los datos correspondientes en la tabla de detalle ventas
		public void insertarDetalle(DataGridView data)
		{
			for (int i = 0; i < data.RowCount; i++) 
			{
				string sql = string.Format("INSERT INTO detalle_ventas VALUES({0},{1},{2},{3},'{4}',{5})"
				,idDetalleVentas,Convert.ToDouble(data["precioDataGrid",i].Value),Convert.ToInt32(data["cantidadDataGrid",i].Value),
				Convert.ToDouble(data["totalDataGrid",i].Value),codigoBarras,idVenta);
				
				FrameBD.SQLIDU(sql);
			}
			
		}
		
		//Inserta los datos correspondientes en la tabla ventas.
		public void insertarVentas()
		{
			string sql = string.Format("INSERT INTO ventas VALUES({0},{1},'{2}','{3}','{4}',{5},'{6}')"
			,idVenta,total,fechaVenta,tipoPago,cancelado,idCliente,CURP);
			
			FrameBD.SQLIDU(sql);
		}
	}
}
