using AppSales.DAL;
using AppSales.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSales.BLL
{
    public class MonedaBLL
    {
         public MonedaBLL()
        { }

        public static Moneda rowToDto(MonedaDS.MonedasRow row)
        {
            Moneda objMoneda = new Moneda();
            objMoneda.pkMoneda = row.pkMoneda;
            objMoneda.decTipoCambio = row.decTipoCambio;
            return objMoneda;
        }
        public static List<Moneda> SelectAll()
        {
            List<Moneda> listadeMonedas = new List<Moneda>();
            AppSales.DAL.MonedaDSTableAdapters.MonedasTableAdapter objDataSet = new AppSales.DAL.MonedaDSTableAdapters.MonedasTableAdapter();
            MonedaDS.MonedasDataTable dtMoneda = objDataSet.GetAllCoins();

            foreach (MonedaDS.MonedasRow row in dtMoneda)
            {
                Moneda objMoneda = rowToDto(row);
                listadeMonedas.Add(objMoneda);
            }
            return listadeMonedas;
        }
        public static int InsertObjetoMoneda(Moneda objMoneda)
        {
            return InsertDatosMoneda(objMoneda.decTipoCambio,objMoneda.pkMoneda);
        }


        public static int InsertDatosMoneda(decimal tipo, int idUsuarioC)
        {

            AppSales.DAL.MonedaDSTableAdapters.MonedasTableAdapter objDataSet = new AppSales.DAL.MonedaDSTableAdapters.MonedasTableAdapter();
            int? MonedaId = 0;

            //objDataSet.Insert1(ref empleadoId, nombre, apellido, ci, fechanac, password, direccion, telefono, correo, fechaContrato, estado, tipo);
            objDataSet.InsertCoin(ref MonedaId, tipo, idUsuarioC);

            return (int)MonedaId;
        }

        public static Moneda GetMonedaById(int pk)
        {
            AppSales.DAL.MonedaDSTableAdapters.MonedasTableAdapter objDataSet = new AppSales.DAL.MonedaDSTableAdapters.MonedasTableAdapter();
            MonedaDS.MonedasDataTable dtMoneda = objDataSet.GetCoinByID(pk);
            Moneda objMoneda = rowToDto(dtMoneda[0]);

            return objMoneda;
        }
        public static void UpdateMoneda(Moneda objMoneda)
        {
            UpdateMoneda(objMoneda.pkMoneda, objMoneda.decTipoCambio,objMoneda.idUsuario);
        }

        public static void UpdateMoneda(int? pk, decimal tipo,int idUsuarioM)
        {
            AppSales.DAL.MonedaDSTableAdapters.MonedasTableAdapter objDataSet = new AppSales.DAL.MonedaDSTableAdapters.MonedasTableAdapter();

            objDataSet.UpdateCoin(pk,tipo,idUsuarioM);
        }
        public static void DeleteMoneda(int id)
        {
            AppSales.DAL.MonedaDSTableAdapters.MonedasTableAdapter objDataSet = new AppSales.DAL.MonedaDSTableAdapters.MonedasTableAdapter();
           objDataSet.DeleteCoin(id);
        }
    
    }
}
