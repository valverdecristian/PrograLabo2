using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class LogDAO
    {
        private SqlConnection sqlConnection;

        public LogDAO()
        {
            sqlConnection = new SqlConnection("Server=.;Database=bomberos-db;Trusted_Connection=True;");
        }

        public void InsertarLog(string mensaje)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO dbo.log (entrada, alumno) VALUES (@mensaje, 'Cristian Valverde')", sqlConnection);
                command.Parameters.AddWithValue("@mensaje", mensaje);
                command.ExecuteNonQuery();
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }

        public string LeerLog()
        {
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("SELECT entrada FROM dbo.log'", sqlConnection);
                SqlDataReader reader = command.ExecuteReader();
                StringBuilder sb = new StringBuilder();

                if(reader.Read())
                {
                    // traeme la columna 0
                    //sb.AppendLine(reader["entrada"].ToString());
                    sb.AppendLine(reader.GetString(0));
                }
                
                return sb.ToString();

            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }
    }
}
