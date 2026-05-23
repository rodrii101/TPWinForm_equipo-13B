namespace AplicacionComercio
{
    partial class FrmCategoria
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
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.btmEliminarCategoria = new System.Windows.Forms.Button();
            this.btmModificarCategoria = new System.Windows.Forms.Button();
            this.btmAgregarCategoria = new System.Windows.Forms.Button();
            this.btmVolverArticulos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCategoria.Location = new System.Drawing.Point(30, 12);
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.RowHeadersWidth = 51;
            this.dgvCategoria.RowTemplate.Height = 24;
            this.dgvCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategoria.Size = new System.Drawing.Size(372, 235);
            this.dgvCategoria.TabIndex = 0;
            // 
            // btmEliminarCategoria
            // 
            this.btmEliminarCategoria.Location = new System.Drawing.Point(108, 325);
            this.btmEliminarCategoria.Name = "btmEliminarCategoria";
            this.btmEliminarCategoria.Size = new System.Drawing.Size(96, 37);
            this.btmEliminarCategoria.TabIndex = 7;
            this.btmEliminarCategoria.Text = "Eliminar";
            this.btmEliminarCategoria.UseVisualStyleBackColor = true;
            this.btmEliminarCategoria.Click += new System.EventHandler(this.btmEliminarCategoria_Click);
            // 
            // btmModificarCategoria
            // 
            this.btmModificarCategoria.Location = new System.Drawing.Point(236, 266);
            this.btmModificarCategoria.Name = "btmModificarCategoria";
            this.btmModificarCategoria.Size = new System.Drawing.Size(96, 37);
            this.btmModificarCategoria.TabIndex = 6;
            this.btmModificarCategoria.Text = "Modificar";
            this.btmModificarCategoria.UseVisualStyleBackColor = true;
            this.btmModificarCategoria.Click += new System.EventHandler(this.btmModificarCategoria_Click);
            // 
            // btmAgregarCategoria
            // 
            this.btmAgregarCategoria.Location = new System.Drawing.Point(104, 266);
            this.btmAgregarCategoria.Name = "btmAgregarCategoria";
            this.btmAgregarCategoria.Size = new System.Drawing.Size(96, 37);
            this.btmAgregarCategoria.TabIndex = 5;
            this.btmAgregarCategoria.Text = "Agregar";
            this.btmAgregarCategoria.UseVisualStyleBackColor = true;
            this.btmAgregarCategoria.Click += new System.EventHandler(this.btmAgregarCategoria_Click);
            // 
            // btmVolverArticulos
            // 
            this.btmVolverArticulos.Location = new System.Drawing.Point(236, 325);
            this.btmVolverArticulos.Name = "btmVolverArticulos";
            this.btmVolverArticulos.Size = new System.Drawing.Size(96, 37);
            this.btmVolverArticulos.TabIndex = 8;
            this.btmVolverArticulos.Text = "Volver";
            this.btmVolverArticulos.UseVisualStyleBackColor = true;
            this.btmVolverArticulos.Click += new System.EventHandler(this.btmVolverArticulos_Click);
            // 
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 376);
            this.Controls.Add(this.btmVolverArticulos);
            this.Controls.Add(this.btmEliminarCategoria);
            this.Controls.Add(this.btmModificarCategoria);
            this.Controls.Add(this.btmAgregarCategoria);
            this.Controls.Add(this.dgvCategoria);
            this.Name = "FrmCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCategoria";
            this.Load += new System.EventHandler(this.FrmCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCategoria;
        private System.Windows.Forms.Button btmEliminarCategoria;
        private System.Windows.Forms.Button btmModificarCategoria;
        private System.Windows.Forms.Button btmAgregarCategoria;
        private System.Windows.Forms.Button btmVolverArticulos;
    }
}