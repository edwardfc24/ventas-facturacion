using AppSales.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSales.DTO
{
    public class Moneda
    {
        public int pkMoneda { get; set; }
        public decimal decTipoCambio { get; set; }
        public int idUsuario { get; set; }
    }
}
