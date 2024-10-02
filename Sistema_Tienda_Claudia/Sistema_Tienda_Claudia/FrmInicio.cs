using System;
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
    public partial class FrmInicioAdmin : Form
    {
        public FrmInicioAdmin(string nombre)
        {
            InitializeComponent();
            labelAdministrador.Text = "Bienvenido " + nombre + " al sistema Tienda Claudia";
        }

        private void agregarProductoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAgProducto ventana1 = new FrmAgProducto();
            ventana1.MdiParent = this;
            ventana1.Show();
        }

        private void quitarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuitarProduc ventana2 = new QuitarProduc();
            ventana2 .MdiParent = this;
            ventana2.Show();
        }

        private void mOdificarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ModificarProduc ventana3 = new ModificarProduc();
            ventana3.MdiParent = this;
            ventana3.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}
