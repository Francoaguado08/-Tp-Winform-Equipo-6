using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;


namespace TP_WinformCatalogo
{
    public partial class frmMarcas : Form
    {
        public frmMarcas()
        {
            InitializeComponent();
        }

        private void frmMarcas_Load(object sender, EventArgs e)
        {
            MarcasNegocio negocio = new MarcasNegocio();
            dgvMarcas.DataSource = negocio.listar();
        }

        private void btnAgregarMarcas_Click(object sender, EventArgs e)
        {
            frmAltaMarcas ventana = new frmAltaMarcas();
            ventana.ShowDialog();
        }

        private void btnEliminarMarcas_Click(object sender, EventArgs e)
        {
            MarcasNegocio negocio = new MarcasNegocio();
            Marca seleccionada;

            try
            {
                DialogResult respuesta = MessageBox.Show("Confirme nuevamente si quiere eliminarlo.", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                    negocio.eliminarMarca(seleccionada.ID);
                    //cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
    
}

