﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Tienda_Claudia
{
    public partial class FrmInicioStandar : Form
    {
        public FrmInicioStandar(string nombre)
        {
            InitializeComponent();
            labelUsuario.Text = "Bienvenido " + nombre + " al sistema Tienda Claudia";
        }
    }
}
