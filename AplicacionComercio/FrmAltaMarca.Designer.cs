namespace AplicacionComercio
{
    partial class FrmAltaMarca
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
            this.txtDescripcionMarca = new System.Windows.Forms.TextBox();
            this.txtIdMarca = new System.Windows.Forms.TextBox();
            this.lblDescripcionMarca = new System.Windows.Forms.Label();
            this.lblIdMarca = new System.Windows.Forms.Label();
            this.btmCancelar = new System.Windows.Forms.Button();
            this.btmAgregarMarca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDescripcionMarca
            // 
            this.txtDescripcionMarca.Location = new System.Drawing.Point(134, 100);
            this.txtDescripcionMarca.Name = "txtDescripcionMarca";
            this.txtDescripcionMarca.Size = new System.Drawing.Size(100, 22);
            this.txtDescripcionMarca.TabIndex = 18;
            // 
            // txtIdMarca
            // 
            this.txtIdMarca.Enabled = false;
            this.txtIdMarca.Location = new System.Drawing.Point(134, 52);
            this.txtIdMarca.Name = "txtIdMarca";
            this.txtIdMarca.Size = new System.Drawing.Size(100, 22);
            this.txtIdMarca.TabIndex = 17;
            // 
            // lblDescripcionMarca
            // 
            this.lblDescripcionMarca.AutoSize = true;
            this.lblDescripcionMarca.Location = new System.Drawing.Point(42, 103);
            this.lblDescripcionMarca.Name = "lblDescripcionMarca";
            this.lblDescripcionMarca.Size = new System.Drawing.Size(79, 16);
            this.lblDescripcionMarca.TabIndex = 16;
            this.lblDescripcionMarca.Text = "Descripcion";
            // 
            // lblIdMarca
            // 
            this.lblIdMarca.AutoSize = true;
            this.lblIdMarca.Location = new System.Drawing.Point(101, 55);
            this.lblIdMarca.Name = "lblIdMarca";
            this.lblIdMarca.Size = new System.Drawing.Size(18, 16);
            this.lblIdMarca.TabIndex = 15;
            this.lblIdMarca.Text = "Id";
            // 
            // btmCancelar
            // 
            this.btmCancelar.Location = new System.Drawing.Point(176, 162);
            this.btmCancelar.Name = "btmCancelar";
            this.btmCancelar.Size = new System.Drawing.Size(96, 37);
            this.btmCancelar.TabIndex = 14;
            this.btmCancelar.Text = "Cancelar";
            this.btmCancelar.UseVisualStyleBackColor = true;
            this.btmCancelar.Click += new System.EventHandler(this.btmCancelar_Click);
            // 
            // btmAgregarMarca
            // 
            this.btmAgregarMarca.Location = new System.Drawing.Point(44, 162);
            this.btmAgregarMarca.Name = "btmAgregarMarca";
            this.btmAgregarMarca.Size = new System.Drawing.Size(96, 37);
            this.btmAgregarMarca.TabIndex = 13;
            this.btmAgregarMarca.Text = "Agregar";
            this.btmAgregarMarca.UseVisualStyleBackColor = true;
            this.btmAgregarMarca.Click += new System.EventHandler(this.btmAgregarMarca_Click);
            // 
            // FrmAltaMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 348);
            this.Controls.Add(this.txtDescripcionMarca);
            this.Controls.Add(this.txtIdMarca);
            this.Controls.Add(this.lblDescripcionMarca);
            this.Controls.Add(this.lblIdMarca);
            this.Controls.Add(this.btmCancelar);
            this.Controls.Add(this.btmAgregarMarca);
            this.Name = "FrmAltaMarca";
            this.Text = "FrmAltaMarca";
            this.Load += new System.EventHandler(this.FrmAltaMarca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescripcionMarca;
        private System.Windows.Forms.TextBox txtIdMarca;
        private System.Windows.Forms.Label lblDescripcionMarca;
        private System.Windows.Forms.Label lblIdMarca;
        private System.Windows.Forms.Button btmCancelar;
        private System.Windows.Forms.Button btmAgregarMarca;
    }
}