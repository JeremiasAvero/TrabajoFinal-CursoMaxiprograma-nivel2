using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace presentacion
{
    public partial class Menu : Form
    {
        private List<Articulo> listaArticulos;
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            cargarDgv();
            cbxCampo.Items.Add("Codigo");
            cbxCampo.Items.Add("Nombre");
            cbxCampo.Items.Add("Descripción");
            cbxCampo.Items.Add("Precio");
            
        }

        private void cargarDgv()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = negocio.listar();
                dgvArticulos.DataSource = listaArticulos;
                dgvArticulos.Columns["Precio"].DefaultCellStyle.Format = "0.00";
                cargarImagen(listaArticulos[0].ImagenUrl);
                ocultarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        

        private void ocultarColumnas()
        {
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
           // dgvArticulos.Columns[""]
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null) 
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
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

        private void tbxFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = tbxFiltroRapido.Text;

            if (filtro.Length >= 3) 
            {
                listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Descripcion.ToUpper().Contains(filtro.ToUpper()));

            }
            else
            {
                listaFiltrada = listaArticulos;
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            altaArticulos alta = new altaArticulos();
            alta.ShowDialog();
            cargarDgv();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();    
            Articulo seleccionado = new Articulo();

            try
            {
                if (dgvArticulos.CurrentRow != null)
                {
                    DialogResult respuesta = MessageBox.Show("Estas seguro de eliminar este Artículo?", "Eliminando", MessageBoxButtons.YesNo);
                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                        negocio.Borrar(seleccionado);
                        cargarDgv();
                        MessageBox.Show("El artículo se eliminó con éxtio");
                    }
                }
                else
                {
                    MessageBox.Show("No hay ningún artículo seleccionado. ");
                }
            }
            catch (Exception ex) 
            {
                throw ex;
            }
               
        }

        private void cbxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cbxCampo.SelectedItem.ToString();

            if (opcion == "Precio")
            {
                cbxCriterio.Items.Clear();
                cbxCriterio.Items.Add("Mayor a");
                cbxCriterio.Items.Add("Menor a");
                cbxCriterio.Items.Add("Igual a");
            }
            else
            {
                cbxCriterio.Items.Clear();
                cbxCriterio.Items.Add("Empieza con");
                cbxCriterio.Items.Add("Termina con");
                cbxCriterio.Items.Add("Contiene");
            }
        }

        private bool ValidarFiltro()
        {
            try
            {
                if (cbxCampo.SelectedIndex < 0)
                {
                    MessageBox.Show("Por favor, selecciona un campo para filtrar. ");
                    return true;               
                }
                if (cbxCriterio.SelectedIndex < 0)
                {
                    MessageBox.Show("Por favor, selecciona un criterio para filtrar. ");
                    return true;
                }
                if (cbxCampo.SelectedItem.ToString() == "Precio")
                {
                    if (string.IsNullOrEmpty(tbxFiltroAv.Text))
                    {
                        MessageBox.Show("Por favor ingresa un número si querés filtrar. ");
                        return true;
                    }
                    if (!(SoloNumeros(tbxFiltroAv.Text)))
                    {
                        MessageBox.Show("Ingresa solo números");
                        return true;
                    }
                }


                
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
            return false;
        }

        private bool SoloNumeros(string cadena)
        {
            foreach(char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;

            }
            return true;
            
        }
        private void btnFiltro_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (ValidarFiltro())
                    return;

                string campo = cbxCampo.SelectedItem.ToString();
                string criterio = cbxCriterio.SelectedItem.ToString();
                string filtro = tbxFiltroAv.Text;
                dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
              
        }

        private void dgvArticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Articulo();
        }

        private void Articulo()
        {
            try
            {

                if (dgvArticulos.CurrentRow != null)
                {
                    Articulo seleccionado;
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                    altaArticulos detalles = new altaArticulos(seleccionado);
                    detalles.ShowDialog();
                    cargarDgv();
                }
                else
                {
                    MessageBox.Show("No hay ningún artículo seleccionado. ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            try
            {

                if (dgvArticulos.CurrentRow != null)
                {
                    Articulo seleccionado;
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                    DetallesArticulo detalles = new DetallesArticulo(seleccionado);
                    detalles.ShowDialog();
                    cargarDgv();
                }
                else
                {
                    MessageBox.Show("No hay ningún artículo seleccionado. ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
