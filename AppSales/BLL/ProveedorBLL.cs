using AppSales.DAL;
using AppSales.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSales.BLL
{
    public class ProveedorBLL
    {
        public ProveedorBLL()
        {

        }

        public static Proveedor rowToDto(ProveedorDS.ProveedoresRow row)
        {
            Proveedor objProveedor = new Proveedor();
            objProveedor.fkPersona = row.pkPersona;
            objProveedor.pkProveedor = row.pkProveedor;
            objProveedor.txtNit = row.txtNit;
            objProveedor.txtNombreCompleto = row.txtNombreCompleto;
            objProveedor.txtDireccion = row.txtDireccion;
            objProveedor.txtTelefono = row.txtTelefono;
            objProveedor.txtCelular = row.txtCelular;
            objProveedor.txtCorreo = row.txtCorreo;
            objProveedor.txtDescripcion = row.txtDescripcion;
            return objProveedor;
        }

        public static Proveedor rowToDto2(ProveedorDS.ProveedoresRow row)
        {
            Proveedor objProveedor = new Proveedor();
            objProveedor.pkProveedor = row.pkProveedor;
            objProveedor.txtNombreCompleto = row.txtNombreCompleto;
            return objProveedor;
        }

        public static List<Proveedor> SelectAll()
        {
            List<Proveedor> listadeProveedores = new List<Proveedor>();
            AppSales.DAL.ProveedorDSTableAdapters.ProveedoresTableAdapter objDataSet = new AppSales.DAL.ProveedorDSTableAdapters.ProveedoresTableAdapter();
            ProveedorDS.ProveedoresDataTable dtProveedor = objDataSet.GetAllProviders();

            foreach (ProveedorDS.ProveedoresRow row in dtProveedor)
            {
                Proveedor objProveedor = rowToDto(row);
                listadeProveedores.Add(objProveedor);
            }
            return listadeProveedores;
        }

        public static int InsertObjetoProveedor(Proveedor objProveedor)
        {
            return InsertDatosProveedor(objProveedor.fkPersona, objProveedor.txtDescripcion);
        }


        public static int InsertDatosProveedor(int fkPersona, string txtDescripcion)
        {

            AppSales.DAL.ProveedorDSTableAdapters.ProveedoresTableAdapter objDataSet = new AppSales.DAL.ProveedorDSTableAdapters.ProveedoresTableAdapter();
            int? ProveedorId = 0;

            objDataSet.InsertProvider(ref ProveedorId, fkPersona, txtDescripcion);

            return (int)ProveedorId;
        }

        public static Proveedor GetProveedorById(int pk)
        {
            List<Proveedor> listadeProveedor = new List<Proveedor>();
            AppSales.DAL.ProveedorDSTableAdapters.ProveedoresTableAdapter objDataSet = new AppSales.DAL.ProveedorDSTableAdapters.ProveedoresTableAdapter();
            ProveedorDS.ProveedoresDataTable dtProveedor = objDataSet.GetProviderByID(pk);
            Proveedor objProveedor = rowToDto(dtProveedor[0]);

            return objProveedor;
        }
        public static List<Proveedor> GetProveedorByName(string name)
        {
            List<Proveedor> listadeProveedores = new List<Proveedor>();
            name = "%" + name + "%";
            List<Proveedor> listadeProveedor = new List<Proveedor>();
            AppSales.DAL.ProveedorDSTableAdapters.ProveedoresTableAdapter objDataSet = new AppSales.DAL.ProveedorDSTableAdapters.ProveedoresTableAdapter();
            ProveedorDS.ProveedoresDataTable dtProveedor = objDataSet.GetProviderByName(name);
            foreach (ProveedorDS.ProveedoresRow row in dtProveedor)
            {
                Proveedor objProveedor = rowToDto2(row);
                listadeProveedores.Add(objProveedor);
            }
            return listadeProveedores;
        }
        public static void UpdateProveedor(Proveedor objProveedor)
        {
            UpdateProvider(objProveedor.fkPersona, objProveedor.txtDescripcion);
        }

        public static void UpdateProvider(int fkPersona, string txtDescripcion)
        {
            AppSales.DAL.ProveedorDSTableAdapters.ProveedoresTableAdapter objDataSet = new AppSales.DAL.ProveedorDSTableAdapters.ProveedoresTableAdapter();

            objDataSet.UpdateProvider(fkPersona, txtDescripcion);
        }
        public static void DeleteProveedor(int id)
        {
            AppSales.DAL.ProveedorDSTableAdapters.ProveedoresTableAdapter objDataSet = new AppSales.DAL.ProveedorDSTableAdapters.ProveedoresTableAdapter();
            objDataSet.DeleteProvider(id);
        }
    }
}
