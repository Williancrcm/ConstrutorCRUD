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
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void btntest_Click(object sender, EventArgs e)
        {
            string connetionString = " ";
            MySqlConnection conn;
            //prueba de conexion
            try
            {
                connetionString = @"Server=localhost;Database=smis043620;Uid=root;Pwd=usbw;SSL Mode=None";
                conn = new MySqlConnection(connetionString);
                conn.Open();
                MetroFramework.MetroMessageBox.Show(this, "Se establecio conexion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception Ex)
            {
                MetroFramework.MetroMessageBox.Show(this, Ex.Message, 
                    "Conexion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }
    }
}
