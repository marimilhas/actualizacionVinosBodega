using System;
using System.Collections.Generic;
using actualizacionVinosBodega.Entidades;
using actualizacionVinosBodega.Datos;
using System.Security.Cryptography;

namespace Datos
{
    // Simulación de extracción de datos de vinos en BD
    class DatosVino
    {
        private DatosBodega objsBodega = new DatosBodega();
        private DatosVarietal objsVarietal = new DatosVarietal();
        private DatosMaridaje objsMaridaje = new DatosMaridaje();
        private List<Varietal> varietales;

        public DatosVino()
        {
            varietales = objsVarietal.obtenerVarietales();
        }

        public List<Vino> ObtenerVinos()
        {
            List<Vino> listaVinos = new List<Vino>();

            // Vinos de Bodega Aconcagua
            listaVinos.Add(new Vino
            {
                nombre = "Vino Tinto Clásico",
                añada = 2018,
                notaDeCataBodega = "Un vino tinto clásico de la región con notas a frutos rojos y especias.",
                precioArs = 1200,
                fechaActualizacion = new DateTime(2023, 10, 15), 
                imagenEtiqueta = "etiqueta_vino_tinto_clasico.jpg",
                varietal = { varietales[0] },
                maridaje = new List<Maridaje>
                {
                    objsMaridaje.maridajes[0],
                    objsMaridaje.maridajes[2]
                },
                bodega = objsBodega.lista[0]
            });

            listaVinos.Add(new Vino
            {
                nombre = "Vino Tinto Reserva",
                añada = 2015,
                notaDeCataBodega = "Un vino tinto reserva de alta calidad con cuerpo y estructura.",
                precioArs = 1800,
                fechaActualizacion = new DateTime(2023, 10, 15),
                imagenEtiqueta = "etiqueta_vino_tinto_reserva.jpg",
                varietal = { varietales[1] },
                maridaje = new List<Maridaje>
                {
                    objsMaridaje.maridajes[0],
                    objsMaridaje.maridajes[3]
                },
                bodega = objsBodega.lista[0]
            });

            listaVinos.Add(new Vino
            {
                nombre = "Vino Tinto Robusto",
                añada = 2017,
                notaDeCataBodega = "Un vino tinto robusto y estructurado con aromas a frutos negros.",
                precioArs = 1500,
                fechaActualizacion = new DateTime(2023, 10, 15),
                imagenEtiqueta = "etiqueta_vino_tinto_robusto.jpg",
                varietal = { varietales[2] },
                maridaje = new List<Maridaje>
                {
                    objsMaridaje.maridajes[0]
                },
                bodega = objsBodega.lista[0]
            });

            // Vinos de Bodega Maipo
            listaVinos.Add(new Vino
            {
                nombre = "Vino Blanco Suave",
                añada = 2020,
                notaDeCataBodega = "Un vino blanco suave y fresco con aromas a frutas tropicales.",
                precioArs = 950,
                fechaActualizacion = new DateTime(2023, 8, 20),
                imagenEtiqueta = "etiqueta_vino_blanco_suave.jpg",
                varietal = { varietales[3] },
                maridaje = new List<Maridaje>
                {
                    objsMaridaje.maridajes[1]
                },
                bodega = objsBodega.lista[1]
            });

            listaVinos.Add(new Vino
            {
                nombre = "Vino Blanco Afrutado",
                añada = 2021,
                notaDeCataBodega = "Un vino blanco afrutado con notas cítricas y frescas.",
                precioArs = 1100,
                fechaActualizacion = new DateTime(2023, 8, 20),
                imagenEtiqueta = "etiqueta_vino_blanco_afrutado.jpg",
                varietal = { varietales[4] },
                maridaje = new List<Maridaje>
                {
                    objsMaridaje.maridajes[2]
                },
                bodega = objsBodega.lista[1]
            });

            listaVinos.Add(new Vino
            {
                nombre = "Vino Tinto Robusto",
                añada = 2017,
                notaDeCataBodega = "Un vino tinto robusto y estructurado con aromas a frutos negros.",
                precioArs = 1500,
                fechaActualizacion = new DateTime(2023, 8, 20),
                imagenEtiqueta = "etiqueta_vino_tinto_robusto.jpg",
                varietal = { varietales[5] },
                maridaje = new List<Maridaje>
                {
                    objsMaridaje.maridajes[0]
                },
                bodega = objsBodega.lista[1]
            });

            // Vinos de Bodega Rioja
            listaVinos.Add(new Vino
            {
                nombre = "Vino Tinto Clásico",
                añada = 2018,
                notaDeCataBodega = "Un vino tinto clásico de la región con notas a frutos rojos y especias.",
                precioArs = 1200,
                fechaActualizacion = new DateTime(2023, 9, 5),
                imagenEtiqueta = "etiqueta_vino_tinto_clasico.jpg",
                varietal = { varietales[6] },
                maridaje = new List<Maridaje>
                {
                    objsMaridaje.maridajes[0],
                    objsMaridaje.maridajes[2]
                },
                bodega = objsBodega.lista[2]
            });

            listaVinos.Add(new Vino
            {
                nombre = "Vino Tinto Reserva",
                añada = 2015,
                notaDeCataBodega = "Un vino tinto reserva de alta calidad con cuerpo y estructura.",
                precioArs = 1800,
                fechaActualizacion = new DateTime(2023, 9, 5),
                imagenEtiqueta = "etiqueta_vino_tinto_reserva.jpg",
                varietal = { varietales[7] },
                maridaje = new List<Maridaje>
                {
                    objsMaridaje.maridajes[0],
                    objsMaridaje.maridajes[3]
                },
                bodega = objsBodega.lista[2]
            });

            listaVinos.Add(new Vino
            {
                nombre = "Vino Rosado Fresco",
                añada = 2019,
                notaDeCataBodega = "Un vino rosado fresco y afrutado con notas a frutas del bosque.",
                precioArs = 1000,
                fechaActualizacion = new DateTime(2023, 9, 5),
                imagenEtiqueta = "etiqueta_vino_rosado_fresco.jpg",
                varietal = { varietales[8] },
                maridaje = new List<Maridaje>
                {
                    objsMaridaje.maridajes[2]
                },
                bodega = objsBodega.lista[2]
            });

            // Vinos de Bodega Napa Valley
            listaVinos.Add(new Vino
            {
                nombre = "Vino Blanco Suave",
                añada = 2020,
                notaDeCataBodega = "Un vino blanco suave y fresco con aromas a frutas tropicales.",
                precioArs = 950,
                fechaActualizacion = new DateTime(2023, 7, 12),
                imagenEtiqueta = "etiqueta_vino_blanco_suave.jpg",
                varietal = { varietales[2] },
                maridaje = new List<Maridaje>
                {
                    objsMaridaje.maridajes[1]
                },
                bodega = objsBodega.lista[3]
            });
            listaVinos.Add(new Vino
            {
                nombre = "Vino Blanco Elegante",
                añada = 2018,
                notaDeCataBodega = "Un vino blanco elegante con notas a frutas blancas y una leve mineralidad.",
                precioArs = 1200,
                fechaActualizacion = new DateTime(2023, 7, 12),
                imagenEtiqueta = "etiqueta_vino_blanco_elegante.jpg",
                varietal = { varietales[2] },
                maridaje = new List<Maridaje>
                {
                    objsMaridaje.maridajes[2]
                },
                bodega = objsBodega.lista[3]
            });

            listaVinos.Add(new Vino
            {
                nombre = "Vino Tinto Reserva",
                añada = 2016,
                notaDeCataBodega = "Un vino tinto reserva complejo y estructurado, con notas a frutos negros y madera.",
                precioArs = 2200,
                fechaActualizacion = new DateTime(2023, 7, 12),
                imagenEtiqueta = "etiqueta_vino_tinto_reserva.jpg",
                varietal = { varietales[1] },
                maridaje = new List<Maridaje>
                {
                    objsMaridaje.maridajes[0],
                    objsMaridaje.maridajes[4]
                },
                bodega = objsBodega.lista[3]
            });

            // Vinos de Bodega El Legado
            listaVinos.Add(new Vino
            {
                nombre = "Vino Tinto Gran Reserva",
                añada = 2014,
                notaDeCataBodega = "Un vino tinto gran reserva de El Legado con aromas complejos y notas de madera.",
                precioArs = 2500,
                fechaActualizacion = new DateTime(2023, 10, 15),
                imagenEtiqueta = "etiqueta_vino_tinto_gran_reserva.jpg",
                varietal = { varietales[1], varietales[1] },
                maridaje = new List<Maridaje>
                {
                    objsMaridaje.maridajes[0],
                    objsMaridaje.maridajes[4]
                },
                bodega = objsBodega.lista[4]
            });

            listaVinos.Add(new Vino
            {
                nombre = "Vino Blanco Joven",
                añada = 2022,
                notaDeCataBodega = "Un vino blanco joven de El Legado con frescura y aromas frutales.",
                precioArs = 1100,
                fechaActualizacion = new DateTime(2023, 10, 15),
                imagenEtiqueta = "etiqueta_vino_blanco_joven.jpg",
                varietal = { varietales[2], varietales[5] },
                maridaje = new List<Maridaje>
                {
                    objsMaridaje.maridajes[1],
                    objsMaridaje.maridajes[5]
                },
                bodega = objsBodega.lista[4]
            });

            // Vinos de Bodega La Cosecha
            listaVinos.Add(new Vino
            {
                nombre = "Vino Tinto Reserva",
                añada = 2017,
                notaDeCataBodega = "Un vino tinto reserva de La Cosecha con aromas intensos y buena estructura.",
                precioArs = 1900,
                fechaActualizacion = new DateTime(2023, 8, 20),
                imagenEtiqueta = "etiqueta_vino_tinto_reserva.jpg",
                varietal = { varietales[3], varietales[7] },
                maridaje = new List<Maridaje>
                {
                    objsMaridaje.maridajes[0],
                    objsMaridaje.maridajes[3]
                },
                bodega = objsBodega.lista[5]
            });

            listaVinos.Add(new Vino
            {
                nombre = "Vino Rosado Semi-Seco",
                añada = 2020,
                notaDeCataBodega = "Un vino rosado semi-seco de La Cosecha con aromas a frutos rojos y frescura.",
                precioArs = 1200,
                fechaActualizacion = new DateTime(2023, 8, 20),
                imagenEtiqueta = "etiqueta_vino_rosado_semi_seco.jpg",
                varietal = { varietales[6], varietales[8] },
                maridaje = new List<Maridaje>
                {
                    objsMaridaje.maridajes[2],
                    objsMaridaje.maridajes[6]
                },
                bodega = objsBodega.lista[5]
            });

            // Vinos de Viña del Sol
            listaVinos.Add(new Vino
            {
                nombre = "Vino Blanco de Autor",
                añada = 2019,
                notaDeCataBodega = "Un vino blanco de autor de Viña del Sol con complejidad y elegancia.",
                precioArs = 1800,
                fechaActualizacion = new DateTime(2023, 9, 5),
                imagenEtiqueta = "etiqueta_vino_blanco_de_autor.jpg",
                varietal = { varietales[2], varietales[4] },
                maridaje = new List<Maridaje>
                {
                    objsMaridaje.maridajes[1],
                    objsMaridaje.maridajes[3]
                },
                bodega = objsBodega.lista[6]
            });

            listaVinos.Add(new Vino
            {
                nombre = "Vino Tinto Joven",
                añada = 2021,
                notaDeCataBodega = "Un vino tinto joven de Viña del Sol con frescura y aromas frutales.",
                precioArs = 1300,
                fechaActualizacion = new DateTime(2023, 9, 5),
                imagenEtiqueta = "etiqueta_vino_tinto_joven.jpg",
                varietal = { varietales[0], varietales[5] },
                maridaje = new List<Maridaje>
                {
                    objsMaridaje.maridajes[2],
                    objsMaridaje.maridajes[4]
                },
                bodega = objsBodega.lista[6]
            });


            return listaVinos;
        }

        public List<Vino> ObtenerVinosBodega(Bodega bodega)
        {
            List<Vino> lista = ObtenerVinos();
            List<Vino> listaVinosBodega = new List<Vino>();
            
            foreach(Vino vino in lista)
            {
                if (vino.bodega == bodega)
                {
                    listaVinosBodega.Add(vino);
                }
            }

            return listaVinosBodega;
        }
    }
}

