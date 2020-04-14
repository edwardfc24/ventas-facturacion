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
    public partial class frmReporteVentaPeriodos : Form
    {
        public frmReporteVentaPeriodos()
        {
            InitializeComponent();
        }

        private void frmReporteVentaPeriodos_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DateTime ini = Convert.ToDateTime(txtFechaInicio.Text);
            DateTime fin = Convert.ToDateTime(txtFechaFin.Text);
            List<Ventas> detalles = VentasBLL.GetVentasBetweenDates(ini, fin);
            ReportDataSource dt = new ReportDataSource("VentasPeriodos", detalles);
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
