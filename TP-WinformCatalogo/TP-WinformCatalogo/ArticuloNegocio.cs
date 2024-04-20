using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //(0) Agrego esto para la conexion.

namespace TP_WinformCatalogo
{   


    /// (1) Clase para crear los metodos de acceso a datos para los Articulos...
    ///(2) Los metodos tienen que ser PUblic para yo poder accederlos desde el exterior.
    internal class ArticuloNegocio
    {
        public List <Articulo> listar() //Metodo que devuelve una lista.
        {
            List<Articulo> lista = new List<Articulo>(); //(1)Creo mi lista.

            //Yo voy a necesitar conectarme a algun lado:
            SqlConnection conexion = new SqlConnection(); //(2) Creo mi conexion.

            //Una vez conectado voy a necesitar realizar comandos:
            SqlCommand comando = new SqlCommand();  //(3) Creo mis comandos.
            
            /*LLEGANDO a esta instancia, voy a tener en la BD un set de datos que lo voy a a alojar en mi
            lector.. Yo cuando realize la lectura voy a obtener la instancia de un OBJ de tipo sqlDataReader.*/
            SqlDataReader lector; //Lo prox es configurarlo.

            try
            {
                //(4)Conexion.
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true"; // A que servidor; A que BD;como me voy a conectar;
                //(5)Comando para realizar la accion, voy a llevar a cabo la lectura inyectando la secuencia de SQL.
                comando.CommandType = System.Data.CommandType.Text;
                //El texto va a ser la consulta de sql.
                comando.CommandText = "Select Codigo, Nombre, Descripcion, Precio From ARTICULOS";
                //(6)Ejecuto ese comando en esta conexion.
                comando.Connection = conexion;  


                conexion.Open(); //abro conexion
                lector = comando.ExecuteReader();//realizo la lectura

                //Ahora voy leyendo, si pudo leer ingresa al while y me posiciona el puntero en la siguiente posicion.
                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    //aux.ID = lector.GetInt32(0);
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    //aux.Marca = (Marca)lector["IdMarca"];
                    //aux.Categoria = (Categoria)lector["IdCategoria"];
                    aux.Precio = (decimal)lector["Precio"];


                    lista.Add(aux); //(7)- Finalmente agrego ese articulo a la lisa.
                }

                conexion.Close();
                //Cuando no tenga mas nada que leer que devuelva la lista.
                return lista;
                




            }
            catch (Exception ex)
            {

                
                
                
                
               throw ex;
            }



        }
         
    
    
    
    
    
    }





}
