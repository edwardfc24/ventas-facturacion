using AppSales.DAL;
using AppSales.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSales.BLL
{
    public class MarcaBLL
    {
        public static Marca rowToDto(MarcaDS.MarcasRow row)
        {
            Marca objMarca = new Marca();
            objMarca.pkMarca = row.pkMarca;
            objMarca.txtNombre = row.txtNombre;
            return objMarca;
        }

        public static List<Marca> SelectAll()
        {
            List<Marca> listadeMarcas = new List<Marca>();
            AppSales.DAL.MarcaDSTableAdapters.MarcasTableAdapter objDataSet = new AppSales.DAL.MarcaDSTableAdapters.MarcasTableAdapter();
            MarcaDS.MarcasDataTable dtMarcas = objDataSet.GetAllMarks();

            foreach (MarcaDS.MarcasRow row in dtMarcas)
            {
                Marca objMarcas = rowToDto(row);
                listadeMarcas.Add(objMarcas);
            }
            return listadeMarcas;
        }

        public static int InsertarMarca(int? idMarca, string nombre, int idUsuario)
        {

            AppSales.DAL.MarcaDSTableAdapters.MarcasTableAdapter objDataSet = new AppSales.DAL.MarcaDSTableAdapters.MarcasTableAdapter();
            objDataSet.InsertMark(ref idMarca, nombre, idUsuario);
            return (int)idMarca;
        }

        public static void UpdateMarca(int pkMarca, string nombre, int usuarioModificacion)
        {
            AppSales.DAL.MarcaDSTableAdapters.MarcasTableAdapter objDataSet = new AppSales.DAL.MarcaDSTableAdapters.MarcasTableAdapter();

            objDataSet.UpdateMark(pkMarca,nombre,usuarioModificacion);
        }

        public static void DeleteMarca(int id)
        {
            AppSales.DAL.MarcaDSTableAdapters.MarcasTableAdapter objDataSet = new AppSales.DAL.MarcaDSTableAdapters.MarcasTableAdapter();
            objDataSet.DeleteMark(id);
        }
    }
}
