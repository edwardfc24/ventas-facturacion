using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSales.DTO
{
    public class Administrador : Persona
    {
        public int pkAdministrador { get; set; }

        public int fkPersona { get; set; }

        public string txtContraseña { get; set; }
    }
}
