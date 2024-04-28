using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TP_WinformCatalogo
{
    public partial class frmAltaArticulos : Form
    {
        private Articulo articulo = null;
        public frmAltaArticulos()
        {
            InitializeComponent();
        }

        public frmAltaArticulos(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
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
                cboMarca.ValueMember = "Descripcion";
                cboMarca.DisplayMember = "Descripcion";
                cboCategoria.DataSource = categoriaNegocio.listar();    
                cboCategoria.ValueMember = "Descripcion";
                cboCategoria.DisplayMember = "Descripcion";

                if(articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtPrecio.Text = articulo.Precio.ToString();
                    txtUrlImagen.Text = articulo.UrlImagen;
                    cboCategoria.SelectedValue = articulo.Categoria.Descripcion;
                    cboMarca.SelectedValue = articulo.Marca.Descripcion;
                    cargarImagen(articulo.UrlImagen);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            //Articulo arti = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();
            Regex regex = new Regex("^[a-zA-Z0-9 ]*$");

            try
            {
                if (articulo == null)
                    articulo = new Articulo();


                if (string.IsNullOrEmpty(txtNombre.Text))
                {
                    MessageBox.Show("⚠️ No se ha ingresado ningun NOMBRE ⚠️");
                    return;
                }
                else if (!regex.IsMatch(txtNombre.Text))
                {
                    MessageBox.Show("⚠️ 'NOMBRE' no permite caracteres especiales ⚠️");
                    return;
                }
                articulo.Nombre = txtNombre.Text;

                if (string.IsNullOrEmpty(txtCodigo.Text))
                {
                    MessageBox.Show("⚠️ No se ha ingresado ningun CODIGO ⚠️");
                    return;
                }
                else if (!regex.IsMatch(txtCodigo.Text))
                {
                    MessageBox.Show("⚠️ 'CODIGO' no permite caracteres especiales ⚠️");
                    return;
                }
                articulo.Codigo = txtCodigo.Text;

                if (!regex.IsMatch(txtDescripcion.Text))
                {
                    MessageBox.Show("⚠️ 'DESCRIPCION' no permite caracteres especiales ⚠️");
                    return;
                }
                articulo.Descripcion = txtDescripcion.Text;

                articulo.UrlImagen = txtUrlImagen.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;

                if (articulo.ID != 0)
                {
                    negocio.modificar(articulo);
                    //negocio.modificarCategoriaArticulo(articulo);
                    //negocio.modificarMarcaArticulo(articulo); 
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    negocio.agregar(articulo);
                    negocio.agregarImagen(articulo);
                    MessageBox.Show("Articulo agregado correctamente");
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);    
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxAltaArticulo.Load(imagen);
            }
            catch (Exception ex)
            {

                pbxAltaArticulo.Load("https://www.came-educativa.com.ar/upsoazej/2022/03/placeholder-2.png");
            }
        }

        //FRONT
        private void btnAceptar_MouseEnter(object sender, EventArgs e)
        {
            btnAceptar.FlatAppearance.BorderColor = Color.Green;
        }  

        private void btnAceptar_MouseLeave_1(object sender, EventArgs e)
        {
            btnAceptar.FlatAppearance.BorderColor = SystemColors.ControlDark;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.FlatAppearance.BorderColor = SystemColors.ControlDark;
        }
        private void btnCancelar_MouseEnter(object sender, EventArgs e)
        {
            btnCancelar.FlatAppearance.BorderColor = Color.Red;
        }


    }
}
