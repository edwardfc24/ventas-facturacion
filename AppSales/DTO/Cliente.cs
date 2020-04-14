using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSales.DTO
{
    public class Cliente : Persona
    {
        public int pkCliente { get; set; }

        public int fkPersona { get; set; }

        public int fkParametroCliente { get; set; }

        public string txtDescripcion { get; set; }
    }
}
