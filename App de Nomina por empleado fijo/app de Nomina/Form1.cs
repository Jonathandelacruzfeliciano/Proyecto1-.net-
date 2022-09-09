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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            timer1.Enabled = true;


            // double b = 100;
            progressBar1.Increment(2);
            label1.Text = "%" + progressBar1.Value;
            if (progressBar1.Value == 100)
            {

                FrmLogin login = new FrmLogin();
                login.Show();
                timer1.Enabled = false;
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

       
    }
}
