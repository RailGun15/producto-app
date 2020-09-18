using Comercio;
using Dominio;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace ProductoApp
{

    public partial class fmrEditar : Form
    {
        Articulo v;
        public fmrEditar(Articulo art )
        {
            InitializeComponent();
            v = art;
            Articulo editadoC = v;
            txtCodArticulo.Text = editadoC.CodArticulo;
            txtNombre.Text = editadoC.Nombre;
            txtDescripcion.Text = editadoC.Descripcion;
            cbxMarca.Text = editadoC.Marca.Nombre;
            //cbxMarca.SelectedIndex = editado.Marca.Id;

            cbxCategoria.Text = editadoC.Categoria.Nombre;
            //cbxCategoria.SelectedIndex = editado.Categoria.Id;
            txtURLimagen.Text = editadoC.UrlImagen;
            txtPrecio.Text = editadoC.Precio.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloComercio articulo = new ArticuloComercio();
            Articulo editado = v;
            editado.Marca = new Marca();
            editado.Categoria = new Categoria();

            editado.CodArticulo = txtCodArticulo.Text;
            editado.Nombre = txtNombre.Text;
            editado.Descripcion = txtDescripcion.Text;
            editado.Marca.Nombre = cbxMarca.Text;
            editado.Marca.Id = cbxMarca.SelectedIndex;

            editado.Categoria.Nombre = cbxCategoria.Text;
            editado.Categoria.Id = cbxCategoria.SelectedIndex;
            editado.UrlImagen = txtURLimagen.Text;
            editado.Precio = Convert.ToDecimal(txtPrecio.Text);

            articulo.editar(editado);

            MessageBox.Show(" Modificacion exitosa ");
            Close();
        }

        private void fmrEditar_Load(object sender, EventArgs e)
        {
            CategoriaComercio categoriaComercio = new CategoriaComercio();
            MarcaComercio maracacomercio = new MarcaComercio();

            cbxCategoria.DataSource = categoriaComercio.Listar();
            cbxMarca.DataSource = maracacomercio.Listar();
        }
    }
}
