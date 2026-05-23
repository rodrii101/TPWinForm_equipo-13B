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
    public partial class FrmCategoria : Form
    {
        private List<Categoria> listaCategorias;
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void btmModificarCategoria_Click(object sender, EventArgs e)
        {
            if (dgvCategoria.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una categoria");
                return;
            }

            Categoria seleccionada;
            seleccionada = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;

            FrmAltaCategoria modificarCategoria = new FrmAltaCategoria(seleccionada);
            modificarCategoria.ShowDialog();
            cargar();
        }
        public void cargar()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                listaCategorias = negocio.listar();
                dgvCategoria.DataSource = listaCategorias;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void btmAgregarCategoria_Click(object sender, EventArgs e)
        {
            FrmAltaCategoria altaCategoria = new FrmAltaCategoria();
            altaCategoria.ShowDialog();
            cargar();
        }

        private void btmVolverArticulos_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btmEliminarCategoria_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            Categoria seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.IdCategoria);
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
