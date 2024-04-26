using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace TP_WinformCatalogo
{
    public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            dgvCategorias.DataSource = negocio.listar();
        }

        private void btnAgregarCategorias_Click(object sender, EventArgs e)
        {
            frmAltaCategorias ventana = new frmAltaCategorias();
            ventana.ShowDialog();
        }
    }
}
