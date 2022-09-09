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
    public partial class reporteEmpleado : Form
    {
        public reporteEmpleado()
        {
            InitializeComponent();
        }

        private void reporteEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'NominaDataSet.Empleados' Puede moverla o quitarla según sea necesario.
            this.EmpleadosTableAdapter.Fill(this.NominaDataSet.Empleados);

            this.reportViewer1.RefreshReport();
        }
    }
}
