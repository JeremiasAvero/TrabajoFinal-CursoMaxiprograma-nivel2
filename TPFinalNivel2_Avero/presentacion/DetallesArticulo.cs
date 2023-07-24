using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class DetallesArticulo : Form
    {
        public DetallesArticulo()
        {
            InitializeComponent();
        }
        Articulo articulo = null;
        

        private OpenFileDialog archivo = null;

        public DetallesArticulo(Articulo articulo)
        {

            this.articulo = articulo;
            InitializeComponent();
            Text = "Modificar Articulo";
        }

        private void DetallesArticulo_Load(object sender, EventArgs e)
        {
            try
            {
                lblId2.Text = articulo.Id.ToString();
                lblCodigo2.Text = articulo.CodigoArticulo;
                lblDescripcion2.Text = articulo.Descripcion;
                lblNombre2.Text = articulo.Nombre;
                lblImagenUrl2.Text = articulo.ImagenUrl;
                lblPrecio2.Text = articulo.Precio.ToString("0.00"); 
                lblMarca2.Text = articulo.Marca.Descripcion;
                lblCategoria2.Text= articulo.Categoria.Descripcion;
                cargarImagen(articulo.ImagenUrl);
            }
            catch (Exception ex) 
            {
                throw ex;
            }

        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxImagenUrl.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxImagenUrl.Load("https://t3.ftcdn.net/jpg/02/68/55/60/360_F_268556011_PlbhKss0alfFmzNuqXdE3L0OfkHQ1rHH.jpg");
                //throw ex;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblNombre2_Click(object sender, EventArgs e)
        {

        }

        private void lblCodigo2_Click(object sender, EventArgs e)
        {

        }

        private void lblDescripcion2_Click(object sender, EventArgs e)
        {

        }

        private void lblId2_Click(object sender, EventArgs e)
        {

        }
    }
}
