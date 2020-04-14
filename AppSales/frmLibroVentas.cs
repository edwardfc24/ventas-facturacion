using AppSales.BLL;
using AppSales.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSales
{
    public partial class frmLibroVentas : Form
    {
        public frmLibroVentas()
        {
            InitializeComponent();
            this.Text = "Libros de Ventas";
            cargarDatosToGrid();
        }
        #region Funciones Auxiliares
        public void cargarDatosToGrid()
        {
            gdLibrosVentas.DataSource = LibroVentasBLL.SelectAll();
        }
        #endregion

        #region Eventos
        private void gdLibrosVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == btnEditar.Index)
            {
                frmInsertarLibroVentas frm = new frmInsertarLibroVentas(1, Convert.ToInt32(gdLibrosVentas.Rows[e.RowIndex].Cells[0].Value));
                frm.MdiParent = this.MdiParent;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
                this.Dispose();
            }
            if (e.ColumnIndex == btnExportar.Index)
            {
                FolderBrowserDialog sf = new FolderBrowserDialog();
                // Feed the dummy name to the save dialog
                DialogResult result = sf.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string savePath = sf.SelectedPath + "\\" + gdLibrosVentas.Rows[e.RowIndex].Cells[1].Value.ToString() + gdLibrosVentas.Rows[e.RowIndex].Cells[2].Value.ToString() + "LV.txt";
                    using (StreamWriter writer = new StreamWriter(savePath, false))
                    {
                        List<DetalleLibroVentas> detalles = DetalleLibroVentasBLL.GetDetalleLibroVentasByIdLibro(Convert.ToInt32(gdLibrosVentas.Rows[e.RowIndex].Cells[0].Value.ToString()));
                        foreach (DetalleLibroVentas detalle in detalles)
                        {
                            writer.WriteLine(detalle.intEspecificacion + "|" + detalle.intNro + "|" + detalle.dateFechaFactura.ToShortDateString() + "|" + detalle.txtNroFactura + "|" + detalle.txtNroAutorizacion + "|" + detalle.txtEstado + "|" +
                                detalle.txtNitCliente + "|" + detalle.txtNombreRazon + "|" + detalle.decImporteTotal.ToString().Replace(',', '.') + "|" + detalle.decImporteImpuestos.ToString().Replace(',', '.') + "|" + detalle.decExportacionesExentos.ToString().Replace(',', '.') + "|" + detalle.decVentasTasaCero.ToString().Replace(',', '.') + "|" +
                                detalle.decSubTotal.ToString().Replace(',', '.') + "|" + detalle.decDescuentos.ToString().Replace(',', '.') + "|" + detalle.decImporteBaseDF.ToString().Replace(',', '.') + "|" + detalle.decDebitoFiscal.ToString().Replace(',', '.') + "|" + detalle.txtCodigoControl + "\n");
                        }
                    }
                    MessageBox.Show("El archivo se guardó en la ruta " + savePath);
                }
            }
            if (e.ColumnIndex == btnImprimir.Index)
            {
                frmReporteLibroVenta frm = new frmReporteLibroVenta();
                frm.IdLibro = Convert.ToInt32(gdLibrosVentas.Rows[e.RowIndex].Cells[0].Value);
                frm.MdiParent = this.MdiParent;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
                this.Dispose();
            }
        }
        private void btnNuevoLibro_Click(object sender, EventArgs e)
        {
            frmInsertarLibroVentas frm = new frmInsertarLibroVentas(1);
            frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            this.Dispose();
        }
        #endregion


    }
}
