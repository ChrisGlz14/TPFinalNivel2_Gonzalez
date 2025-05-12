using dominio;
using negocio;
using baseDatos;
using System.Data.SqlClient;

namespace Catalogo_TpMaxiPrograma

{

    public partial class Form1 : Form
    {
        private List<Articulo> listaArticulos;
        public Form1()
        {
            InitializeComponent();
        }

        private Point _mouseLoc;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseLoc = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.Location.X - _mouseLoc.X;
                int dy = e.Location.Y - _mouseLoc.Y;
                this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal || WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                txtBusqueda.Focus();
            }));

            dgv_Articulos.Rows.Clear();
            NegocioArticulo negocioArticulo = new NegocioArticulo();
            listaArticulos = negocioArticulo.listarTodos();
            dgv_Articulos.DataSource = negocioArticulo.listarTodos();
            dgv_Articulos.Columns["ImagenUrl"].Visible = false;
            PB_ImagenProducto.Load(listaArticulos[0].ImagenUrl);
        }


    }
}