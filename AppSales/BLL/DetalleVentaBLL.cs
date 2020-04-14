using AppSales.DAL;
using AppSales.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSales.BLL
{
    public class DetalleVentaBLL
    {
        public static DetalleVenta rowToDto(DetalleVentaDS.DetalleVentasRow row)
        {
            DetalleVenta objDetalleVenta = new DetalleVenta();
            objDetalleVenta.pkDetalleVenta = row.pkDetalleVenta;
            objDetalleVenta.fkProducto = row.fkProducto;
            objDetalleVenta.fkFactura = row.fkFactura;
            objDetalleVenta.intCantidad = row.intCantidad;
            objDetalleVenta.decimalTotal = row.decimalTotal;
            return objDetalleVenta;
        }
        public static List<DetalleVenta> GetAllDetalleVentas()
        {
            List<DetalleVenta> listDetalleVentas = new List<DetalleVenta>();
            AppSales.DAL.DetalleVentaDSTableAdapters.DetalleVentasTableAdapter objDataSet = new AppSales.DAL.DetalleVentaDSTableAdapters.DetalleVentasTableAdapter();
            DetalleVentaDS.DetalleVentasDataTable dtDetalleVenta = objDataSet.GetAllDetailSales();

            foreach (DetalleVentaDS.DetalleVentasRow row in dtDetalleVenta)
            {
                DetalleVenta objDetalleVenta = rowToDto(row);
                listDetalleVentas.Add(objDetalleVenta);
            }
            return listDetalleVentas;
        }
        public static int InsertarDetalleVenta(int? idDetalleVenta, int fkProducto, int fkFactura, int intCantidad, decimal decimalTotal)
        {

            AppSales.DAL.DetalleVentaDSTableAdapters.DetalleVentasTableAdapter objDataSet = new AppSales.DAL.DetalleVentaDSTableAdapters.DetalleVentasTableAdapter();
            objDataSet.InsertDetailSale(ref idDetalleVenta, fkProducto, fkFactura, intCantidad, decimalTotal);
            return (int)idDetalleVenta;
        }
        public static List<DetalleVenta> GetDetalleVentaByIDFactura(int fkFactura)
        {
            List<DetalleVenta> listDetalleVentas = new List<DetalleVenta>();
            AppSales.DAL.DetalleVentaDSTableAdapters.DetalleVentasTableAdapter objDataSet = new AppSales.DAL.DetalleVentaDSTableAdapters.DetalleVentasTableAdapter();
            DetalleVentaDS.DetalleVentasDataTable dtDetalleVenta = objDataSet.GetDetailSaleByIdBill(fkFactura);

            foreach (DetalleVentaDS.DetalleVentasRow row in dtDetalleVenta)
            {
                DetalleVenta objDetalleVenta = rowToDto(row);
                listDetalleVentas.Add(objDetalleVenta);
            }
            return listDetalleVentas;
        }
    }
}
