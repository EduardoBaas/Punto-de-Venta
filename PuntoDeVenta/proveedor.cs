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
		public int id_proveedor { get; set; }
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
				
				string sql = "SELECT id_proveedor as ID,nombre_proveedor AS 'NOMBRE',direccion AS DIRECCION,correo AS CORREO,telefono AS TELEFONO,rfc AS RFC,duenio AS PROPIETARIO   FROM proveedores"
					+
				" WHERE  nombre_proveedor LIKE '" + prob + "%' and eliminado=0";
			
			dgv.DataSource = FrameBD.SQLSEL(sql);
			dgv.DataMember="datos";
		}
			public void filtarinacyivos( DataGridView dgv)
			{
					string sql = "SELECT id_proveedor,nombre_proveedor,direccion,correo,telefono,rfc,duenio  FROM proveedores"
					+
				" WHERE  eliminado=1";
			
			dgv.DataSource = FrameBD.SQLSEL(sql);
			dgv.DataMember="datos";
			}
			public void guardarproveedor()
		{
			string sql= string.Format("INSERT INTO proveedores(id_proveedor,nombre_proveedor,direccion,correo,telefono,rfc,duenio) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}');",id_proveedor,nombre,direccion,correo,telefono,rfc,duenio);
			FrameBD.SQLIDU(sql);
		}
		
		public void Eliminarproveedor(string id)
		{
			string sql= "UPDATE proveedores SET eliminado=1 WHERE id_proveedor="+id+";";
			FrameBD.SQLIDU(sql);
			
		}
		public void restaurar(string id)
		{
			string sql= "UPDATE proveedores SET eliminado=0 WHERE id_proveedor="+id+";";
			FrameBD.SQLIDU(sql);
		}
		
		
		public void actualizarproveedor(string id,string nom,string direc, string cor, string tel,string rfc,string duen)
		{
			string sql=string.Format("UPDATE proveedores SET nombre_proveedor='{1}',direccion='{2}',correo='{3}', telefono='{4}',rfc='{5}',duenio='{6}'" +
			                         " WHERE id_proveedor='{0}';",id,nom,direc,cor,tel,rfc,duen);
			FrameBD.SQLIDU(sql);
			
				
		}
	
	}
}
