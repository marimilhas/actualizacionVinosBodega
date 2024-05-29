using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;


namespace actualizacionVinosBodega.Entidades
{
    public class Bodega
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

        public bool tienesEsteVino(Vino vinoImportado)
        {
            List<Vino> vinosBodega = new DatosVino().ObtenerVinosBodega(this); // REVISAR
            bool encontrado = false;
            int i = 0;

            while (vinosBodega != null && i < vinosBodega.Count)
            {
                if (vinosBodega[i].sosEsteVino(vinoImportado))
                {
                    encontrado = true;
                    break;
                }
                i++;
            }
            return encontrado;
        }

        public Vino actualizarDatosVino(Vino vinoActualizar, DateTime fechaActual)
        {
            List<Vino> vinosBodega = new DatosVino().ObtenerVinosBodega(this); // REVISAR
            int i = 0;

            while (vinosBodega != null && i < vinosBodega.Count)
            {
                if (vinosBodega[i].sosVinoActualizable(vinoActualizar))
                {
                    vinosBodega[i].precioArs = vinoActualizar.precioArs;    // hace falta crear un método set? aplica a todos
                    vinosBodega[i].notaDeCataBodega = vinoActualizar.notaDeCataBodega;
                    vinosBodega[i].imagenEtiqueta = vinoActualizar.imagenEtiqueta;
                    vinosBodega[i].fechaActualizacion = fechaActual;
                    return vinosBodega[i];
                }
                i++;
            }
            return null;
        }
    }
}
