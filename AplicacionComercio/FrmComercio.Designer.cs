namespace AplicacionComercio
{
    partial class frmComercio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvArticulo = new System.Windows.Forms.DataGridView();
            this.picImageArticulos = new System.Windows.Forms.PictureBox();
            this.btmAgregar = new System.Windows.Forms.Button();
            this.btmModificar = new System.Windows.Forms.Button();
            this.btmEliminar = new System.Windows.Forms.Button();
            this.lblFiltrarRapido = new System.Windows.Forms.Label();
            this.txtFiltradoRapido = new System.Windows.Forms.TextBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.txtFiltradoAvanzado = new System.Windows.Forms.TextBox();
            this.btmFiltrarAvanzado = new System.Windows.Forms.Button();
            this.btmGestionCategoria = new System.Windows.Forms.Button();
            this.btmGestionMarca = new System.Windows.Forms.Button();
            this.btmVerDetalle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImageArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulo
            // 
            this.dgvArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulo.Location = new System.Drawing.Point(13, 61);
            this.dgvArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvArticulo.Name = "dgvArticulo";
            this.dgvArticulo.RowHeadersWidth = 62;
            this.dgvArticulo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulo.Size = new System.Drawing.Size(906, 261);
            this.dgvArticulo.TabIndex = 0;
            this.dgvArticulo.SelectionChanged += new System.EventHandler(this.dgvArticulo_SelectionChanged);
            // 
            // picImageArticulos
            // 
            this.picImageArticulos.Location = new System.Drawing.Point(974, 61);
            this.picImageArticulos.Margin = new System.Windows.Forms.Padding(4);
            this.picImageArticulos.Name = "picImageArticulos";
            this.picImageArticulos.Size = new System.Drawing.Size(328, 261);
            this.picImageArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImageArticulos.TabIndex = 1;
            this.picImageArticulos.TabStop = false;
            // 
            // btmAgregar
            // 
            this.btmAgregar.Location = new System.Drawing.Point(27, 338);
            this.btmAgregar.Name = "btmAgregar";
            this.btmAgregar.Size = new System.Drawing.Size(96, 37);
            this.btmAgregar.TabIndex = 2;
            this.btmAgregar.Text = "Agregar";
            this.btmAgregar.UseVisualStyleBackColor = true;
            this.btmAgregar.Click += new System.EventHandler(this.btmAgregar_Click);
            // 
            // btmModificar
            // 
            this.btmModificar.Location = new System.Drawing.Point(150, 338);
            this.btmModificar.Name = "btmModificar";
            this.btmModificar.Size = new System.Drawing.Size(96, 37);
            this.btmModificar.TabIndex = 3;
            this.btmModificar.Text = "Modificar";
            this.btmModificar.UseVisualStyleBackColor = true;
            this.btmModificar.Click += new System.EventHandler(this.btmModificar_Click);
            // 
            // btmEliminar
            // 
            this.btmEliminar.Location = new System.Drawing.Point(281, 338);
            this.btmEliminar.Name = "btmEliminar";
            this.btmEliminar.Size = new System.Drawing.Size(96, 37);
            this.btmEliminar.TabIndex = 4;
            this.btmEliminar.Text = "Eliminar";
            this.btmEliminar.UseVisualStyleBackColor = true;
            this.btmEliminar.Click += new System.EventHandler(this.btmEliminar_Click);
            // 
            // lblFiltrarRapido
            // 
            this.lblFiltrarRapido.AutoSize = true;
            this.lblFiltrarRapido.Location = new System.Drawing.Point(26, 15);
            this.lblFiltrarRapido.Name = "lblFiltrarRapido";
            this.lblFiltrarRapido.Size = new System.Drawing.Size(97, 16);
            this.lblFiltrarRapido.TabIndex = 5;
            this.lblFiltrarRapido.Text = "Filtrado rapido ";
            // 
            // txtFiltradoRapido
            // 
            this.txtFiltradoRapido.Location = new System.Drawing.Point(129, 12);
            this.txtFiltradoRapido.Name = "txtFiltradoRapido";
            this.txtFiltradoRapido.Size = new System.Drawing.Size(258, 22);
            this.txtFiltradoRapido.TabIndex = 6;
            this.txtFiltradoRapido.TextChanged += new System.EventHandler(this.txtFiltradoRapido_TextChanged);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(58, 413);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(51, 16);
            this.lblCampo.TabIndex = 7;
            this.lblCampo.Text = "Campo";
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(129, 410);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(144, 24);
            this.cboCampo.TabIndex = 9;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(377, 410);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(144, 24);
            this.cboCriterio.TabIndex = 11;
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(302, 413);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(49, 16);
            this.lblCriterio.TabIndex = 10;
            this.lblCriterio.Text = "Criterio";
            // 
            // txtFiltradoAvanzado
            // 
            this.txtFiltradoAvanzado.Location = new System.Drawing.Point(555, 410);
            this.txtFiltradoAvanzado.Name = "txtFiltradoAvanzado";
            this.txtFiltradoAvanzado.Size = new System.Drawing.Size(258, 22);
            this.txtFiltradoAvanzado.TabIndex = 12;
            // 
            // btmFiltrarAvanzado
            // 
            this.btmFiltrarAvanzado.Location = new System.Drawing.Point(852, 403);
            this.btmFiltrarAvanzado.Name = "btmFiltrarAvanzado";
            this.btmFiltrarAvanzado.Size = new System.Drawing.Size(96, 37);
            this.btmFiltrarAvanzado.TabIndex = 13;
            this.btmFiltrarAvanzado.Text = "Buscar";
            this.btmFiltrarAvanzado.UseVisualStyleBackColor = true;
            this.btmFiltrarAvanzado.Click += new System.EventHandler(this.btmFiltrarAvanzado_Click);
            // 
            // btmGestionCategoria
            // 
            this.btmGestionCategoria.Location = new System.Drawing.Point(413, 338);
            this.btmGestionCategoria.Name = "btmGestionCategoria";
            this.btmGestionCategoria.Size = new System.Drawing.Size(158, 37);
            this.btmGestionCategoria.TabIndex = 14;
            this.btmGestionCategoria.Text = "Gestion Categoria";
            this.btmGestionCategoria.UseVisualStyleBackColor = true;
            this.btmGestionCategoria.Click += new System.EventHandler(this.btmGestionCategoria_Click);
            // 
            // btmGestionMarca
            // 
            this.btmGestionMarca.Location = new System.Drawing.Point(604, 338);
            this.btmGestionMarca.Name = "btmGestionMarca";
            this.btmGestionMarca.Size = new System.Drawing.Size(158, 37);
            this.btmGestionMarca.TabIndex = 15;
            this.btmGestionMarca.Text = "Gestion Marca";
            this.btmGestionMarca.UseVisualStyleBackColor = true;
            this.btmGestionMarca.Click += new System.EventHandler(this.btmGestionMarca_Click);
            // 
            // btmVerDetalle
            // 
            this.btmVerDetalle.Location = new System.Drawing.Point(790, 338);
            this.btmVerDetalle.Name = "btmVerDetalle";
            this.btmVerDetalle.Size = new System.Drawing.Size(107, 37);
            this.btmVerDetalle.TabIndex = 16;
            this.btmVerDetalle.Text = "Ver Detalles";
            this.btmVerDetalle.UseVisualStyleBackColor = true;
            this.btmVerDetalle.Click += new System.EventHandler(this.btmVerDetalle_Click);
            // 
            // frmComercio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 458);
            this.Controls.Add(this.btmVerDetalle);
            this.Controls.Add(this.btmGestionMarca);
            this.Controls.Add(this.btmGestionCategoria);
            this.Controls.Add(this.btmFiltrarAvanzado);
            this.Controls.Add(this.txtFiltradoAvanzado);
            this.Controls.Add(this.cboCriterio);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.txtFiltradoRapido);
            this.Controls.Add(this.lblFiltrarRapido);
            this.Controls.Add(this.btmEliminar);
            this.Controls.Add(this.btmModificar);
            this.Controls.Add(this.btmAgregar);
            this.Controls.Add(this.picImageArticulos);
            this.Controls.Add(this.dgvArticulo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1354, 505);
            this.MinimumSize = new System.Drawing.Size(1354, 505);
            this.Name = "frmComercio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicacion Comercio";
            this.Load += new System.EventHandler(this.frmComercio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImageArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulo;
        private System.Windows.Forms.PictureBox picImageArticulos;
        private System.Windows.Forms.Button btmAgregar;
        private System.Windows.Forms.Button btmModificar;
        private System.Windows.Forms.Button btmEliminar;
        private System.Windows.Forms.Label lblFiltrarRapido;
        private System.Windows.Forms.TextBox txtFiltradoRapido;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.TextBox txtFiltradoAvanzado;
        private System.Windows.Forms.Button btmFiltrarAvanzado;
        private System.Windows.Forms.Button btmGestionCategoria;
        private System.Windows.Forms.Button btmGestionMarca;
        private System.Windows.Forms.Button btmVerDetalle;
    }
}

