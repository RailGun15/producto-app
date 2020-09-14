using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comercio;
using Dominio;

namespace ProductoApp
{
    public partial class formArticulos : Form
    {
        public formArticulos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cargar();
          
        }

        private void Cargar()
        {
            ArticuloComercio comercio = new ArticuloComercio();
            dgvLista.DataSource = comercio.Listar();
            dgvLista.Columns[6].Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por Usar la Aplicación!");
            Application.Exit();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            new formCargar().ShowDialog();
        }

        private void dgvLista_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Articulo art = (Articulo)dgvLista.CurrentRow.DataBoundItem;
                pbArticulo.Load(art.UrlImagen);
            }
            catch (Exception)
            {

                
            }
            
        }
    }
}
