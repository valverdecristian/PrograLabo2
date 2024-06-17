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
    public partial class FrmBiblioteca : Form
    {
        public FrmBiblioteca()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefrescarBiblioteca();
        }

        private void RefrescarBiblioteca()
        {
            dtgvBiblioteca.DataSource = JuegoDao.Leer();
            dtgvBiblioteca.Refresh();
            dtgvBiblioteca.Update();
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtgvBiblioteca.SelectedRows.Count > 0)
            {
                Biblioteca biblioteca = (Biblioteca)dtgvBiblioteca.CurrentRow.DataBoundItem;

                JuegoDao.Eliminar(biblioteca.CodigoJuego);
                RefrescarBiblioteca();
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            FrmAlta fmrAlta = new FrmAlta();

            // deberia tener manejo de excepciones
            if(fmrAlta.ShowDialog() == DialogResult.OK)
            {
                RefrescarBiblioteca();
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dtgvBiblioteca.SelectedRows.Count > 0)
            {
                Biblioteca biblioteca = (Biblioteca)dtgvBiblioteca.CurrentRow.DataBoundItem;

                FrmAlta fmrAlta = new FrmAlta(biblioteca.CodigoJuego);
                // deberia tener manejo de excepciones
                if (fmrAlta.ShowDialog() == DialogResult.OK)
                {
                    RefrescarBiblioteca();
                }
            }
        }

    }
}
