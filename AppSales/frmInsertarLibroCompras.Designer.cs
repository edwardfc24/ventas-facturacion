namespace AppSales
{
    partial class frmInsertarLibroCompras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNit = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gdDetalleLibroCompras = new System.Windows.Forms.DataGridView();
            this.detalleLibroComprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalleLibroComprasDS = new AppSales.DAL.DetalleLibroComprasDS();
            this.detalleLibroComprasTableAdapter = new AppSales.DAL.DetalleLibroComprasDSTableAdapters.DetalleLibroComprasTableAdapter();
            this.btnAgregarFila = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtIdRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFechaFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNitProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombreRazon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNroDUI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNroAutorizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtImporteTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtImporteNOSujeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDescuentos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtImporteBaseCF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCreditoFiscal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodigoControl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTipoCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gdDetalleLibroCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleLibroComprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleLibroComprasDS)).BeginInit();
            this.SuspendLayout();
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(723, 152);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(290, 26);
            this.txtYear.TabIndex = 13;
            // 
            // txtMonth
            // 
            this.txtMonth.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonth.Location = new System.Drawing.Point(723, 100);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(290, 26);
            this.txtMonth.TabIndex = 12;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(447, 159);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(46, 19);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Año:";
            // 
            // lblNit
            // 
            this.lblNit.AutoSize = true;
            this.lblNit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNit.Location = new System.Drawing.Point(447, 103);
            this.lblNit.Name = "lblNit";
            this.lblNit.Size = new System.Drawing.Size(46, 19);
            this.lblNit.TabIndex = 10;
            this.lblNit.Text = "Mes:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(528, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(430, 42);
            this.lblTitulo.TabIndex = 14;
            this.lblTitulo.Text = "Edición del Libro de Compras";
            // 
            // gdDetalleLibroCompras
            // 
            this.gdDetalleLibroCompras.AllowUserToAddRows = false;
            this.gdDetalleLibroCompras.AllowUserToDeleteRows = false;
            this.gdDetalleLibroCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdDetalleLibroCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtIdRegistro,
            this.txtNro,
            this.dateFechaFactura,
            this.txtNitProveedor,
            this.txtNombreRazon,
            this.txtNroFactura,
            this.txtNroDUI,
            this.txtNroAutorizacion,
            this.txtImporteTotal,
            this.txtImporteNOSujeto,
            this.txtSubTotal,
            this.txtDescuentos,
            this.txtImporteBaseCF,
            this.txtCreditoFiscal,
            this.txtCodigoControl,
            this.txtTipoCompra,
            this.btnEliminar});
            this.gdDetalleLibroCompras.Location = new System.Drawing.Point(12, 260);
            this.gdDetalleLibroCompras.Name = "gdDetalleLibroCompras";
            this.gdDetalleLibroCompras.Size = new System.Drawing.Size(1524, 313);
            this.gdDetalleLibroCompras.TabIndex = 15;
            this.gdDetalleLibroCompras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdDetalleLibroCompras_CellContentClick);
            this.gdDetalleLibroCompras.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdDetalleLibroCompras_CellEndEdit);
            // 
            // detalleLibroComprasBindingSource
            // 
            this.detalleLibroComprasBindingSource.DataMember = "DetalleLibroCompras";
            this.detalleLibroComprasBindingSource.DataSource = this.detalleLibroComprasDS;
            // 
            // detalleLibroComprasDS
            // 
            this.detalleLibroComprasDS.DataSetName = "DetalleLibroComprasDS";
            this.detalleLibroComprasDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detalleLibroComprasTableAdapter
            // 
            this.detalleLibroComprasTableAdapter.ClearBeforeFill = true;
            // 
            // btnAgregarFila
            // 
            this.btnAgregarFila.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarFila.Location = new System.Drawing.Point(610, 198);
            this.btnAgregarFila.Name = "btnAgregarFila";
            this.btnAgregarFila.Size = new System.Drawing.Size(279, 40);
            this.btnAgregarFila.TabIndex = 16;
            this.btnAgregarFila.Text = "Agregar Compra";
            this.btnAgregarFila.UseVisualStyleBackColor = true;
            this.btnAgregarFila.Click += new System.EventHandler(this.btnAgregarFila_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(829, 605);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(279, 40);
            this.btnGuardar.TabIndex = 27;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(392, 605);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(279, 40);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtIdRegistro
            // 
            this.txtIdRegistro.HeaderText = "ID";
            this.txtIdRegistro.Name = "txtIdRegistro";
            this.txtIdRegistro.Visible = false;
            // 
            // txtNro
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.txtNro.DefaultCellStyle = dataGridViewCellStyle1;
            this.txtNro.HeaderText = "Nro.";
            this.txtNro.Name = "txtNro";
            this.txtNro.ReadOnly = true;
            this.txtNro.Width = 50;
            // 
            // dateFechaFactura
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dateFechaFactura.DefaultCellStyle = dataGridViewCellStyle2;
            this.dateFechaFactura.HeaderText = "Fecha de la Factura o DUI";
            this.dateFechaFactura.Name = "dateFechaFactura";
            // 
            // txtNitProveedor
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.txtNitProveedor.DefaultCellStyle = dataGridViewCellStyle3;
            this.txtNitProveedor.HeaderText = "NIT Proveedor";
            this.txtNitProveedor.Name = "txtNitProveedor";
            // 
            // txtNombreRazon
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.txtNombreRazon.DefaultCellStyle = dataGridViewCellStyle4;
            this.txtNombreRazon.HeaderText = "Nombre o Razón Social";
            this.txtNombreRazon.Name = "txtNombreRazon";
            // 
            // txtNroFactura
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.txtNroFactura.DefaultCellStyle = dataGridViewCellStyle5;
            this.txtNroFactura.HeaderText = "Nro. de la Factura";
            this.txtNroFactura.Name = "txtNroFactura";
            // 
            // txtNroDUI
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.txtNroDUI.DefaultCellStyle = dataGridViewCellStyle6;
            this.txtNroDUI.HeaderText = "Nro. de DUI";
            this.txtNroDUI.Name = "txtNroDUI";
            // 
            // txtNroAutorizacion
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.txtNroAutorizacion.DefaultCellStyle = dataGridViewCellStyle7;
            this.txtNroAutorizacion.HeaderText = "Nro. de Autorización";
            this.txtNroAutorizacion.Name = "txtNroAutorizacion";
            // 
            // txtImporteTotal
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.txtImporteTotal.DefaultCellStyle = dataGridViewCellStyle8;
            this.txtImporteTotal.HeaderText = "Importe Total de la Compra";
            this.txtImporteTotal.Name = "txtImporteTotal";
            // 
            // txtImporteNOSujeto
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.txtImporteNOSujeto.DefaultCellStyle = dataGridViewCellStyle9;
            this.txtImporteNOSujeto.HeaderText = "Importe no sujeto a Crédito Fiscal";
            this.txtImporteNOSujeto.Name = "txtImporteNOSujeto";
            // 
            // txtSubTotal
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.txtSubTotal.DefaultCellStyle = dataGridViewCellStyle10;
            this.txtSubTotal.HeaderText = "Subtotal";
            this.txtSubTotal.Name = "txtSubTotal";
            // 
            // txtDescuentos
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.txtDescuentos.DefaultCellStyle = dataGridViewCellStyle11;
            this.txtDescuentos.HeaderText = "Descuentos, Bonificaciones y Rebajas Obtenidas";
            this.txtDescuentos.Name = "txtDescuentos";
            // 
            // txtImporteBaseCF
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.txtImporteBaseCF.DefaultCellStyle = dataGridViewCellStyle12;
            this.txtImporteBaseCF.HeaderText = "Importe Base para Crédito Fiscal";
            this.txtImporteBaseCF.Name = "txtImporteBaseCF";
            // 
            // txtCreditoFiscal
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.txtCreditoFiscal.DefaultCellStyle = dataGridViewCellStyle13;
            this.txtCreditoFiscal.HeaderText = "Crédito Fiscal";
            this.txtCreditoFiscal.Name = "txtCreditoFiscal";
            // 
            // txtCodigoControl
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.txtCodigoControl.DefaultCellStyle = dataGridViewCellStyle14;
            this.txtCodigoControl.HeaderText = "Código de Control";
            this.txtCodigoControl.Name = "txtCodigoControl";
            // 
            // txtTipoCompra
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.txtTipoCompra.DefaultCellStyle = dataGridViewCellStyle15;
            this.txtTipoCompra.HeaderText = "Tipo de Compra";
            this.txtTipoCompra.Name = "txtTipoCompra";
            this.txtTipoCompra.Width = 50;
            // 
            // btnEliminar
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.NullValue = "Eliminar";
            this.btnEliminar.DefaultCellStyle = dataGridViewCellStyle16;
            this.btnEliminar.HeaderText = "Acciones";
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Text = "btnEliminar";
            this.btnEliminar.Width = 80;
            // 
            // frmInsertarLibroCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppSales.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1552, 699);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregarFila);
            this.Controls.Add(this.gdDetalleLibroCompras);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNit);
            this.DoubleBuffered = true;
            this.Name = "frmInsertarLibroCompras";
            this.Text = "frmInsertarLibroCompras";
            ((System.ComponentModel.ISupportInitialize)(this.gdDetalleLibroCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleLibroComprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleLibroComprasDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNit;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView gdDetalleLibroCompras;
        private DAL.DetalleLibroComprasDS detalleLibroComprasDS;
        private System.Windows.Forms.BindingSource detalleLibroComprasBindingSource;
        private DAL.DetalleLibroComprasDSTableAdapters.DetalleLibroComprasTableAdapter detalleLibroComprasTableAdapter;
        private System.Windows.Forms.Button btnAgregarFila;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtIdRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFechaFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNitProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNombreRazon;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNroDUI;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNroAutorizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtImporteTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtImporteNOSujeto;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDescuentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtImporteBaseCF;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCreditoFiscal;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCodigoControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTipoCompra;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
    }
}