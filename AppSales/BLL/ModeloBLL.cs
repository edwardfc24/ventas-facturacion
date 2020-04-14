using AppSales.DAL;
using AppSales.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSales.BLL
{
    public class ModeloBLL
    {
        public static Modelo rowToDto(ModeloDS.ModelosRow row)
        {
            Modelo objModelo = new Modelo();
            objModelo.pkModelo = row.pkModelo;
            objModelo.txtNombre = row.txtNombre;
            return objModelo;
        }

        public static List<Modelo> SelectAll()
        {
            List<Modelo> listadeModelos = new List<Modelo>();
            AppSales.DAL.ModeloDSTableAdapters.ModelosTableAdapter objDataSet = new AppSales.DAL.ModeloDSTableAdapters.ModelosTableAdapter();
            ModeloDS.ModelosDataTable dtModelos = objDataSet.GetAllModels();

            foreach (ModeloDS.ModelosRow row in dtModelos)
            {
                Modelo objModelos = rowToDto(row);
                listadeModelos.Add(objModelos);
            }
            return listadeModelos;
        }

        public static int InsertarModelo(int? idModelo, string nombre, int idUsuario)
        {

            AppSales.DAL.ModeloDSTableAdapters.ModelosTableAdapter objDataSet = new AppSales.DAL.ModeloDSTableAdapters.ModelosTableAdapter();
            objDataSet.InsertModel(ref idModelo, nombre, idUsuario);
            return (int)idModelo;
        }

        public static void UpdateModelo(int pkModelo, string nombre, int usuarioModificacion)
        {
            AppSales.DAL.ModeloDSTableAdapters.ModelosTableAdapter objDataSet = new AppSales.DAL.ModeloDSTableAdapters.ModelosTableAdapter();

            objDataSet.UpdateModel(pkModelo, nombre, usuarioModificacion);
        }

        public static void DeleteModelo(int id)
        {
            AppSales.DAL.ModeloDSTableAdapters.ModelosTableAdapter objDataSet = new AppSales.DAL.ModeloDSTableAdapters.ModelosTableAdapter();
            objDataSet.DeleteModel(id);
        }
    }
}
