using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSales.DTO
{
    public class Proveedor:Persona
    {
        public int pkProveedor { get; set; }

        public int fkPersona { get; set; }

        public string txtDescripcion { get; set; }
    }
}
