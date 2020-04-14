namespace AppSales
{
    partial class frmInsertarLlaveFactura
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
            this.dtFechaLimite = new System.Windows.Forms.DateTimePicker();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNroAutorizacion = new System.Windows.Forms.TextBox();
            this.txtLlave = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblFechaLimite = new System.Windows.Forms.Label();
            this.lblNombreOferta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtFechaLimite
            // 
            this.dtFechaLimite.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaLimite.Location = new System.Drawing.Point(725, 330);
            this.dtFechaLimite.Margin = new System.Windows.Forms.Padding(4);
            this.dtFechaLimite.Name = "dtFechaLimite";
            this.dtFechaLimite.Size = new System.Drawing.Size(303, 26);
            this.dtFechaLimite.TabIndex = 22;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(469, 82);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(466, 42);
            this.lblTitulo.TabIndex = 21;
            this.lblTitulo.Text = "INSERTAR LLAVE DE FACTURA";
            // 
            // txtNroAutorizacion
            // 
            this.txtNroAutorizacion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroAutorizacion.Location = new System.Drawing.Point(725, 258);
            this.txtNroAutorizacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtNroAutorizacion.Name = "txtNroAutorizacion";
            this.txtNroAutorizacion.Size = new System.Drawing.Size(303, 26);
            this.txtNroAutorizacion.TabIndex = 20;
            // 
            // txtLlave
            // 
            this.txtLlave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLlave.Location = new System.Drawing.Point(725, 192);
            this.txtLlave.Margin = new System.Windows.Forms.Padding(4);
            this.txtLlave.Name = "txtLlave";
            this.txtLlave.Size = new System.Drawing.Size(303, 26);
            this.txtLlave.TabIndex = 19;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(725, 446);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(303, 43);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(392, 446);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(278, 43);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(388, 265);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(141, 19);
            this.lblDescripcion.TabIndex = 16;
            this.lblDescripcion.Text = "Nro. Autorizacion";
            // 
            // lblFechaLimite
            // 
            this.lblFechaLimite.AutoSize = true;
            this.lblFechaLimite.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaLimite.Location = new System.Drawing.Point(388, 330);
            this.lblFechaLimite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaLimite.Name = "lblFechaLimite";
            this.lblFechaLimite.Size = new System.Drawing.Size(106, 19);
            this.lblFechaLimite.TabIndex = 14;
            this.lblFechaLimite.Text = "Fecha Límite";
            // 
            // lblNombreOferta
            // 
            this.lblNombreOferta.AutoSize = true;
            this.lblNombreOferta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreOferta.Location = new System.Drawing.Point(388, 192);
            this.lblNombreOferta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreOferta.Name = "lblNombreOferta";
            this.lblNombreOferta.Size = new System.Drawing.Size(93, 19);
            this.lblNombreOferta.TabIndex = 13;
            this.lblNombreOferta.Text = "Valor Llave";
            // 
            // frmInsertarLlaveFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppSales.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1370, 542);
            this.Controls.Add(this.dtFechaLimite);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtNroAutorizacion);
            this.Controls.Add(this.txtLlave);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblFechaLimite);
            this.Controls.Add(this.lblNombreOferta);
            this.DoubleBuffered = true;
            this.Name = "frmInsertarLlaveFactura";
            this.Text = "frmInsertarLlaveFactura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtFechaLimite;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNroAutorizacion;
        private System.Windows.Forms.TextBox txtLlave;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblFechaLimite;
        private System.Windows.Forms.Label lblNombreOferta;
    }
}