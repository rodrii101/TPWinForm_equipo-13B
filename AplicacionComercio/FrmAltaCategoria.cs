using dominio;
using negocio;
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
    public partial class FrmAltaCategoria : Form
    {
        private Categoria categorias = null;
        public FrmAltaCategoria()
        {
            InitializeComponent();
        }
        public FrmAltaCategoria(Categoria categorias)
        {
            InitializeComponent();
            this.categorias = categorias;
            Text = "Modificar pokemon";
        }

        private void btmCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btmAgregar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocioCategoria = new CategoriaNegocio();
            try
            {
                if (categorias == null)
                {
                    categorias = new Categoria();
                }
                categorias.Descripcion = txtDescripcionCategoria.Text;
                if (categorias.IdCategoria != 0)
                {
                    negocioCategoria.modificarCategoria(categorias);
                    MessageBox.Show("Se modifico correctamente la categoria");
                }
                else
                {
                    negocioCategoria.agregar(categorias);
                    MessageBox.Show("Se agrego correctamente la categoria");
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FrmAltaCategoria_Load(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                int idIncremental = negocio.contarIdCategorias();

                txtIdCategoria.Text = idIncremental.ToString();
                if (categorias != null)
                {
                    txtIdCategoria.Text = categorias.IdCategoria.ToString();
                    txtDescripcionCategoria.Text = categorias.Descripcion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
