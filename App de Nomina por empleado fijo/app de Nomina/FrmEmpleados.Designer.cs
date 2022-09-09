namespace app_de_Nomina
{
    partial class FrmEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.linklblmenu = new System.Windows.Forms.LinkLabel();
            this.btbNuevo = new System.Windows.Forms.Button();
            this.txtNumeroNomina = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.dtpIngreso = new System.Windows.Forms.DateTimePicker();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtCodigoEmpleado = new System.Windows.Forms.TextBox();
            this.btnCrearEmpleado = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(896, 127);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(150, 44);
            this.btnActualizar.TabIndex = 57;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(896, 178);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(150, 44);
            this.btnEliminar.TabIndex = 56;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(103, 327);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(943, 139);
            this.dataGridView1.TabIndex = 55;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // linklblmenu
            // 
            this.linklblmenu.AutoSize = true;
            this.linklblmenu.Location = new System.Drawing.Point(966, 32);
            this.linklblmenu.Name = "linklblmenu";
            this.linklblmenu.Size = new System.Drawing.Size(77, 13);
            this.linklblmenu.TabIndex = 54;
            this.linklblmenu.TabStop = true;
            this.linklblmenu.Text = "Menu Principal";
            this.linklblmenu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblmenu_LinkClicked);
            // 
            // btbNuevo
            // 
            this.btbNuevo.Location = new System.Drawing.Point(896, 229);
            this.btbNuevo.Name = "btbNuevo";
            this.btbNuevo.Size = new System.Drawing.Size(150, 44);
            this.btbNuevo.TabIndex = 53;
            this.btbNuevo.Text = "Nuevo";
            this.btbNuevo.UseVisualStyleBackColor = true;
            this.btbNuevo.Click += new System.EventHandler(this.btbNuevo_Click);
            // 
            // txtNumeroNomina
            // 
            this.txtNumeroNomina.Location = new System.Drawing.Point(732, 251);
            this.txtNumeroNomina.Name = "txtNumeroNomina";
            this.txtNumeroNomina.Size = new System.Drawing.Size(158, 20);
            this.txtNumeroNomina.TabIndex = 52;
            this.txtNumeroNomina.Visible = false;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(575, 218);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(151, 20);
            this.txtSalario.TabIndex = 51;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(634, 183);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(256, 20);
            this.txtDepartamento.TabIndex = 50;
            // 
            // dtpIngreso
            // 
            this.dtpIngreso.Enabled = false;
            this.dtpIngreso.Location = new System.Drawing.Point(658, 111);
            this.dtpIngreso.Name = "dtpIngreso";
            this.dtpIngreso.Size = new System.Drawing.Size(232, 20);
            this.dtpIngreso.TabIndex = 49;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(685, 146);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(205, 20);
            this.txtCargo.TabIndex = 48;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(209, 253);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(252, 20);
            this.txtTelefono.TabIndex = 47;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(209, 216);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(252, 20);
            this.txtDireccion.TabIndex = 46;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(209, 183);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(252, 20);
            this.txtApellido.TabIndex = 45;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(209, 146);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(254, 20);
            this.txtNombre.TabIndex = 44;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(177, 111);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(286, 20);
            this.txtCedula.TabIndex = 43;
            // 
            // txtCodigoEmpleado
            // 
            this.txtCodigoEmpleado.Enabled = false;
            this.txtCodigoEmpleado.Location = new System.Drawing.Point(177, 76);
            this.txtCodigoEmpleado.Name = "txtCodigoEmpleado";
            this.txtCodigoEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoEmpleado.TabIndex = 42;
            // 
            // btnCrearEmpleado
            // 
            this.btnCrearEmpleado.Location = new System.Drawing.Point(896, 76);
            this.btnCrearEmpleado.Name = "btnCrearEmpleado";
            this.btnCrearEmpleado.Size = new System.Drawing.Size(150, 44);
            this.btnCrearEmpleado.TabIndex = 41;
            this.btnCrearEmpleado.Text = "Guardar";
            this.btnCrearEmpleado.UseVisualStyleBackColor = true;
            this.btnCrearEmpleado.Click += new System.EventHandler(this.btnCrearEmpleado_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(504, 251);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(222, 20);
            this.label12.TabIndex = 40;
            this.label12.Text = "Numero de cuenta-Nomina";
            this.label12.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(504, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 20);
            this.label11.TabIndex = 39;
            this.label11.Text = "Salario";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(504, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 20);
            this.label10.TabIndex = 38;
            this.label10.Text = "Departamento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(504, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 20);
            this.label9.TabIndex = 37;
            this.label9.Text = "Cargo desempeñado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(504, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 20);
            this.label8.TabIndex = 36;
            this.label8.Text = "Fecha de ingreso";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(106, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(106, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Direccion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(106, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = "Apellido (s)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(106, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Nombre (s)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Cedula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Complete la informacion requerida para crear empleado";
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 491);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.linklblmenu);
            this.Controls.Add(this.btbNuevo);
            this.Controls.Add(this.txtNumeroNomina);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.dtpIngreso);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtCodigoEmpleado);
            this.Controls.Add(this.btnCrearEmpleado);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmEmpleados";
            this.Text = "FrmEmpleados";
            this.Load += new System.EventHandler(this.FrmEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.LinkLabel linklblmenu;
        private System.Windows.Forms.Button btbNuevo;
        private System.Windows.Forms.TextBox txtNumeroNomina;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.DateTimePicker dtpIngreso;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtCodigoEmpleado;
        private System.Windows.Forms.Button btnCrearEmpleado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}