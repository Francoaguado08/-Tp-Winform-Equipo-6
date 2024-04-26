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

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            //Aca invoco la lectura a la BD...

            ArticuloNegocio negocio = new ArticuloNegocio();
            dgvArticulos.DataSource = negocio.listar(); // a la grilla de datos .datasource(origen de datos) le voy a asiganar la lista.
            listaArticulo = negocio.listar();//Asigna los datos obtenidos de la base de datos a listaArticulo


            dgvArticulos.DataSource = listaArticulo; // Asigna listaArticulo como origen de datos para el DataGridView


            if (listaArticulo.Count > 0)
            {
                cargarImagen(listaArticulo[0].UrlImagen); // Cargo la imagen del primer artículo en el PictureBox
            }
        }


        // Cuando cambio la seleccion de la grilla, quiero cambiar la imagen correspondiente.
       


        // Le pongo la excepcion por si no tiene imagen...
        private void cargarImagen(string imagen)
        {
            try
            {
                pbArticulo.Load(imagen);
            }
            catch (Exception ex)
            {

                pbArticulo.Load("https://www.came-educativa.com.ar/upsoazej/2022/03/placeholder-2.png");
            }


        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
        }
        
        
        // Cuando cambio la seleccion de la grilla, quiero cambiar la imagen correspondiente.
       
        
        private void dgvArticulos_SelectionChanged_1(object sender, EventArgs e)
        {
            //current row (la fila actual) // dataBoundItem (dame el objeto enlazado).
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);
        }
    
    
    
    
    }
   
}
