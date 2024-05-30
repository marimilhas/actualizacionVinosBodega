using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actualizacionVinosBodega.Entidades
{
    public class Siguiendo
    {
        private DateTime fechaFin { get; set; }
        private DateTime fechaInicio { get; set; }
        private Bodega bodega = null; // Mutuamente excluyente
        private Enofilo amigo = null; // Mutuamente excluyente

        public Siguiendo(DateTime inicio, DateTime fin, Bodega bodega) 
        { 
            this.fechaInicio = inicio;
            this.fechaFin = fin;
            this.bodega = bodega;
        }

        public Siguiendo(DateTime inicio, DateTime fin, Enofilo amigo)
        {
            this.fechaInicio = inicio;
            this.fechaFin = fin;    
            this.amigo = amigo;
        }

        public bool sosDeBodega(Bodega bodegaSeleccionada)
        {
            bool res = false;
            if (this.bodega != null && this.bodega.nombre == bodegaSeleccionada.nombre)
            {
                res = true;
            }
            return res;
        }
    }
}
