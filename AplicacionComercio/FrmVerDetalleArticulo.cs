using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionComercio
{
    public partial class FrmVerDetalleArticulo : Form
    {
        private Articulo articulo = null;
        private int indiceImagen = 0;

        public FrmVerDetalleArticulo()
        {
            InitializeComponent();
        }

        public FrmVerDetalleArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void FrmVerDetalleArticulo_Load(object sender, EventArgs e)
        {
            try
            {
                txtCodigo.Text = articulo.Codigo;
                txtNombre.Text = articulo.Nombre;
                txtMarca.Text = articulo.Marca.Descripcion;
                txtCategoria.Text = articulo.Categoria.Descripcion;
                txtPrecio.Text = articulo.Precio.ToString();
                txtDescripcion.Text = articulo.Descripcion;

                cargarImagen();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarImagen()
        {
            try
            {
                if(articulo.Imagenes != null && articulo.Imagenes.Count > 0)
                {
                    pbxImgArticulo.Load(articulo.Imagenes[indiceImagen].ImagenUrl);

                }
                else
                {
                    pbxImgArticulo.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
                    
                }
            }
            catch (Exception )
            {
                pbxImgArticulo.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        private void btmSiguiente_Click(object sender, EventArgs e)
        {
            if (articulo.Imagenes == null || articulo.Imagenes.Count == 0)
                return;
            indiceImagen++;
            if (indiceImagen >= articulo.Imagenes.Count)
                indiceImagen = 0;
            cargarImagen();
        }

        private void btmAnterior_Click(object sender, EventArgs e)
        {
            if (articulo.Imagenes == null || articulo.Imagenes.Count == 0)
                return;
            indiceImagen--;
            if(indiceImagen < 0)
                indiceImagen = articulo.Imagenes.Count - 1;
            cargarImagen();
        }

        private void btmCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
