using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Village_Cines
{
    public static class PeliculasDAO
    {
        static string cadenaConexion;
        static SqlCommand comando;
        static SqlConnection conexion;

        static PeliculasDAO()
        {
            cadenaConexion = @"Data Source=.;Initial Catalog=VillageCines;Integrated Security=True";
            comando = new SqlCommand();
            conexion = new SqlConnection(cadenaConexion);
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
        }
        
        /// <summary>
        /// extrae de la base de datos las peliculas y sus datos y las retorna en forma de una lista de peliculas
        /// </summary>
        /// <returns></returns>
        public static List<Peliculas> Leer()
        {
            List<Peliculas> peliculas = new List<Peliculas>();
            
            try
            {
                conexion.Open();
                comando.CommandText = "SELECT TITULO,GENERO,RECAUDADO,ID FROM PELICULAS";

                using (SqlDataReader dataReader = comando.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        peliculas.Add(new Peliculas(dataReader["TITULO"].ToString(), dataReader["GENERO"].ToString(), Convert.ToDecimal(dataReader["RECAUDADO"]), Convert.ToInt32(dataReader["ID"])));
                    }
                }

            }
            catch(Exception ex)
            {
                throw new ExcepcionPropia("Error al leer la base de datos", ex);
            }
            finally
            {
                conexion.Close();
            }

            return peliculas;
        }

        /// <summary>
        /// modifica la base de datos segun el id de la pelicula
        /// </summary>
        /// <param name="peliculas"></param>
        public static void Modificar(Peliculas peliculas)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"UPDATE PELICULAS SET RECAUDADO = @recaudado WHERE ID= {peliculas.ID}";
                comando.Parameters.AddWithValue("@recaudado", peliculas.Recaudado);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar la base de datos", ex);
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
