using AppSales.DAL;
using AppSales.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSales.BLL
{
    public class GananciasBLL
    {
        public GananciasBLL()
        {

        }

        public static GananciasDTO rowToDto(GananciasDS.GananciasRow row)
        {
            GananciasDTO objGanancias = new GananciasDTO();
            objGanancias.pkGanancias = row.pkGanancias;
            objGanancias.fkProducto = row.fkProducto;
            objGanancias.intCantidad = row.intCantidad;
            objGanancias.decValorCompra = row.decValorCompra;
            objGanancias.decValorVenta = row.decValorVenta;
            objGanancias.decTotal = row.decTotal;
            return objGanancias;
        }

        public static List<GananciasDTO> SelectAll()
        {
            List<GananciasDTO> listadeGanancias = new List<GananciasDTO>();
            AppSales.DAL.GananciasDSTableAdapters.GananciasTableAdapter objDataSet = new AppSales.DAL.GananciasDSTableAdapters.GananciasTableAdapter();
            GananciasDS.GananciasDataTable dtGanancias = objDataSet.GetAllGanancias();

            foreach (GananciasDS.GananciasRow row in dtGanancias)
            {
                GananciasDTO objGanancias = rowToDto(row);
                listadeGanancias.Add(objGanancias);
            }
            return listadeGanancias;
        }

        public static int InsertObjetoGanancias(GananciasDTO objGanancias)
        {
            return InsertDatosGanancias(objGanancias.fkProducto, objGanancias.intCantidad, objGanancias.decValorVenta, objGanancias.decValorCompra, objGanancias.decTotal);
        }


        public static int InsertDatosGanancias(int fkProducto, int intCatidad, decimal decValorVenta, decimal decValorCompra, decimal decTotal)
        {

            AppSales.DAL.GananciasDSTableAdapters.GananciasTableAdapter objDataSet = new AppSales.DAL.GananciasDSTableAdapters.GananciasTableAdapter();
            int? GananciasId = 0;

            objDataSet.Insert_Ganancias(ref GananciasId, fkProducto, intCatidad, decValorCompra, decValorVenta, decTotal);

            return (int)GananciasId;
        }
    }
}
