using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppSales.DTO;
using AppSales.DAL;

namespace AppSales.BLL
{
    public class ClienteBLL
    {
        public ClienteBLL()
        { }

        public static Cliente rowToDto(ClienteDS.ClientesRow row)
        {
            Cliente objCliente = new Cliente();
            objCliente.fkPersona = row.pkPersona;
            objCliente.pkCliente = row.pkCliente;
            objCliente.txtNit = row.txtNit;
            objCliente.txtNombreCompleto = row.txtNombreCompleto;
            objCliente.txtDireccion = row.txtDireccion;
            objCliente.txtTelefono = row.txtTelefono;
            objCliente.txtCelular = row.txtCelular;
            objCliente.txtCorreo = row.txtCorreo;
            objCliente.txtDescripcion = row.txtDescripcion;
            return objCliente;
        }
        public static List<Cliente> SelectAll()
        {
            List<Cliente> listadeClientes = new List<Cliente>();
            AppSales.DAL.ClienteDSTableAdapters.ClientesTableAdapter objDataSet = new AppSales.DAL.ClienteDSTableAdapters.ClientesTableAdapter();
            ClienteDS.ClientesDataTable dtClientes = objDataSet.GetAllClients();

            foreach (ClienteDS.ClientesRow row in dtClientes)
            {
                Cliente objCliente = rowToDto(row);
                listadeClientes.Add(objCliente);
            }
            return listadeClientes;
        }
        public static int InsertObjetoCliente(Cliente objCliente)
        {
            return InsertDatosCliente(objCliente.fkPersona, objCliente.fkParametroCliente);
        }


        public static int InsertDatosCliente(int fkPersona, int fkParametroCliente)
        {

            AppSales.DAL.ClienteDSTableAdapters.ClientesTableAdapter objDataSet = new AppSales.DAL.ClienteDSTableAdapters.ClientesTableAdapter();
            int? ClienteId = 0;

            objDataSet.InsertClient(ref ClienteId, fkPersona, fkParametroCliente);

            return (int)ClienteId;
        }

        public static Cliente GetClienteById(int pk)
        {
            AppSales.DAL.ClienteDSTableAdapters.ClientesTableAdapter objDataSet = new AppSales.DAL.ClienteDSTableAdapters.ClientesTableAdapter();
            ClienteDS.ClientesDataTable dtCliente = objDataSet.GetClientByID(pk);
            Cliente objCliente = rowToDto(dtCliente[0]);

            return objCliente;
        }
        public static Cliente GetClienteByNit(string nit)
        {
            AppSales.DAL.ClienteDSTableAdapters.ClientesTableAdapter objDataSet = new AppSales.DAL.ClienteDSTableAdapters.ClientesTableAdapter();
            ClienteDS.ClientesDataTable dtCliente = objDataSet.GetClientByNit(nit);
            if (dtCliente.Count > 0)
            {
                Cliente objCliente = rowToDto(dtCliente[0]);
                return objCliente;
            }
            return null;
        }
        public static void UpdateCliente(Cliente objCliente)
        {
            UpdateClient(objCliente.fkPersona, objCliente.fkParametroCliente);
        }

        public static void UpdateClient(int fkPersona, int fkParametroCliente)
        {
            AppSales.DAL.ClienteDSTableAdapters.ClientesTableAdapter objDataSet = new AppSales.DAL.ClienteDSTableAdapters.ClientesTableAdapter();

            objDataSet.UpdateClient(fkPersona, fkParametroCliente);
        }
        public static void DeleteCliente(int id)
        {
            AppSales.DAL.ClienteDSTableAdapters.ClientesTableAdapter objDataSet = new AppSales.DAL.ClienteDSTableAdapters.ClientesTableAdapter();
            objDataSet.DeleteCliente(id);
        }

    }
}
