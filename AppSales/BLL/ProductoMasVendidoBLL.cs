using AppSales.DAL;
using AppSales.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSales.BLL
{
    public class ProductoMasVendidoBLL
    {
        public static ProductoMasVendido rowToDto(MasVendidoDS.ProductoMasVendidoRow row)
        {
            ProductoMasVendido objProductoMasVendido = new ProductoMasVendido();
            objProductoMasVendido.txtNombre = row.txtNombre;
            objProductoMasVendido.txtNombreMarca = row.txtNombreMarca;
            objProductoMasVendido.txtNombreTalla = row.txtNombreTalla;
            objProductoMasVendido.intCantidad = row.intCantidad;
            return objProductoMasVendido;
        }
        public static List<ProductoMasVendido> SelectAll()
        {
            List<ProductoMasVendido> listadeProductoMasVendidos = new List<ProductoMasVendido>();
            AppSales.DAL.MasVendidoDSTableAdapters.ProductoMasVendidoTableAdapter objDataSet = new AppSales.DAL.MasVendidoDSTableAdapters.ProductoMasVendidoTableAdapter();
            MasVendidoDS.ProductoMasVendidoDataTable dtProductoMasVendidos = objDataSet.GetProductsMoreSale();

            foreach (MasVendidoDS.ProductoMasVendidoRow row in dtProductoMasVendidos)
            {
                ProductoMasVendido objProductoMasVendido = rowToDto(row);
                listadeProductoMasVendidos.Add(objProductoMasVendido);
            }
            return listadeProductoMasVendidos;
        }
    }
}
