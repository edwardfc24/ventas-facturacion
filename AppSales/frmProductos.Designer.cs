namespace AppSales
{
    partial class frmProductos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tblProductos = new System.Windows.Forms.DataGridView();
            this.fkProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDescripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intCantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decValorCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.decValorVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intGeneroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombre1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombre2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombre3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.chkImprimir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoDS = new AppSales.DAL.ProductoDS();
            this.btnImprimirBarCode = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.productosTableAdapter = new AppSales.DAL.ProductoDSTableAdapters.ProductosTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoDS)).BeginInit();
            this.SuspendLayout();
            // 
            // tblProductos
            // 
            this.tblProductos.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fkProveedorDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.pkProductoDataGridViewTextBoxColumn,
            this.txtCodigoDataGridViewTextBoxColumn,
            this.txtNombreDataGridViewTextBoxColumn,
            this.txtDescripcionDataGridViewTextBoxColumn,
            this.intCantidadDataGridViewTextBoxColumn,
            this.decValorCompraDataGridViewTextBoxColumn,
            this.decValorVentaDataGridViewTextBoxColumn,
            this.intGeneroDataGridViewTextBoxColumn,
            this.Genero,
            this.txtNombre1,
            this.txtNombre2,
            this.txtNombre3,
            this.txtNombreCompleto,
            this.btnUpdate,
            this.btnEliminar,
            this.chkImprimir});
            this.tblProductos.DataSource = this.productosBindingSource;
            this.tblProductos.Location = new System.Drawing.Point(12, 178);
            this.tblProductos.Name = "tblProductos";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblProductos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tblProductos.Size = new System.Drawing.Size(1346, 487);
            this.tblProductos.TabIndex = 5;
            this.tblProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblProductos_CellContentClick);
            this.tblProductos.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tblProductos_ColumnHeaderMouseClick);
            // 
            // fkProveedorDataGridViewTextBoxColumn
            // 
            this.fkProveedorDataGridViewTextBoxColumn.DataPropertyName = "fkProveedor";
            this.fkProveedorDataGridViewTextBoxColumn.HeaderText = "fkProveedor";
            this.fkProveedorDataGridViewTextBoxColumn.Name = "fkProveedorDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "fkMarca";
            this.dataGridViewTextBoxColumn1.HeaderText = "fkMarca";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fkModelo";
            this.dataGridViewTextBoxColumn2.HeaderText = "fkModelo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "fkTalla";
            this.dataGridViewTextBoxColumn3.HeaderText = "fkTalla";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // pkProductoDataGridViewTextBoxColumn
            // 
            this.pkProductoDataGridViewTextBoxColumn.DataPropertyName = "pkProducto";
            this.pkProductoDataGridViewTextBoxColumn.HeaderText = "pkProducto";
            this.pkProductoDataGridViewTextBoxColumn.Name = "pkProductoDataGridViewTextBoxColumn";
            this.pkProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // txtCodigoDataGridViewTextBoxColumn
            // 
            this.txtCodigoDataGridViewTextBoxColumn.DataPropertyName = "txtCodigo";
            this.txtCodigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.txtCodigoDataGridViewTextBoxColumn.Name = "txtCodigoDataGridViewTextBoxColumn";
            // 
            // txtNombreDataGridViewTextBoxColumn
            // 
            this.txtNombreDataGridViewTextBoxColumn.DataPropertyName = "txtNombre";
            this.txtNombreDataGridViewTextBoxColumn.HeaderText = "Producto";
            this.txtNombreDataGridViewTextBoxColumn.Name = "txtNombreDataGridViewTextBoxColumn";
            // 
            // txtDescripcionDataGridViewTextBoxColumn
            // 
            this.txtDescripcionDataGridViewTextBoxColumn.DataPropertyName = "txtDescripcion";
            this.txtDescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.txtDescripcionDataGridViewTextBoxColumn.Name = "txtDescripcionDataGridViewTextBoxColumn";
            // 
            // intCantidadDataGridViewTextBoxColumn
            // 
            this.intCantidadDataGridViewTextBoxColumn.DataPropertyName = "intCantidad";
            this.intCantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.intCantidadDataGridViewTextBoxColumn.Name = "intCantidadDataGridViewTextBoxColumn";
            // 
            // decValorCompraDataGridViewTextBoxColumn
            // 
            this.decValorCompraDataGridViewTextBoxColumn.DataPropertyName = "decValorCompra";
            this.decValorCompraDataGridViewTextBoxColumn.HeaderText = "Valor Compra";
            this.decValorCompraDataGridViewTextBoxColumn.Name = "decValorCompraDataGridViewTextBoxColumn";
            // 
            // decValorVentaDataGridViewTextBoxColumn
            // 
            this.decValorVentaDataGridViewTextBoxColumn.DataPropertyName = "decValorVenta";
            this.decValorVentaDataGridViewTextBoxColumn.HeaderText = "Valor Venta";
            this.decValorVentaDataGridViewTextBoxColumn.Name = "decValorVentaDataGridViewTextBoxColumn";
            // 
            // intGeneroDataGridViewTextBoxColumn
            // 
            this.intGeneroDataGridViewTextBoxColumn.DataPropertyName = "intGenero";
            this.intGeneroDataGridViewTextBoxColumn.HeaderText = "GeneroBase";
            this.intGeneroDataGridViewTextBoxColumn.Name = "intGeneroDataGridViewTextBoxColumn";
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Genero";
            this.Genero.Name = "Genero";
            // 
            // txtNombre1
            // 
            this.txtNombre1.DataPropertyName = "txtNombreMarca";
            this.txtNombre1.HeaderText = "Marca";
            this.txtNombre1.Name = "txtNombre1";
            // 
            // txtNombre2
            // 
            this.txtNombre2.DataPropertyName = "txtNombreTalla";
            this.txtNombre2.HeaderText = "Talla";
            this.txtNombre2.Name = "txtNombre2";
            // 
            // txtNombre3
            // 
            this.txtNombre3.DataPropertyName = "txtNombreModelo";
            this.txtNombre3.HeaderText = "Modelo";
            this.txtNombre3.Name = "txtNombre3";
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.DataPropertyName = "txtNombreProveedor";
            this.txtNombreCompleto.HeaderText = "Proveedor";
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            // 
            // btnUpdate
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "Actualizar";
            this.btnUpdate.DefaultCellStyle = dataGridViewCellStyle2;
            this.btnUpdate.HeaderText = "Acción";
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnUpdate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnEliminar
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "Eliminar";
            this.btnEliminar.DefaultCellStyle = dataGridViewCellStyle3;
            this.btnEliminar.HeaderText = "Acción";
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // chkImprimir
            // 
            this.chkImprimir.HeaderText = "Seleccionar";
            this.chkImprimir.Name = "chkImprimir";
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.productoDS;
            // 
            // productoDS
            // 
            this.productoDS.DataSetName = "ProductoDS";
            this.productoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnImprimirBarCode
            // 
            this.btnImprimirBarCode.Location = new System.Drawing.Point(1055, 149);
            this.btnImprimirBarCode.Name = "btnImprimirBarCode";
            this.btnImprimirBarCode.Size = new System.Drawing.Size(100, 23);
            this.btnImprimirBarCode.TabIndex = 6;
            this.btnImprimirBarCode.Text = "Imprimir";
            this.btnImprimirBarCode.UseVisualStyleBackColor = true;
            this.btnImprimirBarCode.Click += new System.EventHandler(this.btnImprimirBarCode_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(539, 46);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(342, 42);
            this.lblTitulo.TabIndex = 40;
            this.lblTitulo.Text = "LISTA DE PRODUCTOS";
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::AppSales.Properties.Resources.minilulis_logo;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 116);
            this.panel1.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::AppSales.Properties.Resources.minilulis_logo;
            this.panel2.Location = new System.Drawing.Point(1027, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 121);
            this.panel2.TabIndex = 42;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnImprimirBarCode);
            this.Controls.Add(this.tblProductos);
            this.DoubleBuffered = true;
            this.Name = "frmProductos";
            this.Text = "Ver Productos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNombreProveedor;
        private System.Windows.Forms.Button btnImprimirBarCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn intValorCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn intValorVenta;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkMarcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkModeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkTallaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNombreCompletoDataGridViewTextBoxColumn;
        private DAL.ProductoDS productoDS;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private DAL.ProductoDSTableAdapters.ProductosTableAdapter productosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNombre1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNombre2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNombre3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCodigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDescripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intCantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn decValorCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn decValorVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intGeneroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNombre1;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNombre2;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNombre3;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNombreCompleto;
        private System.Windows.Forms.DataGridViewButtonColumn btnUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkImprimir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}