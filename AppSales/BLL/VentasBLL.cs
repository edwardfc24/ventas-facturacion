using AppSales.DAL;
using AppSales.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSales.BLL
{
    public class VentasBLL
    {
        public static Ventas rowToDto(VentaPeriodosDS.VentasRow row)
        {
            Ventas objVentas = new Ventas();
            objVentas.pkFactura = row.pkFactura;
            objVentas.fkCliente = row.fkCliente;
            objVentas.fkEmpleado = row.fkEmpleado;
            objVentas.fkDescuento = row.fkDescuento;
            objVentas.fkMoneda = row.fkMoneda;
            objVentas.txtNroFactura = row.txtNroFactura;
            objVentas.txtNroAutorizacion = row.txtNroAutorizacion;
            objVentas.decTotal = row.decTotal;
            objVentas.bitEstado = Convert.ToInt32(row.bitEstado);
            objVentas.dateFechaCreacion = row.dateFechaCreacion;
            objVentas.dateFechaModificacion = row.dateFechaModificacion;
            objVentas.intIdUsuarioCreacion = row.intIdUsuarioCreacion;
            objVentas.intIdUsuarioModificacion = row.intIdUsuarioModificacion;
            objVentas.intIdUsuarioCreacion = row.intIdUsuarioCreacion;
            return objVentas;
        }
        public static List<Ventas> GetVentasBetweenDates(DateTime inicio, DateTime fin)
        {
            List<Ventas> listVentass = new List<Ventas>();
            AppSales.DAL.VentaPeriodosDSTableAdapters.VentasTableAdapter objDataSet = new AppSales.DAL.VentaPeriodosDSTableAdapters.VentasTableAdapter();
            VentaPeriodosDS.VentasDataTable dtVentas = objDataSet.GetSalesBetweenDates(inicio, fin);

            foreach (VentaPeriodosDS.VentasRow row in dtVentas)
            {
                Ventas objVentas = rowToDto(row);
                listVentass.Add(objVentas);
            }
            return listVentass;
        }
    }
}
