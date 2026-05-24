namespace AplicacionComercio
{
    partial class FrmMarca
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
            this.btmVolverArticulos = new System.Windows.Forms.Button();
            this.btmEliminarMarca = new System.Windows.Forms.Button();
            this.btmModificarMarca = new System.Windows.Forms.Button();
            this.btmAgregarMarca = new System.Windows.Forms.Button();
            this.dgvMarca = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // btmVolverArticulos
            // 
            this.btmVolverArticulos.Location = new System.Drawing.Point(281, 344);
            this.btmVolverArticulos.Name = "btmVolverArticulos";
            this.btmVolverArticulos.Size = new System.Drawing.Size(96, 37);
            this.btmVolverArticulos.TabIndex = 13;
            this.btmVolverArticulos.Text = "Volver";
            this.btmVolverArticulos.UseVisualStyleBackColor = true;
            this.btmVolverArticulos.Click += new System.EventHandler(this.btmVolverArticulos_Click);
            // 
            // btmEliminarMarca
            // 
            this.btmEliminarMarca.Location = new System.Drawing.Point(79, 344);
            this.btmEliminarMarca.Name = "btmEliminarMarca";
            this.btmEliminarMarca.Size = new System.Drawing.Size(96, 37);
            this.btmEliminarMarca.TabIndex = 12;
            this.btmEliminarMarca.Text = "Eliminar";
            this.btmEliminarMarca.UseVisualStyleBackColor = true;
            this.btmEliminarMarca.Click += new System.EventHandler(this.btmEliminarMarca_Click);
            // 
            // btmModificarMarca
            // 
            this.btmModificarMarca.Location = new System.Drawing.Point(281, 285);
            this.btmModificarMarca.Name = "btmModificarMarca";
            this.btmModificarMarca.Size = new System.Drawing.Size(96, 37);
            this.btmModificarMarca.TabIndex = 11;
            this.btmModificarMarca.Text = "Modificar";
            this.btmModificarMarca.UseVisualStyleBackColor = true;
            this.btmModificarMarca.Click += new System.EventHandler(this.btmModificarMarca_Click);
            // 
            // btmAgregarMarca
            // 
            this.btmAgregarMarca.Location = new System.Drawing.Point(79, 285);
            this.btmAgregarMarca.Name = "btmAgregarMarca";
            this.btmAgregarMarca.Size = new System.Drawing.Size(96, 37);
            this.btmAgregarMarca.TabIndex = 10;
            this.btmAgregarMarca.Text = "Agregar";
            this.btmAgregarMarca.UseVisualStyleBackColor = true;
            this.btmAgregarMarca.Click += new System.EventHandler(this.btmAgregarMarca_Click);
            // 
            // dgvMarca
            // 
            this.dgvMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarca.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMarca.Location = new System.Drawing.Point(46, 31);
            this.dgvMarca.Name = "dgvMarca";
            this.dgvMarca.RowHeadersWidth = 51;
            this.dgvMarca.RowTemplate.Height = 24;
            this.dgvMarca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarca.Size = new System.Drawing.Size(372, 235);
            this.dgvMarca.TabIndex = 9;
            // 
            // FrmMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 450);
            this.Controls.Add(this.btmVolverArticulos);
            this.Controls.Add(this.btmEliminarMarca);
            this.Controls.Add(this.btmModificarMarca);
            this.Controls.Add(this.btmAgregarMarca);
            this.Controls.Add(this.dgvMarca);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(469, 497);
            this.MinimumSize = new System.Drawing.Size(469, 497);
            this.Name = "FrmMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMarca";
            this.Load += new System.EventHandler(this.FrmMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btmVolverArticulos;
        private System.Windows.Forms.Button btmEliminarMarca;
        private System.Windows.Forms.Button btmModificarMarca;
        private System.Windows.Forms.Button btmAgregarMarca;
        private System.Windows.Forms.DataGridView dgvMarca;
    }
}