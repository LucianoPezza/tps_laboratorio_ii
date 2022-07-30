using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Village_Cines;
namespace FormPrincipal
{
    public partial class FormVentaDeEntradas2 : Form
    {
        string tituloDeLaPeliculaElegida;
        Json<Peliculas> peliculas;

        public FormVentaDeEntradas2(string tituloDeLaPeliculaElegida)
        {
            this.tituloDeLaPeliculaElegida = tituloDeLaPeliculaElegida;
            peliculas = new Json<Peliculas>();
            InitializeComponent();
        }
        
        /// <summary>
        /// en el evento load se cargan todos los comboboxes con los valores designados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormVentaDeEntradas2_Load(object sender, EventArgs e)
        {

            foreach (Peliculas item in Cine.Peliculas)
            {
            }
            cmbEs3dONo.Items.Add("2D");
            cmbEs3dONo.Items.Add("3D");

            int contador = ObtenerCantidadDeEntradasDisponibles();
            int i = 0;
            while (contador > 0)
            {
                i++;
                cmbCantidadDeEntradas.Items.Add(i);
                contador--;
            }
        }

        /// <summary>
        /// este metodo recibe el string que el constructor del formulario recibio por parametros a travez de una variable global y
        /// se lo pasa al metodo vender de cine por parametros, tambien verifica que el valor de los comboboxes no sean erroneos y luego tambien los pasa por
        /// parametros al metodo vender de cine.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVender_Click(object sender, EventArgs e)
        {
            if(cmbEs3dONo.SelectedItem is null || cmbCantidadDeEntradas.SelectedItem is null)
            {
                MessageBox.Show("Debe ingresar todos los valores antes de confirmar la venta");
            }
            else
            {
                Cine.Vender(tituloDeLaPeliculaElegida, cmbEs3dONo.SelectedItem.ToString(), Convert.ToInt32(cmbCantidadDeEntradas.SelectedItem));
                MessageBox.Show("Venta Exitosa!!");
                Close();
            }
        }

        /// <summary>
        /// Este metodo calcula cuantas entradas hay disponibles segun el titulo de la pelicula que se eligio para comprar entradas
        /// y establece el limite, se pueden comprar todas o 1.
        /// </summary>
        /// <returns></returns>
        public int ObtenerCantidadDeEntradasDisponibles()
        {
            int contadorDeEntradas = 0;
            foreach (Peliculas item in Cine.Peliculas)
            {
                if (item.Titulo == tituloDeLaPeliculaElegida)
                {
                     contadorDeEntradas = item.EntradasDisponibles;
                }
            }

            return contadorDeEntradas;
        }
    }
}
