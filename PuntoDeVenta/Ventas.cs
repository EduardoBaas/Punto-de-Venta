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
		public static uint puerto = 3309;
		public string acceso = "Server=localhost;Port="+puerto+";Password=12345;UserID=root;Database=punto_venta;";
		
		public Ventas()
		{
		}
		
		public void buscarProducto(TextBox prod)
		{
			prod.AutoCompleteSource = AutoCompleteSource.CustomSource;
			prod.AutoCompleteMode = AutoCompleteMode.Suggest;
			AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
			additems(coleccion);
			prod.AutoCompleteCustomSource = coleccion;
		}
		
		public void additems(AutoCompleteStringCollection completar)
		{
			string producto="";
			
			using (MySqlConnection conexion = new MySqlConnection(acceso))
			{
				conexion.Open();
				DataTable tabla = new DataTable();
				MySqlDataAdapter comandos = new MySqlDataAdapter("SELECT nombre_producto FROM productos WHERE nombre_producto LIKE '"+producto+"%';",conexion);
				comandos.Fill(tabla);
				foreach (DataRow X in tabla.Rows)
				{
					completar.Add(X[0].ToString());
				}
				
				conexion.Close();
			}
		}
		
		public void buscarCliente(TextBox clien)
		{
			clien.AutoCompleteSource = AutoCompleteSource.CustomSource;
			clien.AutoCompleteMode = AutoCompleteMode.Suggest;
			AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
			addDatos(coleccion);
			clien.AutoCompleteCustomSource = coleccion;
		}
		
		public void addDatos(AutoCompleteStringCollection completar) 
		{	
			string cliente="";
			
			using (MySqlConnection conexion = new MySqlConnection(acceso))
			{
				conexion.Open();
				DataTable tabla = new DataTable();
				MySqlDataAdapter comandos = new MySqlDataAdapter("SELECT CONCAT(nombre_cliente,' ',apellidoP_cliente,' ',apellidoM_cliente) FROM clientes WHERE nombre_cliente LIKE '"+cliente+"%';",conexion);
				comandos.Fill(tabla);
				foreach (DataRow X in tabla.Rows)
				{
					completar.Add(X[0].ToString());
				}
				conexion.Close();
			}
			
		}
	}
}
