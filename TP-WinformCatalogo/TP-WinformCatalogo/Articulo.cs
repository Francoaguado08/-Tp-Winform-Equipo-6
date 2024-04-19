using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_WinformCatalogo
{
    internal class Articulo
    {

        //ATRIBUTOS DE MI CLASE ARTICULO GENERICA.
        public string Codigo { get; set; }
        [DisplayName("Codigo de Articulo")]

        public string Nombre { get; set; }
        public string  Descripcion  { get; set; }

        public string Marca { get; set; }   //Desplegable...

        public string Categoria { get; set; } //Desplegable...
       
        public string UrlImagen { get; set; }

        public decimal Precio { get; set; }

        /*Recordemos que el comboBox (el desplegable que nos pide) ya tiene que tener cargado sus ITEMS 
        en el LOAD.)? */
    }
}
