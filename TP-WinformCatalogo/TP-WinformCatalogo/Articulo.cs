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

        public string Nombre { get; set; }
        public string  Descripcion  { get; set; }
        public decimal Precio { get; set; }

        /*Recordemos que el comboBox (el desplegable que nos pide) ya tiene que tener cargado sus ITEMS 
        en el LOAD.)? */
    }
}
