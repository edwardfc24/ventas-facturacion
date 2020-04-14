using AppSales.DAL;
using AppSales.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSales.BLL
{
    public class TallaBLL
    {
        public static Talla rowToDto(TallaDS.TallasRow row)
        {
            Talla objTalla = new Talla();
            objTalla.pkTalla = row.pkTalla;
            objTalla.txtNombre = row.txtNombre;
            return objTalla;
        }

        public static List<Talla> SelectAll()
        {
            List<Talla> listadeTallas = new List<Talla>();
            AppSales.DAL.TallaDSTableAdapters.TallasTableAdapter objDataSet = new AppSales.DAL.TallaDSTableAdapters.TallasTableAdapter();
            TallaDS.TallasDataTable dtTallas = objDataSet.GetAllSizes();

            foreach (TallaDS.TallasRow row in dtTallas)
            {
                Talla objTallas = rowToDto(row);
                listadeTallas.Add(objTallas);
            }
            return listadeTallas;
        }

        public static int InsertarTalla(int? idTalla, string nombre, int idUsuario)
        {

            AppSales.DAL.TallaDSTableAdapters.TallasTableAdapter objDataSet = new AppSales.DAL.TallaDSTableAdapters.TallasTableAdapter();
            objDataSet.InsertSize(ref idTalla, nombre, idUsuario);
            return (int)idTalla;
        }

        public static void UpdateTalla(int pkTalla, string nombre, int usuarioModificacion)
        {
            AppSales.DAL.TallaDSTableAdapters.TallasTableAdapter objDataSet = new AppSales.DAL.TallaDSTableAdapters.TallasTableAdapter();

            objDataSet.UpdateSize(pkTalla, nombre, usuarioModificacion);
        }

        public static void DeleteTalla(int id)
        {
            AppSales.DAL.TallaDSTableAdapters.TallasTableAdapter objDataSet = new AppSales.DAL.TallaDSTableAdapters.TallasTableAdapter();
            objDataSet.DeleteSize(id);
        }
    }
}
