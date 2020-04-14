using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSales.DTO
{
    public class DetalleLibroVentas
    {
        public int pkRegistro { get; set; }
        public int intEspecificacion { get; set; }
        public int intNro { get; set; }
        public DateTime dateFechaFactura { get; set; }
        public string txtNroFactura { get; set; }
        public string txtNroAutorizacion { get; set; }
        public string txtEstado { get; set; }
        public string txtNitCliente { get; set; }
        public string txtNombreRazon { get; set; }
        public decimal decImporteTotal { get; set; }
        public decimal decImporteImpuestos { get; set; }
        public decimal decExportacionesExentos { get; set; }
        public decimal decVentasTasaCero { get; set; }
        public decimal decSubTotal { get; set; }
        public decimal decDescuentos { get; set; }
        public decimal decImporteBaseDF { get; set; }
        public decimal decDebitoFiscal { get; set; }
        public string txtCodigoControl { get; set; }
        public int fkLibro { get; set; }
        public DateTime dateFechaCreacion { get; set; }
        public DateTime dateFechaModificacion { get; set; }
        public int intIdUsuarioCreacion { get; set; }
        public int intIdUsuarioModificacion { get; set; }
    }
}
