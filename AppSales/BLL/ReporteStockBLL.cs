using AppSales.DTO;
using AppSales.ReportesDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSales.BLL
{
    public class ReporteStockBLL
    {
        public ReporteStockBLL()
        {

        }

        public static ReporteStock rowToDto(StockProductoDS.StockProductosRow row)
        {
            ReporteStock objCliente = new ReporteStock();
            objCliente.txtCodigo = row.txtCodigo;
            objCliente.txtNombre = row.txtNombre;
            objCliente.txtDescripcion = row.txtDescripcion;
            objCliente.intCantidad = row.intCantidad;
            return objCliente;
        }

        public static List<ReporteStock> SelectAll()
        {
            List<ReporteStock> listadeClientes = new List<ReporteStock>();
            AppSales.ReportesDAL.StockProductoTableAdapters.StockProductosTableAdapter objDataSet = new AppSales.ReportesDAL.StockProductoTableAdapters.StockProductosTableAdapter();
            StockProductoDS.StockProductosDataTable dtClientes = objDataSet.GetStockProductos();

            foreach (StockProductoDS.StockProductosRow row in dtClientes)
            {
                ReporteStock objCliente = rowToDto(row);
                listadeClientes.Add(objCliente);
            }
            return listadeClientes;
        }

    }
}
