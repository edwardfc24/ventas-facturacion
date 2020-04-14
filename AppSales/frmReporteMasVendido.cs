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
    public partial class frmReporteMasVendido : Form
    {
        public frmReporteMasVendido()
        {
            InitializeComponent();
        }

        private void frmReporteMasVendido_Load(object sender, EventArgs e)
        {
            List<ProductoMasVendido> detalles = ProductoMasVendidoBLL.SelectAll();
            ReportDataSource dt = new ReportDataSource("MasVendidos", detalles);
            //ReportParameter pYear = new ReportParameter("dtInicio", DateTime.Now.ToString());
            //this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { pYear });
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(dt);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
