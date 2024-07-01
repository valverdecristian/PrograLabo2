using Entidades;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Newsletter newsletterTecnologia;
        private Newsletter newsletterFinanzas;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // asociamos los dos botones en el load para seguir practicando eventos (en vez de hacerlo con el doble clic)
            // lo que quiero asociar aca es el evento del clic de los botones
            // esto es a modo de ejemplo ya que lo hace el designer
            this.btn_EnviarNewsletterTecnologia.Click += btn_EnviarNewsletterTecnologia_OnClick;
            this.btn_EnviarNewsletterFinanzas.Click += btn_EnviarNewsletterFinanzas_OnClick;

            newsletterTecnologia = new Newsletter("Tecnologia");
            newsletterFinanzas = new Newsletter("Finanzas");

            List<Suscriptor> suscriptores = TraerSuscriptores();

            foreach (Suscriptor suscriptor in suscriptores)
            {
                if (suscriptor.Id % 2 == 0)
                {
                    // le asocio el manejador de suscriptor
                    // objeto.Evento += manejador;
                    newsletterFinanzas.EventoNovedadEnviada += suscriptor.RecibirNovedad;
                }
                else
                {
                    // EventoNovedadEnviada es el evento del objeto newsletter
                    // RecibirNovedad es el manejador de dicho evento en un objeto de tipo Suscriptor
                    newsletterTecnologia.EventoNovedadEnviada += suscriptor.RecibirNovedad;
                }
            }
        }

        private void Btn_EnviarNewsletterTecnologia_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public List<Suscriptor> TraerSuscriptores() // lo trae de la DB
        {
            using (SqlConnection sqlConnection = new SqlConnection("Server=.;Database=CLASE_EVENTOS_DB;Trusted_Connection=True;"))
            {
                SqlCommand command = new();
                command.Connection = sqlConnection;
                command.CommandText = "SELECT id, nombre FROM Usuarios";

                sqlConnection.Open();
                SqlDataReader reader = command.ExecuteReader(); // para consultas
                List<Suscriptor> suscriptores = new List<Suscriptor>();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["ID"]);
                    string nombre = reader["nombre"].ToString();

                    Suscriptor suscriptor = new Suscriptor(id, nombre);
                    suscriptores.Add(suscriptor);
                }

                return suscriptores;
            }
        }

        public void btn_EnviarNewsletterTecnologia_OnClick(object sender, EventArgs e)
        {
            newsletterTecnologia.EnviarNovedades();
        }

        public void btn_EnviarNewsletterFinanzas_OnClick(object sender, EventArgs e)
        {
            newsletterFinanzas.EnviarNovedades();
        }
    }
}