using AppSales.DAL;
using AppSales.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSales.BLL
{
    public class EmpleadoBLL
    {
        public EmpleadoBLL()
        {

        }

        public static Empleado rowToDto(EmpleadoDS.EmpleadosRow row)
        {
            Empleado objEmpleado = new Empleado();
            objEmpleado.fkPersona = row.pkPersona;
            objEmpleado.pkEmpleado = row.pkEmpleado;
            objEmpleado.txtNit = row.txtNit;
            objEmpleado.txtNombreCompleto = row.txtNombreCompleto;
            objEmpleado.txtDireccion = row.txtDireccion;
            objEmpleado.txtTelefono = row.txtTelefono;
            objEmpleado.txtCelular = row.txtCelular;
            objEmpleado.txtCorreo = row.txtCorreo;
            objEmpleado.txtContraseña = row.txtContraseña;
            return objEmpleado;
        }
        public static List<Empleado> SelectAll()
        {
            List<Empleado> listadeEmpleados = new List<Empleado>();
            AppSales.DAL.EmpleadoDSTableAdapters.EmpleadosTableAdapter objDataSet = new AppSales.DAL.EmpleadoDSTableAdapters.EmpleadosTableAdapter();
            EmpleadoDS.EmpleadosDataTable dtEmpleado = objDataSet.GetAllEmployees();

            foreach (EmpleadoDS.EmpleadosRow row in dtEmpleado)
            {
                Empleado objEmpleado = rowToDto(row);
                listadeEmpleados.Add(objEmpleado);
            }
            return listadeEmpleados;
        }
        public static int InsertObjetoEmpleado(Empleado objEmpleado)
        {
            return InsertDatosEmpleado(objEmpleado.fkPersona, objEmpleado.txtContraseña);
        }


        public static int InsertDatosEmpleado(int fkEmpleado, string contraseña)
        {

            AppSales.DAL.EmpleadoDSTableAdapters.EmpleadosTableAdapter objDataSet = new AppSales.DAL.EmpleadoDSTableAdapters.EmpleadosTableAdapter();
            int? EmpleadoId = 0;

            //objDataSet.Insert1(ref empleadoId, nombre, apellido, ci, fechanac, password, direccion, telefono, correo, fechaContrato, estado, tipo);
            objDataSet.InsertEmployee(ref EmpleadoId, fkEmpleado, contraseña);

            return (int)EmpleadoId;
        }

        public static Empleado GetEmpleadoById(int pk)
        {
            AppSales.DAL.EmpleadoDSTableAdapters.EmpleadosTableAdapter objDataSet = new AppSales.DAL.EmpleadoDSTableAdapters.EmpleadosTableAdapter();
            EmpleadoDS.EmpleadosDataTable dtEmpleado = objDataSet.GetEmployeeByID(pk);
            Empleado objEmpleado = rowToDto(dtEmpleado[0]);

            return objEmpleado;
        }

        public static Empleado GetEmpleadoByName(string name)
        {
            name = "%" + name + "%";
            AppSales.DAL.EmpleadoDSTableAdapters.EmpleadosTableAdapter objDataSet = new AppSales.DAL.EmpleadoDSTableAdapters.EmpleadosTableAdapter();
            EmpleadoDS.EmpleadosDataTable dtEmpleado = objDataSet.GetEmployeeByName(name);
            Empleado objEmpleado = rowToDto(dtEmpleado[0]);

            return objEmpleado;
        }
        public static void UpdateEmpleado(Empleado objEmpleado)
        {
            UpdateEmployee(objEmpleado.fkPersona, objEmpleado.txtContraseña);
        }

        public static void UpdateEmployee(int fkPersona, string contraseña)
        {
            AppSales.DAL.EmpleadoDSTableAdapters.EmpleadosTableAdapter objDataSet = new AppSales.DAL.EmpleadoDSTableAdapters.EmpleadosTableAdapter();

            objDataSet.UpdateEmployee(fkPersona, contraseña);
        }
        public static void DeleteEmpleado(int id)
        {
            AppSales.DAL.EmpleadoDSTableAdapters.EmpleadosTableAdapter objDataSet = new AppSales.DAL.EmpleadoDSTableAdapters.EmpleadosTableAdapter();
            objDataSet.DeleteEmployee(id);
        }
    }
}
