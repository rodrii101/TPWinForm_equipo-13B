using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using dominio;
using negocio;
namespace AplicacionComercio
{
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null;
        public frmAltaArticulo()
        {
            InitializeComponent();
        }
        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }

        private void btmCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btmAgregar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if(articulo == null) 
                    articulo = new Articulo();
                articulo.Codigo = txtCodigo.Text;
                if (negocio.existeCodigo(txtCodigo.Text))
                {
                    MessageBox.Show("Codigo ya existente. Ingrese otro.");
                    return;
                }
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Marca = (Marca)cbxMarca.SelectedItem;
                articulo.Categoria = (Categoria)cbxCategoria.SelectedItem;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                if(articulo.Imagenes == null)
                    articulo.Imagenes = new List<Imagenes>();
                if(articulo.Id != 0)
                {
                    if(validarDatosArticulo())
                        return;
                    negocio.modificarArticulo(articulo);
                    MessageBox.Show("Se modifico correctamente el articulo");
                }
                else
                {
                    if(validarDatosArticulo())
                        return;
                    negocio.agregar(articulo);
                    MessageBox.Show("Se agrego correctamente el articulo");
                }     
                Close();
            }
            catch (Exception ex)
            {

               MessageBox.Show(ex.ToString());
            }

        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                cbxMarca.DataSource = marcaNegocio.listarMarca();
                cbxMarca.ValueMember = "Id";
                cbxMarca.DisplayMember = "Descripcion";
                cbxCategoria.DataSource = categoriaNegocio.listar();
                cbxCategoria.ValueMember = "IdCategoria";
                cbxCategoria.DisplayMember = "Descripcion";
                if(articulo != null)
                {
                    btmAgregar.Visible = true;
                    btmModificarImagen.Visible = true;
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    cbxMarca.SelectedValue = articulo.Marca.Id;
                    cbxCategoria.SelectedValue = articulo.Categoria.IdCategoria;
                    txtPrecio.Text = articulo.Precio.ToString();
                    lboxImagen.DataSource = null;
                    lboxImagen.DataSource = articulo.Imagenes;
                    lboxImagen.DisplayMember = "ImagenUrl";

                    cargarImagen(articulo.Imagenes[0].ImagenUrl);

                }
                else{

                    btmAgregar.Visible = true;
                    btmModificarImagen.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void cargarImagen(string imagen)
        {
            try
            {
                pboxImagenAgregar.Load(imagen);
            }
            catch (Exception)
            {
                pboxImagenAgregar.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }

        }
        private void txtImagenUrl_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagenUrl.Text);
        }

        private void btmAgregarImagen_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtImagenUrl.Text))
            {
                if (articulo == null)
                    articulo = new Articulo();
                articulo.Imagenes.Add(new Imagenes{ImagenUrl = txtImagenUrl.Text});
                lboxImagen.DataSource = null; 
                lboxImagen.DataSource = articulo.Imagenes;
                lboxImagen.DisplayMember = "ImagenUrl"; txtImagenUrl.Clear();
            }
        }
        private bool validarDatosArticulo()
        {
            if(string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Debe agregar un codigo al articulo");
                return true;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe agregar un nombre al articulo");
                return true;
            }
            if (string.IsNullOrEmpty(txtDescripcion.Text))
            {
                MessageBox.Show("Debe agregar una descripcion al articulo");
                return true;
            }
            if (string.IsNullOrEmpty(lboxImagen.Text))
            {
                MessageBox.Show("Debe agregar una URL");
                return true;
            }

  
            return false;
        }

        private void btmModificarImagen_Click(object sender, EventArgs e)
        {
            if(lboxImagen.SelectedItem == null)
                return;

            Imagenes img =(Imagenes)lboxImagen.SelectedItem;

            AccesoDatos datos = new AccesoDatos();
            
            datos.setearConsulta("UPDATE IMAGENES SET ImagenUrl = @url WHERE Id = @id");
            datos.setearParametro("@url", txtImagenUrl.Text);
            datos.setearParametro("@id", img.Id);

            datos.ejectuarAccion();
            datos.cerrarConexion();
            
            img.ImagenUrl = txtImagenUrl.Text;
            if (validarDatosArticulo())
                return;
            lboxImagen.DataSource = null;
            lboxImagen.DataSource = articulo.Imagenes;
            lboxImagen.DisplayMember = "ImagenUrl";

            MessageBox.Show("Imagen modificada");
        }

        private void lboxImagen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lboxImagen.SelectedItem != null)
            {
                Imagenes imagen =(Imagenes)lboxImagen.SelectedItem;
                cargarImagen(imagen.ImagenUrl);
            }
        }
    }
}
