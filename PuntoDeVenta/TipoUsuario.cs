/*
 * Created by SharpDevelop.
 * User: pumas
 * Date: 30/07/2018
 * Time: 10:35 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using AccesoADatos;

namespace PuntoDeVenta
{
	/// <summary>
	/// Description of TipoUsuario.
	/// </summary>
	public class TipoUsuario
	{
		public string TipoUser {get; set;}
		public string permisos {get; set;}
		public int idUser {get; set;}
		
		public TipoUsuario()
		{
		}
		
		//insertar tipo de usuario
		public void InsertTipo()
		{
			string sql = string.Format("INSERT INTO tipo_usuario(tipo_usuario,permisos) VALUES('{0}','{1}')",TipoUser,permisos);
			FrameBD.SQLIDU(sql);
		}
		
		public void UpdateTipo()
		{
			string sql =string.Format("UPDATE tipo_usuario SET tipo_usuario = '{0}', permisos = '{1}' WHERE id_tipo = {2}",TipoUser,permisos,idUser);
			FrameBD.SQLIDU(sql);
		}
		
		public void Deletetipo ()
		{
			string sql = string.Format("UPDATE tipo_usuario SET eliminado = '1' WHERE id_tipo = "+idUser+"");
			FrameBD.SQLIDU(sql);
		}
		
		public void RestaurarTipo()
		{
			string sql = string.Format("UPDATE tipo_usuario SET eliminado = '0' WHERE id_tipo = "+idUser+"");
			FrameBD.SQLIDU(sql);
		}
		
		public void Filtrartipo(DataGridView dgv)
		{
			string sql = "SELECT id_tipo AS 'ID tipo', tipo_usuario AS 'Tipo de usuario', permisos AS Permisos" +
			" FROM tipo_usuario WHERE eliminado = '0'";
			dgv.DataSource = FrameBD.SQLSEL(sql);
			dgv.DataMember = "Datos";
		}
		
		public void FiltrartipoD(DataGridView dgv)
		{
			string sql = "SELECT id_tipo AS 'ID tipo', tipo_usuario AS 'Tipo de usuario', permisos AS Permisos" +
			" FROM tipo_usuario WHERE eliminado = '1'";
			dgv.DataSource = FrameBD.SQLSEL(sql);
			dgv.DataMember = "Datos";
		}
		
	}
}
