using AppSales.DAL;
using AppSales.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSales.BLL
{
    public class FacturaBLL
    {
        public static Factura rowToDto(FacturaDS.FacturasRow row)
        {
            Factura objFactura = new Factura();
            objFactura.pkFactura = row.pkFactura;
            objFactura.fkCliente = row.fkCliente;
            objFactura.fkEmpleado = row.fkEmpleado;
            objFactura.fkDescuento = row.fkDescuento;
            objFactura.fkMoneda = row.fkMoneda;
            objFactura.txtNroFactura = row.txtNroFactura;
            objFactura.txtNroAutorizacion = row.txtNroAutorizacion;
            objFactura.txtLLave = row.txtLlave;
            objFactura.decTotal = row.decTotal;
            objFactura.idUsuario = row.intIdUsuarioCreacion;
            return objFactura;
        }
        public static List<Factura> GetAllFacturas()
        {
            List<Factura> listFacturas = new List<Factura>();
            AppSales.DAL.FacturaDSTableAdapters.FacturasTableAdapter objDataSet = new AppSales.DAL.FacturaDSTableAdapters.FacturasTableAdapter();
            FacturaDS.FacturasDataTable dtFactura = objDataSet.GetAllSales();

            foreach (FacturaDS.FacturasRow row in dtFactura)
            {
                Factura objFactura = rowToDto(row);
                listFacturas.Add(objFactura);
            }
            return listFacturas;
        }
        public static int InsertarFactura(int? idFactura, int fkCliente, int fkEmpleado, int fkDescuento, int fkMoneda, string nroFactura, string nroAutorizacion, string llave, decimal total, int idUsuario)
        {

            AppSales.DAL.FacturaDSTableAdapters.FacturasTableAdapter objDataSet = new AppSales.DAL.FacturaDSTableAdapters.FacturasTableAdapter();
            objDataSet.InsertSale(ref idFactura, fkCliente, 2, fkDescuento, fkMoneda, nroFactura, nroAutorizacion, llave, total, idUsuario);
            return (int)idFactura;
        }
        public static Factura GetFacturaByID(int pk)
        {
            AppSales.DAL.FacturaDSTableAdapters.FacturasTableAdapter objDataSet = new AppSales.DAL.FacturaDSTableAdapters.FacturasTableAdapter();
            FacturaDS.FacturasDataTable dtFactura = objDataSet.GetSaleByID(pk);
            Factura objFactura = rowToDto(dtFactura[0]);

            return objFactura;
        }
        public static Factura GetLastFactura()
        {
            AppSales.DAL.FacturaDSTableAdapters.FacturasTableAdapter objDataSet = new AppSales.DAL.FacturaDSTableAdapters.FacturasTableAdapter();
            FacturaDS.FacturasDataTable dtFactura = objDataSet.GetLastSale();
            if (dtFactura.Count > 0)
            {
                Factura objFactura = rowToDto(dtFactura[0]);
                return objFactura;
            }
            return null;
        }
    }
}
