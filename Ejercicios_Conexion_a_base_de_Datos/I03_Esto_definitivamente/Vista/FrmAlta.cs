using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmAlta : Form
    {
        int codigoJuego;
        public FrmAlta(int codigoJuego) : this()
        {
            btnGuardar.Text = "Modificar";
            cmbUsuarios.Hide();
            lblUsuarios.Text = string.Empty;
            this.codigoJuego = codigoJuego;

            PintarForm();
        }

        private void PintarForm()
        {
            Juego juego = JuegoDao.LeerPorId(codigoJuego);

            txtGenero.Text = juego.Genero;
            txtNombre.Text = juego.Nombre;
            nupPrecio.Value = (decimal)juego.Precio;
        }
        public FrmAlta()
        {
            InitializeComponent();
        }

        private void FrmAlta_Load(object sender, EventArgs e)
        {
            // nupPrecio.Maximum = 10000;

            cmbUsuarios.DataSource = UsuarioDao.Leer();
        }

        protected virtual void btnGuardar_Click(object sender, EventArgs e)
        {

            if (btnGuardar.Text != "Modificar")
            {
                Juego nuevoJuego = new Juego(txtNombre.Text, (double)nupPrecio.Value, txtGenero.Text,
                    ((Usuario)cmbUsuarios.SelectedItem).CodigoUsuario);

                JuegoDao.Guardar(nuevoJuego);
            }
            else
            { // para poder modificar otras propiedades
                Juego nuevoJuego = new Juego(txtNombre.Text, (double)nupPrecio.Value, txtGenero.Text,
                    ((Usuario)cmbUsuarios.SelectedItem).CodigoUsuario);

                JuegoDao.Modificar(nuevoJuego);
            }


            DialogResult = DialogResult.OK;
        }
    }
}
