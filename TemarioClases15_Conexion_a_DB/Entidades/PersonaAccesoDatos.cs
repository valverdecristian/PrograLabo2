using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class PersonaAccesoDatos
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;

        static PersonaAccesoDatos()
        {
            connectionString = @"Data Source=.;Initial Catalog=EJERCICIOS_UTN;Integrated Security=True";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        public static void GuardarParametrizado(string nombre)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"INSERT INTO Personas (Nombre) VALUES (@Nombre)";
                command.Parameters.AddWithValue("@Nombre", nombre);

                int rows = command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void Eliminar(int id) //parametrizado
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"DELETE FROM Personas WHERE ID = @ID";
                command.Parameters.AddWithValue("@ID", id);
                int rows = command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void Modificar(string nuevoNombre, int id) // parametrizado
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"UPDATE Personas SET Nombre = (@Nombre) WHERE ID = @ID ";
                command.Parameters.AddWithValue("@Nombre", nuevoNombre);
                command.Parameters.AddWithValue("ID", id);
                int rows = command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static List<Persona> Leer() // NO ESTA PARAMETRIZADO
        {
            List<Persona> personas = new List<Persona>();

            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM Personas";

                // hay que cerrar el dataReader
                using(SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        personas.Add(new Persona(dataReader["Nombre"].ToString(), Convert.ToInt32(dataReader["ID"])));
                    }
                }

                return personas;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static List<Persona> LeerInyeccion(string id) // a modo de ejemplo nada mas
        {
            List<Persona> personas = new List<Persona>();

            try
            {
                connection.Open();
                command.CommandText = $"SELECT * FROM Personas WHERE ID = {id}";

                // hay que cerrar el dataReader
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        personas.Add(new Persona(dataReader["Nombre"].ToString(), Convert.ToInt32(dataReader["ID"])));
                    }
                }

                return personas;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static Persona LeerParametrizado(int id)
        {
            Persona persona = null;

            try
            {
                command.Parameters.Clear(); // estoy obligado a limpiar la lista de parametros
                connection.Open();
                command.CommandText = $"SELECT * FROM Personas WHERE ID = @ID";
                command.Parameters.AddWithValue("@ID", id);

                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        persona = new Persona(dataReader["Nombre"].ToString(), Convert.ToInt32(dataReader["ID"]));
                    }
                }

                return persona;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
