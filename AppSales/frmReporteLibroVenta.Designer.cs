namespace AppSales
{
    partial class frmReporteLibroVenta
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
            this.detalleLibroVentasDS = new AppSales.DAL.DetalleLibroVentasDS();
            this.detalleLibroVentasDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalleLibroVentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalleLibroVentasTableAdapter = new AppSales.DAL.DetalleLibroVentasDSTableAdapters.DetalleLibroVentasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.detalleLibroVentasDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleLibroVentasDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleLibroVentasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "LV";
            reportDataSource1.Value = this.detalleLibroVentasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AppSales.InformeReporte.LibroVenta.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1463, 480);
            this.reportViewer1.TabIndex = 0;
            // 
            // detalleLibroVentasDS
            // 
            this.detalleLibroVentasDS.DataSetName = "DetalleLibroVentasDS";
            this.detalleLibroVentasDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detalleLibroVentasDSBindingSource
            // 
            this.detalleLibroVentasDSBindingSource.DataSource = this.detalleLibroVentasDS;
            this.detalleLibroVentasDSBindingSource.Position = 0;
            // 
            // detalleLibroVentasBindingSource
            // 
            this.detalleLibroVentasBindingSource.DataMember = "DetalleLibroVentas";
            this.detalleLibroVentasBindingSource.DataSource = this.detalleLibroVentasDSBindingSource;
            // 
            // detalleLibroVentasTableAdapter
            // 
            this.detalleLibroVentasTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteLibroVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 480);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReporteLibroVenta";
            this.Text = "frmReporteLibroVenta";
            this.Load += new System.EventHandler(this.frmReporteLibroVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detalleLibroVentasDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleLibroVentasDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleLibroVentasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource detalleLibroVentasDSBindingSource;
        private DAL.DetalleLibroVentasDS detalleLibroVentasDS;
        private System.Windows.Forms.BindingSource detalleLibroVentasBindingSource;
        private DAL.DetalleLibroVentasDSTableAdapters.DetalleLibroVentasTableAdapter detalleLibroVentasTableAdapter;
    }
}