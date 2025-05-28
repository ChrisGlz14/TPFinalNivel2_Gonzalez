namespace Catalogo_TpMaxiPrograma
{
    partial class FormAgregarArticulo
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
            lblNombre = new Label();
            lblDescripcion = new Label();
            lblImagenUrl = new Label();
            lblMarca = new Label();
            lblCategoria = new Label();
            cbCategoria = new ComboBox();
            cbMarca = new ComboBox();
            btnAgregar = new Button();
            btnCancelar = new Button();
            pbNuevoArticulo = new PictureBox();
            txtUrlImagen = new TextBox();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            lblReqNombre = new Label();
            lblReqPrecio = new Label();
            ((System.ComponentModel.ISupportInitialize)pbNuevoArticulo).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(40, 95);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(26, 150);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(72, 15);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "Descripcion:";
            // 
            // lblImagenUrl
            // 
            lblImagenUrl.AutoSize = true;
            lblImagenUrl.Location = new Point(26, 276);
            lblImagenUrl.Name = "lblImagenUrl";
            lblImagenUrl.Size = new Size(68, 15);
            lblImagenUrl.TabIndex = 2;
            lblImagenUrl.Text = "Url Imagen:";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(51, 339);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(43, 15);
            lblMarca.TabIndex = 3;
            lblMarca.Text = "Marca:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(33, 397);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(61, 15);
            lblCategoria.TabIndex = 4;
            lblCategoria.Text = "Categoria:";
            // 
            // cbCategoria
            // 
            cbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(100, 394);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(118, 23);
            cbCategoria.TabIndex = 5;
            // 
            // cbMarca
            // 
            cbMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMarca.FormattingEnabled = true;
            cbMarca.Location = new Point(100, 331);
            cbMarca.Name = "cbMarca";
            cbMarca.Size = new Size(118, 23);
            cbMarca.TabIndex = 6;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.YellowGreen;
            btnAgregar.Location = new Point(450, 401);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(151, 50);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Aceptar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.IndianRed;
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Location = new Point(263, 399);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(151, 52);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // pbNuevoArticulo
            // 
            pbNuevoArticulo.Location = new Point(263, 12);
            pbNuevoArticulo.Name = "pbNuevoArticulo";
            pbNuevoArticulo.Size = new Size(338, 331);
            pbNuevoArticulo.SizeMode = PictureBoxSizeMode.CenterImage;
            pbNuevoArticulo.TabIndex = 9;
            pbNuevoArticulo.TabStop = false;
            // 
            // txtUrlImagen
            // 
            txtUrlImagen.Location = new Point(100, 268);
            txtUrlImagen.Name = "txtUrlImagen";
            txtUrlImagen.Size = new Size(118, 23);
            txtUrlImagen.TabIndex = 10;
            txtUrlImagen.TextChanged += txtUrlImagen_TextChanged;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(51, 213);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(43, 15);
            lblPrecio.TabIndex = 11;
            lblPrecio.Text = "Precio:";
            // 
            // txtPrecio
            // 
            txtPrecio.BackColor = Color.White;
            txtPrecio.Location = new Point(100, 205);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(118, 23);
            txtPrecio.TabIndex = 12;
            txtPrecio.TextChanged += txtPrecio_TextChanged;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(100, 142);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(118, 23);
            txtDescripcion.TabIndex = 13;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(100, 87);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(118, 23);
            txtNombre.TabIndex = 14;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(100, 41);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(118, 23);
            txtCodigo.TabIndex = 15;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(45, 49);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(49, 15);
            lblCodigo.TabIndex = 16;
            lblCodigo.Text = "Codigo:";
            // 
            // lblReqNombre
            // 
            lblReqNombre.AutoSize = true;
            lblReqNombre.Location = new Point(215, 87);
            lblReqNombre.Name = "lblReqNombre";
            lblReqNombre.Size = new Size(12, 15);
            lblReqNombre.TabIndex = 17;
            lblReqNombre.Text = "*";
            // 
            // lblReqPrecio
            // 
            lblReqPrecio.AutoSize = true;
            lblReqPrecio.ForeColor = Color.Black;
            lblReqPrecio.Location = new Point(215, 205);
            lblReqPrecio.Name = "lblReqPrecio";
            lblReqPrecio.Size = new Size(12, 15);
            lblReqPrecio.TabIndex = 18;
            lblReqPrecio.Text = "*";
            // 
            // FormAgregarArticulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 475);
            Controls.Add(lblReqPrecio);
            Controls.Add(lblReqNombre);
            Controls.Add(lblCodigo);
            Controls.Add(txtCodigo);
            Controls.Add(txtNombre);
            Controls.Add(txtDescripcion);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(txtUrlImagen);
            Controls.Add(pbNuevoArticulo);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(cbMarca);
            Controls.Add(cbCategoria);
            Controls.Add(lblCategoria);
            Controls.Add(lblMarca);
            Controls.Add(lblImagenUrl);
            Controls.Add(lblDescripcion);
            Controls.Add(lblNombre);
            Name = "FormAgregarArticulo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAgregarArticulo";
            Load += FormAgregarArticulo_Load;
            ((System.ComponentModel.ISupportInitialize)pbNuevoArticulo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblDescripcion;
        private Label lblImagenUrl;
        private Label lblMarca;
        private Label lblCategoria;
        private ComboBox cbCategoria;
        private ComboBox cbMarca;
        private Button btnAgregar;
        private Button btnCancelar;
        private PictureBox pbNuevoArticulo;
        private TextBox txtUrlImagen;
        private Label lblPrecio;
        private TextBox txtPrecio;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private TextBox txtCodigo;
        private Label lblCodigo;
        private Label lblReqNombre;
        private Label lblReqPrecio;
    }
}