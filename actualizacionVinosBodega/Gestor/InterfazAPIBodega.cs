using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using actualizacionVinosBodega.Datos;
using actualizacionVinosBodega.Entidades;
using Datos;

namespace actualizacionVinosBodega.Gestor
{
    internal class InterfazAPIBodega
    {
        private DatosBodega objsBodega = new DatosBodega();
        private DatosVarietal objsVarietal = new DatosVarietal();
        private DatosMaridaje objsMaridaje = new DatosMaridaje();
        private List<Varietal> varietales;

        public InterfazAPIBodega()
        {
            varietales = objsVarietal.obtenerVarietales();
        }

        
        public List<Vino> obtenerActualizacionesVino()
        {
            // SIMULACIÓN DE ERROR EN LA API
            //throw new Exception("La API no está disponible en este momento. Por favor, inténtelo más tarde.");

            List<Vino> actualizaciones = new List<Vino>();

            actualizaciones.Add(        // ACTUALIZADO - cambió precio
                new Vino(
                    "Vino Blanco Suave",
                    "Un vino blanco suave y fresco con aromas a frutas tropicales.",
                    1300,
                    "etiqueta_vino_blanco_suave.jpg"));

            actualizaciones.Add(        // ACTUALIZADO - cambió nota de cata
                new Vino(
                    "Vino Blanco Elegante",
                    "Un vino blanco refinado con aromas de frutas blancas y un sutil toque mineral.",
                    1200,
                    "etiqueta_vino_blanco_elegante.jpg"));

            actualizaciones.Add(        // ACTUALIZADO - cambió imagen y precio
                new Vino(
                    "Vino Tinto Reserva",
                    "Un vino tinto reserva complejo y estructurado, con notas a frutos negros y madera.",
                    3000,
                    "etiqueta_vino_tinto_reserva_cosecha.jpg"
                    ));

            actualizaciones.Add(        // NUEVO
                new Vino(
                    "L’ Ermitage",
                    2020,
                    "De elegancia singular, con notas a frutos rojos maduros y un toque sutil de especias.",
                    500,
                    "etiqueta_vino_famoso.jpg",
                    new List<Varietal> { varietales[8] },
                    new List<Maridaje>
                    {
                    objsMaridaje.maridajes[1],
                    objsMaridaje.maridajes[6]
                    },
                    objsBodega.lista[3]));

            actualizaciones.Add(        // NUEVO
                new Vino(
                    "Brune & Blonde de Guigal",
                        2016,
                        "Con aromas seductores a frutos negros, violetas y notas especiadas.",
                        4500,
                        "vino_frutos.jpg",
                        new List<Varietal> { varietales[5] },
                        new List<Maridaje>
                        {
                        objsMaridaje.maridajes[0],
                        objsMaridaje.maridajes[4]
                        },
                        objsBodega.lista[3]));

            return actualizaciones;
        }
    }
}
