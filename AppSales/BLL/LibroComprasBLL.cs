using AppSales.DAL;
using AppSales.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSales.BLL
{
    public class LibroComprasBLL
    {
        public static LibroCompras rowToDto(LibroComprasDS.LibroComprasRow row)
        {
            LibroCompras objLibroCompras = new LibroCompras();
            objLibroCompras.pkLibro = row.pkLibro;
            objLibroCompras.txtMes = row.txtMes;
            objLibroCompras.txtAño = row.txtAño;
            return objLibroCompras;
        }
        public static List<LibroCompras> SelectAll()
        {
            List<LibroCompras> listadeLibroCompras = new List<LibroCompras>();
            AppSales.DAL.LibroComprasDSTableAdapters.LibroComprasTableAdapter objDataSet = new AppSales.DAL.LibroComprasDSTableAdapters.LibroComprasTableAdapter();
            LibroComprasDS.LibroComprasDataTable dtLibroCompras = objDataSet.GetAllLibroCompras();

            foreach (LibroComprasDS.LibroComprasRow row in dtLibroCompras)
            {
                LibroCompras objLibroCompras = rowToDto(row);
                listadeLibroCompras.Add(objLibroCompras);
            }
            return listadeLibroCompras;
        }
        public static int InsertObjetoLibroCompras(LibroCompras objLibroCompras)
        {
            return InsertDatosLibroCompras(objLibroCompras.txtMes, objLibroCompras.txtAño);
        }


        public static int InsertDatosLibroCompras(string mes, string año)
        {

            AppSales.DAL.LibroComprasDSTableAdapters.LibroComprasTableAdapter objDataSet = new AppSales.DAL.LibroComprasDSTableAdapters.LibroComprasTableAdapter();
            int? LibroComprasId = 0;

            //objDataSet.Insert1(ref empleadoId, nombre, apellido, ci, fechanac, password, direccion, telefono, correo, fechaContrato, estado, tipo);
            objDataSet.InsertLibroCompras(ref LibroComprasId, mes, año);

            return (int)LibroComprasId;
        }

        public static LibroCompras GetLibroComprasById(int pk)
        {
            AppSales.DAL.LibroComprasDSTableAdapters.LibroComprasTableAdapter objDataSet = new AppSales.DAL.LibroComprasDSTableAdapters.LibroComprasTableAdapter();
            LibroComprasDS.LibroComprasDataTable dtLibroCompras = objDataSet.GetLibroCompraByID(pk);
            LibroCompras objLibroCompras = rowToDto(dtLibroCompras[0]);

            return objLibroCompras;
        }

        public static void UpdateLibroCompras(LibroCompras objLibroCompras)
        {
            UpdateEmployee(objLibroCompras.pkLibro, objLibroCompras.txtMes, objLibroCompras.txtAño);
        }

        public static void UpdateEmployee(int pkLibro, string mes, string año)
        {
            AppSales.DAL.LibroComprasDSTableAdapters.LibroComprasTableAdapter objDataSet = new AppSales.DAL.LibroComprasDSTableAdapters.LibroComprasTableAdapter();

            objDataSet.UpdateLibroCompras(pkLibro, mes, año);
        }
        public static void DeleteLibroCompras(int id)
        {
            AppSales.DAL.LibroComprasDSTableAdapters.LibroComprasTableAdapter objDataSet = new AppSales.DAL.LibroComprasDSTableAdapters.LibroComprasTableAdapter();
            objDataSet.DeleteLibroCompras(id);
        }
    }
}
