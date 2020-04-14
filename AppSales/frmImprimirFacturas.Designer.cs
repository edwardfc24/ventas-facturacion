namespace AppSales
{
    partial class frmImprimirFacturas
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.facturaDS = new AppSales.DAL.FacturaDS();
            this.facturaDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturasTableAdapter = new AppSales.DAL.FacturaDSTableAdapters.FacturasTableAdapter();
            this.txtNroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImprimir = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(532, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(361, 42);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "LISTADO DE FACTURAS";
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.AllowUserToDeleteRows = false;
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtNroFactura,
            this.txtFecha,
            this.txtNit,
            this.txtNombre,
            this.txtMonto,
            this.btnImprimir});
            this.dgvFacturas.Location = new System.Drawing.Point(409, 111);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.ReadOnly = true;
            this.dgvFacturas.Size = new System.Drawing.Size(644, 150);
            this.dgvFacturas.TabIndex = 13;
            this.dgvFacturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFacturas_CellContentClick);
            // 
            // facturaDS
            // 
            this.facturaDS.DataSetName = "FacturaDS";
            this.facturaDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facturaDSBindingSource
            // 
            this.facturaDSBindingSource.DataSource = this.facturaDS;
            this.facturaDSBindingSource.Position = 0;
            // 
            // facturasBindingSource
            // 
            this.facturasBindingSource.DataMember = "Facturas";
            this.facturasBindingSource.DataSource = this.facturaDSBindingSource;
            // 
            // facturasTableAdapter
            // 
            this.facturasTableAdapter.ClearBeforeFill = true;
            // 
            // txtNroFactura
            // 
            this.txtNroFactura.HeaderText = "Nro. de Factura";
            this.txtNroFactura.Name = "txtNroFactura";
            this.txtNroFactura.ReadOnly = true;
            // 
            // txtFecha
            // 
            this.txtFecha.HeaderText = "Fecha de Venta";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            // 
            // txtNit
            // 
            this.txtNit.HeaderText = "Nit Cliente";
            this.txtNit.Name = "txtNit";
            this.txtNit.ReadOnly = true;
            // 
            // txtNombre
            // 
            this.txtNombre.HeaderText = "Nombre";
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            // 
            // txtMonto
            // 
            this.txtMonto.HeaderText = "Monto de la Venta";
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.ReadOnly = true;
            // 
            // btnImprimir
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.NullValue = "Imprimir";
            this.btnImprimir.DefaultCellStyle = dataGridViewCellStyle1;
            this.btnImprimir.HeaderText = "Imprimir";
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.ReadOnly = true;
            // 
            // frmImprimirFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 607);
            this.Controls.Add(this.dgvFacturas);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmImprimirFacturas";
            this.Text = "frmImprimirFacturas";
            this.Load += new System.EventHandler(this.frmImprimirFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.BindingSource facturaDSBindingSource;
        private DAL.FacturaDS facturaDS;
        private System.Windows.Forms.BindingSource facturasBindingSource;
        private DAL.FacturaDSTableAdapters.FacturasTableAdapter facturasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNit;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMonto;
        private System.Windows.Forms.DataGridViewButtonColumn btnImprimir;
    }
}