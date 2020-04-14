using AppSales.DAL;
using AppSales.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSales.BLL
{
    public class DetalleLibroVentasBLL
    {
        public static DetalleLibroVentas rowToDto(DetalleLibroVentasDS.DetalleLibroVentasRow row)
        {
            DetalleLibroVentas objDetalle = new DetalleLibroVentas();
            objDetalle.pkRegistro = row.pkRegistro;
            objDetalle.intEspecificacion = row.intEspecificacion;
            objDetalle.intNro = row.intNro;
            objDetalle.dateFechaFactura = row.dateFechaFactura;
            objDetalle.txtNroFactura = row.txtNroFactura;
            objDetalle.txtNroAutorizacion = row.txtNroAutorizacion;
            objDetalle.txtEstado = row.txtEstado;
            objDetalle.txtNitCliente = row.txtNitCliente;
            objDetalle.txtNombreRazon = row.txtNombreRazon;
            objDetalle.decImporteTotal = row.decImporteTotal;
            objDetalle.decImporteImpuestos = row.decImporteImpuestos;
            objDetalle.decExportacionesExentos = row.decExportacionesExentos;
            objDetalle.decVentasTasaCero = row.decVentasTasaCero;
            objDetalle.decSubTotal = row.decSubTotal;
            objDetalle.decDescuentos = row.decDescuentos;
            objDetalle.decImporteBaseDF = row.decImporteBaseDF;
            objDetalle.decDebitoFiscal = row.decDebitoFiscal;
            objDetalle.txtCodigoControl = row.txtCodigoControl;
            objDetalle.fkLibro = row.fkLibro;
            objDetalle.dateFechaCreacion = row.dateFechaCreacion;
            objDetalle.dateFechaModificacion = row.dateFechaModificacion;
            objDetalle.intIdUsuarioCreacion = row.intIdUsuarioCreacion;
            objDetalle.intIdUsuarioModificacion = row.intIdUsuarioModificacion;
            return objDetalle;
        }
        public static List<DetalleLibroVentas> SelectAll()
        {
            List<DetalleLibroVentas> listadeDetalleLibroVentas = new List<DetalleLibroVentas>();
            AppSales.DAL.DetalleLibroVentasDSTableAdapters.DetalleLibroVentasTableAdapter objDataSet = new AppSales.DAL.DetalleLibroVentasDSTableAdapters.DetalleLibroVentasTableAdapter();
            DetalleLibroVentasDS.DetalleLibroVentasDataTable dtDetalleLibroVentas = objDataSet.GetAllDetalleLibroVentas();

            foreach (DetalleLibroVentasDS.DetalleLibroVentasRow row in dtDetalleLibroVentas)
            {
                DetalleLibroVentas objDetalleLibroVentas = rowToDto(row);
                listadeDetalleLibroVentas.Add(objDetalleLibroVentas);
            }
            return listadeDetalleLibroVentas;
        }
        public static int InsertObjetoDetalleLibroVentas(DetalleLibroVentas objDetalleLibroVentas)
        {
            return InsertDatosDetalleLibroVentas(objDetalleLibroVentas.intNro, objDetalleLibroVentas.dateFechaFactura, objDetalleLibroVentas.txtNroFactura, objDetalleLibroVentas.txtNroAutorizacion, objDetalleLibroVentas.txtNitCliente, objDetalleLibroVentas.txtNombreRazon, objDetalleLibroVentas.decImporteTotal, objDetalleLibroVentas.decImporteImpuestos, objDetalleLibroVentas.decExportacionesExentos, objDetalleLibroVentas.decVentasTasaCero, objDetalleLibroVentas.decSubTotal, objDetalleLibroVentas.decDescuentos, objDetalleLibroVentas.decImporteBaseDF, objDetalleLibroVentas.decDebitoFiscal, objDetalleLibroVentas.txtCodigoControl, objDetalleLibroVentas.fkLibro, objDetalleLibroVentas.intIdUsuarioCreacion);
        }


        public static int InsertDatosDetalleLibroVentas(int nro, DateTime fechaFactura, string txtNroFactura, string txtNroAutorizacion, string txtNitCliente, string txtNombreRazon, decimal decImporteTotal, decimal decImporteImpuestos, decimal decExportacionesExentos, decimal decVentasTasaCero, decimal decSubTotal, decimal decDescuentos, decimal decImporteBaseDF, decimal decDebitoFiscal, string txtCodigoControl, int fkLibro, int idUsuario)
        {

            AppSales.DAL.DetalleLibroVentasDSTableAdapters.DetalleLibroVentasTableAdapter objDataSet = new AppSales.DAL.DetalleLibroVentasDSTableAdapters.DetalleLibroVentasTableAdapter();
            int? DetalleLibroVentasId = 0;

            //objDataSet.Insert1(ref empleadoId, nombre, apellido, ci, fechanac, password, direccion, telefono, correo, fechaContrato, estado, tipo);
            objDataSet.InsertDetalleLibroVentas(ref DetalleLibroVentasId, nro, fechaFactura, txtNroFactura, txtNroAutorizacion, txtNitCliente, txtNombreRazon, decImporteTotal, decImporteImpuestos, decExportacionesExentos, decVentasTasaCero, decSubTotal, decDescuentos, decImporteBaseDF, decDebitoFiscal, txtCodigoControl, fkLibro, idUsuario);

            return (int)DetalleLibroVentasId;
        }

        public static DetalleLibroVentas GetDetalleLibroVentasById(int pk)
        {
            AppSales.DAL.DetalleLibroVentasDSTableAdapters.DetalleLibroVentasTableAdapter objDataSet = new AppSales.DAL.DetalleLibroVentasDSTableAdapters.DetalleLibroVentasTableAdapter();
            DetalleLibroVentasDS.DetalleLibroVentasDataTable dtDetalleLibroVentas = objDataSet.GetDetalleLibroVentaByID(pk);
            DetalleLibroVentas objDetalleLibroVentas = rowToDto(dtDetalleLibroVentas[0]);

            return objDetalleLibroVentas;
        }

        public static List<DetalleLibroVentas> GetDetalleLibroVentasByIdLibro(int pklibro)
        {
            List<DetalleLibroVentas> listadeDetalleLibroVentas = new List<DetalleLibroVentas>();
            AppSales.DAL.DetalleLibroVentasDSTableAdapters.DetalleLibroVentasTableAdapter objDataSet = new AppSales.DAL.DetalleLibroVentasDSTableAdapters.DetalleLibroVentasTableAdapter();
            DetalleLibroVentasDS.DetalleLibroVentasDataTable dtDetalleLibroVentas = objDataSet.GetDetalleLibroVentaByIdLibro(pklibro);
            foreach (DetalleLibroVentasDS.DetalleLibroVentasRow row in dtDetalleLibroVentas)
            {
                DetalleLibroVentas objDetalleLibroVentas = rowToDto(row);
                listadeDetalleLibroVentas.Add(objDetalleLibroVentas);
            }
            return listadeDetalleLibroVentas;
        }

        public static void UpdateDetalleLibroVentas(DetalleLibroVentas objDetalleLibroVentas)
        {
            UpdateDetalle(objDetalleLibroVentas.pkRegistro, objDetalleLibroVentas.intNro, objDetalleLibroVentas.dateFechaFactura, objDetalleLibroVentas.txtNroFactura, objDetalleLibroVentas.txtNroAutorizacion, objDetalleLibroVentas.txtEstado, objDetalleLibroVentas.txtNitCliente, objDetalleLibroVentas.txtNombreRazon, objDetalleLibroVentas.decImporteTotal, objDetalleLibroVentas.decImporteImpuestos, objDetalleLibroVentas.decExportacionesExentos, objDetalleLibroVentas.decVentasTasaCero, objDetalleLibroVentas.decSubTotal, objDetalleLibroVentas.decDescuentos, objDetalleLibroVentas.decImporteBaseDF, objDetalleLibroVentas.decDebitoFiscal, objDetalleLibroVentas.txtCodigoControl, objDetalleLibroVentas.fkLibro, objDetalleLibroVentas.intIdUsuarioCreacion);
        }

        public static void UpdateDetalle(int pkRegistro, int nro, DateTime fechaFactura, string txtNroFactura, string txtNroAutorizacion, string txtEstado, string txtNitCliente, string txtNombreRazon, decimal decImporteTotal, decimal decImporteImpuestos, decimal decExportacionesExentos, decimal decVentasTasaCero, decimal decSubTotal, decimal decDescuentos, decimal decImporteBaseDF, decimal decDebitoFiscal, string txtCodigoControl, int fkLibro, int idUsuario)
        {
            AppSales.DAL.DetalleLibroVentasDSTableAdapters.DetalleLibroVentasTableAdapter objDataSet = new AppSales.DAL.DetalleLibroVentasDSTableAdapters.DetalleLibroVentasTableAdapter();

            objDataSet.UpdateDetalleLibroVentas(pkRegistro, nro, fechaFactura, txtNroFactura, txtNroAutorizacion, txtEstado, txtNitCliente, txtNombreRazon, decImporteTotal, decImporteImpuestos, decExportacionesExentos, decVentasTasaCero, decSubTotal, decDescuentos, decImporteBaseDF, decDebitoFiscal, txtCodigoControl, fkLibro, idUsuario);
        }
        public static void DeleteDetalleLibroVentas(int id)
        {
            AppSales.DAL.DetalleLibroVentasDSTableAdapters.DetalleLibroVentasTableAdapter objDataSet = new AppSales.DAL.DetalleLibroVentasDSTableAdapters.DetalleLibroVentasTableAdapter();
            objDataSet.DeleteDetalleLibroVentas(id);
        }
    }
}
