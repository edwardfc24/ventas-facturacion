using AppSales.DAL;
using AppSales.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSales.BLL
{
    public class LoginBLL
    {
        public LoginBLL()
        {

        }

        public static Login rowToDto(LoginDS.NitPassRow row)
        {
            Login objLogin = new Login();
            objLogin.pkLogin = row.pkEmpleado;

            return objLogin;
        }

        public static Login rowToDto2(LoginAdminDS.AdminNitPassRow row)
        {
            Login objLogin = new Login();
            objLogin.pkLogin = row.pkAdministrador;

            return objLogin;
        }

        public static Login GetEmpleadoNitPass(string nit, string password)
        {
            AppSales.DAL.LoginDSTableAdapters.NitPassTableAdapter objDataSet = new AppSales.DAL.LoginDSTableAdapters.NitPassTableAdapter();
            LoginDS.NitPassDataTable dtLogin = objDataSet.GetEmpleadosNitPass(nit,password);
            Login objLogin;
            if (dtLogin.Count>0)
            {
                objLogin = rowToDto(dtLogin[0]);
                return objLogin;
            }

            return null;
        }

        public static Login GetAdminNitPass(string nit, string password)
        {
            AppSales.DAL.LoginAdminDSTableAdapters.AdminNitPassTableAdapter objDataSet = new AppSales.DAL.LoginAdminDSTableAdapters.AdminNitPassTableAdapter();
            LoginAdminDS.AdminNitPassDataTable dtLogin = objDataSet.GetAdminNitPass(nit, password);
            Login objLogin;
            if (dtLogin.Count > 0)
            {
                objLogin = rowToDto2(dtLogin[0]);
                return objLogin;
            }

            return null;
        }
    }
}
