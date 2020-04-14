using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSales.DTO
{
   public class DetalleVenta
    {
       public int pkDetalleVenta { get; set; }
       public int fkProducto { get; set; }
       public int fkFactura { get; set; }
       public int intCantidad { get; set; }
       public decimal decimalTotal { get; set; }
    }
}
