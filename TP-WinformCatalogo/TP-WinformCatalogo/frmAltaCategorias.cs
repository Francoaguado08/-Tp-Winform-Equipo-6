using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_WinformCatalogo
{
    public partial class frmAltaCategorias : Form
    {
        public frmAltaCategorias()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Categoria arti = new Categoria();
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                arti.Descripcion = txtDescripcion.Text;

                negocio.agregarCategoria(arti);
                MessageBox.Show("Articulo agregado correctamente");
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
