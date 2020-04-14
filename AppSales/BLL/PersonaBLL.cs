using AppSales.DTO;
using AppSales.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSales.BLL
{
    public class PersonaBLL
    {
        public PersonaBLL()
        { }

        public static Persona rowToDto(PersonaDS.PersonasRow row)
        {
            Persona objPersona = new Persona();
            objPersona.pkPersona = row.pkPersona;
            objPersona.txtNit = row.txtNit;
            objPersona.txtNombreCompleto = row.txtNombreCompleto;
            objPersona.txtDireccion = row.txtDireccion;
            objPersona.txtTelefono = row.txtTelefono;
            objPersona.txtCelular = row.txtCelular;
            objPersona.txtCorreo = row.txtCorreo;
            return objPersona;
        }
        public static List<Persona> SelectAll()
        {
            List<Persona> listadePersonas = new List<Persona>();
            AppSales.DAL.PersonaDSTableAdapters.PersonasTableAdapter objDataSet = new AppSales.DAL.PersonaDSTableAdapters.PersonasTableAdapter();
            PersonaDS.PersonasDataTable dtPersona = objDataSet.GetAllPersons();

            foreach (PersonaDS.PersonasRow row in dtPersona)
            {
                Persona objPersona = rowToDto(row);
                listadePersonas.Add(objPersona);
            }
            return listadePersonas;
        }
        public static int InsertObjetoPersona(Persona objPersona)
        {
            return InsertDatosPersona(objPersona.txtNit, objPersona.txtNombreCompleto, objPersona.txtDireccion,
                                        objPersona.txtTelefono, objPersona.txtCelular, objPersona.txtCorreo, objPersona.intIdUsuairo);
        }


        public static int InsertDatosPersona(string txtNit, string txtNombreCompleto, string txtDireccion,
                                        string txtTelefono, string txtCelular, string txtCorreo, int intIdUsuairo)
        {

            AppSales.DAL.PersonaDSTableAdapters.PersonasTableAdapter objDataSet = new AppSales.DAL.PersonaDSTableAdapters.PersonasTableAdapter();
            int? PersonaId = 0;
            objDataSet.InsertPerson(ref PersonaId, txtNit, txtNombreCompleto, txtDireccion, txtTelefono, txtCelular, txtCorreo, intIdUsuairo);

            return (int)PersonaId;
        }

        public static Login comprobarPassword(string nit, string pass)
        {
            Login login = new Login();
            AppSales.DAL.PersonaDSTableAdapters.PersonasTableAdapter objDataSet = new AppSales.DAL.PersonaDSTableAdapters.PersonasTableAdapter();
            int pkLogin = (int)objDataSet.GetAdminByNitPass(nit, pass);
            if (pkLogin != 0)
            {
                login.pkLogin = pkLogin;
                login.txtTipoLogin = "Administrador";
                return login;
            }
            else
            {
                pkLogin = (int)objDataSet.GetEmployeeByNitPass(nit, pass);
                if (pkLogin != 0)
                {
                    login.pkLogin = pkLogin;
                    login.txtTipoLogin = "Empleado";
                    return login;
                }
            }
            return null;
        }

        /*public static Persona GetPersonaById(int pk)
        {
            AppSales.DAL.PersonaDSTableAdapters.PersonasTableAdapter objDataSet = new AppSales.DAL.PersonaDSTableAdapters.PersonasTableAdapter();
            //PersonaDS.PersonasDataTable dtMoneda = objDataSet.GetPersonasById(pk);
            //Moneda objMoneda = rowToDto(dtMoneda[0]);

            //return objMoneda;
            return null;
        }*/
        public static void UpdatePersona(Persona objPersona)
        {
            UpdatePerson(objPersona.pkPersona, objPersona.txtNit, objPersona.txtNombreCompleto, objPersona.txtDireccion, objPersona.txtTelefono,
                        objPersona.txtCelular, objPersona.txtCorreo, objPersona.intIdUsuairo);
        }

        public static void UpdatePerson(int fkPersona, string txtNit, string txtNombreCompleto, string txtDireccion, string txtTelefono, string txtCelular,
                                        string txtCorreo, int intIdUsuario)
        {
            AppSales.DAL.PersonaDSTableAdapters.PersonasTableAdapter objDataSet = new AppSales.DAL.PersonaDSTableAdapters.PersonasTableAdapter();

            objDataSet.UpdatePerson(fkPersona, txtNit, txtNombreCompleto, txtDireccion, txtTelefono, txtCelular, txtCorreo, intIdUsuario);
        }

    }
}
