namespace AppSales
{
    partial class frmVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNitCliente = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.tblDetalleVenta = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.boxDescuentos = new System.Windows.Forms.ComboBox();
            this.discountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descuentoDS = new AppSales.DAL.DescuentoDS();
            this.discountsTableAdapter = new AppSales.DAL.DescuentoDSTableAdapters.DiscountsTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tblDetalleVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descuentoDS)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNitCliente
            // 
            this.txtNitCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNitCliente.Location = new System.Drawing.Point(615, 83);
            this.txtNitCliente.Name = "txtNitCliente";
            this.txtNitCliente.Size = new System.Drawing.Size(290, 26);
            this.txtNitCliente.TabIndex = 11;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(525, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(335, 37);
            this.lblTitulo.TabIndex = 39;
            this.lblTitulo.Text = "FORMULARIO DE VENTA";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.Location = new System.Drawing.Point(388, 86);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(114, 19);
            this.lblProveedor.TabIndex = 40;
            this.lblProveedor.Text = "Nro. de NIT/CI";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(615, 133);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(290, 26);
            this.txtNombreCliente.TabIndex = 41;
            this.txtNombreCliente.Click += new System.EventHandler(this.txtNombreCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 19);
            this.label1.TabIndex = 42;
            this.label1.Text = "Nombre del Cliente";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(532, 608);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(289, 50);
            this.btnGuardar.TabIndex = 43;
            this.btnGuardar.Text = "Confirmar Venta";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(388, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 19);
            this.label2.TabIndex = 44;
            this.label2.Text = "Agregar Producto";
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProducto.Location = new System.Drawing.Point(615, 251);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(290, 26);
            this.txtCodigoProducto.TabIndex = 45;
            this.txtCodigoProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoProducto_KeyPress);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.Location = new System.Drawing.Point(911, 246);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(163, 33);
            this.btnAgregarProducto.TabIndex = 46;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // tblDetalleVenta
            // 
            this.tblDetalleVenta.AllowUserToAddRows = false;
            this.tblDetalleVenta.AllowUserToDeleteRows = false;
            this.tblDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblDetalleVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.txtNombreProducto,
            this.txtCodigo,
            this.txtPrecio,
            this.txtCantidad,
            this.txtSubTotal,
            this.btnEliminar});
            this.tblDetalleVenta.Location = new System.Drawing.Point(294, 308);
            this.tblDetalleVenta.Name = "tblDetalleVenta";
            this.tblDetalleVenta.Size = new System.Drawing.Size(743, 223);
            this.tblDetalleVenta.TabIndex = 47;
            this.tblDetalleVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblDetalleVenta_CellContentClick);
            this.tblDetalleVenta.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblDetalleVenta_CellEndEdit);
            // 
            // idProducto
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.idProducto.DefaultCellStyle = dataGridViewCellStyle3;
            this.idProducto.HeaderText = "Id";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.HeaderText = "Nombre";
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.ReadOnly = true;
            // 
            // txtCodigo
            // 
            this.txtCodigo.HeaderText = "Código";
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            // 
            // txtPrecio
            // 
            this.txtPrecio.HeaderText = "Precio U.";
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.ReadOnly = true;
            // 
            // txtCantidad
            // 
            this.txtCantidad.HeaderText = "Cantidad";
            this.txtCantidad.Name = "txtCantidad";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.HeaderText = "Sub Total";
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            // 
            // btnEliminar
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.NullValue = "Quitar";
            this.btnEliminar.DefaultCellStyle = dataGridViewCellStyle4;
            this.btnEliminar.HeaderText = "Quitar Producto";
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Text = "Quitar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(742, 555);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 48;
            this.label3.Text = "Total a pagar:";
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoTotal.Location = new System.Drawing.Point(972, 555);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(67, 19);
            this.lblMontoTotal.TabIndex = 49;
            this.lblMontoTotal.Text = "0000.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(388, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 19);
            this.label4.TabIndex = 50;
            this.label4.Text = "Seleccionar Descuento";
            // 
            // boxDescuentos
            // 
            this.boxDescuentos.DataSource = this.discountsBindingSource;
            this.boxDescuentos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxDescuentos.FormattingEnabled = true;
            this.boxDescuentos.Location = new System.Drawing.Point(615, 193);
            this.boxDescuentos.Name = "boxDescuentos";
            this.boxDescuentos.Size = new System.Drawing.Size(290, 26);
            this.boxDescuentos.TabIndex = 51;
            // 
            // discountsBindingSource
            // 
            this.discountsBindingSource.DataMember = "Discounts";
            this.discountsBindingSource.DataSource = this.descuentoDS;
            // 
            // descuentoDS
            // 
            this.descuentoDS.DataSetName = "DescuentoDS";
            this.descuentoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // discountsTableAdapter
            // 
            this.discountsTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::AppSales.Properties.Resources.minilulis_logo;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 290);
            this.panel1.TabIndex = 52;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::AppSales.Properties.Resources.minilulis_logo;
            this.panel2.Location = new System.Drawing.Point(947, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(411, 210);
            this.panel2.TabIndex = 53;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::AppSales.Properties.Resources.minilulis_logo;
            this.panel3.Location = new System.Drawing.Point(1043, 285);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(315, 407);
            this.panel3.TabIndex = 54;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::AppSales.Properties.Resources.minilulis_logo;
            this.panel4.Location = new System.Drawing.Point(0, 296);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(288, 405);
            this.panel4.TabIndex = 55;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1370, 704);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.boxDescuentos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMontoTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tblDetalleVenta);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.txtCodigoProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtNitCliente);
            this.DoubleBuffered = true;
            this.Name = "frmVentas";
            this.Text = "frmVEntas";
            ((System.ComponentModel.ISupportInitialize)(this.tblDetalleVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descuentoDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNitCliente;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.DataGridView tblDetalleVenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox boxDescuentos;
        private DAL.DescuentoDS descuentoDS;
        private System.Windows.Forms.BindingSource discountsBindingSource;
        private DAL.DescuentoDSTableAdapters.DiscountsTableAdapter discountsTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}