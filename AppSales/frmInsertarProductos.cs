using AppSales.BLL;
using AppSales.DTO;
using AppSales.Validacion;
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
    public partial class frmInsertarProductos : Form
    {
        private Producto producto;
        private Validaciones validacion;
        private int tipoInsercion = 0;
        public string codProduct = "";
        private int cantidadAuxiliar=0;
        private int decValorCompraAuxiliar = 0;
        public frmInsertarProductos()
        {
            InitializeComponent();
            cargarDatos();
            validacion = new Validaciones();
            this.Text = "Insertar Producto";
        }

        #region get-set

        public int DecValorCompraAuxiliar
        {
            get { return decValorCompraAuxiliar; }
            set { decValorCompraAuxiliar = value; }
        }

        public int CantidadAuxiliar
        {
            get { return cantidadAuxiliar; }
            set { cantidadAuxiliar = value; }
        }

        public int TipoInsercion
        {
            get { return tipoInsercion; }
            set { tipoInsercion = value; }
        }

        public string CodProducto
        {
            get { return codProduct; }
            set { codProduct = value; }
        }

        public ComboBox BoxProveedor
        {
            get { return boxProveedor; }
            set { boxProveedor = value; }
        }
        public ComboBox BoxGenero
        {
            get { return boxGenero; }
            set { boxGenero = value; }
        }
        public ComboBox BoxMarca
        {
            get { return boxMarcas; }
            set { boxMarcas = value; }
        }
        public ComboBox BoxModelo
        {
            get { return boxModelos; }
            set { boxModelos = value; }
        }
        public ComboBox BoxTalla
        {
            get { return boxTallas; }
            set { boxTallas = value; }
        }
        public TextBox TxtCodigo
        {
            get { return txtCodigo; }
            set { txtCodigo = value; }
        }

        public TextBox TxtNombre
        {
            get { return txtNombre; }
            set { txtNombre = value; }
        }

        public TextBox TxtDescripcion
        {
            get { return txtDescripcion; }
            set { txtDescripcion = value; }
        }

        public TextBox TxtCantidad
        {
            get { return txtCantidad; }
            set { txtCantidad = value; }
        }

        public TextBox TxtValorCompra
        {
            get { return txtValorCompra; }
            set { txtValorCompra = value; }
        }

        public TextBox TxtValorVenta
        {
            get { return txtValorVenta; }
            set { txtValorVenta = value; }
        }
        #endregion


        private void frmProductos_Load(object sender, EventArgs e)
        {
            //this.cargarDatos();
        }

        private void btnGuardarRegistro_Click(object sender, EventArgs e)
        {
            if (validacion.nulos(txtCodigo) && validacion.nulos(txtDescripcion) && validacion.nulos(txtNombre) && validacion.nulos(txtCantidad)
                && validacion.nulos(txtValorCompra) && validacion.nulos(txtValorVenta) && BoxProveedor.SelectedIndex!=-1 && boxModelos.SelectedIndex>=0 && 
                BoxTalla.SelectedIndex >=0 && BoxMarca.SelectedIndex >=0)
            {
                this.insertarRegistro();
            }
            else
            {
                MessageBox.Show("Por favor revise que todos lo datos esten correctos");
            }
        }

        public void cargarDatos()
        {
            // Se carga boxProveedores
            boxProveedor.DataSource = ProveedorBLL.GetProveedorByName("");
            boxProveedor.ValueMember = "pkProveedor";
            boxProveedor.DisplayMember = "txtNombreCompleto";
            boxProveedor.SelectedIndex = -1;
            boxProveedor.Text = "Elija su proveedor";
            // Se carga Genero
            boxGenero.Items.Insert(0, "Elija un género");
            boxGenero.Items.Insert(1, "Niño");
            boxGenero.Items.Insert(2, "Niña");
            // Se carga boxMarcas
            boxMarcas.DataSource = MarcaBLL.SelectAll();
            boxMarcas.ValueMember = "pkMarca";
            boxMarcas.DisplayMember = "txtNombre";
            boxMarcas.SelectedIndex = -1;
            boxMarcas.Text = "Elija su Marca";
            // Se carga boxModelos
            boxModelos.DataSource = ModeloBLL.SelectAll();
            boxModelos.ValueMember = "pkModelo";
            boxModelos.DisplayMember = "txtNombre";
            boxModelos.SelectedIndex = -1;
            boxModelos.Text = "Elija su Modelo";
            // Se carga boxTallas
            boxTallas.DataSource = TallaBLL.SelectAll();
            boxTallas.ValueMember = "pkTalla";
            boxTallas.DisplayMember = "txtNombre";
            boxTallas.SelectedIndex = -1;
            boxTallas.Text = "Elija su Talla";
        }

        public void insertarRegistro()
        {
            producto = new Producto();
            if (tipoInsercion == 0)
            {
                producto.fkProveedor = Convert.ToInt32(boxProveedor.SelectedValue);
                producto.txtCodigo = txtCodigo.Text;
                producto.txtNombre = txtNombre.Text;
                producto.txtDescripcion = txtDescripcion.Text;
                producto.intCantidad = Convert.ToInt32(txtCantidad.Text);
                if (boxGenero.SelectedIndex == 1)
                {
                    producto.intGenero = 0;
                }
                if(boxGenero.SelectedIndex == 2)
                {
                    producto.intGenero = 1;
                }

                producto.fkMarca = Convert.ToInt32(boxMarcas.SelectedValue);
                producto.fkModelo = Convert.ToInt32(boxModelos.SelectedValue);
                producto.fkTalla = Convert.ToInt32(boxTallas.SelectedValue);
                producto.decValorCompra = Convert.ToDecimal(txtValorCompra.Text);
                producto.decValorVenta = Convert.ToDecimal(txtValorVenta.Text);
                producto.intIdUsuarioModificacion = IdUsuario.IdUsuarioConectado;
                ProductoBLL.InsertObjetoProducto(producto);
                MessageBox.Show("Producto Guardado Satisfactoriamente");
                this.resetearDatos();
            }

            if (tipoInsercion == 1)
            {
                producto.pkProducto = Convert.ToInt16(codProduct);
                producto.fkProveedor = Convert.ToInt16(boxProveedor.SelectedValue);
                producto.txtCodigo = txtCodigo.Text;
                producto.txtNombre = txtNombre.Text;
                producto.txtDescripcion = txtDescripcion.Text;
                producto.intCantidad = Convert.ToInt16(txtCantidad.Text);
                producto.fkMarca = Convert.ToInt32(boxMarcas.SelectedValue);
                producto.fkModelo = Convert.ToInt32(boxModelos.SelectedValue);
                producto.fkTalla = Convert.ToInt32(boxTallas.SelectedValue);
                if (boxGenero.SelectedIndex == 1)
                {
                    producto.intGenero = 0;
                }
                if (boxGenero.SelectedIndex == 2)
                {
                    producto.intGenero = 1;
                }
                producto.decValorCompra = Convert.ToDecimal(txtValorCompra.Text);
                producto.decValorVenta = Convert.ToDecimal(txtValorVenta.Text);
                producto.intIdUsuarioModificacion = 1;
                ProductoBLL.UpdateProducto(producto);
                MessageBox.Show("El registro se ha actualizado correctamente");
                frmProductos frm = new frmProductos();
                frm.MdiParent = this.MdiParent;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
                this.Dispose();
            }
        }

        public void DisposeAllButThis(Form form)
        {
            foreach (Form frm in this.MdiParent.MdiChildren)
            {
                if (frm.GetType() != form.GetType() || frm.GetType() == form.GetType())
                {
                    frm.Close();
                }
            }
        }

        private void frmInsertarProductos_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        public void resetearDatos()
        {
            txtCantidad.Text = "";
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtNombre.Text = "";
            txtValorCompra.Text = "";
            txtValorVenta.Text = "";
            boxMarcas.SelectedIndex = -1;
            boxMarcas.Text = "Elija su Marca";
            boxProveedor.SelectedIndex = -1;
            boxProveedor.Text = "Elija su proveedor";
            boxModelos.SelectedIndex = -1;
            boxModelos.Text = "Elija su Modelo";
            boxTallas.SelectedIndex = -1;
            boxTallas.Text = "Elija su Talla";
            boxGenero.SelectedIndex = -1;
            boxGenero.Text = "Elija un género";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
