using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitarios
{
   public class URespuesta
    {
        private string mensaje;
        private string url;

        public string Mensaje { get => mensaje; set => mensaje = value; }
        public string Url { get => url; set => url = value; }
    }
}
