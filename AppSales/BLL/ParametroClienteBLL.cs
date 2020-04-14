using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppSales.DTO;
using AppSales.DAL;

namespace AppSales.BLL
{
    public class ParametroClienteBLL
    {

        public ParametroClienteBLL()
        {

        }

        public static ParametroCliente rowToDto(ParametroClienteDS.ParametroClientesRow row)
        {
            ParametroCliente objParametroCliente = new ParametroCliente();
            objParametroCliente.pkParametroCliente = row.pkParametroCliente;
            objParametroCliente.txtDescripcion = row.txtDescripcion;
            return objParametroCliente;
        }
        public static List<ParametroCliente> SelectAll()
        {
            List<ParametroCliente> listadeParametroCliente = new List<ParametroCliente>();
            AppSales.DAL.ParametroClienteDSTableAdapters.ParametroClientesTableAdapter objDataSet = new AppSales.DAL.ParametroClienteDSTableAdapters.ParametroClientesTableAdapter();
            ParametroClienteDS.ParametroClientesDataTable dtParametroCliente = objDataSet.GetParametroClientes();

            foreach (ParametroClienteDS.ParametroClientesRow row in dtParametroCliente)
            {
                ParametroCliente objParametroCliente = rowToDto(row);
                listadeParametroCliente.Add(objParametroCliente);
            }
            return listadeParametroCliente;
        }
        public static int InsertObjetoCliente(Cliente objCliente)
        {
            return InsertDatosCliente(objCliente.fkPersona, objCliente.fkParametroCliente);
        }


        public static int InsertDatosCliente(int fkPersona, int fkParametroCliente)
        {

            AppSales.DAL.ClienteDSTableAdapters.ClientesTableAdapter objDataSet = new AppSales.DAL.ClienteDSTableAdapters.ClientesTableAdapter();
            int? ClienteId = 0;

            //objDataSet.Insert1(ref empleadoId, nombre, apellido, ci, fechanac, password, direccion, telefono, correo, fechaContrato, estado, tipo);
            objDataSet.InsertClient(ref ClienteId, fkPersona, fkParametroCliente);

            return (int)ClienteId;
        }

        public static Cliente GetClienteById(int pk)
        {
            //List<Moneda> listadeMoneda = new List<Moneda>();
            //AppSales.DAL.MonedaDSTableAdapters.MonedasTableAdapter objDataSet = new AppSales.DAL.MonedaDSTableAdapters.MonedasTableAdapter();
            //MonedaDS.MonedasDataTable dtMoneda = objDataSet.GetMonedasById(pk);
            //Moneda objMoneda = rowToDto(dtMoneda[0]);

            //return objMoneda;
            return null;
        }
        public static void UpdateCliente(Cliente objCliente)
        {
            UpdateCliente(objCliente.fkPersona, objCliente.fkParametroCliente);
        }

        public static void UpdateCliente(int fkPersona, int fkParametroCliente)
        {
            AppSales.DAL.ClienteDSTableAdapters.ClientesTableAdapter objDataSet = new AppSales.DAL.ClienteDSTableAdapters.ClientesTableAdapter();

            objDataSet.UpdateClient(fkPersona, fkParametroCliente);
        }
        /*public static void DeleteCliente(int id)
        {
            AppSales.DAL.ClienteDSTableAdapters.ClientesTableAdapter objDataSet = new AppSales.DAL.ClienteDSTableAdapters.ClientesTableAdapter();
            objDataSet.DeleteClient(id);
        }*/
    }
}
