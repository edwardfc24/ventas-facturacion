using AppSales.DAL;
using AppSales.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSales.BLL
{
    public class ProductoBLL
    {
        public ProductoBLL()
        {

        }

        public static Producto rowToDto(ProductoDS.ProductosRow row)
        {
            Producto objProducto = new Producto();
            objProducto.fkProveedor = row.fkProveedor;
            objProducto.fkMarca = row.fkMarca;
            objProducto.fkModelo = row.fkModelo;
            objProducto.fkTalla = row.fkTalla;
            objProducto.pkProducto = row.pkProducto;
            objProducto.txtCodigo = row.txtCodigo;
            objProducto.txtNombre = row.txtNombre;
            objProducto.txtDescripcion = row.txtDescripcion;
            objProducto.intCantidad = row.intCantidad;
            objProducto.decValorCompra = row.decValorCompra;
            objProducto.decValorVenta = row.decValorVenta;
            objProducto.intGenero = row.intGenero;
            objProducto.txtNombreProveedor = row.txtNombreCompleto;
            objProducto.txtNombreMarca = row.txtNombre1;
            objProducto.txtNombreTalla = row.txtNombre2;
            objProducto.txtNombreModelo = row.txtNombre3;
            return objProducto;
        }


        public static List<Producto> SelectAll()
        {
            List<Producto> listadeProductos = new List<Producto>();
            AppSales.DAL.ProductoDSTableAdapters.ProductosTableAdapter objDataSet = new AppSales.DAL.ProductoDSTableAdapters.ProductosTableAdapter();
            ProductoDS.ProductosDataTable dtProductos = objDataSet.GetAllProductosCompleto();

            foreach (ProductoDS.ProductosRow row in dtProductos)
            {
                Producto objProductos = rowToDto(row);
                listadeProductos.Add(objProductos);
            }
            return listadeProductos;
        }

        public static int InsertObjetoProducto(Producto objProducto)
        {
            return InsertDatosProductos(objProducto.fkProveedor, objProducto.txtCodigo, objProducto.txtNombre, objProducto.txtDescripcion, objProducto.intCantidad,
                                        objProducto.decValorCompra, objProducto.decValorVenta, objProducto.intGenero, objProducto.fkMarca, objProducto.fkModelo,
                                        objProducto.fkTalla, objProducto.intIdUsuarioModificacion);
        }


        public static int InsertDatosProductos(int fkProveedor, string txtCodigo, string txtNombreCompleto, string txtDescripcion, int intCantidad, decimal decValorCompra,
                                                decimal decValorVenta, int genero, int fkMarca, int fkModelo, int fkTalla, int intIdUsuario)
        {

            AppSales.DAL.ProductoDSTableAdapters.ProductosTableAdapter objDataSet = new AppSales.DAL.ProductoDSTableAdapters.ProductosTableAdapter();
            int? ProductoId = 0;

            objDataSet.InsertProduct(ref ProductoId, fkProveedor, txtCodigo, txtNombreCompleto, txtDescripcion, intCantidad, decValorCompra, decValorVenta,
                                     genero, fkMarca, fkModelo, fkTalla, intIdUsuario);

            return (int)ProductoId;
        }

        public static Producto GetProductById(int pk)
        {
            AppSales.DAL.ProductoDSTableAdapters.ProductosTableAdapter objDataSet = new AppSales.DAL.ProductoDSTableAdapters.ProductosTableAdapter();
            ProductoDS.ProductosDataTable dtProducto = objDataSet.GetProductByID(pk);
            Producto objProducto = rowToDto(dtProducto[0]);

            return objProducto;
        }
        public static Producto GetProductByCode(string code)
        {
            AppSales.DAL.ProductoDSTableAdapters.ProductosTableAdapter objDataSet = new AppSales.DAL.ProductoDSTableAdapters.ProductosTableAdapter();
            ProductoDS.ProductosDataTable dtProducto = objDataSet.GetProductByCode(code);
            if(dtProducto.Count > 0 ){
                Producto objProducto = rowToDto(dtProducto[0]);
                return objProducto;
            }

            return null;
        }

        public static List<Producto> GetProductsByName(string name)
        {
            List<Producto> listadeProductos = new List<Producto>();
            AppSales.DAL.ProductoDSTableAdapters.ProductosTableAdapter objDataSet = new AppSales.DAL.ProductoDSTableAdapters.ProductosTableAdapter();
            ProductoDS.ProductosDataTable dtProductos = objDataSet.GetProductsByName(name);

            foreach (ProductoDS.ProductosRow row in dtProductos)
            {
                Producto objProductos = rowToDto(row);
                listadeProductos.Add(objProductos);
            }
            return listadeProductos;
        }

        public static List<Producto> GetProductsByMark(int idMarca)
        {
            List<Producto> listadeProductos = new List<Producto>();
            AppSales.DAL.ProductoDSTableAdapters.ProductosTableAdapter objDataSet = new AppSales.DAL.ProductoDSTableAdapters.ProductosTableAdapter();
            ProductoDS.ProductosDataTable dtProductos = objDataSet.GetProductsByMark(idMarca);

            foreach (ProductoDS.ProductosRow row in dtProductos)
            {
                Producto objProductos = rowToDto(row);
                listadeProductos.Add(objProductos);
            }
            return listadeProductos;
        }

        public static List<Producto> GetProductsByModel(int idModelo)
        {
            List<Producto> listadeProductos = new List<Producto>();
            AppSales.DAL.ProductoDSTableAdapters.ProductosTableAdapter objDataSet = new AppSales.DAL.ProductoDSTableAdapters.ProductosTableAdapter();
            ProductoDS.ProductosDataTable dtProductos = objDataSet.GetProductsByModel(idModelo);

            foreach (ProductoDS.ProductosRow row in dtProductos)
            {
                Producto objProductos = rowToDto(row);
                listadeProductos.Add(objProductos);
            }
            return listadeProductos;
        }
        public static List<Producto> GetProductsBySize(int idTalla)
        {
            List<Producto> listadeProductos = new List<Producto>();
            AppSales.DAL.ProductoDSTableAdapters.ProductosTableAdapter objDataSet = new AppSales.DAL.ProductoDSTableAdapters.ProductosTableAdapter();
            ProductoDS.ProductosDataTable dtProductos = objDataSet.GetProductsBySize(idTalla);

            foreach (ProductoDS.ProductosRow row in dtProductos)
            {
                Producto objProductos = rowToDto(row);
                listadeProductos.Add(objProductos);
            }
            return listadeProductos;
        }

        public static Producto GetValidarProducto(int code, int cantidad)
        {
            AppSales.DAL.ProductoDSTableAdapters.ProductosTableAdapter objDataSet = new AppSales.DAL.ProductoDSTableAdapters.ProductosTableAdapter();
            ProductoDS.ProductosDataTable dtProducto = objDataSet.GetValidarStock(code, cantidad);
            if(dtProducto.Count > 0){
                Producto objProducto = rowToDto(dtProducto[0]);
                return objProducto;
            }


            return null;
        }

        public static void UpdateProducto(Producto objProducto)
        {
            UpdateProduct(objProducto.pkProducto, objProducto.fkProveedor, objProducto.txtCodigo, objProducto.txtNombre, objProducto.txtDescripcion,
                           objProducto.intCantidad, objProducto.decValorCompra, objProducto.decValorVenta, objProducto.intGenero,
                           objProducto.fkMarca, objProducto.fkModelo, objProducto.fkTalla, objProducto.intIdUsuarioModificacion);
        }

        public static void UpdateProduct(int pkProducto, int fkProveedor, string txtCodigo, string txtNombre, string txtDescripcion, int intCantidad,
                                         decimal decValorCompra, decimal decValorVenta, int genero, int fkMarca, int fkModelo, int fkTalla, int intIdUsuario)
        {
            AppSales.DAL.ProductoDSTableAdapters.ProductosTableAdapter objDataSet = new AppSales.DAL.ProductoDSTableAdapters.ProductosTableAdapter();

            objDataSet.UpdateProduct(pkProducto, fkProveedor, txtCodigo, txtNombre, txtDescripcion, intCantidad, decValorCompra, decValorVenta,
                                     genero, fkMarca, fkModelo, fkTalla, intIdUsuario);
        }
        public static void DeleteProducto(int id)
        {
            AppSales.DAL.ProductoDSTableAdapters.ProductosTableAdapter objDataSet = new AppSales.DAL.ProductoDSTableAdapters.ProductosTableAdapter();
            objDataSet.DeleteProduct(id);
        }
    }
}
