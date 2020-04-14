using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSales.DTO
{
    public class Producto : Entidades
    {

        public int fkProveedor { get; set; }

        public int fkMarca { get; set; }

        public int fkModelo { get; set; }

        public int fkTalla { get; set; }

        public int pkProducto { get; set; }

        public string txtCodigo { get; set; }

        public string txtNombre { get; set; }

        public string txtDescripcion { get; set; }

        public int intCantidad { get; set; }

        public decimal decValorCompra { get; set; }

        public decimal decValorVenta { get; set; }

        public int intGenero { get; set; }

        public string txtNombreProveedor { get; set; }

        public string txtNombreMarca { get; set; }

        public string txtNombreTalla { get; set; }

        public string txtNombreModelo { get; set; }
    }
}
