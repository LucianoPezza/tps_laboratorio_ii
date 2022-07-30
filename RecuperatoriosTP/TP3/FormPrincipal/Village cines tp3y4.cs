using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Village_Cines;

namespace FormPrincipal
{
    public partial class FormVillagePrincipal : Form
    {
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private string ultimoArchivo = string.Empty;
        private Json<List<Peliculas>> puntoJson;
        private Xml<List<Peliculas>> puntoXml;
        private Txt puntoTxt;
        private string UltimoArchivo
        {
            get
            {
                return ultimoArchivo;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    ultimoArchivo = value;
                }
            }
        }

        public FormVillagePrincipal()
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivo JSON|*.json|Archivo XML|*.xml";
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo JSON|*.json|Archivo XML|*.xml";
            puntoJson = new Json<List<Peliculas>>();
            puntoXml = new Xml<List<Peliculas>>();
            puntoTxt = new Txt();

            InitializeComponent();
        }

        private void FormVillagePrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                Cine.HardcodearDesdeLabaseDeDatos(); 
            }
            catch (ExcepcionPropia ex)
            {
                MostrarVentanaDeError(ex);
                Close();
            }
            finally
            {
                lblTotalRecaudado.Text = $"Total Recaudado:{Cine.Peliculas.CalcularTotalRecaudado().ToString()}";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormVentaDeEntradas_ frmVentas = new FormVentaDeEntradas_();
            frmVentas.ShowDialog();
            lblTotalRecaudado.Text = $"Total Recaudado:{Cine.Peliculas.CalcularTotalRecaudado().ToString()}";
        }


        /// <summary>
        /// Se encarga de mostrar las excepciones lanzadas por archivos en un messageBox
        /// </summary>
        /// <param name="ex"></param>
        private void MostrarVentanaDeError(Exception ex)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Error: {ex.Message}");
            stringBuilder.AppendLine("Detalle:");
            stringBuilder.AppendLine(ex.StackTrace);

            MessageBox.Show(stringBuilder.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Este boton guarda un datos en un archivo si ya tiene uno seleccionado anteriormente, caso contrario tiene que elegir donde guardarlo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!File.Exists(UltimoArchivo))
            {
                GuardarComo();
            }
            else
            {
                Guardar();
            }
        }

        /// <summary>
        /// Este metodo se encarga de guardar manualmente un archivo ya existente.
        /// </summary>
        private void GuardarComo()
        {
            UltimoArchivo = SeleccionarUbicacionGuardado();

            try
            {
                switch (Path.GetExtension(UltimoArchivo))
                {
                    case ".json":
                        puntoJson.Guardar(UltimoArchivo, Cine.Peliculas);
                        break;
                    case ".xml":
                        puntoXml.Guardar(UltimoArchivo, Cine.Peliculas);
                        break;
                }
            }
            catch (Exception ex)
            {
                MostrarVentanaDeError(ex);
            }
        }

        /// <summary>
        /// Este metodo se encarga de guardar los datos en un archivo ya existente y seleccionado
        /// </summary>
        private void Guardar()
        {
            try
            {
                switch (Path.GetExtension(UltimoArchivo))
                {
                    case ".json":
                        puntoJson.Guardar(UltimoArchivo, Cine.Peliculas);
                        break;
                    case ".xml":
                        puntoXml.Guardar(UltimoArchivo, Cine.Peliculas);
                        break;
                }
            }
            catch (Exception ex)
            {
                MostrarVentanaDeError(ex);
            }
        }

        /// <summary>
        /// Este metodo abrir el buscador de archivos para poder elegir el que queramos guardar los datos y tambien retorna
        /// la ruta de ese archivo.
        /// </summary>
        /// <returns></returns>
        private string SeleccionarUbicacionGuardado()
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                return saveFileDialog.FileName;
            }

            return string.Empty;
        }

        /// <summary>
        /// boton que llama al metodo GuardarComo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuaradarComo_Click(object sender, EventArgs e)
        {
            GuardarComo();
        }
    }
}
