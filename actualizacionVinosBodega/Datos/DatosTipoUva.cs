using System.Collections.Generic;
using actualizacionVinosBodega.Entidades;

namespace Datos
{
    // Simulación de extracción de datos de tipos de uva en BD
    class DatosTipoUva
    {
        public List<TipoUva> tiposUva = new List<TipoUva>
        {
            new TipoUva { nombre = "Malbec", descripcion = "Vino puro de uva Malbec" },
            new TipoUva { nombre = "Cabernet Sauvignon", descripcion = "Vino combinado de uva Cabernet Sauvignon y Malbec" },
            new TipoUva { nombre = "Chardonnay", descripcion = "Vino combinado de uva Chardonnay y Viura" },
            new TipoUva { nombre = "Pinot Noir", descripcion = "Vino combinado de uva Pinot Noir y Carmenere" },
            new TipoUva { nombre = "Merlot", descripcion = "Vino combinado de uva Merlot y Tempranillo" },
            new TipoUva { nombre = "Syrah", descripcion = "Vino combinado de uva Syrah y Grenache" },
            new TipoUva { nombre = "Sauvignon Blanc", descripcion = "Vino puro de uva Sauvignon Blanc" },
            new TipoUva { nombre = "Riesling", descripcion = "Vino combinado de uva Riesling y Gewürztraminer" },
            new TipoUva { nombre = "Zinfandel", descripcion = "Vino combinado de uva Zinfandel y Cabernet Franc" }
        };   
    }
}
