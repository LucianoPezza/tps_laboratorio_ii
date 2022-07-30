using System;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace Village_Cines
{
    public abstract class Archivos
    {
        protected abstract string Extension
        { get; }

        public bool ValidarSiExisteElArchivo(string ruta)
        {
            if (!File.Exists(ruta))
            {
                throw new ExcepcionPropia("El archivo no se encontró.");
            }
            return true;
        }

        public bool ValidarExtension(string ruta)
        {
            if (Path.GetExtension(ruta) != Extension)
            {
                throw new ExcepcionPropia($"El archivo no tiene la extensión {Extension}.");
            }
            return true;
        }
    }

    public class Txt : Archivos, IArchivo<string>
    {
        protected override string Extension
        {
            get { return ".txt"; }
        }
        public void Guardar(string ruta, string contenido)
        {
            if (ValidarSiExisteElArchivo(ruta) && ValidarExtension(ruta))
            {
                GuardarArchivo(ruta, contenido);
            }
        }
        public void GuardarComo(string ruta, string contenido)
        {
            if (ValidarExtension(ruta))
            {
                GuardarArchivo(ruta, contenido);
            }
        }

        public string Leer(string ruta)
        {
            if (ValidarSiExisteElArchivo(ruta) && ValidarExtension(ruta))
            {
                using (StreamReader sr = new StreamReader(ruta))
                {
                    return sr.ReadToEnd();
                }
            }
            return string.Empty;
        }

        public void GuardarArchivo(string ruta, string contenido)
        {
            using (StreamWriter sw = new StreamWriter(ruta))
            {
                sw.WriteLine(contenido);
            }
        }
    }

    public class Xml<T> : Archivos, IArchivo<T>
         where T : class
    {
        protected override string Extension
        {
            get { return ".xml"; }
        }
        public void Guardar(string ruta, T contenido)
        {
            if (ValidarSiExisteElArchivo(ruta) && ValidarExtension(ruta))
            {
                Serializar(ruta, contenido);
            }
        }

        public void GuardarComo(string ruta, T contenido)
        {
            if (ValidarExtension(ruta))
            {
                Serializar(ruta, contenido);
            }
        }

        public T Leer(string ruta)
        {
            if (ValidarSiExisteElArchivo(ruta) && ValidarExtension(ruta))
            {
                using (StreamReader streamReader = new StreamReader(ruta))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                    return xmlSerializer.Deserialize(streamReader) as T;
                }
            }

            return null;
        }

        public void Serializar(string ruta, T contenido)
        {
            using (StreamWriter sw = new StreamWriter(ruta))
            {
                XmlSerializer xml = new XmlSerializer(typeof(T));
                xml.Serialize(sw, contenido);
            }
        }
    }

    public class Json<T> : Archivos, IArchivo<T>
   where T : class
    {
        protected override string Extension
        {
            get { return ".json"; }

        }

        public void Guardar(string ruta, T contenido)
        {
            if (ValidarSiExisteElArchivo(ruta) && ValidarExtension(ruta))
            {
                Serializar(ruta, contenido);
            }
        }

        public void GuardarComo(string ruta, T contenido)
        {
            if (ValidarExtension(ruta))
            {
                Serializar(ruta, contenido);
            }
        }

        public T Leer(string ruta)
        {
            if (ValidarSiExisteElArchivo(ruta) && ValidarExtension(ruta))
            {
                using (StreamReader sr = new StreamReader(ruta))
                {
                    string json = sr.ReadToEnd();
                    return JsonSerializer.Deserialize<T>(json);
                }
            }
            return null;
        }

        private void Serializar(string ruta, T contenido)
        {
            using (StreamWriter sw = new StreamWriter(ruta))
            {
                string json = JsonSerializer.Serialize(contenido);
                sw.WriteLine(json);
            }
        }
    }
}
