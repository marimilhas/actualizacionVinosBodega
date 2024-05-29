using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace actualizacionVinosBodega.Entidades
{
    public class TipoUva
    {
        public string nombre { get; set; }
        public string descripcion { get; set; }

        public TipoUva sosTipoUva(TipoUva tipoUva)
        {
            return this.nombre == tipoUva.nombre && this.descripcion == tipoUva.descripcion ? this : null;
        }
    }
}
