using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;

namespace AplicacionComercio
{
    public partial class FrmMarca : Form
    {
        private List<Marca> listaMarcas;

        public FrmMarca()
        {
            InitializeComponent();
        }

        private void FrmMarca_Load(object sender, EventArgs e)
        {
            cargar();
        }

        public void cargar()
        {
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                listaMarcas = negocio.listarMarca();
                dgvMarca.DataSource = listaMarcas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btmAgregarMarca_Click(object sender, EventArgs e)
        {
            FrmAltaMarca altaMarca = new FrmAltaMarca();
            altaMarca.ShowDialog();
            cargar();
        }

        private void btmModificarMarca_Click(object sender, EventArgs e)
        {
            if(dgvMarca.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una marca.");
                return;
            }

            Marca seleccionada;
            seleccionada = (Marca)dgvMarca.CurrentRow.DataBoundItem;

            FrmAltaMarca modificarMarca = new FrmAltaMarca(seleccionada);
            modificarMarca.ShowDialog();
            cargar();
        }

        private void btmEliminarMarca_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            Marca seleccionada;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", 
                                                        "Eliminando",
                                                        MessageBoxButtons.YesNo, 
                                                        MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes)
                {
                    seleccionada = (Marca)dgvMarca.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionada.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btmVolverArticulos_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
