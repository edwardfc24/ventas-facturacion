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
    public partial class frmReporteStockProductos : Form
    {
        public frmReporteStockProductos()
        {
            InitializeComponent();
        }

        private void frmReporteStockProductos_Load(object sender, EventArgs e)
        {
            List<ReporteStock> detalles = ReporteStockBLL.SelectAll();
            ReportDataSource dt = new ReportDataSource("StockProductoss", detalles);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(dt);
            this.reportViewer1.RefreshReport();
        }
    }
}
