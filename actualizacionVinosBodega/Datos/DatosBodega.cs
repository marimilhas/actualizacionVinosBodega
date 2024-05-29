using System;
using System.Collections.Generic;
using actualizacionVinosBodega.Entidades;

namespace actualizacionVinosBodega.Datos
{
    // Simulación de extracción de datos de bodega en BD
    class DatosBodega
    {
        public List<Bodega> lista = new List<Bodega>()
        {
            new Bodega
            {
                nombre = "Bodega Aconcagua",
                descripcion = "Bodega fundada en 1890, especializada en vinos tintos.",
                historia = "Historia rica en tradición vitivinícola.",
                coordenadasUbicacion = "-33.9238, 18.4232",
                fechaUltimaActualizacion = new DateTime(2023, 10, 15),
                periodoActualizacion = 12
            },
            new Bodega
            {
                nombre = "Bodega Maipo",
                descripcion = "Bodega centenaria conocida por sus vinos de alta gama.",
                historia = "Fue fundada en 1905 por inmigrantes italianos.",
                coordenadasUbicacion = "-33.4691, -70.6420",
                fechaUltimaActualizacion = new DateTime(2023, 8, 20),
                periodoActualizacion = 6
            },
            new Bodega
            {
                nombre = "Bodega Rioja",
                descripcion = "Bodega familiar desde 1875, especializada en vinos reserva.",
                historia = "Ha sido gestionada por seis generaciones de la familia Rioja.",
                coordenadasUbicacion = "42.4602, -2.4455",
                fechaUltimaActualizacion = new DateTime(2023, 9, 5),
                periodoActualizacion = 8
            },
            new Bodega
            {
                nombre = "Bodega Napa Valley",
                descripcion = "Una de las bodegas más prestigiosas de California, conocida por sus vinos de alta calidad.",
                historia = "Fundada en 1882, es un ícono en la historia vitivinícola de Estados Unidos.",
                coordenadasUbicacion = "38.5025, -122.2654",
                fechaUltimaActualizacion = new DateTime(2023, 7, 12),
                periodoActualizacion = 10
            },
            new Bodega
            {
                nombre = "Bodega El Legado",
                descripcion = "Fundada en 1890, la Bodega El Legado se especializa en vinos tintos de alta calidad.",
                historia = "Con una rica historia de más de 100 años, la Bodega El Legado ha sido pasada de generación en generación.",
                coordenadasUbicacion = "-70.647240 32.443560",
                fechaUltimaActualizacion = new DateTime(2023, 10, 15),
                periodoActualizacion = 12
            },
            new Bodega
            {
                nombre = "Bodega La Cosecha",
                descripcion = "Ubicada en los fértiles valles de Mendoza, la Bodega La Cosecha produce vinos blancos y rosados premiados internacionalmente.",
                historia = "Fundada por un grupo de enólogos apasionados en 1985, la Bodega La Cosecha ha crecido hasta convertirse en un símbolo de excelencia.",
                coordenadasUbicacion = "-68.822170 -32.890215",
                fechaUltimaActualizacion = new DateTime(2023, 8, 20),
                periodoActualizacion = 6
            },
            new Bodega
            {
                nombre = "Bodega Viña del Sol",
                descripcion = "Situada en los paisajes idílicos del Valle de Colchagua, la Bodega Viña del Sol es conocida por sus vinos premium y tours enológicos.",
                historia = "Establecida en 1992 por una familia de viticultores, Viña del Sol ha ganado numerosos premios por su dedicación a la tradición vinícola.",
                coordenadasUbicacion = "-71.365663 -34.284162",
                fechaUltimaActualizacion = new DateTime(2023, 9, 5),
                periodoActualizacion = 8
            },
        };

        public List<Bodega> Listar()
        {
            return lista;
        }
    }
}

