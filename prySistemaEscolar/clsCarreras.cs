using System;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;
using System.Data;
namespace prySistemaEscolar
{
	internal class clsCarreras
	{
		//usamos un adaptador
		private MySqlDataAdapter consulta;
		//usamos una tabla temporal
		private DataTable tabla;

		//Metodo para cargar datos en el DataGrid
		public DataTable CargarDataGrid()
		{
			tabla = new DataTable();

			clsConexion conexionDB = new clsConexion();
			var conexion =conexionDB.AbrirConexion();
			string sql = "SELECT idCarrera AS Clave,nombreCarrera AS Carrera,descripcion AS Descipción FROM tblcarreras;";
			consulta = new MySqlDataAdapter(sql, conexion);
			consulta.Fill(tabla);
			return (tabla);
		}

		
	}
}
