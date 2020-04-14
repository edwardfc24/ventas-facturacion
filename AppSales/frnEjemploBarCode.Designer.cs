namespace AppSales
{
    partial class frnEjemploBarCode
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

            this.lblBarCode = new System.Windows.Forms.Label();
            this.btnGenerarBarCode = new System.Windows.Forms.Button();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBarCode
            // 
            this.lblBarCode.AutoSize = true;
            this.lblBarCode.Font = new System.Drawing.Font("Bar-Code 39", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblBarCode.Location = new System.Drawing.Point(422, 83);
            this.lblBarCode.Name = "lblBarCode";
            this.lblBarCode.Size = new System.Drawing.Size(137, 40);
            this.lblBarCode.TabIndex = 0;
            this.lblBarCode.Text = "label1";
            // 
            // btnGenerarBarCode
            // 
            this.btnGenerarBarCode.Location = new System.Drawing.Point(230, 168);
            this.btnGenerarBarCode.Name = "btnGenerarBarCode";
            this.btnGenerarBarCode.Size = new System.Drawing.Size(75, 23);
            this.btnGenerarBarCode.TabIndex = 1;
            this.btnGenerarBarCode.Text = "Generar Codigo";
            this.btnGenerarBarCode.UseVisualStyleBackColor = true;
            this.btnGenerarBarCode.Click += new System.EventHandler(this.btnGenerarBarCode_Click);
            // 
            // txtBarCode
            // 
            this.txtBarCode.Location = new System.Drawing.Point(79, 83);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(100, 20);
            this.txtBarCode.TabIndex = 2;
            this.txtBarCode.TextChanged += new System.EventHandler(this.txtBarCode_TextChanged);
            this.txtBarCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarCode_KeyPress);
            // 
            // frnEjemploBarCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 467);
            this.Controls.Add(this.txtBarCode);
            this.Controls.Add(this.btnGenerarBarCode);
            this.Controls.Add(this.lblBarCode);
            this.Name = "frnEjemploBarCode";
            this.Text = "frnEjemploBarCode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBarCode;
        private System.Windows.Forms.Button btnGenerarBarCode;
        private System.Windows.Forms.TextBox txtBarCode;
    }
}