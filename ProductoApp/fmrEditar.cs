using Comercio;
using Dominio;
using System;
using System.Windows.Forms;

namespace ProductoApp
{
    public partial class fmrEditar : Form
    {
        public fmrEditar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloComercio articulo = new ArticuloComercio();
            Articulo editado = new Articulo();
            editado.Marca = new Marca();
            editado.Categoria = new Categoria();

            editado.CodArticulo = txtCodArticulo.Text;
            editado.Nombre = txtNombre.Text;
            editado.Descripcion = txtDescripcion.Text;
            editado.Marca.Nombre = cbxMarca.Text;
            editado.Marca.Id = cbxMarca.SelectedIndex + 1;

            editado.Categoria.Nombre = cbxCategoria.Text.ToString();
            editado.Categoria.Id = cbxCategoria.SelectedIndex + 1;
            editado.UrlImagen = txtURLimagen.Text;
            editado.Precio = Decimal.Parse(txtPrecio.Text);

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
