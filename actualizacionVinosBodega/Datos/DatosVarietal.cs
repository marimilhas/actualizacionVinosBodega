using System.Collections.Generic;
using actualizacionVinosBodega.Entidades;

namespace Datos
{
    // Simulación de extracción de datos de varietales en BD
    class DatosVarietal
    {
        private DatosTipoUva objsTipoUva = new DatosTipoUva();

        public List<Varietal> obtenerVarietales()
        {
            List<Varietal> listaVarietales = new List<Varietal>();

            listaVarietales.Add(new Varietal
            {
                descripcion = "Malbec puro",
                porcentajeComposicion = 100,
                tipoUva = objsTipoUva.tiposUva[0]
            });

            listaVarietales.Add(new Varietal
            {
                descripcion = "Cabernet Sauvignon - Malbec",
                porcentajeComposicion = 70,
                tipoUva = objsTipoUva.tiposUva[1]
            });

            listaVarietales.Add(new Varietal
            {
                descripcion = "Chardonnay - Viura",
                porcentajeComposicion = 50,
                tipoUva = objsTipoUva.tiposUva[2]
            });

            listaVarietales.Add(new Varietal
            {
                descripcion = "Pinot Noir - Carmenere",
                porcentajeComposicion = 60,
                tipoUva = objsTipoUva.tiposUva[3]
            });

            listaVarietales.Add(new Varietal
            {
                descripcion = "Merlot - Tempranillo",
                porcentajeComposicion = 80,
                tipoUva = objsTipoUva.tiposUva[4]
            });

            listaVarietales.Add(new Varietal
            {
                descripcion = "Syrah - Grenache",
                porcentajeComposicion = 65,
                tipoUva = objsTipoUva.tiposUva[5]
            });

            listaVarietales.Add(new Varietal
            {
                descripcion = "Sauvignon Blanc",
                porcentajeComposicion = 100,
                tipoUva = objsTipoUva.tiposUva[6]
            });

            listaVarietales.Add(new Varietal
            {
                descripcion = "Riesling - Gewürztraminer",
                porcentajeComposicion = 50,
                tipoUva = objsTipoUva.tiposUva[7]
            });
            listaVarietales.Add(new Varietal
            {
                descripcion = "Zinfandel - Cabernet Franc",
                porcentajeComposicion = 70,
                tipoUva = objsTipoUva.tiposUva[8]
            });

            return listaVarietales;
        }
    }
}

