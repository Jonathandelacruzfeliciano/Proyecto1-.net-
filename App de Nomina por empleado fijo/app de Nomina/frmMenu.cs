using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace app_de_Nomina
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process calc = new System.Diagnostics.Process { StartInfo = { FileName = @"calc.exe" } };
            calc.Start();
        }

        private void calendarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 calendario = new Form2();
            calendario.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void nominasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultarNominas consultarNominas = new FrmConsultarNominas();
            consultarNominas.Show();
        }

        private void crearNominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNomina nomina = new FrmNomina();
            nomina.Show();
        }

        private void crearEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
             this.Hide();
            FrmEmpleados empleados = new FrmEmpleados();
            empleados.Show();
        
        }

        private void mantenimientoDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios usuarios = new FrmUsuarios();
            usuarios.Show();
            this.Hide();
        }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultaEmpleados consultarEmpleados = new FrmConsultaEmpleados();
            consultarEmpleados.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaUsuarios consultaUsuario = new FrmConsultaUsuarios();
            consultaUsuario.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reporteEmpleado reporte = new reporteEmpleado();
            reporte.Show();
        }
    }
}
