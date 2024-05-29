﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using actualizacionVinosBodega.Entidades;
using actualizacionVinosBodega.Datos;
using actualizacionVinosBodega.Pantalla;
using Datos;

namespace actualizacionVinosBodega.Gestor
{
    public class GestorImportadorBodega
    {
        private PantallaBodegas pantalla;
        private DatosBodega objsbodega; 
        private InterfazAPIBodega interfaz;

        private List<string> bodegasActualizables;
        private Bodega bodegaSeleccionada;
        DateTime fechaActual;
        private List<Vino> infoVinosImportada;
        List<Maridaje> maridajes;
        List<TipoUva> tiposUva;

        List<Tuple<Vino, bool>> vinosActualizarCrear; // se puede poner este atributo?
        List<Vino> resumen;

        public GestorImportadorBodega(PantallaBodegas pantalla)
        {
            this.pantalla = pantalla;
        }

        public void opcionImportarActualizacionBodegas() 
        {
            buscarBodegasActualizables();
            pantalla.mostrarBodegasActualizables(bodegasActualizables); 

            if (bodegaSeleccionada != null)
            {
                infoVinosImportada = importarActualizacionesVino();
                vinosActualizarCrear = determinarVinosParaActualizar();
                resumen = crearOActualizarVinos();
                pantalla.mostrarResumen();

                //pantalla.mostrarBodegaSeleccionada(bodegaSeleccionada.nombre);
                //pantalla.mostrarListaVinos(infoVinosImportada);     // prueba para ver q hasta ahora funciona
            }

        }

        private DateTime obtenerFechaActual()
        {
            return DateTime.Now.Date;
        }

        private void buscarBodegasActualizables()
        {
            fechaActual = obtenerFechaActual();
            objsbodega = new DatosBodega();
            List<Bodega> bodegas = objsbodega.Listar();
            bodegasActualizables = new List<string>();

            foreach (Bodega bodega in bodegas)
            {
                if (bodega.tieneActualizacionNovedadesVino(fechaActual))
                {
                    bodegasActualizables.Add(bodega.nombre);
                }
            }
        }

        public void tomarSeleccionBodega(string nombreBodega)
        {
            List<Bodega> bodegas = objsbodega.Listar();
            foreach(Bodega bodega in bodegas)
            {
                if (bodega.nombre == nombreBodega)
                {
                    bodegaSeleccionada = bodega;
                    break;
                }
            }
        }

        public List<Vino> importarActualizacionesVino()
        {
            interfaz = new InterfazAPIBodega();
            return interfaz.obtenerActualizacionesVino();
        }

        // por cada vino de la api le pregunta a la bodega si lo tiene, en caso contrario se va a crear
        // inicializa la lista vinosParaActualizar con los vinos importados y su estado
        // VER SI MÉTODO CUMPLE CON DIAGRAMA
        private List<Tuple<Vino, bool>> determinarVinosParaActualizar()
        {
            vinosActualizarCrear = new List<Tuple<Vino, bool>>();
            Vino vinoImportado = new Vino();
            bool paraActualizar = false;
            int i = 0;

            while (infoVinosImportada != null && i < infoVinosImportada.Count)
            {
                vinoImportado = infoVinosImportada[i];
                paraActualizar = bodegaSeleccionada.tienesEsteVino(vinoImportado);

                vinosActualizarCrear.Add(new Tuple<Vino, bool>(vinoImportado, paraActualizar));

                i++;
            }

            return vinosActualizarCrear;
        }

        private List<Vino> crearOActualizarVinos()
        {
            List<Vino> resumen = new List<Vino>();
            Vino vinoActCre = null;
            int i = 0;
            while (vinosActualizarCrear != null && i < vinosActualizarCrear.Count)
            {
                if (vinosActualizarCrear[i].Item2) // el vino se actualiza
                {
                    vinoActCre = actualizarDatosVino(vinosActualizarCrear[i].Item1);
                } else
                {
                    vinoActCre = generarVino(vinosActualizarCrear[i].Item1);
                }

                if (vinoActCre != null)
                {
                    resumen.Add(vinoActCre);
                }
                i++;
            }
            return resumen;
        }

        private Vino actualizarDatosVino(Vino vinoActualizar)
        {
            return bodegaSeleccionada.actualizarDatosVino(vinoActualizar, fechaActual); // mensaje a la bodega
        }

        private Vino generarVino(Vino vinoCrear)
        {
            Vino vinoCreado = null;
            List<TipoUva> tiposUva = buscarTipoUva(vinoCrear.varietal);
            List<Maridaje> maridajes = buscarMaridajes(vinoCrear.maridaje);
            vinoCreado = crearVino(vinoCrear, tiposUva, maridajes);
            return vinoCreado;
        }

        private List<Maridaje> buscarMaridajes(List<Maridaje> maridajesImportado)     // inconsistencia con diagrama
        {
            DatosMaridaje objsMaridaje = new DatosMaridaje();
            maridajes = new List<Maridaje>();
            Maridaje maridajeNuevo = null;

            foreach (Maridaje maridajeImp in maridajesImportado)
            {
                foreach(Maridaje maridajeSist in objsMaridaje.maridajes)
                {
                    maridajeNuevo = maridajeSist.sosMaridaje(maridajeImp);
                    if (maridajeNuevo != null) { maridajes.Add(maridajeNuevo); };
                }
            }    
           return maridajes;
        }

        private List<TipoUva> buscarTipoUva(List<Varietal> varietalesImportados)
        {
            DatosTipoUva objsTipoUva = new DatosTipoUva();
            tiposUva = new List<TipoUva>();
            TipoUva tipoUvaNuevo = null;

            foreach(Varietal varietalImp in varietalesImportados)
            {
                TipoUva tipoUvaImportado = varietalImp.tipoUva;
                foreach (TipoUva tipoUva in objsTipoUva.tiposUva)
                {
                    tipoUvaNuevo = tipoUva.sosTipoUva(tipoUvaImportado);
                    if (tipoUvaNuevo != null) { tiposUva.Add(tipoUvaNuevo); };
                }
            }
            return tiposUva;
        }

        private Vino crearVino(Vino vinoCrear, List<TipoUva> tipoUva, List<Maridaje> maridajes) // es list maridaje o uno solo?
        {
            Vino vinoCreado = new Vino
            {
                nombre = vinoCrear.nombre,
                añada = vinoCrear.añada,
                notaDeCataBodega = vinoCrear.notaDeCataBodega,
                precioArs = vinoCrear.precioArs,
                fechaActualizacion = fechaActual,
                imagenEtiqueta = vinoCrear.imagenEtiqueta,
                varietal = vinoCrear.varietal,  // esto lo tiene que hacer el objeto
                maridaje = maridajes,
                bodega = vinoCrear.bodega,
            };
            return vinoCreado;
        }
    }   
}

