using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSales.DTO
{
    public class Persona : Entidades
    {
        public int pkPersona { get; set; }

        public string txtNit { get; set; }

        public string txtNombreCompleto { get; set; }

        public string txtDireccion { get; set; }

        public string txtTelefono { get; set; }

        public string txtCelular { get; set; }

        public string txtCorreo { get; set; }

        public int intIdUsuairo { get; set; }

    }
}
