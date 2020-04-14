namespace AppSales
{
    partial class frmInsertarTalla
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtPk = new System.Windows.Forms.TextBox();
            this.txtTalla = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblTalla = new System.Windows.Forms.Label();
            this.tblTalla = new System.Windows.Forms.DataGridView();
            this.pkTallaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tallasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tallaDS = new AppSales.DAL.TallaDS();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tallasTableAdapter = new AppSales.DAL.TallaDSTableAdapters.TallasTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tblTalla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tallasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tallaDS)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPk
            // 
            this.txtPk.Location = new System.Drawing.Point(2, 78);
            this.txtPk.Name = "txtPk";
            this.txtPk.Size = new System.Drawing.Size(76, 20);
            this.txtPk.TabIndex = 35;
            // 
            // txtTalla
            // 
            this.txtTalla.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTalla.Location = new System.Drawing.Point(625, 209);
            this.txtTalla.Margin = new System.Windows.Forms.Padding(4);
            this.txtTalla.Name = "txtTalla";
            this.txtTalla.Size = new System.Drawing.Size(184, 26);
            this.txtTalla.TabIndex = 34;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(525, 263);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(284, 43);
            this.btnGuardar.TabIndex = 33;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblTalla
            // 
            this.lblTalla.AutoSize = true;
            this.lblTalla.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTalla.Location = new System.Drawing.Point(521, 212);
            this.lblTalla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTalla.Name = "lblTalla";
            this.lblTalla.Size = new System.Drawing.Size(44, 19);
            this.lblTalla.TabIndex = 32;
            this.lblTalla.Text = "Talla";
            // 
            // tblTalla
            // 
            this.tblTalla.AutoGenerateColumns = false;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblTalla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.tblTalla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblTalla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkTallaDataGridViewTextBoxColumn,
            this.txtNombreDataGridViewTextBoxColumn,
            this.btnUpdate,
            this.btnEliminar});
            this.tblTalla.DataSource = this.tallasBindingSource;
            this.tblTalla.Location = new System.Drawing.Point(502, 331);
            this.tblTalla.Name = "tblTalla";
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblTalla.RowHeadersDefaultCellStyle = dataGridViewCellStyle34;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblTalla.RowsDefaultCellStyle = dataGridViewCellStyle35;
            this.tblTalla.Size = new System.Drawing.Size(346, 239);
            this.tblTalla.TabIndex = 31;
            this.tblTalla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblTalla_CellContentClick);
            // 
            // pkTallaDataGridViewTextBoxColumn
            // 
            this.pkTallaDataGridViewTextBoxColumn.DataPropertyName = "pkTalla";
            this.pkTallaDataGridViewTextBoxColumn.HeaderText = "Talla";
            this.pkTallaDataGridViewTextBoxColumn.Name = "pkTallaDataGridViewTextBoxColumn";
            this.pkTallaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // txtNombreDataGridViewTextBoxColumn
            // 
            this.txtNombreDataGridViewTextBoxColumn.DataPropertyName = "txtNombre";
            this.txtNombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.txtNombreDataGridViewTextBoxColumn.Name = "txtNombreDataGridViewTextBoxColumn";
            // 
            // btnUpdate
            // 
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle32.NullValue = "Actualizar";
            this.btnUpdate.DefaultCellStyle = dataGridViewCellStyle32;
            this.btnUpdate.HeaderText = "############";
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnUpdate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnEliminar
            // 
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle33.NullValue = "Eliminar";
            this.btnEliminar.DefaultCellStyle = dataGridViewCellStyle33;
            this.btnEliminar.HeaderText = "###########";
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tallasBindingSource
            // 
            this.tallasBindingSource.DataMember = "Tallas";
            this.tallasBindingSource.DataSource = this.tallaDS;
            // 
            // tallaDS
            // 
            this.tallaDS.DataSetName = "TallaDS";
            this.tallaDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(495, 78);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(340, 37);
            this.lblTitulo.TabIndex = 30;
            this.lblTitulo.Text = "TALLAS DE PRODUCTOS";
            // 
            // tallasTableAdapter
            // 
            this.tallasTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::AppSales.Properties.Resources.minilulis_logo;
            this.panel1.Location = new System.Drawing.Point(2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 701);
            this.panel1.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::AppSales.Properties.Resources.minilulis_logo;
            this.panel2.Location = new System.Drawing.Point(854, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(513, 701);
            this.panel2.TabIndex = 37;
            // 
            // frmInsertarTalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 717);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPk);
            this.Controls.Add(this.txtTalla);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblTalla);
            this.Controls.Add(this.tblTalla);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmInsertarTalla";
            this.Text = "frmInsertarTalla";
            this.Load += new System.EventHandler(this.frmInsertarTalla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblTalla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tallasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tallaDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPk;
        private System.Windows.Forms.TextBox txtTalla;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblTalla;
        private System.Windows.Forms.DataGridView tblTalla;
        private System.Windows.Forms.Label lblTitulo;
        private DAL.TallaDS tallaDS;
        private System.Windows.Forms.BindingSource tallasBindingSource;
        private DAL.TallaDSTableAdapters.TallasTableAdapter tallasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkTallaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btnUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}