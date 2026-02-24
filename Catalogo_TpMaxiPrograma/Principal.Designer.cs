namespace Catalogo_TpMaxiPrograma
{
    partial class PrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            PB_ImagenProducto = new PictureBox();
            btnMin = new Button();
            btnMax = new Button();
            btnCerrar = new Button();
            lblPrecio = new Label();
            panelMinMaxClose = new Panel();
            lblDescripcion = new Label();
            lbl_Precio = new Label();
            lblDolar = new Label();
            lblPrecioDolar = new Label();
            panelDer = new Panel();
            lblPrecioTotalText = new Label();
            lblPrecioTotal = new Label();
            txtDescripcion = new TextBox();
            lblCantidadText = new Label();
            lblCantidad = new Label();
            lblCat = new Label();
            btnAgregarArticulo = new Button();
            lblMarca = new Label();
            cbFiltroMarca = new ComboBox();
            btnEliminarBD = new Button();
            cbFiltroCategoria = new ComboBox();
            btnEditarBD = new Button();
            btnBuscar = new Button();
            dgv_Articulos = new DataGridView();
            panelIzq = new Panel();
            txtBusqueda = new TextBox();
            lblFiltroBuscar = new Label();
            panelCentrado = new Panel();
            ((System.ComponentModel.ISupportInitialize)PB_ImagenProducto).BeginInit();
            panelMinMaxClose.SuspendLayout();
            panelDer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Articulos).BeginInit();
            panelIzq.SuspendLayout();
            panelCentrado.SuspendLayout();
            SuspendLayout();
            // 
            // PB_ImagenProducto
            // 
            PB_ImagenProducto.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PB_ImagenProducto.InitialImage = null;
            PB_ImagenProducto.Location = new Point(72, 29);
            PB_ImagenProducto.Name = "PB_ImagenProducto";
            PB_ImagenProducto.Size = new Size(437, 384);
            PB_ImagenProducto.SizeMode = PictureBoxSizeMode.CenterImage;
            PB_ImagenProducto.TabIndex = 0;
            PB_ImagenProducto.TabStop = false;
            // 
            // btnMin
            // 
            btnMin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.FlatStyle = FlatStyle.Flat;
            btnMin.Image = Properties.Resources.minimizar_24;
            btnMin.Location = new Point(1221, 2);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(40, 35);
            btnMin.TabIndex = 1;
            btnMin.UseVisualStyleBackColor = true;
            btnMin.Click += btnMin_Click;
            // 
            // btnMax
            // 
            btnMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMax.FlatAppearance.BorderSize = 0;
            btnMax.FlatStyle = FlatStyle.Flat;
            btnMax.Image = Properties.Resources.maximizar_24;
            btnMax.Location = new Point(1267, 2);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(40, 35);
            btnMax.TabIndex = 2;
            btnMax.UseVisualStyleBackColor = true;
            btnMax.Click += btnMax_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(227, 101, 113);
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 126, 126);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Image = Properties.Resources.CerrarVentana_2424;
            btnCerrar.Location = new Point(1307, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(40, 35);
            btnCerrar.TabIndex = 3;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblPrecio
            // 
            lblPrecio.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(147, 569);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(36, 25);
            lblPrecio.TabIndex = 13;
            lblPrecio.Text = "---";
            // 
            // panelMinMaxClose
            // 
            panelMinMaxClose.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelMinMaxClose.BackColor = Color.SteelBlue;
            panelMinMaxClose.Controls.Add(btnMax);
            panelMinMaxClose.Controls.Add(btnMin);
            panelMinMaxClose.Controls.Add(btnCerrar);
            panelMinMaxClose.Location = new Point(0, 0);
            panelMinMaxClose.Name = "panelMinMaxClose";
            panelMinMaxClose.Size = new Size(1350, 37);
            panelMinMaxClose.TabIndex = 14;
            panelMinMaxClose.MouseDown += panelMinMaxClose_MouseDown;
            panelMinMaxClose.MouseMove += panelMinMaxClose_MouseMove;
            // 
            // lblDescripcion
            // 
            lblDescripcion.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblDescripcion.AutoSize = true;
            lblDescripcion.BackColor = Color.DarkGray;
            lblDescripcion.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(72, 416);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(121, 25);
            lblDescripcion.TabIndex = 17;
            lblDescripcion.Text = "Descripcion:";
            // 
            // lbl_Precio
            // 
            lbl_Precio.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lbl_Precio.AutoSize = true;
            lbl_Precio.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Precio.Location = new Point(72, 569);
            lbl_Precio.Name = "lbl_Precio";
            lbl_Precio.Size = new Size(73, 25);
            lbl_Precio.TabIndex = 18;
            lbl_Precio.Text = "Precio:";
            // 
            // lblDolar
            // 
            lblDolar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblDolar.AutoSize = true;
            lblDolar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDolar.Location = new Point(72, 607);
            lblDolar.Name = "lblDolar";
            lblDolar.Size = new Size(128, 25);
            lblDolar.TabIndex = 21;
            lblDolar.Text = "Precio Dolar:";
            // 
            // lblPrecioDolar
            // 
            lblPrecioDolar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblPrecioDolar.AutoSize = true;
            lblPrecioDolar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecioDolar.Location = new Point(198, 607);
            lblPrecioDolar.Name = "lblPrecioDolar";
            lblPrecioDolar.Size = new Size(36, 25);
            lblPrecioDolar.TabIndex = 22;
            lblPrecioDolar.Text = "---";
            // 
            // panelDer
            // 
            panelDer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelDer.BackColor = Color.DarkGray;
            panelDer.Controls.Add(lblPrecioTotalText);
            panelDer.Controls.Add(lblPrecioTotal);
            panelDer.Controls.Add(txtDescripcion);
            panelDer.Controls.Add(lblCantidadText);
            panelDer.Controls.Add(lblCantidad);
            panelDer.Controls.Add(PB_ImagenProducto);
            panelDer.Controls.Add(lblPrecioDolar);
            panelDer.Controls.Add(lbl_Precio);
            panelDer.Controls.Add(lblDolar);
            panelDer.Controls.Add(lblPrecio);
            panelDer.Controls.Add(lblDescripcion);
            panelDer.Location = new Point(772, 37);
            panelDer.Name = "panelDer";
            panelDer.Size = new Size(578, 734);
            panelDer.TabIndex = 23;
            // 
            // lblPrecioTotalText
            // 
            lblPrecioTotalText.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblPrecioTotalText.AutoSize = true;
            lblPrecioTotalText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecioTotalText.Location = new Point(189, 691);
            lblPrecioTotalText.Name = "lblPrecioTotalText";
            lblPrecioTotalText.Size = new Size(36, 25);
            lblPrecioTotalText.TabIndex = 27;
            lblPrecioTotalText.Text = "---";
            // 
            // lblPrecioTotal
            // 
            lblPrecioTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblPrecioTotal.AutoSize = true;
            lblPrecioTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecioTotal.Location = new Point(72, 691);
            lblPrecioTotal.Name = "lblPrecioTotal";
            lblPrecioTotal.Size = new Size(121, 25);
            lblPrecioTotal.TabIndex = 26;
            lblPrecioTotal.Text = "Precio Total:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.DarkGray;
            txtDescripcion.BorderStyle = BorderStyle.None;
            txtDescripcion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescripcion.Location = new Point(72, 444);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ReadOnly = true;
            txtDescripcion.ScrollBars = ScrollBars.Vertical;
            txtDescripcion.Size = new Size(437, 109);
            txtDescripcion.TabIndex = 25;
            // 
            // lblCantidadText
            // 
            lblCantidadText.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblCantidadText.AutoSize = true;
            lblCantidadText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantidadText.Location = new Point(170, 648);
            lblCantidadText.Name = "lblCantidadText";
            lblCantidadText.Size = new Size(36, 25);
            lblCantidadText.TabIndex = 24;
            lblCantidadText.Text = "---";
            // 
            // lblCantidad
            // 
            lblCantidad.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantidad.Location = new Point(72, 648);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(97, 25);
            lblCantidad.TabIndex = 23;
            lblCantidad.Text = "Cantidad:";
            // 
            // lblCat
            // 
            lblCat.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblCat.AutoSize = true;
            lblCat.Location = new Point(17, 622);
            lblCat.Name = "lblCat";
            lblCat.Size = new Size(61, 15);
            lblCat.TabIndex = 15;
            lblCat.Text = "Categoria:";
            // 
            // btnAgregarArticulo
            // 
            btnAgregarArticulo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAgregarArticulo.Location = new Point(181, 530);
            btnAgregarArticulo.Name = "btnAgregarArticulo";
            btnAgregarArticulo.Size = new Size(107, 29);
            btnAgregarArticulo.TabIndex = 12;
            btnAgregarArticulo.Text = "Agregar Articulo";
            btnAgregarArticulo.UseVisualStyleBackColor = true;
            btnAgregarArticulo.Click += btnAgregarArticulo_Click;
            // 
            // lblMarca
            // 
            lblMarca.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(231, 621);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(43, 15);
            lblMarca.TabIndex = 16;
            lblMarca.Text = "Marca:";
            // 
            // cbFiltroMarca
            // 
            cbFiltroMarca.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cbFiltroMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFiltroMarca.FormattingEnabled = true;
            cbFiltroMarca.Location = new Point(280, 618);
            cbFiltroMarca.Name = "cbFiltroMarca";
            cbFiltroMarca.Size = new Size(121, 23);
            cbFiltroMarca.TabIndex = 10;
            // 
            // btnEliminarBD
            // 
            btnEliminarBD.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEliminarBD.BackColor = Color.White;
            btnEliminarBD.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 128);
            btnEliminarBD.FlatAppearance.BorderSize = 0;
            btnEliminarBD.Location = new Point(23, 530);
            btnEliminarBD.Name = "btnEliminarBD";
            btnEliminarBD.Size = new Size(132, 29);
            btnEliminarBD.TabIndex = 19;
            btnEliminarBD.Text = "Eliminar Articulo BD";
            btnEliminarBD.UseVisualStyleBackColor = false;
            btnEliminarBD.Click += btnEliminarBD_Click;
            // 
            // cbFiltroCategoria
            // 
            cbFiltroCategoria.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cbFiltroCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFiltroCategoria.FormattingEnabled = true;
            cbFiltroCategoria.Location = new Point(84, 619);
            cbFiltroCategoria.Name = "cbFiltroCategoria";
            cbFiltroCategoria.Size = new Size(121, 23);
            cbFiltroCategoria.TabIndex = 9;
            // 
            // btnEditarBD
            // 
            btnEditarBD.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEditarBD.Location = new Point(308, 530);
            btnEditarBD.Name = "btnEditarBD";
            btnEditarBD.Size = new Size(107, 29);
            btnEditarBD.TabIndex = 20;
            btnEditarBD.Text = "Editar Articulo ";
            btnEditarBD.UseVisualStyleBackColor = true;
            btnEditarBD.Click += btnEditarBD_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBuscar.Location = new Point(422, 601);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(68, 41);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dgv_Articulos
            // 
            dataGridViewCellStyle1.BackColor = Color.Silver;
            dgv_Articulos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Articulos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dgv_Articulos.BackgroundColor = SystemColors.ScrollBar;
            dgv_Articulos.BorderStyle = BorderStyle.None;
            dgv_Articulos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.BackColor = SystemColors.AppWorkspace;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_Articulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_Articulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ScrollBar;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv_Articulos.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_Articulos.Location = new Point(20, 80);
            dgv_Articulos.MultiSelect = false;
            dgv_Articulos.Name = "dgv_Articulos";
            dgv_Articulos.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv_Articulos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgv_Articulos.RowTemplate.Height = 35;
            dgv_Articulos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Articulos.Size = new Size(746, 383);
            dgv_Articulos.TabIndex = 6;
            dgv_Articulos.SelectionChanged += dgv_Articulos_SelectionChanged;
            // 
            // panelIzq
            // 
            panelIzq.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panelIzq.Controls.Add(txtBusqueda);
            panelIzq.Controls.Add(lblFiltroBuscar);
            panelIzq.Location = new Point(20, 3);
            panelIzq.Name = "panelIzq";
            panelIzq.Size = new Size(365, 71);
            panelIzq.TabIndex = 24;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBusqueda.Location = new Point(123, 36);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(179, 23);
            txtBusqueda.TabIndex = 5;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // lblFiltroBuscar
            // 
            lblFiltroBuscar.AccessibleRole = AccessibleRole.Document;
            lblFiltroBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblFiltroBuscar.AutoSize = true;
            lblFiltroBuscar.Font = new Font("Segoe UI", 15F);
            lblFiltroBuscar.Location = new Point(3, 31);
            lblFiltroBuscar.Name = "lblFiltroBuscar";
            lblFiltroBuscar.Size = new Size(123, 28);
            lblFiltroBuscar.TabIndex = 8;
            lblFiltroBuscar.Text = "Filtro Buscar:";
            // 
            // panelCentrado
            // 
            panelCentrado.Anchor = AnchorStyles.None;
            panelCentrado.Controls.Add(panelIzq);
            panelCentrado.Controls.Add(dgv_Articulos);
            panelCentrado.Controls.Add(btnBuscar);
            panelCentrado.Controls.Add(btnEditarBD);
            panelCentrado.Controls.Add(cbFiltroCategoria);
            panelCentrado.Controls.Add(btnEliminarBD);
            panelCentrado.Controls.Add(cbFiltroMarca);
            panelCentrado.Controls.Add(lblMarca);
            panelCentrado.Controls.Add(btnAgregarArticulo);
            panelCentrado.Controls.Add(lblCat);
            panelCentrado.Location = new Point(0, 94);
            panelCentrado.Name = "panelCentrado";
            panelCentrado.Size = new Size(1350, 677);
            panelCentrado.TabIndex = 25;
            // 
            // PrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(194, 194, 194);
            ClientSize = new Size(1350, 771);
            Controls.Add(panelDer);
            Controls.Add(panelMinMaxClose);
            Controls.Add(panelCentrado);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PrincipalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)PB_ImagenProducto).EndInit();
            panelMinMaxClose.ResumeLayout(false);
            panelDer.ResumeLayout(false);
            panelDer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Articulos).EndInit();
            panelIzq.ResumeLayout(false);
            panelIzq.PerformLayout();
            panelCentrado.ResumeLayout(false);
            panelCentrado.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PB_ImagenProducto;
        private Button btnMin;
        private Button btnMax;
        private Button btnCerrar;
        private Label lblPrecio;
        private Panel panelMinMaxClose;
        private Label lblDescripcion;
        private Label lbl_Precio;
        private Label lblDolar;
        private Label lblPrecioDolar;
        private Panel panelDer;
        private Label lblCat;
        private Button btnAgregarArticulo;
        private Label lblMarca;
        private ComboBox cbFiltroMarca;
        private Button btnEliminarBD;
        private ComboBox cbFiltroCategoria;
        private Button btnEditarBD;
        private Button btnBuscar;
        private DataGridView dgv_Articulos;
        private Panel panelIzq;
        private TextBox txtBusqueda;
        private Label lblFiltroBuscar;
        private Panel panelCentrado;
        private Label lblCantidadText;
        private Label lblCantidad;
        private TextBox txtDescripcion;
        private Label lblPrecioTotalText;
        private Label lblPrecioTotal;
    }
}
