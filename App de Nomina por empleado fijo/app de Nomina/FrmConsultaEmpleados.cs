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
    public partial class FrmConsultaEmpleados : Form
    {
        public FrmConsultaEmpleados()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }

        private void FrmConsultaEmpleados_Load(object sender, EventArgs e)
        {
            SqlConnection conecion = new SqlConnection("server=LAPTOP-KQH2TR9E; database=Nomina; Integrated Security=True");
        
        
            conecion.Open();
            string query = "Select * from Empleados";
            SqlDataAdapter adaptador = new SqlDataAdapter(query, conecion);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
            conecion.Close();
        
        }
    }
}
