using System;
using System.Collections.Generic;
using actualizacionVinosBodega.Entidades;
using actualizacionVinosBodega.Datos;
using actualizacionVinosBodega.Pantalla;
using Datos;
using System.Windows.Forms;

namespace actualizacionVinosBodega.Gestor
{
    public class GestorImportadorBodega
    {
        private PantallaBodegas pantalla;
        private DatosBodega objsbodega; 
        private InterfazAPIBodega interfaz;

        private List<string> bodegasActualizables;
        public Bodega bodegaSeleccionada;
        private DateTime fechaActual;
        private List<Vino> infoVinosImportada;
        private List<Maridaje> maridajes;
        private List<TipoUva> tiposUva;
        private List<Tuple<Vino, bool>> vinosActualizarCrear; 
        public List<Vino> resumen;
        private List<string> seguidoresBodega;

        public GestorImportadorBodega(PantallaBodegas pantalla)
        {
            this.pantalla = pantalla;
        }

        public void opcionImportarActualizacionBodegas()
        {
            fechaActual = obtenerFechaActual();
            buscarBodegasActualizables(fechaActual);
            pantalla.mostrarBodegasActualizables(bodegasActualizables);


            //if (bodegaSeleccionada != null)
            //{
            //    infoVinosImportada = importarActualizacionesVino();
            //    vinosActualizarCrear = determinarVinosParaActualizar(infoVinosImportada);
            //    resumen = crearOActualizarVinos(vinosActualizarCrear);

            //    if (resumen != null)
            //    {
            //        pantalla.mostrarResumen(resumen, bodegaSeleccionada);
            //    }
            //    //pantalla.mostrarBodegaSeleccionada(bodegaSeleccionada.nombre);
            //    pantalla.mostrarListaVinos(infoVinosImportada);     // prueba para ver q hasta ahora funciona
            //}

        }

        private DateTime obtenerFechaActual()
        {
            return DateTime.Now.Date;
        }

        private void buscarBodegasActualizables(DateTime fechaActual)
        {
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
            try
            {
                interfaz = new InterfazAPIBodega();
                return interfaz.obtenerActualizacionesVino();
            } catch(Exception e)
            {
                return null;
            }
            
        }

        public List<Tuple<Vino, bool>> determinarVinosParaActualizar(List<Vino> infoVinosImportada)
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

        public List<Vino> crearOActualizarVinos(List<Tuple<Vino, bool>> vinosActualizarCrear)
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
            tiposUva = buscarTipoUva(vinoCrear.varietal);
            maridajes = buscarMaridajes(vinoCrear.maridaje);
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
                    if (maridajeNuevo != null) { 
                        maridajes.Add(maridajeNuevo);
                        break;
                    };
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
                    if (tipoUvaNuevo != null) { 
                        tiposUva.Add(tipoUvaNuevo);
                        break;
                    };
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
    
        private List<string> buscarSeguidoresBodega(Bodega bodegaSeleccionada)
        {
            DatosEnofilo objsEnofilo = new DatosEnofilo();
            List<Enofilo> enofilos = objsEnofilo.enofilos;
            List<string> seguidoresBodega = new List<string>();
            string nombreUsuario;
            int i = 0;

            while (enofilos != null && i < enofilos.Count) 
            {
                if (enofilos[i].sigueBodega(bodegaSeleccionada))
                {
                    nombreUsuario = enofilos[i].getNombreUsuario();
                    seguidoresBodega.Add(nombreUsuario);
                }
                i++;
            }
            return seguidoresBodega;
        }

        private void FinCU()
        {
            pantalla.Close();
        }

    }   
}

