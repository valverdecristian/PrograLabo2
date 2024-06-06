namespace Introduccion
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btn_saludar_Click(object sender, EventArgs e)
        {

            string nombre = tbx_nombre.Text;
            string apellido = txb_apellido.Text;

            // Crear una instancia del formulario Saludo
            SaludoForm saludoForm = new SaludoForm();
            saludoForm.SetDatos(nombre, apellido);
            saludoForm.ShowDialog();
        }
    }
}