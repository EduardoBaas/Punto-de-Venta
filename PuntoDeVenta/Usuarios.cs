/*
 * Created by SharpDevelop.
 * User: pumas
 * Date: 30/07/2018
 * Time: 07:02 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using AccesoADatos;
using System.Windows.Forms;

namespace PuntoDeVenta
{
	/// <summary>
	/// Description of Usuarios.
	/// </summary>
	public class Usuarios
	{
		public string Curp {get; set;}
		public string nombre {get; set;}
		public string ap {get; set;}
		public string am {get; set;}
		public string user {get; set;}
		public string telefono {get; set;}
		public string email {get; set;}
		public string pass {get; set;}
		public int tipo {get; set;}
		
		public Usuarios()
		{
		}
		
		public void GetTipos(ComboBox cmb)
		{
			string consulta = "SELECT * FROM tipo_usuario";
			cmb.DataSource = FrameBD.SQLCOMBO(consulta);
			cmb.DisplayMember = "tipo_usuario";
			cmb.ValueMember = "id_tipo";
		}
		
		//aquí sucede la insersión de datos, tomando los valores get set realizados en el frmUsuarios.
		public void Insertar()
		{
			string sql = string.Format("INSERT INTO usuarios VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}',{8},'0')"
			,Curp,nombre,ap,am,user,telefono,email,pass,tipo);
			FrameBD.SQLIDU(sql);
		}
		
		//sirve para cargar los datos al dgv de usuarios, recibe de parámetro un DataGridView
		public void FiltrarUser(DataGridView dgv)
		{
			string sql = "SELECT usuarios.CURP, usuarios.nombre AS Nombre,usuarios.apellidoP AS 'A. Paterno'," +
			"usuarios.apellidoM AS 'A. Materno',usuarios.usuario AS Usuario,usuarios.telefono AS Telefono," +
			"usuarios.correo AS Correo,usuarios.contrasenia AS Password,tipo_usuario.tipo_usuario AS 'T. de usuario'" +
			" FROM usuarios INNER JOIN tipo_usuario ON usuarios.id_tipo = tipo_usuario.id_tipo" +
			" WHERE usuarios.eliminado = '0'";
			FrameBD.SQLSEL(sql);
			dgv.DataSource = FrameBD.SQLSEL(sql);
			dgv.DataMember = "Datos";
		}
		
		//filtro para el dgv de usuarios eliminados con busqueda incluida
		public void FiltrarUserD(DataGridView dgv,string nom)
		{
			string sql = "SELECT usuarios.CURP, usuarios.nombre AS Nombre,usuarios.apellidoP AS 'A. Paterno'," +
			"usuarios.apellidoM AS 'A. Materno',usuarios.usuario AS Usuario,usuarios.telefono AS Telefono," +
			"usuarios.correo AS Correo,usuarios.contrasenia AS Password,tipo_usuario.tipo_usuario AS 'T. de usuario'" +
			" FROM usuarios INNER JOIN tipo_usuario ON usuarios.id_tipo = tipo_usuario.id_tipo" +
			" WHERE usuarios.eliminado = '1' AND usuarios.nombre like '"+nom+"%'";
			FrameBD.SQLSEL(sql);
			dgv.DataSource = FrameBD.SQLSEL(sql);
			dgv.DataMember = "Datos";
		}
		
		//cambiar el estado de eliminado de un usuario a 1
		public void DeleteUser()
		{
			string sql = "UPDATE usuarios SET eliminado = '1' WHERE CURP = '"+Curp+"'";
			FrameBD.SQLIDU(sql);
		}
		
		//cambiar el estado de eliminado de un usuario a '0'
		public void RestaurarUser()
		{
			string sql = "UPDATE usuarios SET eliminado = '0' WHERE CURP = '"+Curp+"'";
			FrameBD.SQLIDU(sql);
		}
		
		public void UpdateDatos(string condicion)
		{
			string sql = string.Format("UPDATE usuarios SET CURP ='{0}',nombre = '{1}',apellidoP = '{2}',apellidoM = '{3}',usuario ='{4}',telefono ='{5}',correo = '{6}',contrasenia = '{7}',id_tipo = {8}",Curp,nombre,ap,am,user,telefono,email,pass,tipo +
			" WHERE CURP = '"+condicion+"'");
			FrameBD.SQLIDU(sql);
		}
	}
}
