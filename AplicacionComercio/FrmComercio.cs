using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
namespace AplicacionComercio
{
    public partial class frmComercio : Form
    {
        private List<Articulo> listaArticulos;
        public frmComercio()
        {
            InitializeComponent();
        }

        private void frmComercio_Load(object sender, EventArgs e)
        {
            cargar();
            cboCampo.Items.Add("Codigo");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Descripcion");
            cboCampo.Items.Add("Precio");
        }
        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = negocio.listar();
                dgvArticulo.DataSource = listaArticulos;

                dgvArticulo.Columns["Id"].Visible = false;
                if (listaArticulos.Count > 0 && listaArticulos[0].Imagenes.Count > 0)
                    cargarImagen(listaArticulos[0].Imagenes[0].ImagenUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvArticulo_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulo.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
                if (seleccionado.Imagenes != null && seleccionado.Imagenes.Count > 0)
                    cargarImagen(seleccionado.Imagenes[0].ImagenUrl);
                else
                    cargarImagen(null);
            }
        }
        public void cargarImagen(string imagen)
        {
            try
            {
                picImageArticulos.Load(imagen);

            }
            catch (Exception)
            {
                picImageArticulos.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }

        }

        private void btmAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
            cargar();
        }

        private void btmModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            try
            {
                if(dgvArticulo.CurrentRow == null)
                    return;

                seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
                ImagenesNegocio negocio = new ImagenesNegocio();
                seleccionado.Imagenes = negocio.listarImagenes(seleccionado.Id);
                frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
                modificar.ShowDialog();
                cargar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btmEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocioArticulo = new ArticuloNegocio();
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
                    negocioArticulo.eliminarArticulo(seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtFiltradoRapido_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtFiltradoRapido.Text;
            if (filtro.Length > 2) {
                listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains((filtro.ToUpper())));
            }
            else
            {
                listaFiltrada = listaArticulos;
            }
            dgvArticulo.DataSource = null;
            dgvArticulo.DataSource = listaFiltrada;

        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            switch (opcion)
            {
                case "Codigo":
                    cboCriterio.Items.Clear();
                    cboCriterio.Items.Add("Comienza con");
                    cboCriterio.Items.Add("Termina con");
                    cboCriterio.Items.Add("Contiene");
                    break;
                case "Nombre":
                    cboCriterio.Items.Clear();
                    cboCriterio.Items.Add("Comienza con");
                    cboCriterio.Items.Add("Termina con");
                    cboCriterio.Items.Add("Contiene");
                    break;
                case "Descripcion":
                    cboCriterio.Items.Clear();
                    cboCriterio.Items.Add("Comienza con");
                    cboCriterio.Items.Add("Termina con");
                    cboCriterio.Items.Add("Contiene");
                    break;
                
                default:
                    cboCriterio.Items.Clear();
                    cboCriterio.Items.Add("Mayor a");
                    cboCriterio.Items.Add("Menor a");
                    cboCriterio.Items.Add("Igual a");
                    break;
            }
        }

        private bool validarFiltro()
        {
            if (cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el campo para filtrar.");
                return true;
            }
            if (cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el criterio para filtrar.");
                return true;
            }
            Validacion validar = new Validacion();
            if (cboCampo.SelectedItem.ToString() == "Precio"){
                if (string.IsNullOrEmpty(txtFiltradoAvanzado.Text))
                {
                    MessageBox.Show("Debes cargar el filtro para numéricos...");
                    return true;
                }
                if (!(validar.soloNumeros(txtFiltradoAvanzado.Text))){
                    MessageBox.Show("Solo nros para filtrar por un campo numérico...");
                    return true;
                }
            }

            return false;
        }
        private void btmFiltrarAvanzado_Click(object sender, EventArgs e)
        {
           ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (validarFiltro())
                    return;

                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltradoAvanzado.Text;
                dgvArticulo.DataSource = negocio.filtrar(campo, criterio, filtro);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btmGestionCategoria_Click(object sender, EventArgs e)
        {
            FrmCategoria categoria = new FrmCategoria();
            categoria.ShowDialog();
        }

        private void btmGestionMarca_Click(object sender, EventArgs e)
        {
            FrmMarca Marca = new FrmMarca();
            Marca.ShowDialog();
        }
    } 
}
