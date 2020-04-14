using AppSales.DAL;
using AppSales.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSales.BLL
{
    public class LlaveFacturaBLL
    {
        public static LlaveFactura rowToDto(LlaveFacturaDS.LlaveFacturaRow row)
        {
            LlaveFactura objLlaveFactura = new LlaveFactura();
            objLlaveFactura.pkLlave = row.pkLlave;
            objLlaveFactura.txtNroAutorizacion = row.txtNroAutorizacion;
            objLlaveFactura.txtLlave = row.txtLlave;
            objLlaveFactura.dateFechaLimite = row.dateFechaLimite;
            return objLlaveFactura;
        }
        public static List<LlaveFactura> SelectAll()
        {
            List<LlaveFactura> listadeLlaveFactura = new List<LlaveFactura>();
            AppSales.DAL.LlaveFacturaDSTableAdapters.LlaveFacturaTableAdapter objDataSet = new AppSales.DAL.LlaveFacturaDSTableAdapters.LlaveFacturaTableAdapter();
            LlaveFacturaDS.LlaveFacturaDataTable dtLlaveFactura = objDataSet.GetAllLlavesFacturas();

            foreach (LlaveFacturaDS.LlaveFacturaRow row in dtLlaveFactura)
            {
                LlaveFactura objLlaveFactura = rowToDto(row);
                listadeLlaveFactura.Add(objLlaveFactura);
            }
            return listadeLlaveFactura;
        }
        public static int InsertObjetoLlaveFactura(LlaveFactura objLlaveFactura, int idUsuario)
        {
            return InsertDatosLlaveFactura(objLlaveFactura.txtNroAutorizacion, objLlaveFactura.txtLlave, objLlaveFactura.dateFechaLimite, idUsuario);
        }


        public static int InsertDatosLlaveFactura(string nroAutorizacion, string llave, DateTime fechaLimite, int idUsuario)
        {

            AppSales.DAL.LlaveFacturaDSTableAdapters.LlaveFacturaTableAdapter objDataSet = new AppSales.DAL.LlaveFacturaDSTableAdapters.LlaveFacturaTableAdapter();
            int? LlaveFacturaId = 0;

            //objDataSet.Insert1(ref empleadoId, nombre, apellido, ci, fechanac, password, direccion, telefono, correo, fechaContrato, estado, tipo);
            objDataSet.InsertLlaveFactura(ref LlaveFacturaId, nroAutorizacion, llave, fechaLimite, idUsuario);

            return (int)LlaveFacturaId;
        }

        public static LlaveFactura GetLlaveFacturaById(int pk)
        {
            AppSales.DAL.LlaveFacturaDSTableAdapters.LlaveFacturaTableAdapter objDataSet = new AppSales.DAL.LlaveFacturaDSTableAdapters.LlaveFacturaTableAdapter();
            LlaveFacturaDS.LlaveFacturaDataTable dtLlaveFactura = objDataSet.GetLlaveFacturaByID(pk);
            LlaveFactura objLlaveFactura = rowToDto(dtLlaveFactura[0]);

            return objLlaveFactura;
        }
        public static LlaveFactura GetLlaveFacturaByAutorizacion(string autorizacion)
        {
            AppSales.DAL.LlaveFacturaDSTableAdapters.LlaveFacturaTableAdapter objDataSet = new AppSales.DAL.LlaveFacturaDSTableAdapters.LlaveFacturaTableAdapter();
            LlaveFacturaDS.LlaveFacturaDataTable dtLlaveFactura = objDataSet.GetLlaveFacturaByAutorization(autorizacion);
            LlaveFactura objLlaveFactura = rowToDto(dtLlaveFactura[0]);

            return objLlaveFactura;
        }
        public static LlaveFactura GetLastLlaveFactura()
        {
            AppSales.DAL.LlaveFacturaDSTableAdapters.LlaveFacturaTableAdapter objDataSet = new AppSales.DAL.LlaveFacturaDSTableAdapters.LlaveFacturaTableAdapter();
            LlaveFacturaDS.LlaveFacturaDataTable dtLlaveFactura = objDataSet.GetLastLlaveFactura();
            if (dtLlaveFactura.Count > 0)
            {
                LlaveFactura objLlaveFactura = rowToDto(dtLlaveFactura[0]);
                return objLlaveFactura;
            }
            return null;
        }

        public static void UpdateLlaveFactura(LlaveFactura objLlaveFactura, int idUsuario)
        {
            UpdateEmployee(objLlaveFactura.pkLlave, objLlaveFactura.txtNroAutorizacion, objLlaveFactura.txtLlave, objLlaveFactura.dateFechaLimite, idUsuario);
        }

        public static void UpdateEmployee(int pkLlave, string nroAutorizacion, string llave, DateTime fechaLimite, int idUsuario)
        {
            AppSales.DAL.LlaveFacturaDSTableAdapters.LlaveFacturaTableAdapter objDataSet = new AppSales.DAL.LlaveFacturaDSTableAdapters.LlaveFacturaTableAdapter();

            objDataSet.UpdateLlaveFactura(pkLlave, nroAutorizacion, llave, fechaLimite, idUsuario);
        }
        public static void DeleteLlaveFactura(int id)
        {
            AppSales.DAL.LlaveFacturaDSTableAdapters.LlaveFacturaTableAdapter objDataSet = new AppSales.DAL.LlaveFacturaDSTableAdapters.LlaveFacturaTableAdapter();
            objDataSet.DeleteLlaveFactura(id);
        }
    }
}
