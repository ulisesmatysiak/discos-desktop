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
    public partial class frmDiscoteca : Form
    {
        private List<Disco> listaDisco;
        public frmDiscoteca()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmDiscos discos = new frmDiscos();
            discos.ShowDialog();
            cargar();
        }

        private void cargar()
        {
            DiscoNegocio negocio = new DiscoNegocio();
            try
            {
                listaDisco = negocio.listar();
                dgvDiscoteca.DataSource = listaDisco;
                ocultarColumnas();
                cargarImagen(listaDisco[0].UrlImagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvDiscoteca.Columns["UrlImagen"].Visible = false;
            dgvDiscoteca.Columns["Id"].Visible = false;
        }

        private void frmDiscoteca_Load(object sender, EventArgs e)
        {
            cargar();
            cboCampo.Items.Add("Título");
            cboCampo.Items.Add("Cantidad de canciones");
            cboCampo.Items.Add("Género");
        }

        private void dgvDiscoteca_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDiscoteca.CurrentRow != null)
            {
                Disco seleccionado = (Disco)dgvDiscoteca.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImagen);
            }           
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pboDiscoteca.Load(imagen);
            }
            catch (Exception)
            {
                pboDiscoteca.Load("https://crawfordroofing.com.au/wp-content/uploads/2018/04/No-image-available.jpg");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Disco seleccionado;
            seleccionado = (Disco)dgvDiscoteca.CurrentRow.DataBoundItem;

            frmDiscos modificar = new frmDiscos(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DiscoNegocio negocio = new DiscoNegocio();
            Disco seleccionado;

            try
            {
                DialogResult respuesta = MessageBox.Show("Desea eliminar el Disco?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Disco)dgvDiscoteca.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                }              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtbBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Disco> listaFiltrada;
            string filtro = txtbBuscar.Text;

            if (filtro.Length >= 3)
            {
                listaFiltrada = listaDisco.FindAll(x => x.Titulo.ToUpper().Contains(filtro.ToUpper()) || x.Genero.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaDisco;
            }

            dgvDiscoteca.DataSource = null;
            dgvDiscoteca.DataSource = listaFiltrada;
            ocultarColumnas();

        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if (opcion == "Cantidad de canciones")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }

            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DiscoNegocio negocio = new DiscoNegocio();
            try
            {
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCampo.SelectedItem.ToString();
                string filtro = txtbFiltro.Text;
                dgvDiscoteca.DataSource = negocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }           
        }
    }
}
