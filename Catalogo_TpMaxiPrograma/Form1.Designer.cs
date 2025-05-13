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
            btnBuscador = new Button();
            txtBusqueda = new TextBox();
            dgv_Articulos = new DataGridView();
            btn_Buscar = new Button();
            label = new Label();
            CB_ = new ComboBox();
            comboBox2 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)PB_ImagenProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Articulos).BeginInit();
            SuspendLayout();
            // 
            // PB_ImagenProducto
            // 
            PB_ImagenProducto.Location = new Point(789, 99);
            PB_ImagenProducto.Name = "PB_ImagenProducto";
            PB_ImagenProducto.Size = new Size(396, 383);
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
            btnMin.Location = new Point(1082, 0);
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
            btnMax.Location = new Point(1120, 0);
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
            btnCerrar.Location = new Point(1158, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(40, 35);
            btnCerrar.TabIndex = 3;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnBuscador
            // 
            btnBuscador.Cursor = Cursors.Hand;
            btnBuscador.Image = Properties.Resources.lupa_24;
            btnBuscador.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscador.Location = new Point(331, 66);
            btnBuscador.Name = "btnBuscador";
            btnBuscador.Size = new Size(81, 28);
            btnBuscador.TabIndex = 4;
            btnBuscador.Text = "Buscar";
            btnBuscador.TextAlign = ContentAlignment.MiddleRight;
            btnBuscador.UseVisualStyleBackColor = true;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(104, 69);
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
            dgv_Articulos.Location = new Point(40, 99);
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
            dgv_Articulos.Size = new Size(743, 383);
            dgv_Articulos.TabIndex = 6;
            dgv_Articulos.SelectionChanged += dgv_Articulos_SelectionChanged;
            // 
            // btn_Buscar
            // 
            btn_Buscar.Location = new Point(401, 515);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(75, 23);
            btn_Buscar.TabIndex = 7;
            btn_Buscar.Text = "Buscar";
            btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            label.AccessibleRole = AccessibleRole.Document;
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 15F);
            label.Location = new Point(40, 64);
            label.Name = "label";
            label.Size = new Size(58, 28);
            label.TabIndex = 8;
            label.Text = "Filtro";
            // 
            // CB_
            // 
            CB_.FormattingEnabled = true;
            CB_.Location = new Point(40, 516);
            CB_.Name = "CB_";
            CB_.Size = new Size(121, 23);
            CB_.TabIndex = 9;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(204, 516);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(194, 194, 194);
            ClientSize = new Size(1198, 628);
            Controls.Add(comboBox2);
            Controls.Add(CB_);
            Controls.Add(label);
            Controls.Add(btn_Buscar);
            Controls.Add(dgv_Articulos);
            Controls.Add(txtBusqueda);
            Controls.Add(btnBuscador);
            Controls.Add(btnCerrar);
            Controls.Add(btnMax);
            Controls.Add(btnMin);
            Controls.Add(PB_ImagenProducto);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            ((System.ComponentModel.ISupportInitialize)PB_ImagenProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Articulos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PB_ImagenProducto;
        private Button btnMin;
        private Button btnMax;
        private Button btnCerrar;
        private Button btnBuscador;
        private TextBox txtBusqueda;
        private DataGridView dgv_Articulos;
        private Button btn_Buscar;
        private Label label;
        private ComboBox CB_;
        private ComboBox comboBox2;
    }
}
