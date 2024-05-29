using System.Collections.Generic;
using actualizacionVinosBodega.Entidades;

namespace Datos
{
    // Simulación de extracción de datos de varietales en BD
    class DatosVarietal
    {
        public List<Varietal> lista = new List<Varietal>
        {
            new Varietal
            {
                descripcion = "Malbec puro",
                porcentajeComposicion = 100,
                tipoUva = new TipoUva { nombre = "Malbec", descripcion = "Vino puro de uva Malbec" }
            },
            new Varietal
            {
                descripcion = "Cabernet Sauvignon - Malbec",
                porcentajeComposicion = 70,
                tipoUva = new TipoUva { nombre = "Cabernet Sauvignon", descripcion = "Vino combinado de uva Cabernet Sauvignon y Malbec" }
            },
            new Varietal
            {
                descripcion = "Chardonnay - Viura",
                porcentajeComposicion = 50,
                tipoUva = new TipoUva { nombre = "Chardonnay", descripcion = "Vino combinado de uva Chardonnay y Viura" }
            },
            new Varietal
            {
                descripcion = "Pinot Noir - Carmenere",
                porcentajeComposicion = 60,
                tipoUva = new TipoUva { nombre = "Pinot Noir", descripcion = "Vino combinado de uva Pinot Noir y Carmenere" }
            },
            new Varietal
            {
                descripcion = "Merlot - Tempranillo",
                porcentajeComposicion = 80,
                tipoUva = new TipoUva { nombre = "Merlot", descripcion = "Vino combinado de uva Merlot y Tempranillo" }
            },
            new Varietal
            {
                descripcion = "Syrah - Grenache",
                porcentajeComposicion = 65,
                tipoUva = new TipoUva { nombre = "Syrah", descripcion = "Vino combinado de uva Syrah y Grenache" }
            },
            new Varietal
            {
                descripcion = "Sauvignon Blanc",
                porcentajeComposicion = 100,
                tipoUva = new TipoUva { nombre = "Sauvignon Blanc", descripcion = "Vino puro de uva Sauvignon Blanc" }
            },
            new Varietal
            {
                descripcion = "Riesling - Gewürztraminer",
                porcentajeComposicion = 50,
                tipoUva = new TipoUva { nombre = "Riesling", descripcion = "Vino combinado de uva Riesling y Gewürztraminer" }
            },
            new Varietal
            {
                descripcion = "Zinfandel - Cabernet Franc",
                porcentajeComposicion = 70,
                tipoUva = new TipoUva { nombre = "Zinfandel", descripcion = "Vino combinado de uva Zinfandel y Cabernet Franc" }
            }
        };
    }
}

