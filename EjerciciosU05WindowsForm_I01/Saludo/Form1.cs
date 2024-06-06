namespace Saludo
{
    public partial class Saludo : Form
    {
        public Saludo()
        {
            InitializeComponent();


            // Mostrar el saludo en el Label del formulario Saludo
            lbl_mensaje.Text = $"Hola {nombre} {apellido}, bienvenido!";
        }
    }
}