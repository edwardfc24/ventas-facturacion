using AppSales.DAL;
using AppSales.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSales.BLL
{
    public class ReporteGananciasBLL
    {
        public ReporteGananciasBLL()
        {

        }

        public static ReporteGanancias rowToDto(ReporteGananciasDS.ReporteGananciasRow row)
        {
            ReporteGanancias objCliente = new ReporteGanancias();
            objCliente.txtCodigo = row.txtCodigo;
            objCliente.txtNombre = row.txtNombre;
            objCliente.cantidadProductosVendidos = row.cantidadProductosVendidos;
            objCliente.totalVendido = row.totalVendido;
            objCliente.totalComprado = row.totalComprado;
            objCliente.Ganacias = row.Ganacias;
            return objCliente;
        }

        public static List<ReporteGanancias> SelectAll(DateTime fechaInicio, DateTime fechaFin)
        {
            List<ReporteGanancias> listadeClientes = new List<ReporteGanancias>();
            AppSales.DAL.ReporteGananciasDSTableAdapters.ReporteGananciasTableAdapter objDataSet = new AppSales.DAL.ReporteGananciasDSTableAdapters.ReporteGananciasTableAdapter();
            ReporteGananciasDS.ReporteGananciasDataTable dtClientes = objDataSet.GetReporteGanancias(fechaInicio,fechaFin);

            foreach (ReporteGananciasDS.ReporteGananciasRow row in dtClientes)
            {
                ReporteGanancias objCliente = rowToDto(row);
                listadeClientes.Add(objCliente);
            }
            return listadeClientes;
        }
    }
}
