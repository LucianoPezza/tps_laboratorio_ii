using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Village_Cines
{
    public class Peliculas
    {
        string titulo;
        string genero;
        decimal recaudado;
        int cantidadDeEntradas;
        int id;

        public int ID { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Genero { get => genero; set => genero = value; }
        public decimal Recaudado { get => recaudado; set => recaudado = value; }
        public int EntradasDisponibles { get => cantidadDeEntradas; set => cantidadDeEntradas = value; }
        
        
        public Peliculas()
        {

        }

        public Peliculas(string titulo, string genero)
        {
            this.titulo = titulo;
            this.genero = genero;
            this.cantidadDeEntradas = 30;
        }

        public Peliculas(string titulo, string genero, decimal recaudado, int id)
        : this(titulo, genero)
        {
            this.recaudado = recaudado;
            this.id = id;
        }



    }
}
