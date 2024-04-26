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
    public partial class frmAltaArticulo : Form
    {
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            Articulo arti  = new Articulo();   
            ArticuloNegocio negocio = new ArticuloNegocio();    

            try
            {
                arti.Codigo = txtCodigo.Text;   //si tengo que castearlo a entero es int.Parse(--);
                arti.Nombre = txtNombre.Text;   
                arti.Descripcion = txtDescripcion.Text;
                //Tengo mi objeto cargado, ahora lo mando a mi BD.

                negocio.agregar(arti);
                MessageBox.Show("Agregado eexitosamente");
                Close();



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }





        }
    }
}
