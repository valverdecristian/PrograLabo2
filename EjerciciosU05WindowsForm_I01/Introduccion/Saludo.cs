﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Introduccion
{
    public partial class SaludoForm : Form
    {
        public SaludoForm()
        {
            InitializeComponent();
        }

        public void SetDatos(string nombre, string apellido)
        {
            lbl_mensaje.Text = $"¡Hola, Windows Forms!\nSoy {nombre} {apellido}";
        }
    }
}
