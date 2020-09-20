using Comercio;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductoApp
{
    public partial class formCargar : Form
    {
        private readonly formArticulos _form1;
        public formCargar(formArticulos form1)
        {
            InitializeComponent();
            _form1 = form1;
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
            _form1.Cargar();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Articulo art = new Articulo();
            art.Marca = new Marca();
            art.Categoria = new Categoria();

            if (txtCodArt.Text == "")
            {
                error1.SetError(txtCodArt, "Debe ingresar un codigo de articulo");
                txtCodArt.Focus();
                return;
            }
            error1.SetError(txtCodArt, "");

            art.CodArticulo = txtCodArt.Text;

            if (txtNombre.Text == "")
            {
                error1.SetError(txtNombre, "Debe ingresar un nombre para el articulo");
                txtNombre.Focus();
                return;
            }
            error1.SetError(txtNombre, "");

            art.Nombre = txtNombre.Text;


            art.Marca.Nombre = EnumMarca.Text;
            art.Marca.Id = EnumMarca.SelectedIndex + 1;

            art.Categoria.Nombre = EnumCategoria.Text.ToString();
            art.Categoria.Id = EnumCategoria.SelectedIndex + 1;

            if (txtPrecio.Text == "")
            {
                error1.SetError(txtPrecio, "Debe ingresar un precio para el articulo");
                txtPrecio.Focus();
                return;
            }
            error1.SetError(txtPrecio, "");

            art.Precio = Decimal.Parse(txtPrecio.Text);

            art.Descripcion = txtDescripcion.Text;
            art.UrlImagen = txtUrl.Text;

            ArticuloComercio.Cargar(art);

            MessageBox.Show("Articulo Cargado!");


        }


        private void EnumMarca_Click(object sender, EventArgs e)
        {
            MarcaComercio mc = new MarcaComercio();
            EnumMarca.DataSource = mc.Listar();
        }

        private void EnumCategoria_Click(object sender, EventArgs e)
        {
            CategoriaComercio cc = new CategoriaComercio();
            EnumCategoria.DataSource = cc.Listar();
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && (this.Text.IndexOf('.') > 0 || this.Text.Length == 0))
                e.Handled = true;
        }


        private void formCargar_Load(object sender, EventArgs e)
        {

        }

    }
}
