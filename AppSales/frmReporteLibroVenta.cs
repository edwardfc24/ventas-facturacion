using AppSales.BLL;
using AppSales.DTO;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSales
{
    public partial class frmReporteLibroVenta : Form
    {
        public int idLibro;
        private LibroVentas libro;
        public frmReporteLibroVenta()
        {
            InitializeComponent();
        }
        public int IdLibro
        {
            get { return idLibro; }
            set { idLibro = value; }
        }
        private void frmReporteLibroVenta_Load(object sender, EventArgs e)
        {
            ;
            // TODO: This line of code loads data into the 'detalleLibroVentasDS.DetalleLibroVentas' table. You can move, or remove it, as needed.
            libro = LibroVentasBLL.GetLibroVentasById(idLibro);
            List<DetalleLibroVentas> detalles = DetalleLibroVentasBLL.GetDetalleLibroVentasByIdLibro(libro.pkLibro);
            ReportDataSource dt = new ReportDataSource("LV", detalles);
            ReportParameter pYear = new ReportParameter("Year", libro.txtAño);
            ReportParameter pMonth = new ReportParameter("Month", libro.txtMes);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { pYear });
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { pMonth });
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(dt);
            this.reportViewer1.RefreshReport();
        }
    }
}
