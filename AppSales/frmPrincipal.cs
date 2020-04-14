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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Icon = AppSales.Properties.Resources.logo;
            this.Text = "Punto de Venta Minilulis";
            this.MaximizeBox = false;
        }

        public void cerrarMenus()
        {
            menuAgregarDescuento.Visible = false;
            menuPersonas.Visible = false;
            productosToolStripMenuItem.Visible = false;
            menuProductos.Visible = false;
            MenuPrincipalOfertas.Visible = false;
            menuPrincipalDecuentos.Visible = false;
            lCVToolStripMenuItem.Visible = false;
            reportesToolStripMenuItem.Visible = false;

        }

        private void menuAgregarPersonas_Click_1(object sender, EventArgs e)
        {
            frmInsertarPersonas frm = new frmInsertarPersonas();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.MaximizeBox = false;
            frm.Show();
            this.DisposeAllButThis(frm);
        }

        private void menuClientes_Click(object sender, EventArgs e)
        {
            frmClientes frm = new frmClientes();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.MaximizeBox = false;
            frm.Show();
            this.DisposeAllButThis(frm);
        }


        private void menuEmpleados_Click(object sender, EventArgs e)
        {
            frmEmpleados frm = new frmEmpleados();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.MaximizeBox = false;
            frm.Show();
            this.DisposeAllButThis(frm);
        }

        private void menuProveedores_Click(object sender, EventArgs e)
        {
            frmProveedores frm = new frmProveedores();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.MaximizeBox = false;
            frm.Show();
            this.DisposeAllButThis(frm);
        }

        private void menuAgregarProductos_Click_1(object sender, EventArgs e)
        {
            frmInsertarProductos frm = new frmInsertarProductos();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.MaximizeBox = false;
            frm.Show();
            this.DisposeAllButThis(frm);
        }

        private void menuProductos_Click(object sender, EventArgs e)
        {
            frmProductos frm = new frmProductos();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.MaximizeBox = false;
            frm.Show();
            this.DisposeAllButThis(frm);
        }

        private void menuBarCode_Click(object sender, EventArgs e)
        {
            frnEjemploBarCode frm = new frnEjemploBarCode();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.MaximizeBox = false;
            frm.Show();
            this.DisposeAllButThis(frm);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void menuVenta_Click(object sender, EventArgs e)
        {
            frmVentas frm = new frmVentas();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.MaximizeBox = false;
            frm.Show();
            this.DisposeAllButThis(frm);
        }

        private void menuStockProductos_Click(object sender, EventArgs e)
        {
            //frmReporteStockProductos frm = new frmReporteStockProductos();
            //frm.MdiParent = this;
            //frm.WindowState = FormWindowState.Maximized;
            //frm.Show();
        }

        private void MenuAgregarOfertas_Click(object sender, EventArgs e)
        {
            frmInsertarOfertas frm = new frmInsertarOfertas();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.MaximizeBox = false;
            frm.Show();
            this.DisposeAllButThis(frm);
        }

        private void MenuOfertas_Click(object sender, EventArgs e)
        {
            frmOfertas frm = new frmOfertas();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.MaximizeBox = false;
            frm.Show();
            this.DisposeAllButThis(frm);
        }

        private void menuAgregarDescuento_Click(object sender, EventArgs e)
        {
            frmInsertarDescuentos frm = new frmInsertarDescuentos();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.MaximizeBox = false;
            frm.Show();
            this.DisposeAllButThis(frm);
        }

        private void menuDescuento_Click(object sender, EventArgs e)
        {
            frmDescuentos frm = new frmDescuentos();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.MaximizeBox = false;
            frm.Show();
            this.DisposeAllButThis(frm);
        }

        private void libroDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLibroCompras frm = new frmLibroCompras();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.MaximizeBox = false;
            frm.Show();
            this.DisposeAllButThis(frm);
        }

        private void libroVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLibroVentas frm = new frmLibroVentas();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.MaximizeBox = false;
            frm.Show();
            this.DisposeAllButThis(frm);
        }

        private void menuMarcas_Click(object sender, EventArgs e)
        {
            frmInsertarMarcas frm = new frmInsertarMarcas();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.MaximizeBox = false;
            frm.Show();
            this.DisposeAllButThis(frm);
        }

        private void menuModelos_Click(object sender, EventArgs e)
        {
            frmInsertarModelos frm = new frmInsertarModelos();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.MaximizeBox = false;
            frm.Show();
            this.DisposeAllButThis(frm);
        }

        private void menuTalla_Click(object sender, EventArgs e)
        {
            frmInsertarTalla frm = new frmInsertarTalla();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.MaximizeBox = false;
            frm.Show();
            this.DisposeAllButThis(frm);
        }

        private void agregarNuevaLlaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInsertarLlaveFactura frm = new frmInsertarLlaveFactura();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.MaximizeBox = false;
            frm.Show();
            this.DisposeAllButThis(frm);
        }

        private void productosMásVendidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteMasVendido frm = new frmReporteMasVendido();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.MaximizeBox = false;
            frm.Show();
            this.DisposeAllButThis(frm);
        }

        private void ventasPorPeríodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteVentaPeriodos frm = new frmReporteVentaPeriodos();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.MaximizeBox = false;
            frm.Show();
            this.DisposeAllButThis(frm);
        }

        public void DisposeAllButThis(Form form)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() == frm.GetType() && frm != form)
                {
                    frm.Close();
                }
            }
        }

        private void menuStockProductos_Click_1(object sender, EventArgs e)
        {
            frmReporteStockProductos frm = new frmReporteStockProductos();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.MaximizeBox = false;
            frm.Show();
            this.DisposeAllButThis(frm);
        }

        private void buscarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarProducto frm = new frmBuscarProducto();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.MaximizeBox = false;
            frm.Show();
            this.DisposeAllButThis(frm);
        }

        private void menuGanancias_Click(object sender, EventArgs e)
        {
            frmReporteDeGanancias frm = new frmReporteDeGanancias();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.MaximizeBox = false;
            frm.Show();
            this.DisposeAllButThis(frm);
        }

        private void menuImprimirFacturas_Click(object sender, EventArgs e)
        {
            frmImprimirFacturas frm = new frmImprimirFacturas();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.MaximizeBox = false;
            frm.Show();
            this.DisposeAllButThis(frm);
        }

    }
}
