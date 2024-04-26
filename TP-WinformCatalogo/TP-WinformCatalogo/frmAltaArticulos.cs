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
    public partial class frmAltaArticulos : Form
    {
        public frmAltaArticulos()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // se podria poner this.Close() pero no hace falta ya lo reconoce.
            Close();
        }
        

        private void frmAltaArticulos_Load(object sender, EventArgs e)
        {
            MarcasNegocio marcasNegocio = new MarcasNegocio();  
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {

                cboMarca.DataSource = marcasNegocio.listar();
                cboCategoria.DataSource = categoriaNegocio.listar();    




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }





        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {


            Articulo arti = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                arti.Codigo = txtCodigo.Text;
                arti.Nombre = txtNombre.Text;
                arti.Descripcion = txtDescripcion.Text;
                arti.Precio = decimal.Parse(txtPrecio.Text);
               
                arti.Marca = (Marca)cboMarca.SelectedItem;
                arti.Categoria = (Categoria)cboCategoria.SelectedItem;




                negocio.agregar(arti);
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
