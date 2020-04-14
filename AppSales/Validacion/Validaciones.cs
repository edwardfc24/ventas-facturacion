using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSales.Validacion
{
    public class Validaciones
    {

        public void soloNumeros(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        public void soloLetras(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        public Boolean nulos(TextBox cajaTexto)
        {
            if (cajaTexto.Text.Length >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean logitud(TextBox longitud)
        {
            if (longitud.Text.Length == 7 || longitud.Text.Length ==10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
