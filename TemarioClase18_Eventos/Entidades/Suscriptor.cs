using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suscriptor
    {
        private int id;
        private string nombre;

        public Suscriptor(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public int Id => id;
        public string Nombre => nombre;

        // MANEJADOR DEL EVENTO
        public void RecibirNovedad(Newsletter sender, NewsletterEventArgs eventArgs)
        {
            try
            {
                string contenido = String.Empty;
                if(eventArgs is NewsletterEventArgs newsletterEventArgs)
                {
                    contenido = newsletterEventArgs.Contenido;
                }

                // el using se encarga de liberar los recursos
                using (SqlConnection sqlConnection = new SqlConnection("Server=.;Database=CLASE_EVENTOS_DB;Trusted_Connection=True;"))
                {
                    SqlCommand command = new();
                    command.Connection = sqlConnection;
                    command.CommandText = "INSERT INTO Novedades (tema, contenido, id_usuario) VALUES (@tema, @contenido, @id_usuario)";
                    command.Parameters.AddWithValue("@tema", sender.Tema);
                    command.Parameters.AddWithValue("@contenido", contenido);
                    command.Parameters.AddWithValue("@id_usuario", this.id);

                    sqlConnection.Open();
                    // command.ExecuteReader(); // para consultas
                    command.ExecuteNonQuery(); // para insert, update, delete (para comandos)
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
