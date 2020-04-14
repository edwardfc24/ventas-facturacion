namespace AppSales
{
    partial class frmEmpleados
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
            this.tblEmpleados = new System.Windows.Forms.DataGridView();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadoDS = new AppSales.DAL.EmpleadoDS();
            this.empleadosTableAdapter = new AppSales.DAL.EmpleadoDSTableAdapters.EmpleadosTableAdapter();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pkEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombreCompletoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDireccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTelefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCelularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCorreoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoDS)).BeginInit();
            this.SuspendLayout();
            // 
            // tblEmpleados
            // 
            this.tblEmpleados.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.pkEmpleadoDataGridViewTextBoxColumn,
            this.txtNitDataGridViewTextBoxColumn,
            this.txtNombreCompletoDataGridViewTextBoxColumn,
            this.txtDireccionDataGridViewTextBoxColumn,
            this.txtTelefonoDataGridViewTextBoxColumn,
            this.txtCelularDataGridViewTextBoxColumn,
            this.txtCorreoDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn9,
            this.btnUpdate,
            this.btnEliminar});
            this.tblEmpleados.DataSource = this.empleadosBindingSource;
            this.tblEmpleados.Location = new System.Drawing.Point(184, 171);
            this.tblEmpleados.Name = "tblEmpleados";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblEmpleados.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tblEmpleados.Size = new System.Drawing.Size(1043, 477);
            this.tblEmpleados.TabIndex = 5;
            this.tblEmpleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblEmpleados_CellContentClick_1);
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "Empleados";
            this.empleadosBindingSource.DataSource = this.empleadoDS;
            // 
            // empleadoDS
            // 
            this.empleadoDS.DataSetName = "EmpleadoDS";
            this.empleadoDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(528, 65);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(340, 42);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "LISTA DE EMPLEADOS";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::AppSales.Properties.Resources.minilulis_logo;
            this.panel1.Location = new System.Drawing.Point(92, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 120);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::AppSales.Properties.Resources.minilulis_logo;
            this.panel2.Location = new System.Drawing.Point(911, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 120);
            this.panel2.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "pkPersona";
            this.dataGridViewTextBoxColumn8.HeaderText = "pkPersona";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // pkEmpleadoDataGridViewTextBoxColumn
            // 
            this.pkEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "pkEmpleado";
            this.pkEmpleadoDataGridViewTextBoxColumn.HeaderText = "Empleado";
            this.pkEmpleadoDataGridViewTextBoxColumn.Name = "pkEmpleadoDataGridViewTextBoxColumn";
            this.pkEmpleadoDataGridViewTextBoxColumn.ReadOnly = true;
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
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "txtContraseña";
            this.dataGridViewTextBoxColumn9.HeaderText = "Contraseña";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
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
            // frmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1370, 703);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tblEmpleados);
            this.DoubleBuffered = true;
            this.Name = "frmEmpleados";
            this.Text = "frmEmpleados";
            this.Load += new System.EventHandler(this.frmEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkPersonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtContraseñaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtApellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DAL.EmpleadoDS empleadoDS;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private DAL.EmpleadoDSTableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNombreCompletoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDireccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTelefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCelularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCorreoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewButtonColumn btnUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
    }
}