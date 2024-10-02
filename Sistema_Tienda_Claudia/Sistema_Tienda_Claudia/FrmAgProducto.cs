using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Sistema_Tienda_Claudia
{
    public partial class FrmAgProducto : Form
    {
        static string conexionstring = "server= DESKTOP-GK6QR46\\MSSQLSERVER04 ; database = TiendaClaudia; integrated security = true";
        SqlConnection conexion = new SqlConnection(conexionstring);


        public FrmAgProducto()
        {
            InitializeComponent();
        }

        public void consulta()
        {
            string query = "select * from Producto";
            SqlCommand comando = new SqlCommand(query, conexion);
            SqlDataAdapter data = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            GridProductos.DataSource = tabla;
        }

        private void AgregarProduc_Load(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string nom = this.txtNombreProducto.Text;
            decimal pre = Convert.ToDecimal(this.numericPrecioProducto.Value);
            string cadena = "insert into Producto (Precio, Nombre) values ('" + pre + "','" + nom + "')";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            consulta();

            conexion.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {

        }
    }
}
