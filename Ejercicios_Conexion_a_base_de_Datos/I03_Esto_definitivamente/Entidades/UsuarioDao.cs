using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class UsuarioDao
    {
        private static string cadenaConexion;
        private static SqlCommand comando;
        private static SqlConnection conexion;

        static UsuarioDao()
        {
            cadenaConexion = @"Data Source=.;Initial Catalog=EJERCICIOS_UTN;Integrated Security=True";
            comando = new SqlCommand(); // instanciamos nuestro comando
            conexion = new SqlConnection(cadenaConexion); // el comando necesita conectarse a la DB
            comando.Connection = conexion; // se le asigna al comando la conexion
            comando.CommandType = System.Data.CommandType.Text; // que tipo de comando va a ser
        }

        public static List<Usuario> Leer()
        {
            List<Usuario> usuarios = new List<Usuario>();

            try
            {
                conexion.Open();
                comando.CommandText = "SELECT CODIGO_USUARIO, USERNAME FROM USUARIOS";
                SqlDataReader dataReader = comando.ExecuteReader();

                while (dataReader.Read())
                {
                    usuarios.Add(new Usuario(dataReader["USERNAME"].ToString(), Convert.ToInt32(dataReader["CODIGO_USUARIO"])));
                }

                dataReader.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }

            return usuarios;
        }
    }
}
