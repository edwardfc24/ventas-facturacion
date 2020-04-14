namespace AppSales
{
    partial class frmInsertarLibroVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAgregarFila = new System.Windows.Forms.Button();
            this.gdDetalleLibroVentas = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNit = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtIdRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFechaFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNroAutorizacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNitCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombreRazon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtImporteTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtImpuestos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtExcentos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtImporteVentasTasaCero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDescuentos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtImporteBaseDF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDebitoFiscal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodigoControl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gdDetalleLibroVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarFila
            // 
            this.btnAgregarFila.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarFila.Location = new System.Drawing.Point(685, 201);
            this.btnAgregarFila.Name = "btnAgregarFila";
            this.btnAgregarFila.Size = new System.Drawing.Size(279, 40);
            this.btnAgregarFila.TabIndex = 23;
            this.btnAgregarFila.Text = "Agregar Venta";
            this.btnAgregarFila.UseVisualStyleBackColor = true;
            this.btnAgregarFila.Click += new System.EventHandler(this.btnAgregarFila_Click);
            // 
            // gdDetalleLibroVentas
            // 
            this.gdDetalleLibroVentas.AllowUserToAddRows = false;
            this.gdDetalleLibroVentas.AllowUserToDeleteRows = false;
            this.gdDetalleLibroVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdDetalleLibroVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtIdRegistro,
            this.txtNro,
            this.dateFechaFactura,
            this.txtNroFactura,
            this.txtNroAutorizacion,
            this.txtEstado,
            this.txtNitCliente,
            this.txtNombreRazon,
            this.txtImporteTotal,
            this.txtImpuestos,
            this.txtExcentos,
            this.txtImporteVentasTasaCero,
            this.txtSubTotal,
            this.txtDescuentos,
            this.txtImporteBaseDF,
            this.txtDebitoFiscal,
            this.txtCodigoControl,
            this.btnEliminar});
            this.gdDetalleLibroVentas.Location = new System.Drawing.Point(14, 263);
            this.gdDetalleLibroVentas.Name = "gdDetalleLibroVentas";
            this.gdDetalleLibroVentas.Size = new System.Drawing.Size(1623, 313);
            this.gdDetalleLibroVentas.TabIndex = 22;
            this.gdDetalleLibroVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdDetalleLibroVentas_CellContentClick);
            this.gdDetalleLibroVentas.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdDetalleLibroVentas_CellEndEdit);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(603, 33);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(399, 42);
            this.lblTitulo.TabIndex = 21;
            this.lblTitulo.Text = "Edición del Libro de Ventas";
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(798, 155);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(290, 26);
            this.txtYear.TabIndex = 20;
            // 
            // txtMonth
            // 
            this.txtMonth.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonth.Location = new System.Drawing.Point(798, 103);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(290, 26);
            this.txtMonth.TabIndex = 19;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(522, 162);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(46, 19);
            this.lblNombre.TabIndex = 18;
            this.lblNombre.Text = "Año:";
            // 
            // lblNit
            // 
            this.lblNit.AutoSize = true;
            this.lblNit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNit.Location = new System.Drawing.Point(522, 106);
            this.lblNit.Name = "lblNit";
            this.lblNit.Size = new System.Drawing.Size(46, 19);
            this.lblNit.TabIndex = 17;
            this.lblNit.Text = "Mes:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(436, 603);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(279, 40);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(873, 603);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(279, 40);
            this.btnGuardar.TabIndex = 25;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtIdRegistro
            // 
            dataGridViewCellStyle1.NullValue = "-1";
            this.txtIdRegistro.DefaultCellStyle = dataGridViewCellStyle1;
            this.txtIdRegistro.HeaderText = "ID";
            this.txtIdRegistro.Name = "txtIdRegistro";
            this.txtIdRegistro.Visible = false;
            // 
            // txtNro
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.txtNro.DefaultCellStyle = dataGridViewCellStyle2;
            this.txtNro.HeaderText = "Nro.";
            this.txtNro.Name = "txtNro";
            this.txtNro.ReadOnly = true;
            this.txtNro.Width = 50;
            // 
            // dateFechaFactura
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dateFechaFactura.DefaultCellStyle = dataGridViewCellStyle3;
            this.dateFechaFactura.HeaderText = "Fecha Factura";
            this.dateFechaFactura.Name = "dateFechaFactura";
            // 
            // txtNroFactura
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.txtNroFactura.DefaultCellStyle = dataGridViewCellStyle4;
            this.txtNroFactura.HeaderText = "Nro. de Factura";
            this.txtNroFactura.Name = "txtNroFactura";
            // 
            // txtNroAutorizacion
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.txtNroAutorizacion.DefaultCellStyle = dataGridViewCellStyle5;
            this.txtNroAutorizacion.HeaderText = "Nro. de Autorización";
            this.txtNroAutorizacion.Name = "txtNroAutorizacion";
            // 
            // txtEstado
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.txtEstado.DefaultCellStyle = dataGridViewCellStyle6;
            this.txtEstado.HeaderText = "Estado";
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Width = 50;
            // 
            // txtNitCliente
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.txtNitCliente.DefaultCellStyle = dataGridViewCellStyle7;
            this.txtNitCliente.HeaderText = "NIT/CI Cliente";
            this.txtNitCliente.Name = "txtNitCliente";
            // 
            // txtNombreRazon
            // 
            this.txtNombreRazon.HeaderText = "Nombre o Razón Social";
            this.txtNombreRazon.Name = "txtNombreRazon";
            // 
            // txtImporteTotal
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.txtImporteTotal.DefaultCellStyle = dataGridViewCellStyle8;
            this.txtImporteTotal.HeaderText = "Importe Total de Venta";
            this.txtImporteTotal.Name = "txtImporteTotal";
            // 
            // txtImpuestos
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.txtImpuestos.DefaultCellStyle = dataGridViewCellStyle9;
            this.txtImpuestos.HeaderText = "Importe ICE / IEHD/ Tasas";
            this.txtImpuestos.Name = "txtImpuestos";
            // 
            // txtExcentos
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.txtExcentos.DefaultCellStyle = dataGridViewCellStyle10;
            this.txtExcentos.HeaderText = "Exportaciones y operaciones Exentas";
            this.txtExcentos.Name = "txtExcentos";
            // 
            // txtImporteVentasTasaCero
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.txtImporteVentasTasaCero.DefaultCellStyle = dataGridViewCellStyle11;
            this.txtImporteVentasTasaCero.HeaderText = "Ventas Gravadas a Tasa Cero";
            this.txtImporteVentasTasaCero.Name = "txtImporteVentasTasaCero";
            // 
            // txtSubTotal
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.txtSubTotal.DefaultCellStyle = dataGridViewCellStyle12;
            this.txtSubTotal.HeaderText = "Subtotal";
            this.txtSubTotal.Name = "txtSubTotal";
            // 
            // txtDescuentos
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.txtDescuentos.DefaultCellStyle = dataGridViewCellStyle13;
            this.txtDescuentos.HeaderText = "Descuentos, Bonificaciones y Rebajas Otorgadas";
            this.txtDescuentos.Name = "txtDescuentos";
            // 
            // txtImporteBaseDF
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.txtImporteBaseDF.DefaultCellStyle = dataGridViewCellStyle14;
            this.txtImporteBaseDF.HeaderText = "Importe Base para Débito Fiscal";
            this.txtImporteBaseDF.Name = "txtImporteBaseDF";
            // 
            // txtDebitoFiscal
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.txtDebitoFiscal.DefaultCellStyle = dataGridViewCellStyle15;
            this.txtDebitoFiscal.HeaderText = "Débito Fiscal";
            this.txtDebitoFiscal.Name = "txtDebitoFiscal";
            // 
            // txtCodigoControl
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.txtCodigoControl.DefaultCellStyle = dataGridViewCellStyle16;
            this.txtCodigoControl.HeaderText = "Código de Control";
            this.txtCodigoControl.Name = "txtCodigoControl";
            // 
            // btnEliminar
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.NullValue = "Eliminar";
            this.btnEliminar.DefaultCellStyle = dataGridViewCellStyle17;
            this.btnEliminar.HeaderText = "Acciones";
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Text = "btnEliminar";
            this.btnEliminar.Width = 80;
            // 
            // frmInsertarLibroVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppSales.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1651, 655);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregarFila);
            this.Controls.Add(this.gdDetalleLibroVentas);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNit);
            this.DoubleBuffered = true;
            this.Name = "frmInsertarLibroVentas";
            this.Text = "frmInsertarLibroVentas";
            ((System.ComponentModel.ISupportInitialize)(this.gdDetalleLibroVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarFila;
        private System.Windows.Forms.DataGridView gdDetalleLibroVentas;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNit;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtIdRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFechaFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNroAutorizacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNitCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNombreRazon;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtImporteTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtImpuestos;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtExcentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtImporteVentasTasaCero;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDescuentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtImporteBaseDF;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDebitoFiscal;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCodigoControl;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
    }
}