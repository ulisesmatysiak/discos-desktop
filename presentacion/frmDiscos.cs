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
    public partial class frmDiscos : Form
    {
        private Disco disco = null;
        public frmDiscos()
        {
            InitializeComponent();
        }

        public frmDiscos(Disco disco)
        {
            InitializeComponent();
            this.disco = disco;
            Text = "Modificar disco";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();   
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Disco disco = new Disco();
            DiscoNegocio negocio = new DiscoNegocio();  

            try
            {
                if (disco == null)
                {
                    disco = new Disco();
                }
                disco.Titulo = txtbTitulo.Text;
                disco.Fecha = dtpFecha.Value;
                disco.CantidadCanciones = int.Parse(numCanciones.Text);
                disco.UrlImagen = txtbImagen.Text;
                disco.Genero = (Estilo)cboEstilo.SelectedItem;
                disco.Formato = (Edicion)cboFormato.SelectedItem;

                if (disco.Id != 0)
                {
                    negocio.modificar(disco);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    negocio.agregar(disco);
                    MessageBox.Show("Agregado exitosamente");

                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmDiscos_Load(object sender, EventArgs e)
        {
            EstiloNegocio estiloNegocio = new EstiloNegocio();
            EdicionNegocio edicionNegocio = new EdicionNegocio();
            try
            {               
                cboEstilo.DataSource = estiloNegocio.listar();
                cboEstilo.ValueMember = "Id";
                cboEstilo.DisplayMember = "Descripcion";
                cboFormato.DataSource = edicionNegocio.listar();
                cboFormato.ValueMember = "Id";
                cboFormato.DisplayMember = "Descripcion";

                if (disco != null)
                {
                    txtbTitulo.Text = disco.Titulo;
                    dtpFecha.Value = disco.Fecha;
                    numCanciones.Value = disco.CantidadCanciones;
                    txtbImagen.Text = disco.UrlImagen;
                    cargarImagen(disco.UrlImagen);
                    cboEstilo.SelectedValue = disco.Genero.Id;
                    cboFormato.SelectedValue = disco.Formato.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtbImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtbImagen.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pboDiscos.Load(imagen);
            }
            catch (Exception)
            {
                pboDiscos.Load("https://crawfordroofing.com.au/wp-content/uploads/2018/04/No-image-available.jpg");
            }
        }

        private void btnAgregarImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtbImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);

            }
        }
    }
}
