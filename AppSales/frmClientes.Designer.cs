namespace AppSales
{
    partial class frmClientes
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tblClientes = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombreCompletoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDireccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTelefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCelularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCorreoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDescripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteDS = new AppSales.DAL.ClienteDS();
            this.clientesTableAdapter = new AppSales.DAL.ClienteDSTableAdapters.ClientesTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tblClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDS)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(559, 82);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(301, 42);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "LISTA DE CLIENTES";
            // 
            // tblClientes
            // 
            this.tblClientes.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.pkClienteDataGridViewTextBoxColumn,
            this.txtNitDataGridViewTextBoxColumn,
            this.txtNombreCompletoDataGridViewTextBoxColumn,
            this.txtDireccionDataGridViewTextBoxColumn,
            this.txtTelefonoDataGridViewTextBoxColumn,
            this.txtCelularDataGridViewTextBoxColumn,
            this.txtCorreoDataGridViewTextBoxColumn,
            this.txtDescripcionDataGridViewTextBoxColumn,
            this.btnUpdate,
            this.btnEliminar});
            this.tblClientes.DataSource = this.clientesBindingSource;
            this.tblClientes.Location = new System.Drawing.Point(109, 187);
            this.tblClientes.Name = "tblClientes";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblClientes.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tblClientes.Size = new System.Drawing.Size(1144, 474);
            this.tblClientes.TabIndex = 4;
            this.tblClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblClientes_CellContentClick);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "pkPersona";
            this.dataGridViewTextBoxColumn7.HeaderText = "pkPersona";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // pkClienteDataGridViewTextBoxColumn
            // 
            this.pkClienteDataGridViewTextBoxColumn.DataPropertyName = "pkCliente";
            this.pkClienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.pkClienteDataGridViewTextBoxColumn.Name = "pkClienteDataGridViewTextBoxColumn";
            this.pkClienteDataGridViewTextBoxColumn.ReadOnly = true;
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
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.clienteDS;
            // 
            // clienteDS
            // 
            this.clienteDS.DataSetName = "ClienteDS";
            this.clienteDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::AppSales.Properties.Resources.minilulis_logo;
            this.panel1.Location = new System.Drawing.Point(12, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 111);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::AppSales.Properties.Resources.minilulis_logo;
            this.panel2.Location = new System.Drawing.Point(940, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 111);
            this.panel2.TabIndex = 6;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1370, 688);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tblClientes);
            this.Controls.Add(this.lblTitulo);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "frmClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView tblClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkPersonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fkPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtApellidosDataGridViewTextBoxColumn;
        private DAL.ClienteDS clienteDS;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private DAL.ClienteDSTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkClienteDataGridViewTextBoxColumn;
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