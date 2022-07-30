using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Village_Cines
{

    /// <summary>
    /// este metodo calcula todo lo recaudado de todos los elementos de la lista y los devuelve
    /// </summary>
    /// <returns></returns>
    public static class Metodo_de_extension
    {
        public static decimal CalcularTotalRecaudado(this List<Peliculas> lista)
        {
            decimal totalRecaudado = 0;
            foreach (Peliculas item in lista)
            {
                totalRecaudado += item.Recaudado;
            }

            return totalRecaudado;
        }
    }
}
