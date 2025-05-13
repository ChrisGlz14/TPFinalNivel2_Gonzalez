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

            NegocioArticulo negocioArticulo = new NegocioArticulo();
            listaArticulos = negocioArticulo.listarTodos();
            dgv_Articulos.DataSource = negocioArticulo.listarTodos();
            PB_ImagenProducto.Load(listaArticulos[0].ImagenUrl);
            OcultarColumnas();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;

            string Filtro = txtBusqueda.Text.Trim();

            if (Filtro.Length > 0)
            {
                listaFiltrada = listaArticulos.FindAll(Articulo =>
                Articulo.Nombre.ToUpper().Contains(txtBusqueda.Text.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulos;
            }

            dgv_Articulos.DataSource = null;

            dgv_Articulos.DataSource = listaFiltrada;

            OcultarColumnas();

        }

        private void OcultarColumnas()
        {
            dgv_Articulos.Columns["ImagenUrl"].Visible = false;
            dgv_Articulos.Columns["IdArticulo"].Visible = false;
        }

        private void dgv_Articulos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Articulos != null)
                {
                    Articulo seleccionado = (Articulo)dgv_Articulos.CurrentRow.DataBoundItem;
                    PB_ImagenProducto.Load(seleccionado.ImagenUrl);
                }
            }
            catch
            {
                PB_ImagenProducto.Load("https://uc91c3135ff277c06a85085a5957.previews.dropboxusercontent.com/p/thumb/ACqn0v7i0qjRKsE1CQEj94K6YD2qOO8iIe9nr9Okeb_bHrJB9Wa0vpcJANujPvsWOpfl6ROGTiivZ_H4PR17NMyo2115aDtY5EwxuocfRJTJ7tScwZfMfr7D8a8Ljr2d6b-z9dFHfdVQL6hUHtUOGf3PAcPppcJCoNkUGohkE6mvD7rUdiAffDorRwrp1Q3Cp3JUBqdGFb5OokB1B4HC3AMN5GunSQRrWIgSAg4IZWSyoqDUsJf1fYNNIBbMLhyUqBpuW_1L4VtGYFpPX9gkrTPTn7wNCaCplD2oDBUt84Uq2h5EPw8Dv5Ge6kgGN1cadSmTEhnHwqC-y5KllAKbkf16ZAq1RRLU_H-ZAf5HWVeoHdqRi0bouJTeWD6XXklhf4E/p.jpeg?is_prewarmed=true");
            }
        }

        
    }
}