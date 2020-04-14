using AppSales.DAL;
using AppSales.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSales.BLL
{
    public class VariacionPrecioProductosBLL
    {
        public VariacionPrecioProductosBLL()
        {

        }

        public static VariacionesPrecioProductos rowToDto(VariacionPrecioProductoDS.VariacionesPrecioProductoRow row)
        {
            VariacionesPrecioProductos objVariaciones = new VariacionesPrecioProductos();
            objVariaciones.pkVariation = row.pkVariacion;
            objVariaciones.fkProducto = row.fkProducto;
            objVariaciones.intCantidad = row.intCantidad;
            objVariaciones.decValorCompra = row.decValorCompra;
            objVariaciones.decValorVenta = row.decValorVenta;
            return objVariaciones;
        }

        public static List<VariacionesPrecioProductos> SelectAll()
        {
            List<VariacionesPrecioProductos> listadeVariacionesPrecios = new List<VariacionesPrecioProductos>();
            AppSales.DAL.VariacionPrecioProductoDSTableAdapters.VariacionesPrecioProductoTableAdapter objDataSet = new AppSales.DAL.VariacionPrecioProductoDSTableAdapters.VariacionesPrecioProductoTableAdapter();
            VariacionPrecioProductoDS.VariacionesPrecioProductoDataTable dtVariacion = objDataSet.GetAllVariacionPrecioProducto();

            foreach (VariacionPrecioProductoDS.VariacionesPrecioProductoRow row in dtVariacion)
            {
                VariacionesPrecioProductos objVariacion = rowToDto(row);
                listadeVariacionesPrecios.Add(objVariacion);
            }
            return listadeVariacionesPrecios;
        }

        public static int InsertObjetoVariacion(VariacionesPrecioProductos objVariacion)
        {
            return InsertDatosVariacion(objVariacion.fkProducto, objVariacion.intCantidad, objVariacion.decValorCompra, objVariacion.decValorVenta);
        }


        public static int InsertDatosVariacion(int fkProducto, int cantidad, decimal valorCompra, decimal valorVenta)
        {

            AppSales.DAL.VariacionPrecioProductoDSTableAdapters.VariacionesPrecioProductoTableAdapter objDataSet = new AppSales.DAL.VariacionPrecioProductoDSTableAdapters.VariacionesPrecioProductoTableAdapter();
            int? VariacionId = 0;
            objDataSet.Insert_variacionesPrecioProducto(ref VariacionId, fkProducto, cantidad, valorCompra, valorVenta);

            return (int)VariacionId;
        }
    }
}
