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

                dgvArticulos.Columns["UrlImagen"].Visible = false;  


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
            //current row (la fila actual) // dataBoundItem (dame el objeto enlazado).
            Articulo seleccionado = (Articulo) dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);


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
    }
}
