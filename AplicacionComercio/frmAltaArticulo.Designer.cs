namespace AplicacionComercio
{
    partial class frmAltaArticulo
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btmAgregar = new System.Windows.Forms.Button();
            this.btmCancelar = new System.Windows.Forms.Button();
            this.txtImagenUrl = new System.Windows.Forms.TextBox();
            this.txtImagen = new System.Windows.Forms.Label();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.pboxImagenAgregar = new System.Windows.Forms.PictureBox();
            this.btmAgregarImagen = new System.Windows.Forms.Button();
            this.lboxImagen = new System.Windows.Forms.ListBox();
            this.btmModificarImagen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImagenAgregar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(28, 38);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(51, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(28, 72);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(28, 111);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(79, 16);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(28, 182);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(66, 16);
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(28, 146);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(45, 16);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Marca";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(123, 35);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(87, 22);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(123, 108);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(205, 22);
            this.txtDescripcion.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(123, 69);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(205, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(28, 220);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(46, 16);
            this.lblPrecio.TabIndex = 10;
            this.lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(123, 217);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(205, 22);
            this.txtPrecio.TabIndex = 5;
            // 
            // btmAgregar
            // 
            this.btmAgregar.Location = new System.Drawing.Point(64, 395);
            this.btmAgregar.Name = "btmAgregar";
            this.btmAgregar.Size = new System.Drawing.Size(84, 41);
            this.btmAgregar.TabIndex = 7;
            this.btmAgregar.Text = "Agregar";
            this.btmAgregar.UseVisualStyleBackColor = true;
            this.btmAgregar.Click += new System.EventHandler(this.btmAgregar_Click);
            // 
            // btmCancelar
            // 
            this.btmCancelar.Location = new System.Drawing.Point(191, 395);
            this.btmCancelar.Name = "btmCancelar";
            this.btmCancelar.Size = new System.Drawing.Size(102, 41);
            this.btmCancelar.TabIndex = 8;
            this.btmCancelar.Text = "Cancelar";
            this.btmCancelar.UseVisualStyleBackColor = true;
            this.btmCancelar.Click += new System.EventHandler(this.btmCancelar_Click);
            // 
            // txtImagenUrl
            // 
            this.txtImagenUrl.Location = new System.Drawing.Point(123, 245);
            this.txtImagenUrl.Name = "txtImagenUrl";
            this.txtImagenUrl.Size = new System.Drawing.Size(205, 22);
            this.txtImagenUrl.TabIndex = 6;
            this.txtImagenUrl.Leave += new System.EventHandler(this.txtImagenUrl_Leave);
            // 
            // txtImagen
            // 
            this.txtImagen.AutoSize = true;
            this.txtImagen.Location = new System.Drawing.Point(28, 248);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(72, 16);
            this.txtImagen.TabIndex = 14;
            this.txtImagen.Text = "Url Imagen";
            // 
            // cbxMarca
            // 
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(123, 143);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(205, 24);
            this.cbxMarca.TabIndex = 3;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(123, 179);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(205, 24);
            this.cbxCategoria.TabIndex = 4;
            // 
            // pboxImagenAgregar
            // 
            this.pboxImagenAgregar.Location = new System.Drawing.Point(373, 38);
            this.pboxImagenAgregar.Name = "pboxImagenAgregar";
            this.pboxImagenAgregar.Size = new System.Drawing.Size(270, 264);
            this.pboxImagenAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxImagenAgregar.TabIndex = 18;
            this.pboxImagenAgregar.TabStop = false;
            // 
            // btmAgregarImagen
            // 
            this.btmAgregarImagen.Location = new System.Drawing.Point(442, 332);
            this.btmAgregarImagen.Name = "btmAgregarImagen";
            this.btmAgregarImagen.Size = new System.Drawing.Size(144, 41);
            this.btmAgregarImagen.TabIndex = 19;
            this.btmAgregarImagen.Text = "Agregar Imagen";
            this.btmAgregarImagen.UseVisualStyleBackColor = true;
            this.btmAgregarImagen.Click += new System.EventHandler(this.btmAgregarImagen_Click);
            // 
            // lboxImagen
            // 
            this.lboxImagen.FormattingEnabled = true;
            this.lboxImagen.ItemHeight = 16;
            this.lboxImagen.Location = new System.Drawing.Point(123, 273);
            this.lboxImagen.Name = "lboxImagen";
            this.lboxImagen.Size = new System.Drawing.Size(205, 100);
            this.lboxImagen.TabIndex = 20;
            this.lboxImagen.SelectedIndexChanged += new System.EventHandler(this.lboxImagen_SelectedIndexChanged);
            // 
            // btmModificarImagen
            // 
            this.btmModificarImagen.Location = new System.Drawing.Point(442, 332);
            this.btmModificarImagen.Name = "btmModificarImagen";
            this.btmModificarImagen.Size = new System.Drawing.Size(144, 41);
            this.btmModificarImagen.TabIndex = 21;
            this.btmModificarImagen.Text = "Moficar imagen";
            this.btmModificarImagen.UseVisualStyleBackColor = true;
            this.btmModificarImagen.Click += new System.EventHandler(this.btmModificarImagen_Click);
            // 
            // frmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 538);
            this.Controls.Add(this.btmModificarImagen);
            this.Controls.Add(this.lboxImagen);
            this.Controls.Add(this.btmAgregarImagen);
            this.Controls.Add(this.pboxImagenAgregar);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.txtImagenUrl);
            this.Controls.Add(this.txtImagen);
            this.Controls.Add(this.btmCancelar);
            this.Controls.Add(this.btmAgregar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(673, 585);
            this.MinimumSize = new System.Drawing.Size(673, 585);
            this.Name = "frmAltaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAltaArticulo";
            this.Load += new System.EventHandler(this.frmAltaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxImagenAgregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btmAgregar;
        private System.Windows.Forms.Button btmCancelar;
        private System.Windows.Forms.TextBox txtImagenUrl;
        private System.Windows.Forms.Label txtImagen;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.PictureBox pboxImagenAgregar;
        private System.Windows.Forms.Button btmAgregarImagen;
        private System.Windows.Forms.ListBox lboxImagen;
        private System.Windows.Forms.Button btmModificarImagen;
    }
}