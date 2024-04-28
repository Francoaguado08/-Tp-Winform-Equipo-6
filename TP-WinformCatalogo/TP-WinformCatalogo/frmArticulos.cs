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
using Dominio;


namespace TP_WinformCatalogo
{
    public partial class frmArticulos : Form
    {
        private List<Articulo> listaArticulo;

        public frmArticulos()
        {
            InitializeComponent();
            //txtFiltroArticulos.KeyPress += txtFiltroArticulos_KeyPress;
            // si es que quiero que en mi filtro no se permita teclear numeros...
        }
        // Cuando cargo por primera vez va estar asi...
        private void frmArticulos_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            //Aca invoco la lectura a la BD...
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
            listaArticulo = negocio.listar(); // Asigna los datos obtenidos de la base de datos a listaArticulo

            dgvArticulos.DataSource = listaArticulo; // Asigna listaArticulo como origen de datos para el DataGridView
            ocultarColumnas(); 

            // Verifica si listaArticulo tiene elementos antes de intentar cargar la imagen del primer artículo
            if (listaArticulo.Count > 0)
            {                                                
                    cargarImagen(listaArticulo[0].UrlImagen); // Cargo la imagen del primer artículo en el PictureBox
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        // Cuando cambio la seleccion de la grilla, quiero cambiar la imagen correspondiente.
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                //current row (la fila actual) // dataBoundItem (dame el objeto enlazado).
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImagen);
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxArticulo.Load("https://www.came-educativa.com.ar/upsoazej/2022/03/placeholder-2.png");
            }
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            frmAltaArticulos alta = new frmAltaArticulos();
            alta.ShowDialog();
            cargar();
        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show("Confirme nuevamente si quiere eliminarlo.", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminarArticulo(seleccionado.ID);
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        //FILTRO RAPIDO CON BTN.
        /*
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtFiltro.Text;

            if (filtro != "")
            {
                listaFiltrada = listaArticulo.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulo;
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            ocultarColumnas();
        }
        */

        private void ocultarColumnas()
        {
            dgvArticulos.Columns["UrlImagen"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["Codigo"].Visible = false;
            dgvArticulos.Columns["Descripcion"].Visible = false;
            dgvArticulos.Columns["Categoria"].Visible = false;
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtFiltro.Text;

            if (filtro.Length >=3)
            {
                listaFiltrada = listaArticulo.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulo;
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            frmAltaArticulos modificar = new frmAltaArticulos(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void chkbVerDetalle_CheckedChanged(object sender, EventArgs e)
        {
            if(chkbVerDetalle.Checked)
            {
                dgvArticulos.Columns["Codigo"].Visible = true;
                dgvArticulos.Columns["Descripcion"].Visible = true;
                dgvArticulos.Columns["Categoria"].Visible = true;
            }
            else
            {
                ocultarColumnas();
            }
        }

        //Validar que en mi filtro no pueda escribir numero.
        /* private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
         {
             if (char.IsDigit(e.KeyChar))
             {
                 // Si es un dígito numérico, cancelar el evento KeyPress para evitar que se escriba en el TextBox
                 e.Handled = true;
             }
         }*/
    }
}
