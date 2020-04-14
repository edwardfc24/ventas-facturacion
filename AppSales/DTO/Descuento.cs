using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSales.DTO
{
    public class Descuento : Entidades
    {
        public int pkDescuento { get; set; }

        public string txtNombre { get; set; }

        public DateTime dateFechaInicio { get; set; }

        public DateTime dateFechaFin { get; set; }

        public int descuento { get; set; }

        public string  descripcion { get; set; }
    }
}
