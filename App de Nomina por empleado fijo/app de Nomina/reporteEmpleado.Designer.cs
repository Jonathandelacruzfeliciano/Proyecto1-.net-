namespace app_de_Nomina
{
    partial class reporteEmpleado
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.NominaDataSet = new app_de_Nomina.NominaDataSet();
            this.EmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmpleadosTableAdapter = new app_de_Nomina.NominaDataSetTableAdapters.EmpleadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.NominaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.EmpleadosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "app_de_Nomina.Reporteempleado.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(893, 435);
            this.reportViewer1.TabIndex = 0;
            // 
            // NominaDataSet
            // 
            this.NominaDataSet.DataSetName = "NominaDataSet";
            this.NominaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EmpleadosBindingSource
            // 
            this.EmpleadosBindingSource.DataMember = "Empleados";
            this.EmpleadosBindingSource.DataSource = this.NominaDataSet;
            // 
            // EmpleadosTableAdapter
            // 
            this.EmpleadosTableAdapter.ClearBeforeFill = true;
            // 
            // reporteEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 435);
            this.Controls.Add(this.reportViewer1);
            this.Name = "reporteEmpleado";
            this.Text = "reporteEmpleado";
            this.Load += new System.EventHandler(this.reporteEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NominaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EmpleadosBindingSource;
        private NominaDataSet NominaDataSet;
        private NominaDataSetTableAdapters.EmpleadosTableAdapter EmpleadosTableAdapter;
    }
}