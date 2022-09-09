using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.Sql;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace app_de_Nomina
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        SqlConnection conecion = new SqlConnection("server=LAPTOP-KQH2TR9E; database=Nomina; Integrated Security=True");
        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
                txtUsuario.Focus();
            }
            else if (string.IsNullOrEmpty(txtContraseña.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
                txtUsuario.Focus();
            }
            else
            {
                conecion.Open();
                string query = "Select * from Usuarios where Usuario='" + txtUsuario.Text + "' AND Contraseña='" + txtContraseña.Text + "'";
                SqlCommand cm = new SqlCommand(query, conecion);
               
                SqlDataReader lector;
                lector = cm.ExecuteReader();
                if (lector.HasRows == true)
                {
                    MessageBox.Show("Bienvenido");
                    frmMenu menu = new frmMenu();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("DATOS ERRONEOS");
                    txtUsuario.Clear();
                    txtContraseña.Clear();
                    txtUsuario.Focus();
                }
                conecion.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            FrmUsuarios Usuarios = new FrmUsuarios();
           Usuarios.Show();
           
        } 
    }
}
