using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actualizacionVinosBodega.Entidades
{
    public class Maridaje
    {
        public string nombre { get; set; }
        public string descripcion { get; set; }

        public Maridaje sosMaridaje(Maridaje maridajeVino)
        {
            return this.nombre == maridajeVino.nombre && this.descripcion == maridajeVino.descripcion ? this : null;
        }
    }
}
