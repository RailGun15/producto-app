using Comercio;
using Dominio;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace ProductoApp
{

    public partial class fmrEditar : Form
    {
        private Articulo v = null;
        public fmrEditar(Articulo art)
        {
            InitializeComponent();
            v = art;
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
            if (v == null)
                v = new Articulo();

            editado.CodArticulo = txtCodArticulo.Text;
            editado.Nombre = txtNombre.Text;
            editado.Descripcion = txtDescripcion.Text;
            editado.Marca.Nombre = cbxMarca.Text;
            editado.Marca = (Marca)cbxMarca.SelectedItem;

            editado.Categoria = (Categoria)cbxCategoria.SelectedItem;
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
            cbxCategoria.ValueMember = "Id";
            cbxCategoria.DisplayMember = "Nombre";
            cbxCategoria.SelectedIndex = -1;

            cbxMarca.DataSource = maracacomercio.Listar();
            cbxMarca.ValueMember = "Id";
            cbxMarca.DisplayMember = "Nombre";
            cbxMarca.SelectedIndex = -1;


            if (v != null)
            {
                txtCodArticulo.Text = v.CodArticulo;
                txtNombre.Text = v.Nombre;
                txtDescripcion.Text = v.Descripcion;

                cbxMarca.SelectedValue = v.Marca.Id;

                cbxCategoria.SelectedValue = v.Categoria.Id;

                txtURLimagen.Text = v.UrlImagen;
                txtPrecio.Text = v.Precio.ToString();
            }
        }
    }
}
