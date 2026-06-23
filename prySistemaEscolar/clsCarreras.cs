using System;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;
using System.Data;
namespace prySistemaEscolar
{
	internal class clsCarreras
	{
		private string descripcion;
		private int idcarrera;//este atributo es para referencia en update y delete
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



		//Metodo para actualizar 
		public string GuardarActualizar(int tipoOperacion)
		{
			string msg = "";

			clsConexion conexionBD=new clsConexion();
			using (var conexion = conexionBD.AbrirConexion())
			{


				switch (tipoOperacion)
				{
					case 0://insertar 
						string sql = "INSERT INTO tblcarreras(nombreCarrera,descrpcion) VALUES(@nombreCarrera,'@descripcion');";
						break;
					case 1://actualizar

						break;

				}
			}//libera la cnexion
		}

		

		
	}

		
	
}

