using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace prySistemaEscolar
{
    internal class clsLogin
    {
        private string usuario;
        private string password;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }

        //Atributo estatico
        private static string perfil;
        private static bool esAdministrador;
        private static bool esdocenete;

        //Propiedad Estatica
        public static bool EsAdminitrador { get => esAdministrador; }
        public static bool EsDocente { get => esdocenete; }

        public void AsignarPermisos()
        {
            switch (perfil)
            {
                case "Administrador":
                    esAdministrador = true;
                    esdocenete = false;
                    break;
                case "Docente":
                    esAdministrador = false;
                    esdocenete = true;
                    break;
                default:
                    esAdministrador = false;
                    esdocenete = false;
                    break;
            }
        }
        public bool ValidarAcceso()
        {
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT perfil FROM tblUsuarios " +
                                 "WHERE nombreUsuario = @usuario AND password = @password;";
                    using (var consulta = new MySqlCommand(sql, conexion))
                    {
                        consulta.Parameters.AddWithValue("@usuario", usuario);
                        consulta.Parameters.AddWithValue("@password", password);

                        using (var resultado = consulta.ExecuteReader())
                        {
                            if (resultado.Read())
                            {
                                perfil = resultado.GetString("perfil");
                                MessageBox.Show("Tu perfil es: " + perfil, "Sistema");
                                return true;
                            }
                            else
                            {
                                throw new Exception("Usuario o contraseña incorrectos.");
                            }
                        }// Liberar MySqlDataReader
                    }// Liberar MySqlCommand
                }//Liberar MySqlConnection a través de tu clase
            }
            catch (Exception ex)
            {
                //Si ocurre un error, lo relanzamos para que lo capture el formulario
                throw new Exception(ex.Message, ex); 
            }
        }//Fin del método
    }
}