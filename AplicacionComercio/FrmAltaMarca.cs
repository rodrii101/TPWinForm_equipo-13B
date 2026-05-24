using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace AplicacionComercio
{
    public partial class FrmAltaMarca : Form
    {
        private Marca marcas = null;
        public FrmAltaMarca(Marca marcas)
        {
            InitializeComponent();
            this.marcas = marcas;
            Text = "Modificar marca";
        }
        public FrmAltaMarca()
        {
            InitializeComponent();
        }

        private void btmAgregarMarca_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocioMarca = new MarcaNegocio();
            try
            {
                if(marcas == null)
                {
                    marcas = new Marca();
                }

                marcas.Descripcion = txtDescripcionMarca.Text;

                if (validarDatosMarca())
                    return;
                
                if(marcas.Id != 0)
                {
                    negocioMarca.modificarMarca(marcas);
                    MessageBox.Show("La marca se ha modificado correctamente.");
                }
                else
                {
                    negocioMarca.agregarMarca(marcas);
                    MessageBox.Show("La marca se agrego correctamente la marca");
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FrmAltaMarca_Load(object sender, EventArgs e)
        {
            MarcaNegocio negocioMarca = new MarcaNegocio();
            try
            {
                int idIncremental = negocioMarca.contarIdMarcas();
                txtIdMarca.Text = idIncremental.ToString();

                if(marcas != null)
                {
                    txtIdMarca.Text = marcas.Id.ToString();
                    txtDescripcionMarca.Text = marcas.Descripcion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btmCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool validarDatosMarca()
        {
            if (string.IsNullOrEmpty(txtDescripcionMarca.Text))
            {
                MessageBox.Show("Debe ingresar una descripcion.");
                return true;
            }
            return false;
        }
    }
}
