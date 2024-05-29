using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using actualizacionVinosBodega.Entidades;
using actualizacionVinosBodega.Datos;
using actualizacionVinosBodega.Pantalla;

namespace actualizacionVinosBodega.Gestor
{
    public class GestorImportadorBodega
    {
        private PantallaBodegas pantalla;
        private DatosBodega objsbodega = new DatosBodega(); // instancia de la capa de datos
        private InterfazAPIBodega interfaz = new InterfazAPIBodega();
        
        private Bodega bodegaSeleccionada;
        private List<string> bodegasActualizables = new List<string>();
        private List<Vino> infoVinosImportada = new List<Vino>();
        DateTime fechaActual;

        public GestorImportadorBodega(PantallaBodegas pantalla)
        {
            this.pantalla = pantalla;
        }

        public void opcionImportarActualizacionBodegas() 
        {
            bodegasActualizables = buscarBodegasActualizables();
            pantalla.mostrarBodegasActualizables(bodegasActualizables);
            importarActualizacionesVino();
            determinarVinosParaActualizar();

            //if (bodegaSeleccionada != null)
            //{
            //    importarActualizacionesVino();
            //}

        }

        private DateTime obtenerFechaActual()
        {
            return DateTime.Now.Date;
        }

        public List<string> buscarBodegasActualizables()
        {
            fechaActual = obtenerFechaActual();
            List<Bodega> bodegas = objsbodega.Listar();
            List<string> nombresActualizables = new List<string>();

            foreach (Bodega bodega in bodegas)
            {
                if (bodega.tieneActualizacionNovedadesVino(fechaActual))
                {
                    nombresActualizables.Add(bodega.nombre);
                }
            }
            return nombresActualizables;
        }

        public void tomarSeleccionBodega(string nombreBodega)
        {
            List<Bodega> bodegas = objsbodega.Listar();
            foreach(Bodega bodega in bodegas)
            {
                if (bodega.nombre.Equals(nombreBodega))
                {
                    bodegaSeleccionada = bodega;
                }
            }
        }

        public void importarActualizacionesVino()
        {
            infoVinosImportada = interfaz.obtenerActualizacionesVino();
        }

        public void determinarVinosParaActualizar()
        {
            List<Vino> vinosBodegaImportados = new List<Vino>();
            int indice = 0;

            while (infoVinosImportada != null && indice < infoVinosImportada.Count)
            {
                Vino vinoBodega = bodegaSeleccionada.tienesEsteVino(infoVinosImportada[indice]);
                if (vinoBodega != null)
                {
                    vinosBodegaImportados.Add(vinoBodega);
                } else
                {
                    vinosBodegaImportados.Add(infoVinosImportada[indice]);
                }
            }
        }
    }
}

