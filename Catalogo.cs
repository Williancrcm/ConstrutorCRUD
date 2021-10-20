using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConstruccionInterfaz
{
    class Catalogo
    {
        //propiedades
        public int _catalogoID { get; set; }
        public int _catalogo2 { get; set; }
        public string _productos { get; set; }
        public string _ofertas { get; set; }
        public string _precios { get; set; }

        //instancia a la clase crud
        private Crud crud = new Crud();

        //metodo para retornar los registros de la tabla catalogo
        public MySqlDataReader getAllCatalogos()
        {
            string query = "SELECT catalogoID, productos, ofertas, precios"
                + "FROM catalogo";

            //llamado al metodo select de la clase crud 
            return crud.select(query);
        }

        //metodo para insertar o editar un registro
        public Boolean newEditBook(string action)
        {
            if (action == "new")
            {
                string query = "INSERT INTO catalogoID (catalogoID, productos, ofertas, precios)" +
                    "VALUES ('" + _catalogoID + "', '" + _productos + "', '" + _ofertas + "', '" + _precios + "')";
                crud.executeQuery(query); //llamato al metodo executeQuery de la clase Crud
                return true;
            }
            else if (action == "edit")
            {
                string query = "UPDATE catalogoID SET "
                    + "catalogoID='" + _catalogoID + "' ,"
                    + "productos='" + _productos + "',"
                    + "ofertas='" + _ofertas + "',"
                    + "precios='" + _precios + "'"
                    + "WHERE "
                    + "catalogo2='" + _catalogo2 + "'";
                crud.executeQuery(query);
                return true;
            }

            return false;
        }

        //metodo para eliminar
        public Boolean deleteCatalogo()
        {
            string query = "DELETE FROM book WHERE catalogo2='" + _catalogo2 + "'";
            crud.executeQuery(query);
            return true;
        }
    }
}
