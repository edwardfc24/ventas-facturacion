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
    public partial class frmInsertarLibroVentas : Form
    {
        public int user;
        public int idLibro = 0;
        private LibroVentas libro;
        public frmInsertarLibroVentas(int idUser)
        {
            InitializeComponent();
            this.Text = "Insertar Libro de Ventas";
            user = idUser;
        }
        public frmInsertarLibroVentas(int idUser, int pkLibro)
        {
            InitializeComponent();
            this.Text = "Actualizar Libro de Ventas";
            user = idUser;
            idLibro = pkLibro;
            libro = LibroVentasBLL.GetLibroVentasById(idLibro);
            txtMonth.Text = libro.txtMes;
            txtYear.Text = libro.txtAño;
            cargarDatosTabla();
            gdDetalleLibroVentas.Refresh();
        }

        private void cargarDatosTabla()
        {
            List<DetalleLibroVentas> lista = DetalleLibroVentasBLL.GetDetalleLibroVentasByIdLibro(idLibro);
            foreach (DetalleLibroVentas venta in lista)
            {
                Object[] row = { venta.pkRegistro, venta.intNro, venta.dateFechaFactura, venta.txtNroFactura, venta.txtNroAutorizacion, venta.txtEstado, venta.txtNitCliente, venta.txtNombreRazon, venta.decImporteTotal, venta.decImporteImpuestos, venta.decExportacionesExentos, venta.decVentasTasaCero, venta.decSubTotal, venta.decDescuentos, venta.decImporteBaseDF, venta.decDebitoFiscal, venta.txtCodigoControl };
                gdDetalleLibroVentas.Rows.Add(row);
            }
            gdDetalleLibroVentas.Refresh();
        }
        #region Eventos
        private void gdDetalleLibroVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == btnEliminar.Index)
            {
                gdDetalleLibroVentas.Rows.RemoveAt(e.RowIndex);
                gdDetalleLibroVentas.Refresh();
            }
        }

        private void gdDetalleLibroVentas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow fila in gdDetalleLibroVentas.Rows)
            {
                if (fila.Cells["txtImporteTotal"] != null)
                {
                    fila.Cells["txtSubTotal"].Value = Convert.ToDouble(fila.Cells["txtImporteTotal"].Value) - Convert.ToDouble(fila.Cells["txtImpuestos"].Value) - Convert.ToDouble(fila.Cells["txtExcentos"].Value) - Convert.ToDouble(fila.Cells["txtImporteVentasTasaCero"].Value);
                    fila.Cells["txtImporteBaseDF"].Value = Convert.ToDouble(fila.Cells["txtSubTotal"].Value) - Convert.ToDouble(fila.Cells["txtDescuentos"].Value);
                    fila.Cells["txtDebitoFiscal"].Value = (double)Convert.ToDouble(fila.Cells["txtImporteBaseDF"].Value) * 13 / 100;
                }
                if (fila.Cells["txtImporteVentasTasaCero"] != null)
                {
                    fila.Cells["txtSubTotal"].Value = Convert.ToDouble(fila.Cells["txtImporteTotal"].Value) - Convert.ToDouble(fila.Cells["txtImpuestos"].Value) - Convert.ToDouble(fila.Cells["txtExcentos"].Value) - Convert.ToDouble(fila.Cells["txtImporteVentasTasaCero"].Value);
                    fila.Cells["txtImporteBaseDF"].Value = Convert.ToDouble(fila.Cells["txtSubTotal"].Value) - Convert.ToDouble(fila.Cells["txtDescuentos"].Value);
                    fila.Cells["txtDebitoFiscal"].Value = (double)Convert.ToDouble(fila.Cells["txtImporteBaseDF"].Value) * 13 / 100;
                }
                if (fila.Cells["txtDescuentos"].Value != null)
                {
                    fila.Cells["txtImporteBaseDF"].Value = Convert.ToDouble(fila.Cells["txtSubTotal"].Value) - Convert.ToDouble(fila.Cells["txtDescuentos"].Value);
                    fila.Cells["txtDebitoFiscal"].Value = (double)Convert.ToDouble(fila.Cells["txtImporteBaseDF"].Value) * 13 / 100;
                }
            }
        }

        private void btnAgregarFila_Click(object sender, EventArgs e)
        {
            Object[] row = { -1, (gdDetalleLibroVentas.RowCount + 1), "dd/mm/aaaa", "0000000", "00000000", "V", "00000000", "Nombre", 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            gdDetalleLibroVentas.Rows.Add(row);
            gdDetalleLibroVentas.Refresh();
        }
        #endregion
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (idLibro != 0)
            {
                foreach (DataGridViewRow fila in gdDetalleLibroVentas.Rows)
                {
                    double total = Convert.ToDouble(fila.Cells["txtImporteTotal"].Value);
                    double impuestos = Convert.ToDouble(fila.Cells["txtImpuestos"].Value);
                    double excentos = Convert.ToDouble(fila.Cells["txtExcentos"].Value);
                    double tasaCero = Convert.ToDouble(fila.Cells["txtImporteVentasTasaCero;"].Value);
                    double subtotal = Convert.ToDouble(fila.Cells["txtSubTotal"].Value);
                    double descuentos = Convert.ToDouble(fila.Cells["txtDescuentos"].Value);
                    double baseDF = Convert.ToDouble(fila.Cells["txtImporteBaseDF"].Value);
                    double debitoFiscal = Convert.ToDouble(fila.Cells["txtDebitoFiscal"].Value);
                    if (fila.Cells["txtIdRegistro"].Value.ToString() != "-1")
                        DetalleLibroVentasBLL.UpdateDetalle(Convert.ToInt32(fila.Cells["txtIdRegistro"].Value), Convert.ToInt32(fila.Cells["txtNro"].Value), Convert.ToDateTime(fila.Cells["dateFechaFactura"].Value), fila.Cells["txtNroFactura"].Value.ToString(), fila.Cells["txtNroAutorizacion"].Value.ToString(), fila.Cells["txtEstado"].Value.ToString(), fila.Cells["txtNitCliente"].Value.ToString(), fila.Cells["txtNombreRazon"].Value.ToString(), Convert.ToDecimal(total), Convert.ToDecimal(impuestos), Convert.ToDecimal(excentos), Convert.ToDecimal(tasaCero), Convert.ToDecimal(subtotal), Convert.ToDecimal(descuentos), Convert.ToDecimal(baseDF), Convert.ToDecimal(debitoFiscal), fila.Cells["txtCodigoControl"].Value.ToString(), idLibro, user);
                    else
                        DetalleLibroVentasBLL.InsertDatosDetalleLibroVentas(Convert.ToInt32(fila.Cells["txtNro"].Value), Convert.ToDateTime(fila.Cells["dateFechaFactura"].Value), fila.Cells["txtNroFactura"].Value.ToString(), fila.Cells["txtNroAutorizacion"].Value.ToString(), fila.Cells["txtNitCliente"].Value.ToString(), fila.Cells["txtNombreRazon"].Value.ToString(), Convert.ToDecimal(total), Convert.ToDecimal(impuestos), Convert.ToDecimal(excentos), Convert.ToDecimal(tasaCero), Convert.ToDecimal(subtotal), Convert.ToDecimal(descuentos), Convert.ToDecimal(baseDF), Convert.ToDecimal(debitoFiscal), fila.Cells["txtCodigoControl"].Value.ToString(), idLibro, user);
                }
            }
            else
            {
                idLibro = LibroVentasBLL.InsertDatosLibroVentas(txtMonth.Text, txtYear.Text);
                foreach (DataGridViewRow fila in gdDetalleLibroVentas.Rows)
                {
                    double total = Convert.ToDouble(fila.Cells["txtImporteTotal"].Value);
                    double impuestos = Convert.ToDouble(fila.Cells["txtImpuestos"].Value);
                    double excentos = Convert.ToDouble(fila.Cells["txtExcentos"].Value);
                    double tasaCero = Convert.ToDouble(fila.Cells["txtImporteVentasTasaCero;"].Value);
                    double subtotal = Convert.ToDouble(fila.Cells["txtSubTotal"].Value);
                    double descuentos = Convert.ToDouble(fila.Cells["txtDescuentos"].Value);
                    double baseDF = Convert.ToDouble(fila.Cells["txtImporteBaseDF"].Value);
                    double debitoFiscal = Convert.ToDouble(fila.Cells["txtDebitoFiscal"].Value);
                    DetalleLibroVentasBLL.InsertDatosDetalleLibroVentas(Convert.ToInt32(fila.Cells["txtNro"].Value), Convert.ToDateTime(fila.Cells["dateFechaFactura"].Value), fila.Cells["txtNroFactura"].Value.ToString(), fila.Cells["txtNroAutorizacion"].Value.ToString(), fila.Cells["txtNitCliente"].Value.ToString(), fila.Cells["txtNombreRazon"].Value.ToString(), Convert.ToDecimal(total), Convert.ToDecimal(impuestos), Convert.ToDecimal(excentos), Convert.ToDecimal(tasaCero), Convert.ToDecimal(subtotal), Convert.ToDecimal(descuentos), Convert.ToDecimal(baseDF), Convert.ToDecimal(debitoFiscal), fila.Cells["txtCodigoControl"].Value.ToString(), idLibro, user);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
