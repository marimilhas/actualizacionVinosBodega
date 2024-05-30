using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actualizacionVinosBodega.Entidades
{
    public class Enofilo
    {
        public string nombre {  get; set; }
        public string apellido { get; set; }
        public string imagenPerfil { get; set; }
        public Usuario usuario { get; set; }
        public List<Siguiendo> seguido { get; set; } = null;

        public bool sigueBodega(Bodega bodegaSeleccionada)
        {
            bool res = false;
            foreach(Siguiendo seguido in this.seguido)
            {
                res = seguido.sosDeBodega(bodegaSeleccionada);
                if (res) break;
            }
            return res;
        }

        public string getNombreUsuario()
        {
            return this.usuario.getNombre();
        }
    }
}
