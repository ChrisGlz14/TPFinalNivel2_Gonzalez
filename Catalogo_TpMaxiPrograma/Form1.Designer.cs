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
            PB_ImagenProducto = new PictureBox();
            btnMin = new Button();
            btnMax = new Button();
            btnCerrar = new Button();
            btnBuscador = new Button();
            txtBusqueda = new TextBox();
            dgv_Articulos = new DataGridView();
            btn_Buscar = new Button();
            ((System.ComponentModel.ISupportInitialize)PB_ImagenProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Articulos).BeginInit();
            SuspendLayout();
            // 
            // PB_ImagenProducto
            // 
            PB_ImagenProducto.Location = new Point(749, 99);
            PB_ImagenProducto.Name = "PB_ImagenProducto";
            PB_ImagenProducto.Size = new Size(410, 383);
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
            btnMin.Location = new Point(1081, 0);
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
            btnMax.Location = new Point(1119, 0);
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
            btnCerrar.Location = new Point(1157, 0);
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
            btnBuscador.Location = new Point(267, 59);
            btnBuscador.Name = "btnBuscador";
            btnBuscador.Size = new Size(81, 28);
            btnBuscador.TabIndex = 4;
            btnBuscador.Text = "Buscar";
            btnBuscador.TextAlign = ContentAlignment.MiddleRight;
            btnBuscador.UseVisualStyleBackColor = true;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(40, 63);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(221, 23);
            txtBusqueda.TabIndex = 5;
            // 
            // dgv_Articulos
            // 
            dgv_Articulos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Articulos.Location = new Point(40, 99);
            dgv_Articulos.Name = "dgv_Articulos";
            dgv_Articulos.Size = new Size(703, 383);
            dgv_Articulos.TabIndex = 6;
            // 
            // btn_Buscar
            // 
            btn_Buscar.Location = new Point(51, 516);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(75, 23);
            btn_Buscar.TabIndex = 7;
            btn_Buscar.Text = "Buscar";
            btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(194, 194, 194);
            ClientSize = new Size(1197, 628);
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
    }
}
