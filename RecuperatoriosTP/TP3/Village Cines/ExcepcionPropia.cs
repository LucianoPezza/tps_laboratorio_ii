using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Village_Cines
{
    public class ExcepcionPropia:Exception
    {
        public ExcepcionPropia(string mensaje, Exception inner)
            : base(mensaje, inner)
        {

        }

        public ExcepcionPropia(string mensaje)
        :this(mensaje, null)
        {

        }
    }
}
