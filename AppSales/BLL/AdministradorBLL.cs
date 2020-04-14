using AppSales.DAL;
using AppSales.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSales.BLL
{
    public class AdministradorBLL
    {
        public static Administrador rowToDto(AdministradorDS.AdministradorRow row)
        {
            Administrador objAdministrador = new Administrador();
            objAdministrador.fkPersona = row.pkPersona;
            objAdministrador.pkAdministrador = row.pkAdministrador;
            objAdministrador.txtNit = row.txtNit;
            objAdministrador.txtNombreCompleto = row.txtNombreCompleto;
            objAdministrador.txtDireccion = row.txtDireccion;
            objAdministrador.txtTelefono = row.txtTelefono;
            objAdministrador.txtCelular = row.txtCelular;
            objAdministrador.txtCorreo = row.txtCorreo;
            objAdministrador.txtContraseña = row.txtContraseña;
            return objAdministrador;
        }
        public static List<Administrador> SelectAll()
        {
            List<Administrador> listadeAdministrador = new List<Administrador>();
            AppSales.DAL.AdministradorDSTableAdapters.AdministradorTableAdapter objDataSet = new AppSales.DAL.AdministradorDSTableAdapters.AdministradorTableAdapter();
            AdministradorDS.AdministradorDataTable dtAdministrador = objDataSet.GetAllAdmins();

            foreach (AdministradorDS.AdministradorRow row in dtAdministrador)
            {
                Administrador objAdministrador = rowToDto(row);
                listadeAdministrador.Add(objAdministrador);
            }
            return listadeAdministrador;
        }
        public static int InsertObjetoAdministrador(Administrador objAdministrador)
        {
            return InsertDatosAdministrador(objAdministrador.fkPersona, objAdministrador.txtContraseña);
        }


        public static int InsertDatosAdministrador(int fkAdministrador, string contraseña)
        {

            AppSales.DAL.AdministradorDSTableAdapters.AdministradorTableAdapter objDataSet = new AppSales.DAL.AdministradorDSTableAdapters.AdministradorTableAdapter();
            int? AdministradorId = 0;

            //objDataSet.Insert1(ref empleadoId, nombre, apellido, ci, fechanac, password, direccion, telefono, correo, fechaContrato, estado, tipo);
            objDataSet.InsertAdmin(ref AdministradorId, fkAdministrador, contraseña);

            return (int)AdministradorId;
        }

        public static Administrador GetAdministradorById(int pk)
        {
            AppSales.DAL.AdministradorDSTableAdapters.AdministradorTableAdapter objDataSet = new AppSales.DAL.AdministradorDSTableAdapters.AdministradorTableAdapter();
            AdministradorDS.AdministradorDataTable dtAdministrador = objDataSet.GetAdminByID(pk);
            Administrador objAdministrador = rowToDto(dtAdministrador[0]);

            return objAdministrador;
        }

        public static void UpdateAdministrador(Administrador objAdministrador)
        {
            UpdateEmployee(objAdministrador.fkPersona, objAdministrador.txtContraseña);
        }

        public static void UpdateEmployee(int fkPersona, string contraseña)
        {
            AppSales.DAL.AdministradorDSTableAdapters.AdministradorTableAdapter objDataSet = new AppSales.DAL.AdministradorDSTableAdapters.AdministradorTableAdapter();

            objDataSet.UpdateAdmin(fkPersona, contraseña);
        }
        /*public static void DeleteAdministrador(int id)
        {
            AppSales.DAL.AdministradorDSTableAdapters.AdministradorTableAdapter objDataSet = new AppSales.DAL.AdministradorDSTableAdapters.AdministradorTableAdapter();
            objDataSet.DeleteEmployee(id);
        }*/
    }
}
