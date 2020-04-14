using AppSales.BLL;
using AppSales.DTO;
using AppSales.Facturacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing.QrCode;

namespace AppSales
{
    public partial class frmImprimirFacturas : Form
    {
        private List<Factura> listaFacturas;
        private List<DetalleLibroVentas> listaDetalleLibro;
        private string original = "ORIGINAL";
        private NumeralToLiteral objLiteral = new NumeralToLiteral();
        public frmImprimirFacturas()
        {
            InitializeComponent();
            cargarTabla();
        }

        private void frmImprimirFacturas_Load(object sender, EventArgs e)
        {

        }
        public void cargarTabla()
        {
            listaFacturas = FacturaBLL.GetAllFacturas();
            listaDetalleLibro = DetalleLibroVentasBLL.SelectAll();
            foreach (Factura item in listaFacturas)
            {
                foreach (DetalleLibroVentas det in listaDetalleLibro)
                {
                    if (item.txtNroFactura == det.txtNroFactura)
                    {
                        dgvFacturas.Rows.Add(item.txtNroFactura, det.dateFechaFactura.ToShortDateString(), det.txtNitCliente, det.txtNombreRazon, item.decTotal);
                    }
                }
            }
        }
        public string generarCuerpoFactura(string nro, string autorizacion, string fecha, string hora, string nit, string nombre, List<DetalleVenta> productos, string total, string codigo)
        {
            string factura = "";
            factura += "                               MINILULIS" + "\n";
            factura += "         BARRIO URBARI AV. BARRIENTOS NRO.24" + "\n";
            factura += "          COND. TORRE MANGABEIRA P.B. OF. 2" + "\n";
            factura += "                          TELÉFONO: 3599175" + "\n";
            factura += "                      SANTA CRUZ - BOLIVIA" + "\n";
            factura += "                                FACTURA" + "\n";
            factura += "                                " + original + "\n";
            factura += "------------------------------------------------------------------" + "\n";
            factura += "                            NIT: 4648284010" + "\n";
            factura += "                   NRO. FACTURA: " + rellenarConCeros(5, nro) + "\n";
            factura += "              NRO. AUTORIZACIÓN: " + autorizacion + "\n";
            factura += "------------------------------------------------------------------" + "\n";
            factura += "                     COMERCIO MINORISTA" + "\n";
            factura += "------------------------------------------------------------------" + "\n";
            factura += " FECHA: " + fecha + "       " + hora + "\n";
            factura += " NIT/CI: " + nit + "\n";
            factura += " SEÑOR(ES): " + nombre + "\n";
            factura += "------------------------------------------------------------------" + "\n";
            factura += String.Format("{0,-20}  {1,-20}  {2}", "CANT.", "PRODUCTO", "SUB-TOTAL") + "\n";
            factura += "------------------------------------------------------------------" + "\n";
            foreach (DetalleVenta item in productos)
            {
                Producto auxProd = ProductoBLL.GetProductById(item.fkProducto);
                string nam = "";
                if (auxProd.txtNombre.Length >= 12)
                {
                    nam = auxProd.txtNombre.Substring(0, 12) + "...";
                }
                else
                {
                    nam = auxProd.txtNombre;
                    if (rellenarDecimales(item.decimalTotal + "").Length == 5)
                    {
                        while (nam.Length < 20)
                        {
                            nam += " ";
                        }
                        nam += "...";
                    }
                    else
                    {
                        while (nam.Length < 15)
                        {
                            nam += " ";
                        }
                        nam += "...";
                    }
                }
                factura += String.Format("  {0,-20}  {1,-20}  {2,17}", item.intCantidad, nam, rellenarDecimales(item.decimalTotal + "")) + "\n";
            }
            factura += "------------------------------------------------------------------" + "\n";
            if (total.Length == 7)
                factura += "                                               TOTAL BS. " + rellenarDecimales(total) + "\n";
            else
                factura += "                                                TOTAL BS. " + rellenarDecimales(total) + "\n";
            factura += "------------------------------------------------------------------" + "\n";
            factura += " SON: " + objLiteral.Convertir(rellenarDecimales(total), true) + "\n";
            factura += " CÓDIGO DE CONTROL: " + codigo + "\n";
            LlaveFactura llave = LlaveFacturaBLL.GetLlaveFacturaByAutorizacion(autorizacion);
            factura += " FECHA LÍMITE DE EMISIÓN: " + llave.dateFechaLimite.ToShortDateString() + "\n";
            return factura;
        }
        public string generarLeyendaFactura()
        {
            string factura = "";
            //factura += "\"LA ALTERACIÓN, FALSIFICACIÓN O COMERCIALIZACIÓN" + "\n";
            //factura += "          DE ESTE DOCUMENTO TIENE CARCEL.\"" + "\n";
            factura += "\"ESTA FACTURA CONTRIBUYE AL DESARROLLO DEL PAÍS." + "\n";
            factura += "        EL USO ÍLICITO DE ÉSTA  SERÁ SANCIONADO" + "\n";
            factura += "                     DE ACUERDO A LEY\" ";
            return factura;
        }
        public void imprimirFactura(string nro, string autorizacion, string fecha, string hora, string nit, string nombre, List<DetalleVenta> productos, string total, string codigo, string bcf, string descuento)
        {
            string factura = generarCuerpoFactura(nro, autorizacion, fecha, hora, nit, nombre, productos, total, codigo);
            Bitmap qrCode = generarQR(nro, autorizacion, fecha, total, bcf, codigo, nit, descuento);
            string leyenda = generarLeyendaFactura();
            int numLines = factura.Split('\n').Length * 13;
            PrintDocument p = new PrintDocument();
            p.PrintPage += delegate(object sender1, PrintPageEventArgs e1)
            {
                e1.Graphics.DrawString(factura, new Font("Tahoma", 8), new SolidBrush(Color.Black), new RectangleF(0, 0, p.DefaultPageSettings.PrintableArea.Width, p.DefaultPageSettings.PrintableArea.Height));
                e1.Graphics.DrawImage(qrCode, 80, numLines);
                e1.Graphics.DrawString(leyenda, new Font("Tahoma", 7), new SolidBrush(Color.Black), new RectangleF(0, (numLines + 100), p.DefaultPageSettings.PrintableArea.Width, p.DefaultPageSettings.PrintableArea.Height));
            };
            try
            {
                p.Print();
            }
            catch (Exception ex)
            {
                throw new Exception("Exception Occured While Printing", ex);
            }
        }
        public string rellenarConCeros(int longitud, string cadena)
        {
            string aux = "";
            int stop = longitud - cadena.Length;
            for (int i = 0; i < stop; i++)
            {
                aux += "0";
            }
            aux += cadena;
            return aux;
        }
        public string rellenarDecimales(string cadena)
        {
            string aux = "";
            if (cadena.Contains(","))
            {
                string[] num = cadena.Split(',');
                if (num[1].Length == 1)
                    num[1] += "0";
                aux += num[0] + "." + num[1];
                return aux;
            }
            else
            {
                aux += cadena;
                aux += ".00";
                return aux;
            }
        }
        public Bitmap generarQR(string nroFactura, string auto, string fecha, string total, string bcf, string codigo, string nit, string descuento)
        {
            QRCodeWriter qr = new QRCodeWriter();
            string qrCode = "4648284010|";
            qrCode += nroFactura + "|";
            qrCode += auto + "|";
            qrCode += fecha + "|";
            qrCode += rellenarDecimales(total) + "|";
            qrCode += rellenarDecimales(bcf) + "|";
            qrCode += codigo + "|";
            qrCode += nit + "|";
            qrCode += "0|0|0|";
            qrCode += rellenarDecimales(descuento);
            var matrix = qr.encode(qrCode, ZXing.BarcodeFormat.QR_CODE, 100, 100);

            ZXing.BarcodeWriter w = new ZXing.BarcodeWriter();

            w.Format = ZXing.BarcodeFormat.QR_CODE;

            Bitmap img = w.Write(matrix);

            return img;
        }
        private void dgvFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (Factura item in listaFacturas)
            {
                foreach (DetalleLibroVentas det in listaDetalleLibro)
                {
                    if (item.txtNroFactura == Convert.ToString(dgvFacturas.Rows[e.RowIndex].Cells[0].Value) && det.txtNroFactura == Convert.ToString(dgvFacturas.Rows[e.RowIndex].Cells[0].Value.ToString()))
                    {
                        if (original == " COPIA")
                            original = "ORIGINAL";
                        List<DetalleVenta> listaDetalle = DetalleVentaBLL.GetDetalleVentaByIDFactura(item.pkFactura);
                        imprimirFactura(item.txtNroFactura, det.txtNroAutorizacion, det.dateFechaFactura.ToShortDateString(), det.dateFechaFactura.ToShortTimeString(), det.txtNitCliente, det.txtNombreRazon, listaDetalle, det.decImporteTotal + "", det.txtCodigoControl, det.decImporteBaseDF + "", det.decDescuentos + "");
                        original = "COPIA";
                        imprimirFactura(item.txtNroFactura, det.txtNroAutorizacion, det.dateFechaFactura.ToShortDateString(), det.dateFechaFactura.ToShortTimeString(), det.txtNitCliente, det.txtNombreRazon, listaDetalle, det.decImporteTotal + "", det.txtCodigoControl, det.decImporteBaseDF + "", det.decDescuentos + "");
                        return;
                    }
                }
            }
        }
    }
}
