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
    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados()
        {
            InitializeComponent();
        }
        

        private void linklblmenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }

        private void btnCrearEmpleado_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else if (string.IsNullOrEmpty(txtCargo.Text))
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else if (string.IsNullOrEmpty(txtCedula.Text))
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else if (string.IsNullOrEmpty(txtDepartamento.Text))
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else if (string.IsNullOrEmpty(txtSalario.Text))
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else
            {
                GuardarEmpleados();
                //btnCrearEmpleado.Enabled = false;
            }

        }

        SqlConnection conecion = new SqlConnection("server=LAPTOP-KQH2TR9E; database=Nomina; Integrated Security=True");

        public void mostrarEmpleados()
        {
            string query = "Select * from empleados";
            SqlDataAdapter adaptador = new SqlDataAdapter(query, conecion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            btbNuevo.Visible = false;
            mostrarEmpleados();
        }

        public void GuardarEmpleados()
        {
            
            conecion.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SP_InsertarEmpleado", conecion);
            SqlCommand cm = new SqlCommand();
           
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, (30)).Value = txtNombre.Text;
            adapter.SelectCommand.Parameters.Add("@Apellido", SqlDbType.VarChar, (30)).Value = txtApellido.Text;
            adapter.SelectCommand.Parameters.Add("@Direccion", SqlDbType.VarChar, (100)).Value = txtDireccion.Text;
            adapter.SelectCommand.Parameters.Add("@Telefono", SqlDbType.VarChar, (20)).Value = txtTelefono.Text;
            adapter.SelectCommand.Parameters.Add("@FechaIngreso", SqlDbType.DateTime).Value = dtpIngreso.MaxDate;
            adapter.SelectCommand.Parameters.Add("@Cargo", SqlDbType.VarChar, (50)).Value = txtCargo.Text;
            adapter.SelectCommand.Parameters.Add("@Departamento", SqlDbType.VarChar, (50)).Value = txtDepartamento.Text;
            adapter.SelectCommand.Parameters.Add("@Salario", SqlDbType.VarChar, (50)).Value = txtSalario.Text;
            adapter.SelectCommand.Parameters.Add("@Cedula", SqlDbType.VarChar, (30)).Value = txtCedula.Text;
            
            adapter.SelectCommand.ExecuteNonQuery();
            MessageBox.Show("Datos Registrados exitosamente!!!");
            limpiarCampos();
            mostrarEmpleados();

            conecion.Close();
        }
        public void ActualizarEmpleado()
        {
           
            conecion.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SP_ActualizarEmpleado", conecion);
            SqlCommand cm = new SqlCommand();
          
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.Add("@Id", SqlDbType.Int).Value = txtCodigoEmpleado.Text;
            adapter.SelectCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, (30)).Value = txtNombre.Text;
            adapter.SelectCommand.Parameters.Add("@Apellido", SqlDbType.VarChar, (30)).Value = txtApellido.Text;
            adapter.SelectCommand.Parameters.Add("@Direccion", SqlDbType.VarChar, (100)).Value = txtDireccion.Text;
            adapter.SelectCommand.Parameters.Add("@Telefono", SqlDbType.VarChar, (20)).Value = txtTelefono.Text;
            adapter.SelectCommand.Parameters.Add("@FechaIngreso", SqlDbType.DateTime).Value = dtpIngreso.MaxDate;
            adapter.SelectCommand.Parameters.Add("@Cargo", SqlDbType.VarChar, (50)).Value = txtCargo.Text;
            adapter.SelectCommand.Parameters.Add("@Departamento", SqlDbType.VarChar, (50)).Value = txtDepartamento.Text;
            adapter.SelectCommand.Parameters.Add("@Salario", SqlDbType.VarChar, (50)).Value = txtSalario.Text;
            adapter.SelectCommand.Parameters.Add("@Cedula", SqlDbType.VarChar, (30)).Value = txtCedula.Text;
           
            adapter.SelectCommand.ExecuteNonQuery();
            MessageBox.Show("Datos actualizados exitosamente!!!");
            limpiarCampos();
            mostrarEmpleados();

            conecion.Close();
        }
        private void limpiarCampos()
        {
            btnCrearEmpleado.Enabled = true;
            txtTelefono.Clear();
            txtSalario.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtDepartamento.Clear();
            txtCedula.Clear();
            txtCodigoEmpleado.Clear();
            txtCargo.Clear();
            txtApellido.Clear();
        }

        private void btbNuevo_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            btnCrearEmpleado.Enabled = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else if (string.IsNullOrEmpty(txtCargo.Text))
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else if (string.IsNullOrEmpty(txtCedula.Text))
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else if (string.IsNullOrEmpty(txtDepartamento.Text))
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else if (string.IsNullOrEmpty(txtSalario.Text))
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else
            {
                ActualizarEmpleado();
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Eliminar Registro?", "Eliminar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    EliminarEmpleado(Convert.ToInt32(txtCodigoEmpleado.Text));
                    MessageBox.Show("Registro eliminado exitosamente!");
                }
                else
                {
                    MessageBox.Show("Registro no eliminado");
                    limpiarCampos();
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione el registro a eliminar");
            }
            mostrarEmpleados();

        }
        public void EliminarEmpleado(int Id)
        {
            conecion.Open();
            SqlCommand cm = new SqlCommand("SP_EliminarEmpleado",conecion);
            cm.CommandText = "SP_EliminarEmpleado";
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.AddWithValue("@Id", Id);
            cm.ExecuteNonQuery();
            //btnCrearEmpleado.Enabled = false;
            conecion.Close();
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
