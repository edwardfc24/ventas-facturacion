using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSales.DTO
{
    public class LlaveFactura
    {
        public int pkLlave { get; set; }
        public string txtNroAutorizacion { get; set; }
        public string txtLlave { get; set; }
        public DateTime dateFechaLimite { get; set; }
    }
}
