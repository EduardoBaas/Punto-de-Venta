/*
 * Creado por SharpDevelop.
 * Usuario: ERNESTO MORENO
 * Fecha: 25/07/2018
 * Hora: 11:53 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using AccesoADatos;
using System.Windows.Forms;

namespace PuntoDeVenta
{
	/// <summary>
	/// Description of proveedor.
	/// </summary>
	public class proveedor
	{
		public string nombre { get; set; }
		public string direccion { get; set; }
		public string correo { get; set; }
		public string telefono { get; set; }
		public string rfc { get; set; }
		public string duenio { get; set; }
		public string eliminado { get; set; }
		public proveedor()
		{
		}
		
			public void filtarproveedor(string prob, DataGridView dgv)
		{
				
				string sql = "SELECT nombre_proveedor,direccion,correo,telefono,rfc,duenio  FROM proveedores";
					//+
				//" WHERE  LIKE '" + prob + "%'";
			
			dgv.DataSource = FrameBD.SQLSEL(sql);
			dgv.DataMember="datos";
		}
	}
}
