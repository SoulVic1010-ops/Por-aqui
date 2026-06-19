using System;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;
using System.Data;
namespace prySistemaEscolar
{
	internal class clsCarreras
	{
		private string nombreCarrera;
		//usamos un adaptador
		private MySqlDataAdapter consulta;
		//usamos una tabla temporal
		private DataTable tabla;

		//propiedad para el nombreCarrera
		public string NombreCarrera{ get => nombreCarrera; set =>nombreCarrera = value;}


		//Metodo para cargar datos en el DataGrid
		public DataTable CargarDataGrid()
		{
			tabla = new DataTable();
			try
			{
				clsConexion conexionDB = new clsConexion();
				using (var conexion = conexionDB.AbrirConexion()) 
				{
					string sql = "SELECT idCarrera AS Clave,nombreCarrera AS Carrera,descripcion AS Descipción FROM tblcarreras;";
					using (consulta = new MySqlDataAdapter(sql, conexion)) 
					{
						consulta.Fill(tabla);
					}//liberar la consulta
				}//Liberar la conexion 
			}
			catch (Exception ex)
			{
				throw new Exception("Error en la conexion "+ex.Message);
			}
			return (tabla);
		}

		//metodo para consultar por coincidencias
		public DataTable Consultar()
		{
			tabla = new DataTable();
			try 
			{
				clsConexion conexionBD = new clsConexion();
				using (var conexion = conexionBD.AbrirConexion())
				{
					string sql = "SELECT idCarrera AS Clave,nombreCarrera AS Carrera,descripcion AS Descipción FROM tblcarreras WHERE nombreCarrera LIKE @carrera;";
					using (var consultar = new MySqlCommand(sql, conexion))
					{
						consultar.Parameters.AddWithValue("@carrera", "%"+nombreCarrera+"%");
						using (consulta  = new MySqlDataAdapter(consultar))
						{
							consulta.Fill(tabla);
						}//libera el adaptador 
					}//liberar la consulta
				}//Libera la conexion
			}catch(Exception ex)
			{
				throw new Exception("Error en la conexion de la base de datos" + ex.Message);
			}
			return tabla;
		}
	}

		
	
}

