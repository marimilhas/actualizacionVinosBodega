using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actualizacionVinosBodega.Entidades
{
    public class Usuario
    {
        public string nombre { get; set; }

        public Usuario(string nombre)
        {
            this.nombre = nombre;
        }

        public string getNombre()
        {
            return this.nombre;
        }
    }
}
