using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySqlConnector;

namespace prySistemaEscolar
{
    internal class clsConexion
    {
        private string host = "189.240.192.140";
        private string bd = "bdescuelagbequipo2";
        private string usuario = "gbEquipo2";
        private string password = "grupo2";
        private string puerto = "3306";

        private string cadenaConexion => $"server = {host}; database = {bd}; user = {usuario}; password = {password}; port = {puerto}";

        public MySqlConnection AbrirConexion()
        { 
            var conexion = new MySqlConnection(cadenaConexion);
            try
            {
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar conectarse a la base de datos" + ex.Message,ex);
            }
        }
        public void CerrarConexion(MySqlConnection conexion)
        {
            try
            {
                if (conexion != null && conexion.State != ConnectionState.Closed)
                {
                    conexion.Close();
                    conexion.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cerrar la conexion con la base de datos" + ex.Message,ex);
            }
        }
    }
}