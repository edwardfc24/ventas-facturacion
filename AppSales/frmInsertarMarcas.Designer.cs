namespace AppSales
{
    partial class frmInsertarMarcas
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
            this.tblMarcas = new System.Windows.Forms.DataGridView();
            this.pkMarcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.marcasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.marcaDS = new AppSales.DAL.MarcaDS();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.marcasTableAdapter = new AppSales.DAL.MarcaDSTableAdapters.MarcasTableAdapter();
            this.txtPk = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tblMarcas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaDS)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(506, 87);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(334, 37);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "MARCA DE PRODUCTOS";
            // 
            // tblMarcas
            // 
            this.tblMarcas.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblMarcas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblMarcas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkMarcaDataGridViewTextBoxColumn,
            this.txtNombreDataGridViewTextBoxColumn,
            this.btnUpdate,
            this.btnEliminar});
            this.tblMarcas.DataSource = this.marcasBindingSource;
            this.tblMarcas.Location = new System.Drawing.Point(513, 340);
            this.tblMarcas.Name = "tblMarcas";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblMarcas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblMarcas.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tblMarcas.Size = new System.Drawing.Size(346, 239);
            this.tblMarcas.TabIndex = 19;
            this.tblMarcas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblMarcas_CellContentClick);
            // 
            // pkMarcaDataGridViewTextBoxColumn
            // 
            this.pkMarcaDataGridViewTextBoxColumn.DataPropertyName = "pkMarca";
            this.pkMarcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.pkMarcaDataGridViewTextBoxColumn.Name = "pkMarcaDataGridViewTextBoxColumn";
            this.pkMarcaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // txtNombreDataGridViewTextBoxColumn
            // 
            this.txtNombreDataGridViewTextBoxColumn.DataPropertyName = "txtNombre";
            this.txtNombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.txtNombreDataGridViewTextBoxColumn.Name = "txtNombreDataGridViewTextBoxColumn";
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
            // marcasBindingSource
            // 
            this.marcasBindingSource.DataMember = "Marcas";
            this.marcasBindingSource.DataSource = this.marcaDS;
            // 
            // marcaDS
            // 
            this.marcaDS.DataSetName = "MarcaDS";
            this.marcaDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtMarca
            // 
            this.txtMarca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(636, 218);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(188, 26);
            this.txtMarca.TabIndex = 22;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(536, 272);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(288, 43);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(532, 221);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(55, 19);
            this.lblMarca.TabIndex = 20;
            this.lblMarca.Text = "Marca";
            // 
            // marcasTableAdapter
            // 
            this.marcasTableAdapter.ClearBeforeFill = true;
            // 
            // txtPk
            // 
            this.txtPk.Location = new System.Drawing.Point(12, 123);
            this.txtPk.Name = "txtPk";
            this.txtPk.Size = new System.Drawing.Size(76, 20);
            this.txtPk.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::AppSales.Properties.Resources.minilulis_logo;
            this.panel1.Location = new System.Drawing.Point(6, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 737);
            this.panel1.TabIndex = 37;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::AppSales.Properties.Resources.minilulis_logo;
            this.panel2.Location = new System.Drawing.Point(865, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(494, 701);
            this.panel2.TabIndex = 38;
            // 
            // frmInsertarMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPk);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.tblMarcas);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmInsertarMarcas";
            this.Text = "frmInsertarMarcas";
            this.Load += new System.EventHandler(this.frmInsertarMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblMarcas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView tblMarcas;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblMarca;
        private DAL.MarcaDS marcaDS;
        private System.Windows.Forms.BindingSource marcasBindingSource;
        private DAL.MarcaDSTableAdapters.MarcasTableAdapter marcasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkMarcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btnUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
        private System.Windows.Forms.TextBox txtPk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}