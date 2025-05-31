using dominio;
using negocio;
using baseDatos;
using System.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;

namespace Catalogo_TpMaxiPrograma

{

    public partial class Form1 : Form
    {
        private List<Articulo> listaArticulos = new List<Articulo>();
        public Form1()
        {
            InitializeComponent();
        }

        private Point _mouseLoc;

        private void panelMinMaxClose_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseLoc = e.Location;
        }

        private void panelMinMaxClose_MouseMove(object sender, MouseEventArgs e)
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

        private void CargarOpcionesComboBox()
        {
            cbFiltroCategoria.Items.Clear();
            cbFiltroMarca.Items.Clear();

            cbFiltroCategoria.Items.AddRange(new string[] { "Celulares", "Televisores", "Media", "Audio" });
            cbFiltroMarca.Items.AddRange(new string[] { "Samsung", "Apple", "Sony", "Huawei", "Motorola" });
        }





        private void CargarArticulos()
        {
            NegocioArticulo negocio = new NegocioArticulo();
            listaArticulos = negocio.listar();
            dgv_Articulos.DataSource = listaArticulos;
            OcultarColumnas();

        }





        private void Form1_Load(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                txtBusqueda.Focus();
            }));

            CargarArticulos();
            //combo box con opciones
            CargarOpcionesComboBox();
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

            if (listaFiltrada.Count > 0)
            {
                dgv_Articulos.ClearSelection();
                dgv_Articulos.Rows[0].Selected = true;

                Articulo seleccionado = (Articulo)dgv_Articulos.Rows[0].DataBoundItem;

            }
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
                if (dgv_Articulos.CurrentRow != null && dgv_Articulos.CurrentRow.DataBoundItem != null)
                {
                    Articulo seleccionado = (Articulo)dgv_Articulos.CurrentRow.DataBoundItem;
                    PB_ImagenProducto.Load(seleccionado.ImagenUrl);
                    lbl_Descripcion.Text = seleccionado.Descripcion;
                    lblPrecio.Text = seleccionado.Precio.ToString();
                }
            }
            catch
            {
                PB_ImagenProducto.Load("https://dl.dropboxusercontent.com/scl/fi/5luas6t52pjoz7ryja30i/no-data-found.png?rlkey=zlh4tsnf3yt0rvys1igwicjsx");
            }
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            FormAgregarArticulo nuevoForm = new FormAgregarArticulo();



            nuevoForm.ShowDialog();
            CargarArticulos();
        }



        private void btnEliminarBD_Click(object sender, EventArgs e)
        {
            NegocioArticulo negocio = new NegocioArticulo();
            Articulo seleccionado = (Articulo)dgv_Articulos.CurrentRow.DataBoundItem; //seleeciono el articulo


            DialogResult resultado =
            MessageBox.Show(
            "¿Desea eliminar: " + seleccionado.Nombre + "?",
            "Confirmación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
            );

            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("ID a eliminar: " + seleccionado.IdArticulo); // DEBUG
                negocio.eliminarArticulo(seleccionado.IdArticulo);

                MessageBox.Show("El artículo fue eliminado correctamente.");
                CargarArticulos(); // actualizamos el listado, no olvidarme en los demas
            }
        }

        private void btnEditarBD_Click(object sender, EventArgs e)
        {
            NegocioArticulo negocio = new NegocioArticulo();
            Articulo seleccionado = (Articulo)dgv_Articulos.CurrentRow.DataBoundItem;
            FormAgregarArticulo editar = new FormAgregarArticulo(seleccionado);
            editar.ShowDialog();
            negocio.modificar(seleccionado);
            CargarArticulos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            NegocioArticulo negocio = new NegocioArticulo();

            try
            {
                if (cbFiltroCategoria.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccioná una categoría.");
                    return;
                }

                if (cbFiltroMarca.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccioná una marca.");
                    return;
                }

                string categoria = cbFiltroCategoria.SelectedItem.ToString() ?? "";
                string marca = cbFiltroMarca.SelectedItem.ToString() ?? "";


                if (string.IsNullOrEmpty(categoria) || string.IsNullOrEmpty(marca))
                {
                    MessageBox.Show("Por favor, seleccioná valores válidos en los filtros.");
                    return;
                }

                // busqueda
                dgv_Articulos.DataSource = negocio.listarFiltro(categoria, marca);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al filtrar: " + ex.Message);
            }
        }

       
    }



}