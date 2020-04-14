using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppSales.BLL;
using AppSales.DTO;
using AppSales.Facturacion;
using ZXing.QrCode;
using System.Drawing.Printing;

namespace AppSales
{
    public partial class frmVentas : Form
    {
        private string cambiar;
        private NumeralToLiteral objLiteral;
        private CodigoControl objControl;
        private LlaveFactura llave;
        private Factura lastFactura;
        private LibroVentas lastLibroVenta;
        private Cliente objCliente;
        private string fecha;
        private string original = "ORIGINAL";
        private List<Producto> listaProductos;
        private double sumaReal;
        private double sumaDescuentos;
        public frmVentas()
        {
            this.Text = "Realizar Venta";
            InitializeComponent();
            txtNombreCliente.GotFocus += txtNombreCliente_Click;
            objLiteral = new NumeralToLiteral();
            fecha = DateTime.Now.Year + "";
            fecha += DateTime.Now.Month + "";
            fecha += DateTime.Now.Day + "";
            llave = LlaveFacturaBLL.GetLastLlaveFactura();
            lastFactura = FacturaBLL.GetLastFactura();
            lastLibroVenta = LibroVentasBLL.GetLastLibroVentas();
            listaProductos = new List<Producto>();
            cargarBoxDescuentos();
            sumaReal = 0;
            sumaDescuentos = 0;
        }

        #region Funciones Auxiliares
        public void cargarNombreCliente()
        {
            if (txtNitCliente.Text != "")
            {
                objCliente = ClienteBLL.GetClienteByNit(txtNitCliente.Text);
                if (objCliente != null)
                {
                    txtNombreCliente.Text = objCliente.txtNombreCompleto;
                }
            }
            else
            {
                txtNitCliente.Text = "0";
                txtNombreCliente.Text = "SIN NOMBRE";
                objCliente = ClienteBLL.GetClienteByNit("0");
            }
        }
        public void insertarFilaProducto()
        {
            Producto objProducto = ProductoBLL.GetProductByCode(cambiar);
            if (objProducto != null)
            {
                Object[] row = { objProducto.pkProducto, objProducto.txtNombre, objProducto.txtCodigo, getDescuento(objProducto.decValorVenta), 1, getDescuento(objProducto.decValorVenta) };
                tblDetalleVenta.Rows.Add(row);
                tblDetalleVenta.Refresh();
                sumarTotalVenta();
                listaProductos.Add(objProducto);
            }
            tblDetalleVenta.Refresh();
            lblMontoTotal.Text = rellenarDecimales(sumarTotalVenta() + "");
        }
        public double sumarTotalVenta()
        {
            double total = 0;
            foreach (DataGridViewRow fila in tblDetalleVenta.Rows)
            {
                if (fila.Cells["txtSubTotal"] != null)
                    total += Convert.ToDouble(fila.Cells["txtSubTotal"].Value);
            }
            return total;
        }
        public int getNroFactura()
        {
            int num = 1;
            if (lastFactura != null)
            {
                if (lastFactura.txtNroAutorizacion.Equals(llave.txtNroAutorizacion))
                {
                    num = Convert.ToInt32(lastFactura.txtNroFactura) + 1;
                    return num;
                }
            }
            return num;
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
        private void cargarBoxDescuentos()
        {
            boxDescuentos.DataSource = DescuentoBLL.SelectAll();
            boxDescuentos.DisplayMember = "txtNombre";
            boxDescuentos.ValueMember = "pkDescuento";
        }
        public Producto getProductoOfList(string id)
        {
            int idProd = Convert.ToInt32(id);
            Producto p = null;
            foreach (Producto prod in listaProductos)
            {
                if (prod.pkProducto == idProd)
                    return prod;
            }
            return p;
        }
        public Bitmap generarQR()
        {
            QRCodeWriter qr = new QRCodeWriter();
            double dif = sumaReal - sumaDescuentos;
            string qrCode = "4648284010|";
            qrCode += getNroFactura() + "|";
            qrCode += llave.txtNroAutorizacion + "|";
            qrCode += DateTime.Now.ToShortDateString() + "|";
            qrCode += rellenarDecimales(sumaReal + "") + "|";
            if (dif == sumaReal)
                qrCode += rellenarDecimales(sumaReal + "") + "|";
            else
                qrCode += rellenarDecimales((sumaReal - dif) + "") + "|";
            qrCode += getCodigoControl() + "|";
            qrCode += txtNitCliente.Text + "|";
            qrCode += "0|0|0|";
            if (dif == sumaReal)
                qrCode += "0|";
            else
                qrCode += rellenarDecimales(dif + "");
            var matrix = qr.encode(qrCode, ZXing.BarcodeFormat.QR_CODE, 100, 100);

            ZXing.BarcodeWriter w = new ZXing.BarcodeWriter();

            w.Format = ZXing.BarcodeFormat.QR_CODE;

            Bitmap img = w.Write(matrix);

            return img;
        }
        public string getCodigoControl()
        {
            objControl = new CodigoControl();
            return objControl.Generar(llave.txtNroAutorizacion, getNroFactura() + "", txtNitCliente.Text, fecha, lblMontoTotal.Text, @llave.txtLlave);
        }
        public string generarCuerpoFactura()
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
            factura += "                   NRO. FACTURA: " + rellenarConCeros(5, getNroFactura() + "") + "\n";
            factura += "              NRO. AUTORIZACIÓN: " + llave.txtNroAutorizacion + "\n";
            factura += "------------------------------------------------------------------" + "\n";
            factura += "                     COMERCIO MINORISTA" + "\n";
            factura += "------------------------------------------------------------------" + "\n";
            factura += " FECHA: " + DateTime.Now.ToShortDateString() + "       " + DateTime.Now.ToShortTimeString() + "\n";
            factura += " NIT/CI: " + txtNitCliente.Text + "\n";
            factura += " SEÑOR(ES): " + txtNombreCliente.Text.ToUpper() + "\n";
            factura += "------------------------------------------------------------------" + "\n";
            factura += String.Format("{0,-20}  {1,-20}  {2}", "CANT.", "PRODUCTO", "SUB-TOTAL") + "\n";
            factura += "------------------------------------------------------------------" + "\n";
            foreach (DataGridViewRow fila in tblDetalleVenta.Rows)
            {
                if (fila.Cells["txtSubTotal"] != null)
                {
                    int a = -50;
                    if (fila.Cells["txtNombreProducto"].Value.ToString().Length >= 12 && !fila.Cells["txtNombreProducto"].Value.ToString().Contains("..."))
                    {
                        fila.Cells["txtNombreProducto"].Value = fila.Cells["txtNombreProducto"].Value.ToString().Substring(0, 12) + "...";
                    }
                    else
                    {
                        if (rellenarDecimales(fila.Cells["txtSubtotal"].Value.ToString()).Length == 5)
                        {
                            while (fila.Cells["txtNombreProducto"].Value.ToString().Length < 20)
                            {
                                fila.Cells["txtNombreProducto"].Value += " ";
                            }
                            if (!fila.Cells["txtNombreProducto"].Value.ToString().Contains("..."))
                            {
                                fila.Cells["txtNombreProducto"].Value += "...";
                            }
                        }
                        else
                        {
                            while (fila.Cells["txtNombreProducto"].Value.ToString().Length < 15)
                            {
                                fila.Cells["txtNombreProducto"].Value += " ";
                            }
                            if (!fila.Cells["txtNombreProducto"].Value.ToString().Contains("..."))
                            {
                                fila.Cells["txtNombreProducto"].Value += "...";
                            }
                        }
                    }
                    factura += String.Format("  {0,-20}  {1,-20}  {2,17}", fila.Cells["txtCantidad"].Value, fila.Cells["txtNombreProducto"].Value, rellenarDecimales(fila.Cells["txtSubtotal"].Value.ToString())) + "\n";
                    //factura += "     " + fila.Cells["txtCantidad"].Value + "       " + fila.Cells["txtNombreProducto"].Value.ToString().PadLeft(10) + " " + fila.Cells["txtSubtotal"].Value.ToString().PadLeft(10) + "\n";
                }
            }
            factura += "------------------------------------------------------------------" + "\n";
            if (lblMontoTotal.Text.Length == 7)
                factura += "                                               TOTAL BS. " + lblMontoTotal.Text + "\n";
            else
                factura += "                                                TOTAL BS. " + lblMontoTotal.Text + "\n";
            factura += "------------------------------------------------------------------" + "\n";
            factura += " SON: " + objLiteral.Convertir(lblMontoTotal.Text, true) + "\n";
            factura += " CÓDIGO DE CONTROL: " + getCodigoControl() + "\n";
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
        public void imprimirFactura()
        {
            string factura = generarCuerpoFactura();
            Bitmap qrCode = generarQR();
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
        public double getDescuento(decimal monto)
        {
            int pkD = Convert.ToInt32(boxDescuentos.SelectedValue);
            double desc = (100 - (DescuentoBLL.GetDescuentoById(pkD).descuento));
            return ((double)monto * (desc / 100));
        }
        #endregion
        #region Funciones relacionadas a Eventos
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            cambiar = txtCodigoProducto.Text;
            bool flag = false;
            foreach (DataGridViewRow fila in tblDetalleVenta.Rows)
            {
                if (fila.Cells["txtCodigo"] != null)
                {
                    if (fila.Cells["txtCodigo"].Value.ToString() == cambiar)
                    {
                        fila.Cells["txtCantidad"].Value = Convert.ToInt32(fila.Cells["txtCantidad"].Value) + 1;
                        fila.Cells["txtSubTotal"].Value = Convert.ToDouble(fila.Cells["txtPrecio"].Value) * Convert.ToDouble(fila.Cells["txtCantidad"].Value);
                        sumarTotalVenta();
                        flag = true;
                    }
                }
            }
            if (!flag)
                insertarFilaProducto();
            txtCodigoProducto.Text = "";
            if (txtCodigoProducto.Text != "")
            {
                cambiar = txtCodigoProducto.Text;
                insertarFilaProducto();
                txtCodigoProducto.Text = "";
            }
        }
        private void txtCodigoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cambiar = txtCodigoProducto.Text;
                bool flag = false;
                foreach (DataGridViewRow fila in tblDetalleVenta.Rows)
                {
                    if (fila.Cells["txtCodigo"] != null)
                    {
                        if (fila.Cells["txtCodigo"].Value.ToString() == cambiar)
                        {
                            fila.Cells["txtCantidad"].Value = Convert.ToInt32(fila.Cells["txtCantidad"].Value) + 1;
                            fila.Cells["txtSubTotal"].Value = Convert.ToDouble(fila.Cells["txtPrecio"].Value) * Convert.ToDouble(fila.Cells["txtCantidad"].Value);
                            sumarTotalVenta();
                            flag = true;
                        }
                    }
                }
                if (!flag)
                    insertarFilaProducto();
                txtCodigoProducto.Text = "";
            }
        }

        private void tblDetalleVenta_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow fila in tblDetalleVenta.Rows)
            {
                if (e.ColumnIndex == fila.Cells["txtCantidad"].ColumnIndex)
                {
                    if (ProductoBLL.GetValidarProducto(Convert.ToInt16(fila.Cells["idProducto"].Value.ToString()), Convert.ToInt32(fila.Cells["txtCantidad"].Value.ToString())) != null)
                    {
                        if (fila.Cells["txtSubTotal"] != null)
                            fila.Cells["txtSubTotal"].Value = Convert.ToDouble(fila.Cells["txtPrecio"].Value) * Convert.ToDouble(fila.Cells["txtCantidad"].Value);
                    }
                    else
                    {
                        MessageBox.Show("La cantidad que solicita no se encuentra en el stock");
                    }
                }
            }
            lblMontoTotal.Text = rellenarDecimales(sumarTotalVenta() + "");
            tblDetalleVenta.Refresh();
        }

        private void txtNombreCliente_Click(object sender, EventArgs e)
        {
            cargarNombreCliente();
        }

        private void tblDetalleVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == btnEliminar.Index)
            {
                tblDetalleVenta.Rows.RemoveAt(e.RowIndex);
                sumarTotalVenta();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validarStock() == true)
            {
                if (txtNitCliente.Text != "" && txtNombreCliente.Text != "" && tblDetalleVenta.RowCount > 0)
                {
                    string nroFact = getNroFactura().ToString();
                    int idCliente;
                    if (objCliente == null)
                    {
                        int idPersona = PersonaBLL.InsertDatosPersona(txtNitCliente.Text, txtNombreCliente.Text, "", "", "", "", 1);
                        idCliente = ClienteBLL.InsertDatosCliente(idPersona, 1);
                    }
                    else
                    {
                        idCliente = objCliente.pkCliente;
                    }
                    int idFactura = 0;
                    if (llave != null && llave.txtLlave != "")
                    {
                        idFactura = FacturaBLL.InsertarFactura(0, idCliente, 2, Convert.ToInt32(boxDescuentos.SelectedValue), 1, nroFact, llave.txtNroAutorizacion, llave.txtLlave, Convert.ToDecimal(sumarTotalVenta()), 1);
                    }
                    else
                    {
                        MessageBox.Show("USTED NO HA INGRESADO LA LLAVE NI EL CODIGO DE AUTORIZACIÓN DE LA FACTURA");
                        return;
                    }
                    foreach (DataGridViewRow fila in tblDetalleVenta.Rows)
                    {
                        if (Convert.ToInt32(fila.Cells["txtCantidad"].Value.ToString()) > 0)
                        {
                            if (fila.Cells["idProducto"] != null)
                            {
                                GananciasDTO ganancias = new GananciasDTO();
                                ganancias.fkProducto = Convert.ToInt32(fila.Cells["idProducto"].Value.ToString());
                                ganancias.intCantidad = Convert.ToInt32(fila.Cells["txtCantidad"].Value.ToString());
                                Producto pro = ProductoBLL.GetProductById(ganancias.fkProducto);
                                ganancias.decValorVenta = pro.decValorVenta;
                                ganancias.decValorCompra = pro.decValorCompra;
                                ganancias.decTotal = Convert.ToDecimal(fila.Cells["txtSubTotal"].Value.ToString());
                                DetalleVentaBLL.InsertarDetalleVenta(0, Convert.ToInt32(fila.Cells["idProducto"].Value.ToString()), idFactura, Convert.ToInt32(fila.Cells["txtCantidad"].Value.ToString()), Convert.ToDecimal(fila.Cells["txtSubTotal"].Value.ToString()));
                                GananciasBLL.InsertObjetoGanancias(ganancias);
                                Producto auxProducto = getProductoOfList(fila.Cells["idProducto"].Value.ToString());
                                auxProducto.intCantidad -= Convert.ToInt32(fila.Cells["txtCantidad"].Value.ToString());
                                ProductoBLL.UpdateProducto(auxProducto);
                                sumaReal += (double)auxProducto.decValorVenta * Convert.ToInt32(fila.Cells["txtCantidad"].Value.ToString());
                                sumaDescuentos += Convert.ToDouble(fila.Cells["txtSubTotal"].Value.ToString());
                            }
                        }
                        else
                        {
                            MessageBox.Show("Usted a ingresado una cantidad de 0");
                            return;
                        }
                    }
                    if (lastLibroVenta != null)
                    {
                        if (lastLibroVenta.txtMes == DateTime.Now.Month.ToString() && lastLibroVenta.txtAño == DateTime.Now.Year.ToString())
                        {
                            List<DetalleLibroVentas> lista = DetalleLibroVentasBLL.GetDetalleLibroVentasByIdLibro(lastLibroVenta.pkLibro);
                            int lastNro = 0;
                            if (lista.Count != 0)
                            {
                                lastNro = lista[(lista.Count - 1)].intNro;
                            }
                            if (sumaReal == sumaDescuentos)
                            {
                                sumaDescuentos = 0;
                            }
                            double dif = sumaReal - sumaDescuentos;
                            double db = 0;
                            if (dif == sumaReal)
                            {
                                db = sumaReal * 13 / 100;
                            }
                            else
                            {
                                db = (sumaReal - dif) * 13 / 100;
                            }
                            DetalleLibroVentasBLL.InsertDatosDetalleLibroVentas(lastNro + 1, DateTime.Now, nroFact, llave.txtNroAutorizacion, txtNitCliente.Text, txtNombreCliente.Text, Convert.ToDecimal(sumaReal), 0, 0, 0, Convert.ToDecimal(sumaReal), (dif == sumaReal) ? 0 : Convert.ToDecimal(dif), (dif == sumaReal) ? Convert.ToDecimal(sumaReal) : Convert.ToDecimal(sumaReal - dif), Convert.ToDecimal(db), getCodigoControl(), lastLibroVenta.pkLibro, 1);
                        }
                        else
                        {
                            int pkLibro = LibroVentasBLL.InsertDatosLibroVentas(DateTime.Now.Month.ToString(), DateTime.Now.Year.ToString());
                            int lastNro = 0;
                            if (sumaReal == sumaDescuentos)
                            {
                                sumaDescuentos = 0;
                            }
                            double dif = sumaReal - sumaDescuentos;
                            double db = 0;
                            if (dif == sumaReal)
                            {
                                db = sumaReal * 13 / 100;
                            }
                            else
                            {
                                db = (sumaReal - dif) * 13 / 100;
                            }
                            DetalleLibroVentasBLL.InsertDatosDetalleLibroVentas(lastNro + 1, DateTime.Now, nroFact, llave.txtNroAutorizacion, txtNitCliente.Text, txtNombreCliente.Text, Convert.ToDecimal(sumaReal), 0, 0, 0, Convert.ToDecimal(sumaReal), (dif == sumaReal) ? 0 : Convert.ToDecimal(dif), (dif == sumaReal) ? Convert.ToDecimal(sumaReal) : Convert.ToDecimal(sumaReal - dif), Convert.ToDecimal(db), getCodigoControl(), pkLibro, 1);
                        }
                    }
                    else
                    {
                        int pkLibro = LibroVentasBLL.InsertDatosLibroVentas(DateTime.Now.Month.ToString(), DateTime.Now.Year.ToString());
                        int lastNro = 0;
                        if (sumaReal == sumaDescuentos)
                        {
                            sumaDescuentos = 0;
                        }
                        double dif = sumaReal - sumaDescuentos;
                        double db = 0;
                        if (dif == sumaReal)
                        {
                            db = sumaReal * 13 / 100;
                        }
                        else
                        {
                            db = (sumaReal - dif) * 13 / 100;
                        }
                        DetalleLibroVentasBLL.InsertDatosDetalleLibroVentas(lastNro + 1, DateTime.Now, nroFact, llave.txtNroAutorizacion, txtNitCliente.Text, txtNombreCliente.Text, Convert.ToDecimal(sumaReal), 0, 0, 0, Convert.ToDecimal(sumaReal), (dif == sumaReal) ? 0 : Convert.ToDecimal(dif), (dif == sumaReal) ? Convert.ToDecimal(sumaReal) : Convert.ToDecimal(sumaReal - dif), Convert.ToDecimal(db), getCodigoControl(), pkLibro, 1);
                    }
                    if (original == " COPIA")
                        original = "ORIGINAL";
                    imprimirFactura();
                    original = " COPIA";
                    imprimirFactura();
                    tblDetalleVenta.RowCount = 0;
                    txtNitCliente.Text = "";
                    txtNombreCliente.Text = "";
                    sumaReal = 0;
                    sumaDescuentos = 0;
                    lastFactura = FacturaBLL.GetLastFactura();
                    llave = LlaveFacturaBLL.GetLastLlaveFactura();
                    lastFactura = FacturaBLL.GetLastFactura();
                    lastLibroVenta = LibroVentasBLL.GetLastLibroVentas();
                    listaProductos = new List<Producto>();
                }
                else
                {
                    MessageBox.Show("Debe ingresar el nit, el nombre del cliente y al menos un producto");
                }
            }
        }

        public bool validarStock()
        {
            foreach (DataGridViewRow fila in tblDetalleVenta.Rows)
            {
                if (ProductoBLL.GetValidarProducto(Convert.ToInt16(fila.Cells["idProducto"].Value.ToString()), Convert.ToInt32(fila.Cells["txtCantidad"].Value.ToString())) != null)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion
    }
}
