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
        private List<Articulo> listaOriginal;

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
            listaOriginal = comercio.Listar();
            dgvLista.DataSource = listaOriginal;
            dgvLista.Columns[0].Visible = false;
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
                pbArticulo.ImageLocation = art.UrlImagen;
                pbArticulo.Load();
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
                    c.Eliminar((int)art.Id);
                    Cargar();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Debe seleccionar la fila a eliminar");

            }
        }

        private void filterMarca_Click(object sender, EventArgs e)
        {
            MarcaComercio mc = new MarcaComercio();
            filterMarca.DataSource = mc.Listar();
        }

        private void filterCategoria_Click(object sender, EventArgs e)
        {
            CategoriaComercio mc = new CategoriaComercio();
            filterCategoria.DataSource = mc.Listar();
        }

        private void filterNombre_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filterNombre.Text))
            {
                Cargar();
                DataTable dt = ToDataTable<Articulo>((List<Articulo>)dgvLista.DataSource);
                if (int.TryParse(filterNombre.Text, out int n)) // si todo el string es numerico devuelve true y lo carga en la variable n
                {
                    dt.DefaultView.RowFilter = string.Format("Precio >= {0}", n);
                }
                else // si es texto busca por otras columnas
                {
                    dt.DefaultView.RowFilter = string.Format("Nombre like '%{0}%' OR Descripcion like '%{0}%' OR CodArticulo like '%{0}%'", filterNombre.Text.Trim().Replace("'", "''"));
                }
                dgvLista.DataSource = dt;
                dgvLista.Refresh();
            }
            else
            {
                Cargar();
            }

        }

        private void filterMarca_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filterCategoria.Text))
            {
                ArticuloComercio mc = new ArticuloComercio();
                Marca m = (Marca)filterMarca.SelectedItem;
                dgvLista.DataSource = mc.BuscarMarca(m);
            }
            else
            {
                ArticuloComercio mc = new ArticuloComercio();
                Marca m = (Marca)filterMarca.SelectedItem;
                Categoria c = (Categoria)filterCategoria.SelectedItem;
                dgvLista.DataSource = mc.BuscarMarcaCategoria(m,c);
            }
        }

        private void filterCategoria_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filterMarca.Text))
            {
                ArticuloComercio mc = new ArticuloComercio();
                Categoria c = (Categoria)filterCategoria.SelectedItem;
                dgvLista.DataSource = mc.BuscarCategoria(c);
                dgvLista.Refresh();
            }
            else
            {
                ArticuloComercio mc = new ArticuloComercio();
                Marca m = (Marca)filterMarca.SelectedItem;
                Categoria c = (Categoria)filterCategoria.SelectedItem;
                dgvLista.DataSource = mc.BuscarMarcaCategoria(m, c);
                dgvLista.Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filterMarca.Text = "";
            filterCategoria.Text = "";
            filterNombre.Text = "";
            Cargar();
        }
        
        //funcion generica para convertir una lista en un datatable
        public static DataTable ToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
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
