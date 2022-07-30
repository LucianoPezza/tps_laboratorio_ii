using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Village_Cines;
namespace FormPrincipal
{
    public partial class FormVentaDeEntradas_ : Form
    {
        public delegate int DelegadoEntradas();
        private event DelegadoEntradas eventoReponerEntradas;
        private Task hilo;
        public FormVentaDeEntradas_()
        {
            InitializeComponent();
            eventoReponerEntradas += ActualizarEntradas;
        }

        private void FormVentaDeEntradas__Load(object sender, EventArgs e)
        {
            ActualizarDtg();
        }

        /// <summary>
        /// Este metodo actualiza los valores cargados en el dtg
        /// </summary>
        public void ActualizarDtg()
        {
            dtgEntradas.DataSource = Cine.Peliculas;
            dtgEntradas.Refresh();
            dtgEntradas.Update();
        }

        /// <summary>
        /// Este boton extrae el nombre de la celda elegida del dtg para pasarselo al constructor del proximo formulario, tambien verfica y no deja avanzar al 
        /// proximo formulario en el caso de que no haya suficientes entradas(0), tambien repone automaticamente las entradas una vez llegan a 0.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVenderEntradas_Click(object sender, EventArgs e)
        {

            string tituloPelicula = dtgEntradas.CurrentRow.Cells[1].Value.ToString();

            bool hayEntradas = VerificarSiHayEntradas(tituloPelicula);

            if (hayEntradas)
            {
                FormVentaDeEntradas2 frmVentaDeEntradas2 = new FormVentaDeEntradas2(tituloPelicula);

                frmVentaDeEntradas2.ShowDialog();
                IniciarReponerEntradas();
                ActualizarDtg();
            }
            else
            {
                MessageBox.Show("Esa pelicula no tiene mas cupo, seleccione otra");
            }
        }

        /// <summary>
        /// este metodo devuelve true si las entradas de todas las peliculas de la lista son mas que cero. 
        /// </summary>
        /// <param name="peliculaAVerificar"></param>
        /// <returns></returns>
        public bool VerificarSiHayEntradas(string peliculaAVerificar)
        {
            foreach (Peliculas item in Cine.Peliculas)
            {
                if (item.Titulo == peliculaAVerificar)
                {
                    if (item.EntradasDisponibles > 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// metodo sencillo del evento que simplemente reestablece las entradas a su valor original
        /// </summary>
        /// <returns></returns>
        public int ActualizarEntradas()
        {
            return 30;
        }

        /// <summary>
        /// este metodo se encarga de activar el evento para reponer entradas y que lo haga automaticamente cada vez
        /// que las entradas lleguen a 0, antes pasan 5 segundos en el hilo secundario y luego se reestablecen las entradas,
        /// mientras se pueden realizar mas ventas en las otras peliculas que tengan entradas disponibles.
        /// </summary>
        public void ReponerEntradas()
        {
            Thread.Sleep(5000);
            if (dtgEntradas.InvokeRequired)
            {
                foreach (Peliculas peliculas in Cine.Peliculas)
                {
                    if (peliculas.EntradasDisponibles == 0)
                    {
                        this.dtgEntradas.BeginInvoke((MethodInvoker)delegate ()
                        {                             
                            peliculas.EntradasDisponibles = eventoReponerEntradas.Invoke();
                            ActualizarDtg();
                        });

                    }

                }
            }
         

        }

        /// <summary>
        /// Este metodo simplemente pone en un hilo secundario el metodo Reponer entradas
        /// </summary>
        public void IniciarReponerEntradas()
        {
            hilo = new Task(ReponerEntradas);
            hilo.Start();
            ActualizarDtg();

        }

        /// <summary>
        /// Este boton sirve en el caso de que si se cierra el formulario antes de que sucedan los 5 segundos del metodo reponerEntradas y por lo tanto
        /// estas no se repondran, para eso esta este boton.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReponerManualmente_Click(object sender, EventArgs e)
        {
            IniciarReponerEntradas();
        }
    }
}
