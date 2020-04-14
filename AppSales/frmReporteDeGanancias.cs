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
    public partial class frmReporteDeGanancias : Form
    {
        public frmReporteDeGanancias()
        {
            InitializeComponent();
        }

        private void frmReporteDeGanancias_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
        }

        private void btnGenerar_Click_1(object sender, EventArgs e)
        {
            DateTime ini = Convert.ToDateTime(txtFechaInicio.Text);
            DateTime fin = Convert.ToDateTime(txtFechaFin.Text);
            List<ReporteGanancias> detalles = ReporteGananciasBLL.SelectAll(ini, fin);
            ReportDataSource dt = new ReportDataSource("Ganancias", detalles);
            ReportParameter pYear = new ReportParameter("dtInicio", txtFechaInicio.Text);
            ReportParameter pMonth = new ReportParameter("dtFin", txtFechaFin.Text);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { pYear });
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { pMonth });
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(dt);
            this.reportViewer1.RefreshReport();
        }
    }
}
