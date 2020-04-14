using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSales.DTO
{
    public class Factura
    {
        public int pkFactura { get; set; }
        public int fkCliente { get; set; }
        public int fkEmpleado { get; set; }
        public int fkDescuento { get; set; }
        public int fkMoneda { get; set; }
        public string txtNroFactura { get; set; }
        public string txtNroAutorizacion { get; set; }
        public string txtLLave { get; set; }
        public decimal decTotal { get; set; }
        public int idUsuario { get; set; }
    }
}
