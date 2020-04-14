namespace AppSales
{
    partial class frmDescuentos
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
            this.tblDescuentos = new System.Windows.Forms.DataGridView();
            this.pkDescuentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFechaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFechaFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.discountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descuentoDS = new AppSales.DAL.DescuentoDS();
            this.discountsTableAdapter = new AppSales.DAL.DescuentoDSTableAdapters.DiscountsTableAdapter();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblDescuentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descuentoDS)).BeginInit();
            this.SuspendLayout();
            // 
            // tblDescuentos
            // 
            this.tblDescuentos.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblDescuentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblDescuentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblDescuentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkDescuentoDataGridViewTextBoxColumn,
            this.txtNombreDataGridViewTextBoxColumn,
            this.dateFechaInicioDataGridViewTextBoxColumn,
            this.dateFechaFinDataGridViewTextBoxColumn,
            this.intDescuento,
            this.txtDescripcion,
            this.btnUpdate,
            this.btnEliminar});
            this.tblDescuentos.DataSource = this.discountsBindingSource;
            this.tblDescuentos.Location = new System.Drawing.Point(176, 159);
            this.tblDescuentos.Name = "tblDescuentos";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblDescuentos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblDescuentos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tblDescuentos.Size = new System.Drawing.Size(1004, 424);
            this.tblDescuentos.TabIndex = 6;
            this.tblDescuentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblDescuentos_CellContentClick);
            // 
            // pkDescuentoDataGridViewTextBoxColumn
            // 
            this.pkDescuentoDataGridViewTextBoxColumn.DataPropertyName = "pkDescuento";
            this.pkDescuentoDataGridViewTextBoxColumn.HeaderText = "pkDescuento";
            this.pkDescuentoDataGridViewTextBoxColumn.Name = "pkDescuentoDataGridViewTextBoxColumn";
            this.pkDescuentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // txtNombreDataGridViewTextBoxColumn
            // 
            this.txtNombreDataGridViewTextBoxColumn.DataPropertyName = "txtNombre";
            this.txtNombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.txtNombreDataGridViewTextBoxColumn.Name = "txtNombreDataGridViewTextBoxColumn";
            this.txtNombreDataGridViewTextBoxColumn.Width = 200;
            // 
            // dateFechaInicioDataGridViewTextBoxColumn
            // 
            this.dateFechaInicioDataGridViewTextBoxColumn.DataPropertyName = "dateFechaInicio";
            this.dateFechaInicioDataGridViewTextBoxColumn.HeaderText = "Fecha Inicio";
            this.dateFechaInicioDataGridViewTextBoxColumn.Name = "dateFechaInicioDataGridViewTextBoxColumn";
            this.dateFechaInicioDataGridViewTextBoxColumn.Width = 130;
            // 
            // dateFechaFinDataGridViewTextBoxColumn
            // 
            this.dateFechaFinDataGridViewTextBoxColumn.DataPropertyName = "dateFechaFin";
            this.dateFechaFinDataGridViewTextBoxColumn.HeaderText = "Fecha Fin";
            this.dateFechaFinDataGridViewTextBoxColumn.Name = "dateFechaFinDataGridViewTextBoxColumn";
            this.dateFechaFinDataGridViewTextBoxColumn.Width = 130;
            // 
            // intDescuento
            // 
            this.intDescuento.DataPropertyName = "Descuento";
            this.intDescuento.HeaderText = "Descuento";
            this.intDescuento.Name = "intDescuento";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.DataPropertyName = "Descripcion";
            this.txtDescripcion.HeaderText = "Descripcion";
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Width = 200;
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
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(518, 62);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(358, 42);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "LISTA DE DESCUENTOS";
            // 
            // frmDescuentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppSales.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tblDescuentos);
            this.DoubleBuffered = true;
            this.Name = "frmDescuentos";
            this.Text = "frmDescuentos";
            this.Load += new System.EventHandler(this.frmDescuentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblDescuentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descuentoDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblDescuentos;
        private DAL.DescuentoDS descuentoDS;
        private System.Windows.Forms.BindingSource discountsBindingSource;
        private DAL.DescuentoDSTableAdapters.DiscountsTableAdapter discountsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn intDescuentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDescripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkDescuentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFechaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFechaFinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDescripcion;
        private System.Windows.Forms.DataGridViewButtonColumn btnUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
    }
}