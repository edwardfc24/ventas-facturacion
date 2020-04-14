namespace AppSales
{
    partial class frmBuscarProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscado = new System.Windows.Forms.TextBox();
            this.lblValorVenta = new System.Windows.Forms.Label();
            this.optID = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optSize = new System.Windows.Forms.RadioButton();
            this.optModel = new System.Windows.Forms.RadioButton();
            this.optMark = new System.Windows.Forms.RadioButton();
            this.optCode = new System.Windows.Forms.RadioButton();
            this.optName = new System.Windows.Forms.RadioButton();
            this.boxOpciones = new System.Windows.Forms.ComboBox();
            this.dgvEncontrados = new System.Windows.Forms.DataGridView();
            this.pkProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTalla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncontrados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(599, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(245, 37);
            this.lblTitulo.TabIndex = 39;
            this.lblTitulo.Text = "Buscar Productos";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(544, 185);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(257, 50);
            this.btnBuscar.TabIndex = 42;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscado
            // 
            this.txtBuscado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscado.Location = new System.Drawing.Point(249, 115);
            this.txtBuscado.Name = "txtBuscado";
            this.txtBuscado.Size = new System.Drawing.Size(209, 26);
            this.txtBuscado.TabIndex = 41;
            // 
            // lblValorVenta
            // 
            this.lblValorVenta.AutoSize = true;
            this.lblValorVenta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorVenta.Location = new System.Drawing.Point(130, 118);
            this.lblValorVenta.Name = "lblValorVenta";
            this.lblValorVenta.Size = new System.Drawing.Size(104, 19);
            this.lblValorVenta.TabIndex = 40;
            this.lblValorVenta.Text = "Buscar por: ";
            // 
            // optID
            // 
            this.optID.AutoSize = true;
            this.optID.Location = new System.Drawing.Point(24, 39);
            this.optID.Name = "optID";
            this.optID.Size = new System.Drawing.Size(36, 17);
            this.optID.TabIndex = 43;
            this.optID.TabStop = true;
            this.optID.Text = "ID";
            this.optID.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optSize);
            this.groupBox1.Controls.Add(this.optModel);
            this.groupBox1.Controls.Add(this.optMark);
            this.groupBox1.Controls.Add(this.optCode);
            this.groupBox1.Controls.Add(this.optName);
            this.groupBox1.Controls.Add(this.optID);
            this.groupBox1.Location = new System.Drawing.Point(464, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 75);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // optSize
            // 
            this.optSize.AutoSize = true;
            this.optSize.Location = new System.Drawing.Point(339, 39);
            this.optSize.Name = "optSize";
            this.optSize.Size = new System.Drawing.Size(48, 17);
            this.optSize.TabIndex = 48;
            this.optSize.TabStop = true;
            this.optSize.Text = "Talla";
            this.optSize.UseVisualStyleBackColor = true;
            this.optSize.CheckedChanged += new System.EventHandler(this.optSize_CheckedChanged);
            // 
            // optModel
            // 
            this.optModel.AutoSize = true;
            this.optModel.Location = new System.Drawing.Point(273, 39);
            this.optModel.Name = "optModel";
            this.optModel.Size = new System.Drawing.Size(60, 17);
            this.optModel.TabIndex = 47;
            this.optModel.TabStop = true;
            this.optModel.Text = "Modelo";
            this.optModel.UseVisualStyleBackColor = true;
            this.optModel.CheckedChanged += new System.EventHandler(this.optModel_CheckedChanged);
            // 
            // optMark
            // 
            this.optMark.AutoSize = true;
            this.optMark.Location = new System.Drawing.Point(212, 39);
            this.optMark.Name = "optMark";
            this.optMark.Size = new System.Drawing.Size(55, 17);
            this.optMark.TabIndex = 46;
            this.optMark.TabStop = true;
            this.optMark.Text = "Marca";
            this.optMark.UseVisualStyleBackColor = true;
            this.optMark.CheckedChanged += new System.EventHandler(this.optMark_CheckedChanged);
            // 
            // optCode
            // 
            this.optCode.AutoSize = true;
            this.optCode.Location = new System.Drawing.Point(148, 39);
            this.optCode.Name = "optCode";
            this.optCode.Size = new System.Drawing.Size(58, 17);
            this.optCode.TabIndex = 45;
            this.optCode.TabStop = true;
            this.optCode.Text = "Código";
            this.optCode.UseVisualStyleBackColor = true;
            // 
            // optName
            // 
            this.optName.AutoSize = true;
            this.optName.Location = new System.Drawing.Point(80, 39);
            this.optName.Name = "optName";
            this.optName.Size = new System.Drawing.Size(62, 17);
            this.optName.TabIndex = 44;
            this.optName.TabStop = true;
            this.optName.Text = "Nombre";
            this.optName.UseVisualStyleBackColor = true;
            // 
            // boxOpciones
            // 
            this.boxOpciones.Enabled = false;
            this.boxOpciones.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxOpciones.FormattingEnabled = true;
            this.boxOpciones.Location = new System.Drawing.Point(898, 110);
            this.boxOpciones.Name = "boxOpciones";
            this.boxOpciones.Size = new System.Drawing.Size(290, 26);
            this.boxOpciones.TabIndex = 49;
            this.boxOpciones.Text = "Seleccione una opción";
            // 
            // dgvEncontrados
            // 
            this.dgvEncontrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEncontrados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pkProducto,
            this.txtNombre,
            this.txtCodigo,
            this.txtMarca,
            this.txtModelo,
            this.txtTalla,
            this.btnUpdate,
            this.btnEliminar});
            this.dgvEncontrados.Location = new System.Drawing.Point(260, 270);
            this.dgvEncontrados.Name = "dgvEncontrados";
            this.dgvEncontrados.Size = new System.Drawing.Size(843, 150);
            this.dgvEncontrados.TabIndex = 50;
            this.dgvEncontrados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEncontrados_CellContentClick);
            // 
            // pkProducto
            // 
            this.pkProducto.HeaderText = "ID";
            this.pkProducto.Name = "pkProducto";
            // 
            // txtNombre
            // 
            this.txtNombre.HeaderText = "Nombre";
            this.txtNombre.Name = "txtNombre";
            // 
            // txtCodigo
            // 
            this.txtCodigo.HeaderText = "Código";
            this.txtCodigo.Name = "txtCodigo";
            // 
            // txtMarca
            // 
            this.txtMarca.HeaderText = "Marca";
            this.txtMarca.Name = "txtMarca";
            // 
            // txtModelo
            // 
            this.txtModelo.HeaderText = "Modelo";
            this.txtModelo.Name = "txtModelo";
            // 
            // txtTalla
            // 
            this.txtTalla.HeaderText = "Talla";
            this.txtTalla.Name = "txtTalla";
            // 
            // btnUpdate
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.NullValue = "Editar";
            this.btnUpdate.DefaultCellStyle = dataGridViewCellStyle1;
            this.btnUpdate.HeaderText = "Editar";
            this.btnUpdate.Name = "btnUpdate";
            // 
            // btnEliminar
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.NullValue = "Eliminar";
            this.btnEliminar.DefaultCellStyle = dataGridViewCellStyle2;
            this.btnEliminar.HeaderText = "Eliminar";
            this.btnEliminar.Name = "btnEliminar";
            // 
            // frmBuscarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 738);
            this.Controls.Add(this.dgvEncontrados);
            this.Controls.Add(this.boxOpciones);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscado);
            this.Controls.Add(this.lblValorVenta);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmBuscarProducto";
            this.Text = "frmBuscarProducto";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEncontrados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscado;
        private System.Windows.Forms.Label lblValorVenta;
        private System.Windows.Forms.RadioButton optID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optSize;
        private System.Windows.Forms.RadioButton optModel;
        private System.Windows.Forms.RadioButton optMark;
        private System.Windows.Forms.RadioButton optCode;
        private System.Windows.Forms.RadioButton optName;
        private System.Windows.Forms.ComboBox boxOpciones;
        private System.Windows.Forms.DataGridView dgvEncontrados;
        private System.Windows.Forms.DataGridViewTextBoxColumn pkProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTalla;
        private System.Windows.Forms.DataGridViewButtonColumn btnUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminar;
    }
}