using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSales.DTO
{
    public class VariacionesPrecioProductos
    {
        public int pkVariation { get; set; }
        
        public int fkProducto{get; set;}

        public int intCantidad{get;set;}

        public decimal decValorCompra{get;set;}

        public decimal decValorVenta{ get; set; }

    }
}
