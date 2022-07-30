using System;
using System.Collections.Generic;

namespace Village_Cines
{
    public static class Cine
    {
        static List<Peliculas> peliculas;

        public static List<Peliculas> Peliculas
        {
            get { return peliculas; }
            set { peliculas = value; }
        }

        static Cine()
        {
            peliculas = new List<Peliculas>();
        }

        public static void HardcodearDesdeLabaseDeDatos()
        {
            try
            {
                peliculas = PeliculasDAO.Leer();
            }
            catch (Exception ex)
            {
                throw new ExcepcionPropia("debe conectarse primero a la base de datos y luego abrir el formulario.", ex);
            }
        }

        /// <summary>
        /// Este metodo me permite recorrer la lista peliculas y en cuanto un titulo de la lista coincida con el pasado por paramentros,
        /// a esa pelicula se le suma su atributo recaudado dependiendo si el modelado de la pelicual es 2d o 3d. Tambien actualiza la base de datos.
        ///
        /// </summary>
        /// <param name="tituloPelicula"></param>
        /// <param name="modelado"></param>
        /// <param name="cantidadDeEntradas"></param>
        public static bool Vender(string tituloPelicula, string modelado, int cantidadDeEntradas)
        {
            foreach (Peliculas pelicula in peliculas)
            {
                if (pelicula.Titulo == tituloPelicula)
                {

                    switch (modelado)
                    {
                        case "2D":
                            pelicula.Recaudado += 500 * cantidadDeEntradas;
                            pelicula.EntradasDisponibles -= cantidadDeEntradas;
                            break;
                        case "3D":
                            pelicula.Recaudado += 700 * cantidadDeEntradas;
                            pelicula.EntradasDisponibles -= cantidadDeEntradas;
                            break;

                    }

                    PeliculasDAO.Modificar(pelicula);
                    return true;
                }
            }
            return false;
        }
    }
}
