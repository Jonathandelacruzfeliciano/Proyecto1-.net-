using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace app_de_Nomina
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }
        SqlConnection conecion = new SqlConnection("server=LAPTOP-KQH2TR9E; database=Nomina; Integrated Security=True");
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe llenar todos los campos");
                limpiarCampos();
                txtNombre.Focus();
            }
            else if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Debe llenar todos los campos");
                limpiarCampos();
                txtNombre.Focus();
            }
            else if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Debe llenar todos los campos");
                limpiarCampos();
                txtNombre.Focus();
            }
            else if (string.IsNullOrEmpty(txtContraseña.Text))
            {
                MessageBox.Show("Debe llenar todos los campos");
                limpiarCampos();
                txtNombre.Focus();
            }
            else
            {
                GuardarUsuario();
                limpiarCampos();
                txtNombre.Focus();
            }

            cargarUsuarios();
        }
        public void cargarUsuarios()
        {
            conecion.Open();
            string query = "Select * from Usuarios";
            SqlDataAdapter adaptador = new SqlDataAdapter(query, conecion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
            conecion.Close();
        }
        public void limpiarCampos()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtUsuario.Clear();
            txtContraseña.Clear();
            txtNombre.Focus();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
          
            cargarUsuarios();
        }

        public void eliminarUsuario(int Id)
        {
            conecion.Open();
            SqlCommand cm = new SqlCommand("SP_EliminarUsuario", conecion);
            cm.CommandText = "SP_EliminarUsuario";
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@Id", Id);
            cm.ExecuteNonQuery();
            conecion.Close();
        }
        public void GuardarUsuario()
        {
            conecion.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter("SP_InsertarUsuario", conecion);
            adaptador.SelectCommand.CommandType = CommandType.StoredProcedure;
            adaptador.SelectCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, (30)).Value = txtNombre.Text;
            adaptador.SelectCommand.Parameters.Add("@Apellido", SqlDbType.VarChar, (30)).Value = txtApellido.Text;
            adaptador.SelectCommand.Parameters.Add("@Usuario", SqlDbType.VarChar, (50)).Value = txtUsuario.Text;
            adaptador.SelectCommand.Parameters.Add("@Contraseña", SqlDbType.VarChar, (50)).Value = txtContraseña.Text;
            adaptador.SelectCommand.ExecuteNonQuery();
            MessageBox.Show("Usuario guardado exitosamente");
            conecion.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Eliminar Usuario?", "Eliminar Usuario", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    eliminarUsuario(Convert.ToInt32(txtId.Text));
                }
                else
                {
                    MessageBox.Show("Usuario no eliminado");
                    limpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar usuario a eliminar");
            }

            cargarUsuarios();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLogin Login = new FrmLogin();
            Login.Show();
            this.Hide();
        }
    }
}
