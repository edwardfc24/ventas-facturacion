using AppSales.BLL;
using AppSales.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSales
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = false;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nit = txtUserName.Text;
            string contraseña = txtPassword.Text;
            if (LoginBLL.GetEmpleadoNitPass(nit, contraseña) != null)
            {
                frmPrincipal frm = new frmPrincipal();
                frm.cerrarMenus();
                IdUsuario.IdUsuarioConectado = LoginBLL.GetEmpleadoNitPass(nit, contraseña).pkLogin;
                this.Hide();
                frm.ShowDialog();
                this.Close();
                return;
            }
            else
            {
                if (LoginBLL.GetAdminNitPass(nit, contraseña) != null)
                {
                    frmPrincipal frm = new frmPrincipal();
                    IdUsuario.IdUsuarioConectado = LoginBLL.GetAdminNitPass(nit, contraseña).pkLogin;
                    this.Hide();
                    frm.ShowDialog();
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Datos incorrectos");
                }
            }


            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
