using baseDatos;
using dominio;
using Microsoft.Extensions.Options;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalogo_TpMaxiPrograma
{
    public partial class FormAgregarArticulo : Form
    {

        private Articulo articulo = null;
        public FormAgregarArticulo()
        {
            InitializeComponent();
            Text = "Agregar Nuevo Articulo";
            btnAgregar.Text = "Agregar Articulo";
        }

        public FormAgregarArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
            btnAgregar.Text = "Aplicar Cambios";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAgregarArticulo_Load(object sender, EventArgs e)
        {
            NegocioArticulo negocio = new NegocioArticulo();
            try
            {
                NegocioMarca negocioMarca = new NegocioMarca();
                NegocioCategoria negocioCategoria = new NegocioCategoria();

                cbMarca.DataSource = negocioMarca.listar();
                cbMarca.ValueMember = "IdMarca";
                cbMarca.DisplayMember = "DescripcionMarca";

                cbCategoria.DataSource = negocioCategoria.listar();
                cbCategoria.ValueMember = "IdCategoria";
                cbCategoria.DisplayMember = "DescripcionCategoria";


                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtPrecio.Text = articulo.Precio.ToString();
                    txtDescripcion.Text = articulo.Descripcion;
                    txtUrlImagen.Text = articulo.ImagenUrl;
                    cargarImagen(articulo.ImagenUrl);
                    cbMarca.SelectedValue = articulo.Marca.IdMarca;
                    cbCategoria.SelectedValue = articulo.Categoria.IdCategoria;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbNuevoArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pbNuevoArticulo.Load("https://dl.dropboxusercontent.com/scl/fi/5luas6t52pjoz7ryja30i/no-data-found.png?rlkey=zlh4tsnf3yt0rvys1igwicjsx");
            }
        }



        //Boton agregar y modiciar
        private void btnAgregar_Click(object sender, EventArgs e) //Tengo que hacer validacion porque sino añade siempre un articulo

        {
            try
            {
                NegocioArticulo negocio = new NegocioArticulo();
                if (articulo == null)
                {
                    articulo = new Articulo();
                    articulo.Codigo = txtCodigo.Text;
                    articulo.Nombre = txtNombre.Text;
                    articulo.Descripcion = txtDescripcion.Text;
                   
                    
                    if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
                    {
                        MessageBox.Show("El precio debe ser un número válido.");
                        return;
                    }

                    articulo.Precio = precio;

                    articulo.ImagenUrl = txtUrlImagen.Text;

                    if(cbCategoria.SelectedItem == null || cbMarca.SelectedItem == null)
                    {
                        MessageBox.Show("Debes seleccionar una categoría y una marca.");
                        return;
                    }

                    articulo.Categoria = (Categoria)cbCategoria.SelectedItem;
                    articulo.Marca = (Marca)cbMarca.SelectedItem;
                    cargarImagen(pbNuevoArticulo.Text);
                    negocio.Agregar(articulo);
                    MessageBox.Show("Felicitaciones Maxi! Articulo agregado correctamente.");
                    negocio.listar();
                }
                else if (articulo.IdArticulo != 0)
                {
                    articulo.Codigo = txtCodigo.Text;
                    articulo.Nombre = txtNombre.Text;
                    articulo.Descripcion = txtDescripcion.Text;
                    articulo.Precio = decimal.Parse(txtPrecio.Text);
                    articulo.ImagenUrl = txtUrlImagen.Text;

                    //Validacion de que tenemos una cat y marca seleccionada
                    if (cbCategoria.SelectedItem == null || cbMarca.SelectedItem == null)
                    {
                        MessageBox.Show("Debes seleccionar una categoría y una marca.");
                        return;
                    }


                    articulo.Categoria = (Categoria)cbCategoria.SelectedItem;
                    articulo.Marca = (Marca)cbMarca.SelectedItem;
                    cargarImagen(pbNuevoArticulo.Text);
                    negocio.modificar(articulo);
                    MessageBox.Show("Felicitaciones Maxi! Articulo modificado correctamente.");
                    negocio.listar();
                }



                Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtUrlImagen_TextChanged(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
        }

       
        // Metodo para poder hacer validaciones 
        private bool ValidarCampo(TextBox txt, Label lbl, Label lblError)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.BackColor = Color.Red;
                lblError.ForeColor = Color.Red;
                lblError.Visible = true;
                return false;
            }
            else
            {
                txt.BackColor = Color.White;
                lblError.Visible = false;
                return true;
            }

        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo(txtPrecio, lblPrecio, lblReqPrecio);
        }


        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',') //Importante para los numeros con punto
            {
                e.Handled = true; //Evita que se escirba el caracter
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarCampo(txtNombre, lblNombre, lblReqNombre);
        }

        
    }
}
