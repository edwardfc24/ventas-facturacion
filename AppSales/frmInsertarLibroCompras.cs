using AppSales.BLL;
using AppSales.DTO;
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
    public partial class frmInsertarLibroCompras : Form
    {
        public int user;
        public int idLibro = 0;
        private LibroCompras libro;
        public frmInsertarLibroCompras(int idUser)
        {
            InitializeComponent();
            this.Text = "Insertar Libro de Compras";
            user = idUser;
        }
        public frmInsertarLibroCompras(int idUser, int pkLibro)
        {
            InitializeComponent();
            this.Text = "Actualizar Libro de Compras";
            user = idUser;
            idLibro = pkLibro;
            libro = LibroComprasBLL.GetLibroComprasById(idLibro);
            txtMonth.Text = libro.txtMes;
            txtYear.Text = libro.txtAño;
            cargarDatosTabla();
            gdDetalleLibroCompras.Refresh();
        }

        private void cargarDatosTabla()
        {
            List<DetalleLibroCompras> lista = DetalleLibroComprasBLL.GetDetalleLibroComprasByIdLibro(idLibro);
            foreach (DetalleLibroCompras compra in lista)
            {
                Object[] row = { compra.pkRegistro, compra.intNro, compra.dateFechaFactura, compra.txtNitProeveedor, compra.txtNombreRazon, compra.txtNroFactura, compra.txtNroDUI, compra.txtNroAutorizacion, compra.decImporteTotal, compra.decImporteNOSujeto, compra.decSubTotal, compra.decDescuentos, compra.decImporteBaseCF, compra.decCreditoFiscal, compra.txtCodigoControl, compra.txtTipoCompra };
                gdDetalleLibroCompras.Rows.Add(row);
            }
            gdDetalleLibroCompras.Refresh();
        }
        #region Eventos
        private void btnAgregarFila_Click(object sender, EventArgs e)
        {
            Object[] row = { -1, (gdDetalleLibroCompras.RowCount + 1), "dd/mm/aaaa", "0000000", "Nombre", 0, 0, "00000000", 0, 0, 0, 0, 0, 0, 0, 1 };
            gdDetalleLibroCompras.Rows.Add(row);
            gdDetalleLibroCompras.Refresh();
        }


        private void gdDetalleLibroCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == btnEliminar.Index)
            {
                gdDetalleLibroCompras.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void gdDetalleLibroCompras_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow fila in gdDetalleLibroCompras.Rows)
            {
                if (e.ColumnIndex == fila.Cells["txtImporteTotal"].ColumnIndex)
                {
                    fila.Cells["txtSubTotal"].Value = Convert.ToDouble(fila.Cells["txtImporteTotal"].Value) - Convert.ToDouble(fila.Cells["txtImporteNOSujeto"].Value);
                    fila.Cells["txtImporteBaseCF"].Value = Convert.ToDouble(fila.Cells["txtSubTotal"].Value) - Convert.ToDouble(fila.Cells["txtDescuentos"].Value);
                    fila.Cells["txtCreditoFiscal"].Value = (double)Convert.ToDouble(fila.Cells["txtImporteBaseCF"].Value) * 13 / 100;
                }
                if (e.ColumnIndex == fila.Cells["txtImporteNOSujeto"].ColumnIndex)
                {
                    fila.Cells["txtSubTotal"].Value = Convert.ToDouble(fila.Cells["txtImporteTotal"].Value) - Convert.ToDouble(fila.Cells["txtImporteNOSujeto"].Value);
                    fila.Cells["txtImporteBaseCF"].Value = Convert.ToDouble(fila.Cells["txtSubTotal"].Value) - Convert.ToDouble(fila.Cells["txtDescuentos"].Value);
                    fila.Cells["txtCreditoFiscal"].Value = (double)Convert.ToDouble(fila.Cells["txtImporteBaseCF"].Value) * 13 / 100;
                }
                if (e.ColumnIndex == fila.Cells["txtDescuentos"].ColumnIndex)
                {
                    fila.Cells["txtImporteBaseCF"].Value = Convert.ToDouble(fila.Cells["txtSubTotal"].Value) - Convert.ToDouble(fila.Cells["txtDescuentos"].Value);
                    fila.Cells["txtCreditoFiscal"].Value = (double)Convert.ToDouble(fila.Cells["txtImporteBaseCF"].Value) * 13 / 100;
                }
            }
        }
        #endregion

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (idLibro != 0)
            {
                foreach (DataGridViewRow fila in gdDetalleLibroCompras.Rows)
                {
                    double total = Convert.ToDouble(fila.Cells["txtImporteTotal"].Value);
                    double noSujeto = Convert.ToDouble(fila.Cells["txtImporteNOSujeto"].Value);
                    double subtotal = Convert.ToDouble(fila.Cells["txtSubTotal"].Value);
                    double descuentos = Convert.ToDouble(fila.Cells["txtDescuentos"].Value);
                    double baseCF = Convert.ToDouble(fila.Cells["txtImporteBaseCF"].Value);
                    double creditoFiscal = Convert.ToDouble(fila.Cells["txtCreditoFiscal"].Value);
                    if (fila.Cells["txtIdRegistro"].Value.ToString() != "-1")
                        DetalleLibroComprasBLL.UpdateDetalle(Convert.ToInt32(fila.Cells["txtIdRegistro"].Value), Convert.ToInt32(fila.Cells["txtNro"].Value), Convert.ToDateTime(fila.Cells["dateFechaFactura"].Value), fila.Cells["txtNitProveedor"].Value.ToString(), fila.Cells["txtNombreRazon"].Value.ToString(), fila.Cells["txtNroFactura"].Value.ToString(), fila.Cells["txtNroDUI"].Value.ToString(), fila.Cells["txtNroAutorizacion"].Value.ToString(), Convert.ToDecimal(total), Convert.ToDecimal(noSujeto), Convert.ToDecimal(subtotal), Convert.ToDecimal(descuentos), Convert.ToDecimal(baseCF), Convert.ToDecimal(creditoFiscal), fila.Cells["txtCodigoControl"].Value.ToString(),
fila.Cells["txtTipoCompra"].Value.ToString(), idLibro, user);
                    else
                        DetalleLibroComprasBLL.InsertDatosDetalleLibroCompras(Convert.ToInt32(fila.Cells["txtNro"].Value), Convert.ToDateTime(fila.Cells["dateFechaFactura"].Value), fila.Cells["txtNitProveedor"].Value.ToString(), fila.Cells["txtNombreRazon"].Value.ToString(), fila.Cells["txtNroFactura"].Value.ToString(), fila.Cells["txtNroDUI"].Value.ToString(), fila.Cells["txtNroAutorizacion"].Value.ToString(), Convert.ToDecimal(total), Convert.ToDecimal(noSujeto), Convert.ToDecimal(subtotal), Convert.ToDecimal(descuentos), Convert.ToDecimal(baseCF), Convert.ToDecimal(creditoFiscal), fila.Cells["txtCodigoControl"].Value.ToString(),
fila.Cells["txtTipoCompra"].Value.ToString(), idLibro, user);
                }
            }
            else
            {
                idLibro = LibroComprasBLL.InsertDatosLibroCompras(txtMonth.Text, txtYear.Text);
                foreach (DataGridViewRow fila in gdDetalleLibroCompras.Rows)
                {
                    double total = Convert.ToDouble(fila.Cells["txtImporteTotal"].Value);
                    double noSujeto = Convert.ToDouble(fila.Cells["txtImporteNOSujeto"].Value);
                    double subtotal = Convert.ToDouble(fila.Cells["txtSubTotal"].Value);
                    double descuentos = Convert.ToDouble(fila.Cells["txtDescuentos"].Value);
                    double baseCF = Convert.ToDouble(fila.Cells["txtImporteBaseCF"].Value);
                    double creditoFiscal = Convert.ToDouble(fila.Cells["txtCreditoFiscal"].Value);
                    DetalleLibroComprasBLL.InsertDatosDetalleLibroCompras(Convert.ToInt32(fila.Cells["txtNro"].Value), Convert.ToDateTime(fila.Cells["dateFechaFactura"].Value), fila.Cells["txtNitProveedor"].Value.ToString(), fila.Cells["txtNombreRazon"].Value.ToString(), fila.Cells["txtNroFactura"].Value.ToString(), fila.Cells["txtNroDUI"].Value.ToString(), fila.Cells["txtNroAutorizacion"].Value.ToString(), Convert.ToDecimal(total), Convert.ToDecimal(noSujeto), Convert.ToDecimal(subtotal), Convert.ToDecimal(descuentos), Convert.ToDecimal(baseCF), Convert.ToDecimal(creditoFiscal), fila.Cells["txtCodigoControl"].Value.ToString(),
                                            fila.Cells["txtTipoCompra"].Value.ToString(), idLibro, user);
                }
                MessageBox.Show("Se agregó correctamente el Libro de Compras");
            }
        }
    }
}
