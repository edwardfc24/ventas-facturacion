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
    public partial class frmLibroCompras : Form
    {
        public frmLibroCompras()
        {
            InitializeComponent();
            this.Text = "Libros de Compras";
            cargarDatosToGrid();
        }
        #region Funciones Auxiliares
        public void cargarDatosToGrid()
        {
            gdLibrosCompras.DataSource = LibroComprasBLL.SelectAll();
        }
        #endregion
        #region Eventos
        private void gdLibrosCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == btnEditar.Index)
            {
                frmInsertarLibroCompras frm = new frmInsertarLibroCompras(Convert.ToInt32(gdLibrosCompras.Rows[e.RowIndex].Cells[0].Value), 1);
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
                    string savePath = sf.SelectedPath + "\\" + gdLibrosCompras.Rows[e.RowIndex].Cells[1].Value.ToString() + gdLibrosCompras.Rows[e.RowIndex].Cells[2].Value.ToString() + "LC.txt";
                    using (StreamWriter writer = new StreamWriter(savePath, false))
                    {
                        List<DetalleLibroCompras> detalles = DetalleLibroComprasBLL.GetDetalleLibroComprasByIdLibro(Convert.ToInt32(gdLibrosCompras.Rows[e.RowIndex].Cells[0].Value.ToString()));
                        foreach (DetalleLibroCompras detalle in detalles)
                        {
                            writer.WriteLine(detalle.intEspecificacion + "|" + detalle.intNro + "|" + detalle.dateFechaFactura.ToShortDateString() + "|" + detalle.txtNitProeveedor + "|" + detalle.txtNombreRazon + "|" + detalle.txtNroFactura + "|" +
                                detalle.txtNroDUI + "|" + detalle.txtNroAutorizacion + "|" + detalle.decImporteTotal.ToString().Replace(',', '.') + "|" + detalle.decImporteNOSujeto.ToString().Replace(',', '.') + "|" + detalle.decSubTotal.ToString().Replace(',', '.') + "|" + detalle.decDescuentos.ToString().Replace(',', '.') + "|" +
                                detalle.decImporteBaseCF.ToString().Replace(',', '.') + "|" + detalle.decCreditoFiscal.ToString().Replace(',', '.') + "|" + detalle.txtCodigoControl + "|" + detalle.txtTipoCompra + "\n");
                        }
                    }
                    MessageBox.Show("El archivo se guardó en la ruta " + savePath);
                }
            }
            if (e.ColumnIndex == btnImprimir.Index)
            {
                frmReporteLibroCompra frm = new frmReporteLibroCompra();
                frm.IdLibro = Convert.ToInt32(gdLibrosCompras.Rows[e.RowIndex].Cells[0].Value);
                frm.MdiParent = this.MdiParent;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
                this.Dispose();
            }
        }

        private void btnNuevoLibro_Click(object sender, EventArgs e)
        {
            frmInsertarLibroCompras frm = new frmInsertarLibroCompras(1);
            frm.MdiParent = this.MdiParent;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            this.Dispose();
        }
        #endregion
    }
}
