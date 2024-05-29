using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;


namespace actualizacionVinosBodega.Entidades
{
    class Bodega
    {
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string historia { get; set; }
        public string coordenadasUbicacion { get; set; }
        public DateTime fechaUltimaActualizacion { get; set; }
        public int periodoActualizacion { get; set; } //en meses

        public bool tieneActualizacionNovedadesVino(DateTime fechaActual)
        {
            int diferencia = (fechaActual.Year - fechaUltimaActualizacion.Year) * 12
                        + fechaActual.Month - fechaUltimaActualizacion.Month;

            if (fechaActual.Day < fechaUltimaActualizacion.Day)
            {
                diferencia--;
            }

            return diferencia >= periodoActualizacion;
        }

        public Vino tienesEsteVino(Vino vino)
        {
            List<Vino> vinosBodega = new DatosVino().ObtenerVinosBodega(this); // REVISAR
            Vino vinoEncontrado = null;
            int i = 0;

            while (vinosBodega != null && i < vinosBodega.Count)
            {
                if (vinosBodega[i].sosEsteVino(vino))
                {
                    vinoEncontrado = vinosBodega[i];
                } 
            }
            return vinoEncontrado;
        }
    }
}
