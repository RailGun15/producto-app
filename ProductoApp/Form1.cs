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
        public static bool showed = false;

        public formArticulos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        public void Cargar()
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
            new formCargar(this).ShowDialog();
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
                if (!showed)
                {
                    showed = true;
                    MessageBox.Show("Imagen no Disponible");
                }
                
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ArticuloComercio c = new ArticuloComercio();
                Articulo art = (Articulo)dgvLista.CurrentRow.DataBoundItem;
                var confirmar = MessageBox.Show("Esta seguro de eliminar este articulo?",
                                     "Confirme!",
                                     MessageBoxButtons.YesNo);
                if (confirmar == DialogResult.Yes)
                {
                    c.Eliminar(art.Id);
                    Cargar();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Debe seleccionar la fila a eliminar");

            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            
            Articulo art = (Articulo)dgvLista.CurrentRow.DataBoundItem;
            fmrEditar editar = new fmrEditar(art);
            editar.ShowDialog();
            Cargar();
        }
    }
}
