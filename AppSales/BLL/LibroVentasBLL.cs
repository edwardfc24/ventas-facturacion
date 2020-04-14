using AppSales.DAL;
using AppSales.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSales.BLL
{
    public class LibroVentasBLL
    {
        public static LibroVentas rowToDto(LibroVentasDS.LibroVentasRow row)
        {
            LibroVentas objLibroVentas = new LibroVentas();
            objLibroVentas.pkLibro = row.pkLibro;
            objLibroVentas.txtMes = row.txtMes;
            objLibroVentas.txtAño = row.txtAño;
            return objLibroVentas;
        }
        public static List<LibroVentas> SelectAll()
        {
            List<LibroVentas> listadeLibroVentas = new List<LibroVentas>();
            AppSales.DAL.LibroVentasDSTableAdapters.LibroVentasTableAdapter objDataSet = new AppSales.DAL.LibroVentasDSTableAdapters.LibroVentasTableAdapter();
            LibroVentasDS.LibroVentasDataTable dtLibroVentas = objDataSet.GetAllLibroVentas();

            foreach (LibroVentasDS.LibroVentasRow row in dtLibroVentas)
            {
                LibroVentas objLibroVentas = rowToDto(row);
                listadeLibroVentas.Add(objLibroVentas);
            }
            return listadeLibroVentas;
        }
        public static int InsertObjetoLibroVentas(LibroVentas objLibroVentas)
        {
            return InsertDatosLibroVentas(objLibroVentas.txtMes, objLibroVentas.txtAño);
        }


        public static int InsertDatosLibroVentas(string mes, string año)
        {

            AppSales.DAL.LibroVentasDSTableAdapters.LibroVentasTableAdapter objDataSet = new AppSales.DAL.LibroVentasDSTableAdapters.LibroVentasTableAdapter();
            int? LibroVentasId = 0;

            //objDataSet.Insert1(ref empleadoId, nombre, apellido, ci, fechanac, password, direccion, telefono, correo, fechaContrato, estado, tipo);
            objDataSet.InsertLibroVentas(ref LibroVentasId, mes, año);

            return (int)LibroVentasId;
        }

        public static LibroVentas GetLibroVentasById(int pk)
        {
            AppSales.DAL.LibroVentasDSTableAdapters.LibroVentasTableAdapter objDataSet = new AppSales.DAL.LibroVentasDSTableAdapters.LibroVentasTableAdapter();
            LibroVentasDS.LibroVentasDataTable dtLibroVentas = objDataSet.GetLibroVentaByID(pk);
            LibroVentas objLibroVentas = rowToDto(dtLibroVentas[0]);

            return objLibroVentas;
        }

        public static LibroVentas GetLastLibroVentas()
        {
            AppSales.DAL.LibroVentasDSTableAdapters.LibroVentasTableAdapter objDataSet = new AppSales.DAL.LibroVentasDSTableAdapters.LibroVentasTableAdapter();
            LibroVentasDS.LibroVentasDataTable dtLibroVentas = objDataSet.GetLastLibroVenta();
            if (dtLibroVentas.Count > 0)
            {
                LibroVentas objLibroVentas = rowToDto(dtLibroVentas[0]);
                return objLibroVentas;
            }
            return null;
        }

        public static void UpdateLibroVentas(LibroVentas objLibroVentas)
        {
            UpdateEmployee(objLibroVentas.pkLibro, objLibroVentas.txtMes, objLibroVentas.txtAño);
        }

        public static void UpdateEmployee(int pkLibro, string mes, string año)
        {
            AppSales.DAL.LibroVentasDSTableAdapters.LibroVentasTableAdapter objDataSet = new AppSales.DAL.LibroVentasDSTableAdapters.LibroVentasTableAdapter();

            objDataSet.UpdateLibroVentas(pkLibro, mes, año);
        }
        public static void DeleteLibroVentas(int id)
        {
            AppSales.DAL.LibroVentasDSTableAdapters.LibroVentasTableAdapter objDataSet = new AppSales.DAL.LibroVentasDSTableAdapters.LibroVentasTableAdapter();
            objDataSet.DeleteLibroVentas(id);
        }
    }
}
