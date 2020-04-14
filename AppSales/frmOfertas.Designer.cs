namespace AppSales
{
    partial class frmOfertas
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
            this.tblOfertas = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.ofertaDS = new AppSales.DAL.OfertaDS();
            this.ofertasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ofertasTableAdapter = new AppSales.DAL.OfertaDSTableAdapters.OfertasTableAdapter();
            this.pkOfertaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFechaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFechafinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDescripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblOfertas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ofertaDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ofertasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tblOfertas
            // 
            this.tblOfertas.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblOfertas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblOfertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblOfertas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkOfertaDataGridViewTextBoxColumn,
            this.txtNombreDataGridViewTextBoxColumn,
            this.dateFechaInicioDataGridViewTextBoxColumn,
            this.dateFechafinDataGridViewTextBoxColumn,
            this.txtDescripcionDataGridViewTextBoxColumn,
            this.btnUpdate,
            this.btnEliminar});
            this.tblOfertas.DataSource = this.ofertasBindingSource;
            this.tblOfertas.Location = new System.Drawing.Point(155, 203);
            this.tblOfertas.Name = "tblOfertas";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblOfertas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblOfertas.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tblOfertas.Size = new System.Drawing.Size(1045, 428);
            this.tblOfertas.TabIndex = 5;
            this.tblOfertas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblOfertas_CellContentClick);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(541, 73);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(270, 37);
            this.lblTitulo.TabIndex = 17;
            this.lblTitulo.Text = "LISTA DE OFERTAS";
            // 
            // ofertaDS
            // 
            this.ofertaDS.DataSetName = "OfertaDS";
            this.ofertaDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ofertasBindingSource
            // 
            this.ofertasBindingSource.DataMember = "Ofertas";
            this.ofertasBindingSource.DataSource = this.ofertaDS;
            // 
            // ofertasTableAdapter
            // 
            this.ofertasTableAdapter.ClearBeforeFill = true;
            // 
            // pkOfertaDataGridViewTextBoxColumn
            // 
            this.pkOfertaDataGridViewTextBoxColumn.DataPropertyName = "id_Ofertas";
            this.pkOfertaDataGridViewTextBoxColumn.HeaderText = "pkOferta";
            this.pkOfertaDataGridViewTextBoxColumn.Name = "pkOfertaDataGridViewTextBoxColumn";
            this.pkOfertaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // txtNombreDataGridViewTextBoxColumn
            // 
            this.txtNombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.txtNombreDataGridViewTextBoxColumn.HeaderText = "Oferta";
            this.txtNombreDataGridViewTextBoxColumn.Name = "txtNombreDataGridViewTextBoxColumn";
            this.txtNombreDataGridViewTextBoxColumn.Width = 200;
            // 
            // dateFechaInicioDataGridViewTextBoxColumn
            // 
            this.dateFechaInicioDataGridViewTextBoxColumn.DataPropertyName = "FechaInicio";
            this.dateFechaInicioDataGridViewTextBoxColumn.HeaderText = "Fecha Inicial";
            this.dateFechaInicioDataGridViewTextBoxColumn.Name = "dateFechaInicioDataGridViewTextBoxColumn";
            this.dateFechaInicioDataGridViewTextBoxColumn.Width = 200;
            // 
            // dateFechafinDataGridViewTextBoxColumn
            // 
            this.dateFechafinDataGridViewTextBoxColumn.DataPropertyName = "Fechafin";
            this.dateFechafinDataGridViewTextBoxColumn.HeaderText = "Fecha Final";
            this.dateFechafinDataGridViewTextBoxColumn.Name = "dateFechafinDataGridViewTextBoxColumn";
            this.dateFechafinDataGridViewTextBoxColumn.Width = 200;
            // 
            // txtDescripcionDataGridViewTextBoxColumn
            // 
            this.txtDescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
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
            // frmOfertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppSales.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.tblOfertas);
            this.DoubleBuffered = true;
            this.Name = "frmOfertas";
            this.Text = "frmOfertas";
            this.Load += new System.EventHandler(this.frmOfertas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblOfertas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ofertaDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ofertasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tblOfertas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOfertasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaIngresoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblTitulo;
        private DAL.OfertaDS ofertaDS;
        private System.Windows.Forms.BindingSource ofertasBindingSource;
        private DAL.OfertaDSTableAdapters.OfertasTableAdapter ofertasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkOfertaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFechaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFechafinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDescripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btnUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;

    }
}