using AppSales.DAL;
using AppSales.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSales.BLL
{
    public class DetalleLibroComprasBLL
    {
        public static DetalleLibroCompras rowToDto(DetalleLibroComprasDS.DetalleLibroComprasRow row)
        {
            DetalleLibroCompras objDetalle = new DetalleLibroCompras();
            objDetalle.pkRegistro = row.pkRegistro;
            objDetalle.intEspecificacion = row.intEspecificacion;
            objDetalle.intNro = row.intNro;
            objDetalle.dateFechaFactura = row.dateFechaFactura;
            objDetalle.txtNitProeveedor = row.txtNitProeveedor;
            objDetalle.txtNombreRazon = row.txtNombreRazon;
            objDetalle.txtNroFactura = row.txtNroFactura;
            objDetalle.txtNroDUI = row.txtNroDUI;
            objDetalle.txtNroAutorizacion = row.txtNroAutorizacion;
            objDetalle.decImporteTotal = row.decImporteTotal;
            objDetalle.decImporteNOSujeto = row.decImporteNOSujeto;
            objDetalle.decSubTotal = row.decSubTotal;
            objDetalle.decDescuentos = row.decDescuentos;
            objDetalle.decImporteBaseCF = row.decImporteBaseCF;
            objDetalle.decCreditoFiscal = row.decCreditoFiscal;
            objDetalle.txtCodigoControl = row.txtCodigoControl;
            objDetalle.txtTipoCompra = row.txtTipoCompra;
            objDetalle.fkLibro = row.fkLibro;
            objDetalle.dateFechaCreacion = row.dateFechaCreacion;
            objDetalle.dateFechaModificacion = row.dateFechaModificacion;
            objDetalle.intIdUsuarioCreacion = row.intIdUsuarioCreacion;
            objDetalle.intIdUsuarioModificacion = row.intIdUsuarioModificacion;
            return objDetalle;
        }
        public static List<DetalleLibroCompras> SelectAll()
        {
            List<DetalleLibroCompras> listadeDetalleLibroCompras = new List<DetalleLibroCompras>();
            AppSales.DAL.DetalleLibroComprasDSTableAdapters.DetalleLibroComprasTableAdapter objDataSet = new AppSales.DAL.DetalleLibroComprasDSTableAdapters.DetalleLibroComprasTableAdapter();
            DetalleLibroComprasDS.DetalleLibroComprasDataTable dtDetalleLibroCompras = objDataSet.GetAllDetalleLibroCompras();

            foreach (DetalleLibroComprasDS.DetalleLibroComprasRow row in dtDetalleLibroCompras)
            {
                DetalleLibroCompras objDetalleLibroCompras = rowToDto(row);
                listadeDetalleLibroCompras.Add(objDetalleLibroCompras);
            }
            return listadeDetalleLibroCompras;
        }
        public static int InsertObjetoDetalleLibroCompras(DetalleLibroCompras objDetalleLibroCompras)
        {
            return InsertDatosDetalleLibroCompras(objDetalleLibroCompras.intNro, objDetalleLibroCompras.dateFechaFactura, objDetalleLibroCompras.txtNitProeveedor, objDetalleLibroCompras.txtNombreRazon, objDetalleLibroCompras.txtNroFactura, objDetalleLibroCompras.txtNroDUI, objDetalleLibroCompras.txtNroAutorizacion, objDetalleLibroCompras.decImporteTotal, objDetalleLibroCompras.decImporteNOSujeto, objDetalleLibroCompras.decSubTotal, objDetalleLibroCompras.decDescuentos, objDetalleLibroCompras.decImporteBaseCF, objDetalleLibroCompras.decCreditoFiscal, objDetalleLibroCompras.txtCodigoControl, objDetalleLibroCompras.txtTipoCompra, objDetalleLibroCompras.fkLibro, objDetalleLibroCompras.intIdUsuarioCreacion);
        }


        public static int InsertDatosDetalleLibroCompras(int nro, DateTime fechaFactura, string nitProveedor, string nombreRazon, string nroFactura, string nroDUI, string nroAutorizacion, decimal importeTotal, decimal importeNOSujeto, decimal subtotal, decimal descuentos, decimal importeBaseCF, decimal creditoFiscal, string codigoControl, string tipoCompra, int fkLibro, int idUsuario)
        {

            AppSales.DAL.DetalleLibroComprasDSTableAdapters.DetalleLibroComprasTableAdapter objDataSet = new AppSales.DAL.DetalleLibroComprasDSTableAdapters.DetalleLibroComprasTableAdapter();
            int? DetalleLibroComprasId = 0;

            //objDataSet.Insert1(ref empleadoId, nombre, apellido, ci, fechanac, password, direccion, telefono, correo, fechaContrato, estado, tipo);
            objDataSet.InsertDetalleLibroCompras(ref DetalleLibroComprasId, nro, fechaFactura, nitProveedor, nombreRazon, nroFactura, nroDUI, nroAutorizacion, importeTotal, importeNOSujeto, subtotal, descuentos, importeBaseCF, creditoFiscal, codigoControl, tipoCompra, fkLibro, idUsuario);

            return (int)DetalleLibroComprasId;
        }

        public static DetalleLibroCompras GetDetalleLibroComprasById(int pk)
        {
            AppSales.DAL.DetalleLibroComprasDSTableAdapters.DetalleLibroComprasTableAdapter objDataSet = new AppSales.DAL.DetalleLibroComprasDSTableAdapters.DetalleLibroComprasTableAdapter();
            DetalleLibroComprasDS.DetalleLibroComprasDataTable dtDetalleLibroCompras = objDataSet.GetDetalleLibroCompraByID(pk);
            DetalleLibroCompras objDetalleLibroCompras = rowToDto(dtDetalleLibroCompras[0]);

            return objDetalleLibroCompras;
        }

        public static List<DetalleLibroCompras> GetDetalleLibroComprasByIdLibro(int pkLibro)
        {
            List<DetalleLibroCompras> listadeDetalleLibroCompras = new List<DetalleLibroCompras>();
            AppSales.DAL.DetalleLibroComprasDSTableAdapters.DetalleLibroComprasTableAdapter objDataSet = new AppSales.DAL.DetalleLibroComprasDSTableAdapters.DetalleLibroComprasTableAdapter();
            DetalleLibroComprasDS.DetalleLibroComprasDataTable dtDetalleLibroCompras = objDataSet.GetDetalleLibroCompraByIdLibro(pkLibro);
            foreach (DetalleLibroComprasDS.DetalleLibroComprasRow row in dtDetalleLibroCompras)
            {
                DetalleLibroCompras objDetalleLibroCompras = rowToDto(row);
                listadeDetalleLibroCompras.Add(objDetalleLibroCompras);
            }
            return listadeDetalleLibroCompras;
        }

        public static void UpdateDetalleLibroCompras(DetalleLibroCompras objDetalleLibroCompras)
        {
            UpdateDetalle(objDetalleLibroCompras.pkRegistro, objDetalleLibroCompras.intNro, objDetalleLibroCompras.dateFechaFactura, objDetalleLibroCompras.txtNitProeveedor, objDetalleLibroCompras.txtNombreRazon, objDetalleLibroCompras.txtNroFactura, objDetalleLibroCompras.txtNroDUI, objDetalleLibroCompras.txtNroAutorizacion, objDetalleLibroCompras.decImporteTotal, objDetalleLibroCompras.decImporteNOSujeto, objDetalleLibroCompras.decSubTotal, objDetalleLibroCompras.decDescuentos, objDetalleLibroCompras.decImporteBaseCF, objDetalleLibroCompras.decCreditoFiscal, objDetalleLibroCompras.txtCodigoControl, objDetalleLibroCompras.txtTipoCompra, objDetalleLibroCompras.fkLibro, objDetalleLibroCompras.intIdUsuarioModificacion);
        }

        public static void UpdateDetalle(int pkRegistro, int nro, DateTime fechaFactura, string nitProveedor, string nombreRazon, string nroFactura, string nroDUI, string nroAutorizacion, decimal importeTotal, decimal importeNOSujeto, decimal subtotal, decimal descuentos, decimal importeBaseCF, decimal creditoFiscal, string codigoControl, string tipoCompra, int fkLibro, int idUsuario)
        {
            AppSales.DAL.DetalleLibroComprasDSTableAdapters.DetalleLibroComprasTableAdapter objDataSet = new AppSales.DAL.DetalleLibroComprasDSTableAdapters.DetalleLibroComprasTableAdapter();

            objDataSet.UpdateDetalleLibroCompras(pkRegistro, nro, fechaFactura, nitProveedor, nombreRazon, nroFactura, nroDUI, nroAutorizacion, importeTotal, importeNOSujeto, subtotal, descuentos, importeBaseCF, creditoFiscal, codigoControl, tipoCompra, fkLibro, idUsuario);
        }
        public static void DeleteDetalleLibroCompras(int id)
        {
            AppSales.DAL.DetalleLibroComprasDSTableAdapters.DetalleLibroComprasTableAdapter objDataSet = new AppSales.DAL.DetalleLibroComprasDSTableAdapters.DetalleLibroComprasTableAdapter();
            objDataSet.DeleteDetalleLibroCompras(id);
        }
    }
}
