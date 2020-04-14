using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSales.DTO
{
    public class IdUsuario
    {
        private static int idUsuarioConectado = 0;

        public IdUsuario()
        {

        }

        public static int IdUsuarioConectado
        {
            get { return IdUsuario.idUsuarioConectado; }
            set { IdUsuario.idUsuarioConectado = value; }
        }
    }
}
