using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSales.DTO
{
    public class ReporteGanancias
    {
        public string txtCodigo { get; set; }

        public string txtNombre { get; set; }

        public int cantidadProductosVendidos { get; set; }

        public decimal totalVendido { get; set; }

        public decimal totalComprado { get; set; }

        public decimal Ganacias { get; set; }
    }
}
