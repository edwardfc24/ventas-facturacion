namespace AppSales
{
    partial class frmLibroVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnNuevoLibro = new System.Windows.Forms.Button();
            this.gdLibrosVentas = new System.Windows.Forms.DataGridView();
            this.pkLibroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtAñoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnExportar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnImprimir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.libroVentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libroVentasDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libroVentasDS = new AppSales.DAL.LibroVentasDS();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.libroVentasTableAdapter = new AppSales.DAL.LibroVentasDSTableAdapters.LibroVentasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gdLibrosVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroVentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroVentasDSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroVentasDS)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevoLibro
            // 
            this.btnNuevoLibro.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoLibro.Location = new System.Drawing.Point(522, 410);
            this.btnNuevoLibro.Name = "btnNuevoLibro";
            this.btnNuevoLibro.Size = new System.Drawing.Size(305, 45);
            this.btnNuevoLibro.TabIndex = 13;
            this.btnNuevoLibro.Text = "Agregar nuevo libro de venta";
            this.btnNuevoLibro.UseVisualStyleBackColor = true;
            this.btnNuevoLibro.Click += new System.EventHandler(this.btnNuevoLibro_Click);
            // 
            // gdLibrosVentas
            // 
            this.gdLibrosVentas.AllowUserToDeleteRows = false;
            this.gdLibrosVentas.AutoGenerateColumns = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdLibrosVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gdLibrosVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdLibrosVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkLibroDataGridViewTextBoxColumn,
            this.txtMesDataGridViewTextBoxColumn,
            this.txtAñoDataGridViewTextBoxColumn,
            this.btnEditar,
            this.btnExportar,
            this.btnImprimir});
            this.gdLibrosVentas.DataSource = this.libroVentasBindingSource;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdLibrosVentas.DefaultCellStyle = dataGridViewCellStyle10;
            this.gdLibrosVentas.Location = new System.Drawing.Point(358, 196);
            this.gdLibrosVentas.Name = "gdLibrosVentas";
            this.gdLibrosVentas.ReadOnly = true;
            this.gdLibrosVentas.Size = new System.Drawing.Size(643, 150);
            this.gdLibrosVentas.TabIndex = 12;
            this.gdLibrosVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdLibrosVentas_CellContentClick);
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.NullValue = "Editar";
            this.btnEditar.DefaultCellStyle = dataGridViewCellStyle7;
            this.btnEditar.HeaderText = "Acciones";
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ReadOnly = true;
            this.btnEditar.Text = "Editar";
            // 
            // btnExportar
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.NullValue = "Exportar";
            this.btnExportar.DefaultCellStyle = dataGridViewCellStyle8;
            this.btnExportar.HeaderText = "Acciones";
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.ReadOnly = true;
            // 
            // btnImprimir
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.NullValue = "Imprimir";
            this.btnImprimir.DefaultCellStyle = dataGridViewCellStyle9;
            this.btnImprimir.HeaderText = "Acciones";
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.ReadOnly = true;
            // 
            // libroVentasBindingSource
            // 
            this.libroVentasBindingSource.DataMember = "LibroVentas";
            this.libroVentasBindingSource.DataSource = this.libroVentasDSBindingSource;
            // 
            // libroVentasDSBindingSource
            // 
            this.libroVentasDSBindingSource.DataSource = this.libroVentasDS;
            this.libroVentasDSBindingSource.Position = 0;
            // 
            // libroVentasDS
            // 
            this.libroVentasDS.DataSetName = "LibroVentasDS";
            this.libroVentasDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(547, 78);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(300, 42);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Text = "LIBROS DE VENTAS";
            // 
            // libroVentasTableAdapter
            // 
            this.libroVentasTableAdapter.ClearBeforeFill = true;
            // 
            // frmLibroVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppSales.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1370, 629);
            this.Controls.Add(this.btnNuevoLibro);
            this.Controls.Add(this.gdLibrosVentas);
            this.Controls.Add(this.lblTitulo);
            this.DoubleBuffered = true;
            this.Name = "frmLibroVentas";
            this.Text = "frmLibroVentas";
            ((System.ComponentModel.ISupportInitialize)(this.gdLibrosVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroVentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroVentasDSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libroVentasDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevoLibro;
        private System.Windows.Forms.DataGridView gdLibrosVentas;
        private System.Windows.Forms.BindingSource libroVentasDSBindingSource;
        private DAL.LibroVentasDS libroVentasDS;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.BindingSource libroVentasBindingSource;
        private DAL.LibroVentasDSTableAdapters.LibroVentasTableAdapter libroVentasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkLibroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtAñoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btnEditar;
        private System.Windows.Forms.DataGridViewButtonColumn btnExportar;
        private System.Windows.Forms.DataGridViewButtonColumn btnImprimir;
    }
}