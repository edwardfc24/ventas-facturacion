using AppSales.DAL;
using AppSales.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSales.BLL
{
    public class DescuentoBLL
    {
        public static Descuento rowToDto(DescuentoDS.DiscountsRow row)
        {
            Descuento objDescuento = new Descuento();
            objDescuento.pkDescuento = row.pkDescuento;
            objDescuento.txtNombre = row.txtNombre;
            objDescuento.dateFechaInicio = row.dateFechaInicio;
            objDescuento.dateFechaFin = row.dateFechaFin;
            objDescuento.descuento = row.intDescuento;
            objDescuento.descripcion = row.txtDescripcion;
            return objDescuento;
        }
        public static List<Descuento> SelectAll()
        {
            List<Descuento> listadeDescuentos = new List<Descuento>();
            AppSales.DAL.DescuentoDSTableAdapters.DiscountsTableAdapter objDataSet = new AppSales.DAL.DescuentoDSTableAdapters.DiscountsTableAdapter();
            DescuentoDS.DiscountsDataTable dtDescuentos = objDataSet.GetAllDiscounts();

            foreach (DescuentoDS.DiscountsRow row in dtDescuentos)
            {
                Descuento objDescuento = rowToDto(row);
                listadeDescuentos.Add(objDescuento);
            }
            return listadeDescuentos;
        }
        public static int InsertObjetoDescuento(Descuento objDescuento)
        {
            return InsertDatosDescuento(objDescuento.txtNombre, objDescuento.dateFechaInicio, objDescuento.dateFechaFin, objDescuento.descuento, objDescuento.descripcion,objDescuento.intIdUsuarioCreacion);
        }


        public static int InsertDatosDescuento(string nombre, DateTime dateFechaInicio, DateTime dateFechaFin, int descuentos, string txtDescripcion,int intUsuario )
        {

            AppSales.DAL.DescuentoDSTableAdapters.DiscountsTableAdapter objDataSet = new AppSales.DAL.DescuentoDSTableAdapters.DiscountsTableAdapter();
            int? DescuentoId = 0;

            objDataSet.InsertDiscount(ref DescuentoId, nombre, dateFechaInicio, dateFechaFin, descuentos,txtDescripcion,intUsuario);

            return (int)DescuentoId;
        }

        public static Descuento GetDescuentoById(int pk)
        {
            AppSales.DAL.DescuentoDSTableAdapters.DiscountsTableAdapter objDataSet = new AppSales.DAL.DescuentoDSTableAdapters.DiscountsTableAdapter();
            DescuentoDS.DiscountsDataTable dtDescuento = objDataSet.GetDiscountByID(pk);
            Descuento objDescuento = rowToDto(dtDescuento[0]);

            return objDescuento;
        }

        public static void UpdateDescuento(Descuento objDescuento)
        {
            UpdateDiscounts(objDescuento.pkDescuento, objDescuento.txtNombre,objDescuento.dateFechaInicio,objDescuento.dateFechaFin,objDescuento.descuento,objDescuento.descripcion,objDescuento.intIdUsuarioModificacion);
        }

        public static void UpdateDiscounts(int pkDescuento, string nombre, DateTime fechaInicio, DateTime fechaFin, int descuento, string descripcion, int usuario)
        {
            AppSales.DAL.DescuentoDSTableAdapters.DiscountsTableAdapter objDataSet = new AppSales.DAL.DescuentoDSTableAdapters.DiscountsTableAdapter();

            objDataSet.UpdateDiscount(pkDescuento,nombre,fechaInicio,fechaFin,descuento,descripcion,usuario);
        }
        public static void DeleteDescuento(int id)
        {
            AppSales.DAL.DescuentoDSTableAdapters.DiscountsTableAdapter objDataSet = new AppSales.DAL.DescuentoDSTableAdapters.DiscountsTableAdapter();
            objDataSet.DeleteDiscount(id);
        }
    }

}
