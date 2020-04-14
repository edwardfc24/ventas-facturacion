namespace AppSales
{
    partial class frmReporteMasVendido
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
            this.masVendidoDS = new AppSales.DAL.MasVendidoDS();
            this.masVendidoDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.masVendidoDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masVendidoDSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "MasVendidos";
            reportDataSource1.Value = this.masVendidoDSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AppSales.InformeReporte.MasVendidos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1323, 583);
            this.reportViewer1.TabIndex = 0;
            // 
            // masVendidoDS
            // 
            this.masVendidoDS.DataSetName = "MasVendidoDS";
            this.masVendidoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // masVendidoDSBindingSource
            // 
            this.masVendidoDSBindingSource.DataSource = this.masVendidoDS;
            this.masVendidoDSBindingSource.Position = 0;
            // 
            // frmReporteMasVendido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 583);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReporteMasVendido";
            this.Text = "frmReporteMasVendido";
            this.Load += new System.EventHandler(this.frmReporteMasVendido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masVendidoDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masVendidoDSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource masVendidoDSBindingSource;
        private DAL.MasVendidoDS masVendidoDS;

    }
}