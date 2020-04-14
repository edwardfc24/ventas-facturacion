namespace AppSales
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPersonas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuAgregarPersonas = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMarcas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuModelos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTalla = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAgregarProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPrincipalOfertas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuOfertas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAgregarOfertas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipalDecuentos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDescuento = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAgregarDescuento = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevaLlaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImprimirFacturas = new System.Windows.Forms.ToolStripMenuItem();
            this.lCVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libroDeComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libroVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosMásVendidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasPorPeríodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStockProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGanancias = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPersonas,
            this.productosToolStripMenuItem,
            this.MenuPrincipalOfertas,
            this.menuPrincipalDecuentos,
            this.ventasToolStripMenuItem,
            this.lCVToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(670, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuPersonas
            // 
            this.menuPersonas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuClientes,
            this.toolStripSeparator1,
            this.menuEmpleados,
            this.toolStripSeparator2,
            this.menuProveedores,
            this.toolStripSeparator3,
            this.menuAgregarPersonas});
            this.menuPersonas.Name = "menuPersonas";
            this.menuPersonas.Size = new System.Drawing.Size(66, 20);
            this.menuPersonas.Text = "Personas";
            // 
            // menuClientes
            // 
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(166, 22);
            this.menuClientes.Text = "Clientes";
            this.menuClientes.Click += new System.EventHandler(this.menuClientes_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
            // 
            // menuEmpleados
            // 
            this.menuEmpleados.Name = "menuEmpleados";
            this.menuEmpleados.Size = new System.Drawing.Size(166, 22);
            this.menuEmpleados.Text = "Empleados";
            this.menuEmpleados.Click += new System.EventHandler(this.menuEmpleados_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(163, 6);
            // 
            // menuProveedores
            // 
            this.menuProveedores.Name = "menuProveedores";
            this.menuProveedores.Size = new System.Drawing.Size(166, 22);
            this.menuProveedores.Text = "Proveedores";
            this.menuProveedores.Click += new System.EventHandler(this.menuProveedores_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(163, 6);
            // 
            // menuAgregarPersonas
            // 
            this.menuAgregarPersonas.Name = "menuAgregarPersonas";
            this.menuAgregarPersonas.Size = new System.Drawing.Size(166, 22);
            this.menuAgregarPersonas.Text = "Agregar Personas";
            this.menuAgregarPersonas.Click += new System.EventHandler(this.menuAgregarPersonas_Click_1);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMarcas,
            this.menuModelos,
            this.menuTalla,
            this.menuProductos,
            this.menuAgregarProductos,
            this.buscarProductosToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // menuMarcas
            // 
            this.menuMarcas.Name = "menuMarcas";
            this.menuMarcas.Size = new System.Drawing.Size(173, 22);
            this.menuMarcas.Text = "Marcas";
            this.menuMarcas.Click += new System.EventHandler(this.menuMarcas_Click);
            // 
            // menuModelos
            // 
            this.menuModelos.Name = "menuModelos";
            this.menuModelos.Size = new System.Drawing.Size(173, 22);
            this.menuModelos.Text = "Modelos";
            this.menuModelos.Click += new System.EventHandler(this.menuModelos_Click);
            // 
            // menuTalla
            // 
            this.menuTalla.Name = "menuTalla";
            this.menuTalla.Size = new System.Drawing.Size(173, 22);
            this.menuTalla.Text = "Talla";
            this.menuTalla.Click += new System.EventHandler(this.menuTalla_Click);
            // 
            // menuProductos
            // 
            this.menuProductos.Name = "menuProductos";
            this.menuProductos.Size = new System.Drawing.Size(173, 22);
            this.menuProductos.Text = "Productos";
            this.menuProductos.Click += new System.EventHandler(this.menuProductos_Click);
            // 
            // menuAgregarProductos
            // 
            this.menuAgregarProductos.Name = "menuAgregarProductos";
            this.menuAgregarProductos.Size = new System.Drawing.Size(173, 22);
            this.menuAgregarProductos.Text = "Agregar Productos";
            this.menuAgregarProductos.Click += new System.EventHandler(this.menuAgregarProductos_Click_1);
            // 
            // buscarProductosToolStripMenuItem
            // 
            this.buscarProductosToolStripMenuItem.Name = "buscarProductosToolStripMenuItem";
            this.buscarProductosToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.buscarProductosToolStripMenuItem.Text = "Buscar Productos";
            this.buscarProductosToolStripMenuItem.Click += new System.EventHandler(this.buscarProductosToolStripMenuItem_Click);
            // 
            // MenuPrincipalOfertas
            // 
            this.MenuPrincipalOfertas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuOfertas,
            this.MenuAgregarOfertas});
            this.MenuPrincipalOfertas.Name = "MenuPrincipalOfertas";
            this.MenuPrincipalOfertas.Size = new System.Drawing.Size(57, 20);
            this.MenuPrincipalOfertas.Text = "Ofertas";
            // 
            // MenuOfertas
            // 
            this.MenuOfertas.Name = "MenuOfertas";
            this.MenuOfertas.Size = new System.Drawing.Size(157, 22);
            this.MenuOfertas.Text = "Ofertas";
            this.MenuOfertas.Click += new System.EventHandler(this.MenuOfertas_Click);
            // 
            // MenuAgregarOfertas
            // 
            this.MenuAgregarOfertas.Name = "MenuAgregarOfertas";
            this.MenuAgregarOfertas.Size = new System.Drawing.Size(157, 22);
            this.MenuAgregarOfertas.Text = "Agregar Ofertas";
            this.MenuAgregarOfertas.Click += new System.EventHandler(this.MenuAgregarOfertas_Click);
            // 
            // menuPrincipalDecuentos
            // 
            this.menuPrincipalDecuentos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDescuento,
            this.menuAgregarDescuento});
            this.menuPrincipalDecuentos.Name = "menuPrincipalDecuentos";
            this.menuPrincipalDecuentos.Size = new System.Drawing.Size(80, 20);
            this.menuPrincipalDecuentos.Text = "Descuentos";
            // 
            // menuDescuento
            // 
            this.menuDescuento.Name = "menuDescuento";
            this.menuDescuento.Size = new System.Drawing.Size(175, 22);
            this.menuDescuento.Text = "Descuentos";
            this.menuDescuento.Click += new System.EventHandler(this.menuDescuento_Click);
            // 
            // menuAgregarDescuento
            // 
            this.menuAgregarDescuento.Name = "menuAgregarDescuento";
            this.menuAgregarDescuento.Size = new System.Drawing.Size(175, 22);
            this.menuAgregarDescuento.Text = "Agregar Descuento";
            this.menuAgregarDescuento.Click += new System.EventHandler(this.menuAgregarDescuento_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevaLlaveToolStripMenuItem,
            this.menuImprimirFacturas,
            this.ventasToolStripMenuItem1});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // agregarNuevaLlaveToolStripMenuItem
            // 
            this.agregarNuevaLlaveToolStripMenuItem.Name = "agregarNuevaLlaveToolStripMenuItem";
            this.agregarNuevaLlaveToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.agregarNuevaLlaveToolStripMenuItem.Text = "Agregar nueva Llave";
            this.agregarNuevaLlaveToolStripMenuItem.Click += new System.EventHandler(this.agregarNuevaLlaveToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem1
            // 
            this.ventasToolStripMenuItem1.Name = "ventasToolStripMenuItem1";
            this.ventasToolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.ventasToolStripMenuItem1.Text = "Ventas";
            this.ventasToolStripMenuItem1.Click += new System.EventHandler(this.menuVenta_Click);
            // 
            // menuImprimirFacturas
            // 
            this.menuImprimirFacturas.Name = "menuImprimirFacturas";
            this.menuImprimirFacturas.Size = new System.Drawing.Size(181, 22);
            this.menuImprimirFacturas.Text = "Imprimir Facturas";
            this.menuImprimirFacturas.Click += new System.EventHandler(this.menuImprimirFacturas_Click);
            // 
            // lCVToolStripMenuItem
            // 
            this.lCVToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.libroDeComprasToolStripMenuItem,
            this.libroVentasToolStripMenuItem});
            this.lCVToolStripMenuItem.Name = "lCVToolStripMenuItem";
            this.lCVToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.lCVToolStripMenuItem.Text = "LCV";
            // 
            // libroDeComprasToolStripMenuItem
            // 
            this.libroDeComprasToolStripMenuItem.Name = "libroDeComprasToolStripMenuItem";
            this.libroDeComprasToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.libroDeComprasToolStripMenuItem.Text = "Libro de Compras";
            this.libroDeComprasToolStripMenuItem.Click += new System.EventHandler(this.libroDeComprasToolStripMenuItem_Click);
            // 
            // libroVentasToolStripMenuItem
            // 
            this.libroVentasToolStripMenuItem.Name = "libroVentasToolStripMenuItem";
            this.libroVentasToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.libroVentasToolStripMenuItem.Text = "Libro de Ventas";
            this.libroVentasToolStripMenuItem.Click += new System.EventHandler(this.libroVentasToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosMásVendidosToolStripMenuItem,
            this.ventasPorPeríodosToolStripMenuItem,
            this.menuStockProductos,
            this.menuGanancias});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // productosMásVendidosToolStripMenuItem
            // 
            this.productosMásVendidosToolStripMenuItem.Name = "productosMásVendidosToolStripMenuItem";
            this.productosMásVendidosToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.productosMásVendidosToolStripMenuItem.Text = "Productos más vendidos";
            this.productosMásVendidosToolStripMenuItem.Click += new System.EventHandler(this.productosMásVendidosToolStripMenuItem_Click);
            // 
            // ventasPorPeríodosToolStripMenuItem
            // 
            this.ventasPorPeríodosToolStripMenuItem.Name = "ventasPorPeríodosToolStripMenuItem";
            this.ventasPorPeríodosToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.ventasPorPeríodosToolStripMenuItem.Text = "Ventas por períodos";
            this.ventasPorPeríodosToolStripMenuItem.Click += new System.EventHandler(this.ventasPorPeríodosToolStripMenuItem_Click);
            // 
            // menuStockProductos
            // 
            this.menuStockProductos.Name = "menuStockProductos";
            this.menuStockProductos.Size = new System.Drawing.Size(204, 22);
            this.menuStockProductos.Text = "Stock Productos";
            this.menuStockProductos.Click += new System.EventHandler(this.menuStockProductos_Click_1);
            // 
            // menuGanancias
            // 
            this.menuGanancias.Name = "menuGanancias";
            this.menuGanancias.Size = new System.Drawing.Size(204, 22);
            this.menuGanancias.Text = "Ganancias";
            this.menuGanancias.Click += new System.EventHandler(this.menuGanancias_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppSales.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(670, 248);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuProductos;
        private System.Windows.Forms.ToolStripMenuItem menuAgregarProductos;
        private System.Windows.Forms.ToolStripMenuItem MenuPrincipalOfertas;
        private System.Windows.Forms.ToolStripMenuItem MenuOfertas;
        private System.Windows.Forms.ToolStripMenuItem MenuAgregarOfertas;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalDecuentos;
        private System.Windows.Forms.ToolStripMenuItem menuDescuento;
        private System.Windows.Forms.ToolStripMenuItem menuAgregarDescuento;
        private System.Windows.Forms.ToolStripMenuItem menuPersonas;
        private System.Windows.Forms.ToolStripMenuItem menuClientes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuEmpleados;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuProveedores;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuAgregarPersonas;
        private System.Windows.Forms.ToolStripMenuItem lCVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libroDeComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libroVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevaLlaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuMarcas;
        private System.Windows.Forms.ToolStripMenuItem menuModelos;
        private System.Windows.Forms.ToolStripMenuItem menuTalla;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosMásVendidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasPorPeríodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuStockProductos;
        private System.Windows.Forms.ToolStripMenuItem buscarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuGanancias;
        private System.Windows.Forms.ToolStripMenuItem menuImprimirFacturas;
    }
}

