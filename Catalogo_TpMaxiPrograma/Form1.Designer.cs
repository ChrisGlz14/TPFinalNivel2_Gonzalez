namespace Catalogo_TpMaxiPrograma
{
    partial class Form1
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
            txtBusqueda = new TextBox();
            dgv_Articulos = new DataGridView();
            btnBuscar = new Button();
            label = new Label();
            cbFiltroCategoria = new ComboBox();
            cbFiltroMarca = new ComboBox();
            lbl_Descripcion = new Label();
            btnAgregarArticulo = new Button();
            lblPrecio = new Label();
            panelMinMaxClose = new Panel();
            lblCat = new Label();
            lblMarca = new Label();
            label1 = new Label();
            label2 = new Label();
            btnEliminarBD = new Button();
            btnEditarBD = new Button();
            ((System.ComponentModel.ISupportInitialize)PB_ImagenProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Articulos).BeginInit();
            panelMinMaxClose.SuspendLayout();
            SuspendLayout();
            // 
            // PB_ImagenProducto
            // 
            PB_ImagenProducto.Location = new Point(873, 99);
            PB_ImagenProducto.Name = "PB_ImagenProducto";
            PB_ImagenProducto.Size = new Size(434, 384);
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
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(141, 69);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(221, 23);
            txtBusqueda.TabIndex = 5;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // dgv_Articulos
            // 
            dataGridViewCellStyle1.BackColor = Color.Silver;
            dgv_Articulos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            dgv_Articulos.Location = new Point(12, 100);
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
            dgv_Articulos.Size = new Size(855, 383);
            dgv_Articulos.TabIndex = 6;
            dgv_Articulos.SelectionChanged += dgv_Articulos_SelectionChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(444, 562);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label
            // 
            label.AccessibleRole = AccessibleRole.Document;
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 15F);
            label.Location = new Point(12, 64);
            label.Name = "label";
            label.Size = new Size(123, 28);
            label.TabIndex = 8;
            label.Text = "Filtro Buscar:";
            // 
            // cbFiltroCategoria
            // 
            cbFiltroCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFiltroCategoria.FormattingEnabled = true;
            cbFiltroCategoria.Location = new Point(87, 563);
            cbFiltroCategoria.Name = "cbFiltroCategoria";
            cbFiltroCategoria.Size = new Size(121, 23);
            cbFiltroCategoria.TabIndex = 9;
            // 
            // cbFiltroMarca
            // 
            cbFiltroMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFiltroMarca.FormattingEnabled = true;
            cbFiltroMarca.Location = new Point(283, 562);
            cbFiltroMarca.Name = "cbFiltroMarca";
            cbFiltroMarca.Size = new Size(121, 23);
            cbFiltroMarca.TabIndex = 10;
            // 
            // lbl_Descripcion
            // 
            lbl_Descripcion.AutoSize = true;
            lbl_Descripcion.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Descripcion.Location = new Point(1015, 506);
            lbl_Descripcion.Name = "lbl_Descripcion";
            lbl_Descripcion.Size = new Size(36, 25);
            lbl_Descripcion.TabIndex = 11;
            lbl_Descripcion.Text = "---";
            // 
            // btnAgregarArticulo
            // 
            btnAgregarArticulo.Location = new Point(170, 489);
            btnAgregarArticulo.Name = "btnAgregarArticulo";
            btnAgregarArticulo.Size = new Size(107, 29);
            btnAgregarArticulo.TabIndex = 12;
            btnAgregarArticulo.Text = "Agregar Articulo";
            btnAgregarArticulo.UseVisualStyleBackColor = true;
            btnAgregarArticulo.Click += btnAgregarArticulo_Click;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(969, 567);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(36, 25);
            lblPrecio.TabIndex = 13;
            lblPrecio.Text = "---";
            // 
            // panelMinMaxClose
            // 
            panelMinMaxClose.BackColor = Color.Gray;
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
            // lblCat
            // 
            lblCat.AutoSize = true;
            lblCat.Location = new Point(20, 566);
            lblCat.Name = "lblCat";
            lblCat.Size = new Size(61, 15);
            lblCat.TabIndex = 15;
            lblCat.Text = "Categoria:";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(234, 565);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(43, 15);
            lblMarca.TabIndex = 16;
            lblMarca.Text = "Marca:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(894, 506);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 17;
            label1.Text = "Descripcion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(894, 567);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 18;
            label2.Text = "Precio:";
            // 
            // btnEliminarBD
            // 
            btnEliminarBD.Location = new Point(12, 489);
            btnEliminarBD.Name = "btnEliminarBD";
            btnEliminarBD.Size = new Size(132, 29);
            btnEliminarBD.TabIndex = 19;
            btnEliminarBD.Text = "Eliminar Articulo BD";
            btnEliminarBD.UseVisualStyleBackColor = true;
            btnEliminarBD.Click += btnEliminarBD_Click;
            // 
            // btnEditarBD
            // 
            btnEditarBD.Location = new Point(297, 489);
            btnEditarBD.Name = "btnEditarBD";
            btnEditarBD.Size = new Size(107, 29);
            btnEditarBD.TabIndex = 20;
            btnEditarBD.Text = "Editar Articulo ";
            btnEditarBD.UseVisualStyleBackColor = true;
            btnEditarBD.Click += btnEditarBD_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(194, 194, 194);
            ClientSize = new Size(1350, 628);
            Controls.Add(btnEditarBD);
            Controls.Add(btnEliminarBD);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblMarca);
            Controls.Add(lblCat);
            Controls.Add(panelMinMaxClose);
            Controls.Add(lblPrecio);
            Controls.Add(btnAgregarArticulo);
            Controls.Add(lbl_Descripcion);
            Controls.Add(cbFiltroMarca);
            Controls.Add(cbFiltroCategoria);
            Controls.Add(label);
            Controls.Add(btnBuscar);
            Controls.Add(dgv_Articulos);
            Controls.Add(txtBusqueda);
            Controls.Add(PB_ImagenProducto);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)PB_ImagenProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Articulos).EndInit();
            panelMinMaxClose.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PB_ImagenProducto;
        private Button btnMin;
        private Button btnMax;
        private Button btnCerrar;
        private TextBox txtBusqueda;
        private DataGridView dgv_Articulos;
        private Button btnBuscar;
        private Label label;
        private ComboBox cbFiltroCategoria;
        private ComboBox cbFiltroMarca;
        private Label lbl_Descripcion;
        private Button btnAgregarArticulo;
        private Label lblPrecio;
        private Panel panelMinMaxClose;
        private Label lblCat;
        private Label lblMarca;
        private Label label1;
        private Label label2;
        private Button btnEliminarBD;
        private Button btnEditarBD;
    }
}
