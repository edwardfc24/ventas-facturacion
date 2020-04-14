namespace AppSales
{
    partial class frmProveedores
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
            this.tblProveedor = new System.Windows.Forms.DataGridView();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedorDS = new AppSales.DAL.ProveedorDS();
            this.proveedoresTableAdapter = new AppSales.DAL.ProveedorDSTableAdapters.ProveedoresTableAdapter();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pkPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombreCompletoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDireccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTelefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCelularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCorreoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDescripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDS)).BeginInit();
            this.SuspendLayout();
            // 
            // tblProveedor
            // 
            this.tblProveedor.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblProveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkPersona,
            this.pkProveedorDataGridViewTextBoxColumn,
            this.txtNitDataGridViewTextBoxColumn,
            this.txtNombreCompletoDataGridViewTextBoxColumn,
            this.txtDireccionDataGridViewTextBoxColumn,
            this.txtTelefonoDataGridViewTextBoxColumn,
            this.txtCelularDataGridViewTextBoxColumn,
            this.txtCorreoDataGridViewTextBoxColumn,
            this.txtDescripcionDataGridViewTextBoxColumn,
            this.btnUpdate,
            this.btnEliminar});
            this.tblProveedor.DataSource = this.proveedoresBindingSource;
            this.tblProveedor.Location = new System.Drawing.Point(62, 161);
            this.tblProveedor.Name = "tblProveedor";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblProveedor.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblProveedor.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tblProveedor.Size = new System.Drawing.Size(1245, 379);
            this.tblProveedor.TabIndex = 5;
            this.tblProveedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblProveedor_CellContentClick);
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataMember = "Proveedores";
            this.proveedoresBindingSource.DataSource = this.proveedorDS;
            // 
            // proveedorDS
            // 
            this.proveedorDS.DataSetName = "ProveedorDS";
            this.proveedorDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedoresTableAdapter
            // 
            this.proveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(542, 62);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(379, 42);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "LISTA DE PROVEEDORES";
            // 
            // pkPersona
            // 
            this.pkPersona.DataPropertyName = "fkPersona";
            this.pkPersona.HeaderText = "pkPersona";
            this.pkPersona.Name = "pkPersona";
            this.pkPersona.ReadOnly = true;
            // 
            // pkProveedorDataGridViewTextBoxColumn
            // 
            this.pkProveedorDataGridViewTextBoxColumn.DataPropertyName = "pkProveedor";
            this.pkProveedorDataGridViewTextBoxColumn.HeaderText = "Proveedor";
            this.pkProveedorDataGridViewTextBoxColumn.Name = "pkProveedorDataGridViewTextBoxColumn";
            this.pkProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // txtNitDataGridViewTextBoxColumn
            // 
            this.txtNitDataGridViewTextBoxColumn.DataPropertyName = "txtNit";
            this.txtNitDataGridViewTextBoxColumn.HeaderText = "Carnet";
            this.txtNitDataGridViewTextBoxColumn.Name = "txtNitDataGridViewTextBoxColumn";
            // 
            // txtNombreCompletoDataGridViewTextBoxColumn
            // 
            this.txtNombreCompletoDataGridViewTextBoxColumn.DataPropertyName = "txtNombreCompleto";
            this.txtNombreCompletoDataGridViewTextBoxColumn.HeaderText = "Nombre Completo";
            this.txtNombreCompletoDataGridViewTextBoxColumn.Name = "txtNombreCompletoDataGridViewTextBoxColumn";
            this.txtNombreCompletoDataGridViewTextBoxColumn.Width = 200;
            // 
            // txtDireccionDataGridViewTextBoxColumn
            // 
            this.txtDireccionDataGridViewTextBoxColumn.DataPropertyName = "txtDireccion";
            this.txtDireccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.txtDireccionDataGridViewTextBoxColumn.Name = "txtDireccionDataGridViewTextBoxColumn";
            // 
            // txtTelefonoDataGridViewTextBoxColumn
            // 
            this.txtTelefonoDataGridViewTextBoxColumn.DataPropertyName = "txtTelefono";
            this.txtTelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.txtTelefonoDataGridViewTextBoxColumn.Name = "txtTelefonoDataGridViewTextBoxColumn";
            // 
            // txtCelularDataGridViewTextBoxColumn
            // 
            this.txtCelularDataGridViewTextBoxColumn.DataPropertyName = "txtCelular";
            this.txtCelularDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.txtCelularDataGridViewTextBoxColumn.Name = "txtCelularDataGridViewTextBoxColumn";
            // 
            // txtCorreoDataGridViewTextBoxColumn
            // 
            this.txtCorreoDataGridViewTextBoxColumn.DataPropertyName = "txtCorreo";
            this.txtCorreoDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.txtCorreoDataGridViewTextBoxColumn.Name = "txtCorreoDataGridViewTextBoxColumn";
            this.txtCorreoDataGridViewTextBoxColumn.Width = 200;
            // 
            // txtDescripcionDataGridViewTextBoxColumn
            // 
            this.txtDescripcionDataGridViewTextBoxColumn.DataPropertyName = "txtDescripcion";
            this.txtDescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.txtDescripcionDataGridViewTextBoxColumn.Name = "txtDescripcionDataGridViewTextBoxColumn";
            this.txtDescripcionDataGridViewTextBoxColumn.Width = 200;
            // 
            // btnUpdate
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "Actualizar";
            this.btnUpdate.DefaultCellStyle = dataGridViewCellStyle2;
            this.btnUpdate.HeaderText = "############";
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnUpdate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnEliminar
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "Eliminar";
            this.btnEliminar.DefaultCellStyle = dataGridViewCellStyle3;
            this.btnEliminar.HeaderText = "###########";
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppSales.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1370, 579);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tblProveedor);
            this.DoubleBuffered = true;
            this.Name = "frmProveedores";
            this.Text = "InsertarPersona";
            this.Load += new System.EventHandler(this.frmProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkPersonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtApellidosDataGridViewTextBoxColumn;
        private DAL.ProveedorDS proveedorDS;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private DAL.ProveedorDSTableAdapters.ProveedoresTableAdapter proveedoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNombreCompletoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDireccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTelefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCelularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCorreoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDescripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btnUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
    }
}