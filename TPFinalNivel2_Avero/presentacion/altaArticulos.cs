using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using System.Configuration;

namespace presentacion
{
    public partial class altaArticulos : Form
    {
        Articulo articulo = null;
        public altaArticulos()
        {
            InitializeComponent();
        }

        private OpenFileDialog archivo = null;

        public altaArticulos(Articulo articulo)
        {
         
            this.articulo = articulo;
            InitializeComponent();
            Text = "Modificar Articulo";
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (articulo == null)

                    articulo = new Articulo();
                if (!(string.IsNullOrEmpty(tbxCodigo.Text) || string.IsNullOrEmpty(tbxNombre.Text) || string.IsNullOrEmpty(tbxDescripcion.Text) || string.IsNullOrEmpty(tbxImagenUrl.Text) || string.IsNullOrEmpty(tbxPrecio.Text)))
                {
                    articulo.CodigoArticulo = tbxCodigo.Text;
                    articulo.Nombre = tbxNombre.Text;
                    articulo.Descripcion = tbxDescripcion.Text;
                    articulo.ImagenUrl = tbxImagenUrl.Text;

                    articulo.Marca = (Marca)cbxMarca.SelectedItem;
                    articulo.Categoria = (Categoria)cbxCategoria.SelectedItem;
                    if (SoloNumeros(tbxPrecio.Text.ToString()))
                    {
                        articulo.Precio = decimal.Parse(tbxPrecio.Text);
                    }
                    else
                    {
                        MessageBox.Show("Porfavor, en el campo precio, ingresa solo números");
                        return;
                    }
                    
                    if (articulo.Id != 0)
                    {
                        negocio.Modificar(articulo);
                        MessageBox.Show("Disco modificado exitosamente");
                    }
                    else
                    {

                        negocio.Agregar(articulo);
                        MessageBox.Show("Disco agregado exitosamente");

                    }
                }
                else
                {
                    MessageBox.Show("Por favor rellena todos los campos. ");
                }
                         

                if (archivo != null && articulo != null && !(tbxImagenUrl.Text.Contains("HTTP")))
                {
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool CampoVacio(string campo)
        {
            if (campo == " ")
                return true;
            else
                return false;

        }
        private bool SoloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;

            }
            return true;

        }
        private void altaArticulos_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            if (articulo != null)
                btnAgregar.Text = "Aplicar";
            try
            {
                cbxMarca.DataSource = marcaNegocio.listar();
                cbxMarca.ValueMember = "Id";
                cbxMarca.DisplayMember = "Descripcion";
                cbxCategoria.DataSource = categoriaNegocio.listar();
                cbxCategoria.ValueMember = "Id";
                cbxCategoria.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    tbxCodigo.Text = articulo.CodigoArticulo;
                    tbxNombre.Text = articulo.Nombre;
                    tbxDescripcion.Text = articulo.Descripcion;
                    tbxImagenUrl.Text = articulo.ImagenUrl;
                    cargarImagen(articulo.ImagenUrl);
                    tbxPrecio.Text = articulo.Precio.ToString("0.00");
                    cbxMarca.SelectedValue = articulo.Marca.Id;
                    cbxCategoria.SelectedValue = articulo.Categoria.Id;
                }
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
                pbxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxArticulo.Load("https://t3.ftcdn.net/jpg/02/68/55/60/360_F_268556011_PlbhKss0alfFmzNuqXdE3L0OfkHQ1rHH.jpg");
                //throw ex;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                tbxImagenUrl.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
            }
        }
    }
}
