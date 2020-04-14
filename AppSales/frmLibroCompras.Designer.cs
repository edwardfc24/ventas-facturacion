namespace AppSales
{
    partial class frmLibroCompras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gdLibrosCompras = new System.Windows.Forms.DataGridView();
            this.pkLibroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAñoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnExportar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnImprimir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.libroComprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libroComprasDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libroComprasDS = new AppSales.DAL.LibroComprasDS();
            this.libroComprasTableAdapter = new AppSales.DAL.LibroComprasDSTableAdapters.LibroComprasTableAdapter();
            this.btnNuevoLibro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdLibrosCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroComprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroComprasDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroComprasDS)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(518, 72);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(338, 42);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "LIBROS DE COMPRAS ";
            // 
            // gdLibrosCompras
            // 
            this.gdLibrosCompras.AllowUserToDeleteRows = false;
            this.gdLibrosCompras.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdLibrosCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gdLibrosCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdLibrosCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkLibroDataGridViewTextBoxColumn,
            this.txtMesDataGridViewTextBoxColumn,
            this.txtAñoDataGridViewTextBoxColumn,
            this.btnEditar,
            this.btnExportar,
            this.btnImprimir});
            this.gdLibrosCompras.DataSource = this.libroComprasBindingSource;
            this.gdLibrosCompras.Location = new System.Drawing.Point(349, 204);
            this.gdLibrosCompras.Name = "gdLibrosCompras";
            this.gdLibrosCompras.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdLibrosCompras.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gdLibrosCompras.Size = new System.Drawing.Size(643, 150);
            this.gdLibrosCompras.TabIndex = 9;
            this.gdLibrosCompras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdLibrosCompras_CellContentClick);
            // 
            // pkLibroDataGridViewTextBoxColumn
            // 
            this.pkLibroDataGridViewTextBoxColumn.DataPropertyName = "pkLibro";
            this.pkLibroDataGridViewTextBoxColumn.HeaderText = "idLibro";
            this.pkLibroDataGridViewTextBoxColumn.Name = "pkLibroDataGridViewTextBoxColumn";
            this.pkLibroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // txtMesDataGridViewTextBoxColumn
            // 
            this.txtMesDataGridViewTextBoxColumn.DataPropertyName = "txtMes";
            this.txtMesDataGridViewTextBoxColumn.HeaderText = "Mes";
            this.txtMesDataGridViewTextBoxColumn.Name = "txtMesDataGridViewTextBoxColumn";
            this.txtMesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // txtAñoDataGridViewTextBoxColumn
            // 
            this.txtAñoDataGridViewTextBoxColumn.DataPropertyName = "txtAño";
            this.txtAñoDataGridViewTextBoxColumn.HeaderText = "Año";
            this.txtAñoDataGridViewTextBoxColumn.Name = "txtAñoDataGridViewTextBoxColumn";
            this.txtAñoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnEditar
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.NullValue = "Editar";
            this.btnEditar.DefaultCellStyle = dataGridViewCellStyle2;
            this.btnEditar.HeaderText = "Acciones";
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ReadOnly = true;
            this.btnEditar.Text = "Editar";
            // 
            // btnExportar
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.NullValue = "Exportar";
            this.btnExportar.DefaultCellStyle = dataGridViewCellStyle3;
            this.btnExportar.HeaderText = "Acciones";
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.ReadOnly = true;
            // 
            // btnImprimir
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.NullValue = "Imprimir";
            this.btnImprimir.DefaultCellStyle = dataGridViewCellStyle4;
            this.btnImprimir.HeaderText = "Acciones";
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.ReadOnly = true;
            // 
            // libroComprasBindingSource
            // 
            this.libroComprasBindingSource.DataMember = "LibroCompras";
            this.libroComprasBindingSource.DataSource = this.libroComprasDSBindingSource;
            // 
            // libroComprasDSBindingSource
            // 
            this.libroComprasDSBindingSource.DataSource = this.libroComprasDS;
            this.libroComprasDSBindingSource.Position = 0;
            // 
            // libroComprasDS
            // 
            this.libroComprasDS.DataSetName = "LibroComprasDS";
            this.libroComprasDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // libroComprasTableAdapter
            // 
            this.libroComprasTableAdapter.ClearBeforeFill = true;
            // 
            // btnNuevoLibro
            // 
            this.btnNuevoLibro.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoLibro.Location = new System.Drawing.Point(506, 429);
            this.btnNuevoLibro.Name = "btnNuevoLibro";
            this.btnNuevoLibro.Size = new System.Drawing.Size(331, 48);
            this.btnNuevoLibro.TabIndex = 10;
            this.btnNuevoLibro.Text = "Agregar nuevo libro de compra";
            this.btnNuevoLibro.UseVisualStyleBackColor = true;
            this.btnNuevoLibro.Click += new System.EventHandler(this.btnNuevoLibro_Click);
            // 
            // frmLibroCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppSales.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1370, 645);
            this.Controls.Add(this.btnNuevoLibro);
            this.Controls.Add(this.gdLibrosCompras);
            this.Controls.Add(this.lblTitulo);
            this.DoubleBuffered = true;
            this.Name = "frmLibroCompras";
            this.Text = "frmLibroCompras";
            ((System.ComponentModel.ISupportInitialize)(this.gdLibrosCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroComprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroComprasDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroComprasDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView gdLibrosCompras;
        private DAL.LibroComprasDS libroComprasDS;
        private System.Windows.Forms.BindingSource libroComprasDSBindingSource;
        private System.Windows.Forms.BindingSource libroComprasBindingSource;
        private DAL.LibroComprasDSTableAdapters.LibroComprasTableAdapter libroComprasTableAdapter;
        private System.Windows.Forms.Button btnNuevoLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkLibroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAñoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnExportar;
        private System.Windows.Forms.DataGridViewButtonColumn btnImprimir;
    }
}