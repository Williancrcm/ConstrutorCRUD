using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ConstruccionInterfaz
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       

        private void Form2_Load(object sender, EventArgs e)
        {
                
            fillDataGridView();
           // ControlsDisable();
        }
        //utilizado para mostrar los registros en el datagridview
        public void fillDataGridView()
        {
            //instancia de la clase libro| Book
            Catalogo catalogo = new Catalogo();

            clearDataGridView();

            dgtCatalogos.Columns.Add("catalogoID", "CATALOGO ID");
            dgtCatalogos.Columns.Add("productos", "PRODUCTOS");
            dgtCatalogos.Columns.Add("ofertas", "OFERTAS");
            dgtCatalogos.Columns.Add("precios", "PRECIOS");
            

            //llamado al medoto getBooks() de la clase Book
            MySqlDataReader dataReader = catalogo.getAllCatalogos();

            //leer el resultado y mostrarlo en el datagridview
            while (dataReader.Read())
            {
                dgtCatalogos.Rows.Add(
                        dataReader.GetValue(0),
                        dataReader.GetValue(1),
                        dataReader.GetValue(2),
                        dataReader.GetValue(3),
                        dataReader.GetValue(4)
                       );
            }
        }

        public void clearDataGridView()
        {
            dgtCatalogos.Columns.Clear();
            dgtCatalogos.Rows.Clear();
        }
        //deshabilita los controles de formulario
        public void controlsDisable()
        {
            txtId.Enabled = false;
            txtProductos.Enabled = false;
            txtOfertas.Enabled = false;
            txtPrecios.Enabled = false;
            
        }
        //habilitar los controles de formulario
        public void controlsEnable()
        {
            txtId.Enabled = false;
            txtProductos.Enabled = true;
            txtOfertas.Enabled = true;
            txtPrecios.Enabled = true;
            
        }
        //limpiar el contenido de los controles
        public void clearControls()
        {
            txtId.Text = "";
            txtProductos.Text = "";
            txtOfertas.Text = "";
            txtPrecios.Text = "";
            
        }
        
        private void dgtCatalogos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void mbEliminar_Click(object sender, EventArgs e)
        {
            string mensaje = "Esta seguro que desea eliminar el registro?";
            if (MetroFramework.MetroMessageBox.Show(this, mensaje, "CONFIRMACION",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Catalogo catalogo = new Catalogo();
                catalogo._catalogo2 = Convert.ToInt32(dgtCatalogos.CurrentRow.Cells[0].Value);

                //llamado al metodo deleteCatalogo() de la clase Catalogo
                if (catalogo.deleteCatalogo())
                {
                    MetroFramework.MetroMessageBox.Show(this, "Los datos se han eliminado exitosamente!",
                        "CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //actualizar datagridview
                    fillDataGridView();

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Los datos  no se han podido eliminar",
                        "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

       
}
