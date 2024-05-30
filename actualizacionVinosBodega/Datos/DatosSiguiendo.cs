using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using actualizacionVinosBodega.Entidades;

namespace actualizacionVinosBodega.Datos
{
    public class DatosSiguiendo
    {
        private DatosEnofilo objsEnofilo = new DatosEnofilo();
        private DatosBodega objsBodega = new DatosBodega();
        public List<Siguiendo> lista;

        public List<Siguiendo> listar()
        {
            List<Siguiendo> lista = new List<Siguiendo>()
            {
                new Siguiendo(new DateTime(2020, 4, 23), new DateTime(2023, 5, 17), objsEnofilo.enofilos[1]),
                new Siguiendo(new DateTime(2022, 6, 13), new DateTime(2024, 2, 9), objsEnofilo.enofilos[2]),
                new Siguiendo(new DateTime(2021, 11, 30), new DateTime(2023, 10, 29), objsEnofilo.enofilos[3]),
                new Siguiendo(new DateTime(2020, 2, 7), new DateTime(2024, 1, 23), objsEnofilo.enofilos[4]),
                new Siguiendo(new DateTime(2021, 5, 19), new DateTime(2025, 7, 12), objsEnofilo.enofilos[5]),
                new Siguiendo(new DateTime(2020, 8, 27), new DateTime(2023, 9, 5), objsEnofilo.enofilos[6]),
                new Siguiendo(new DateTime(2022, 4, 14), new DateTime(2025, 8, 21), objsEnofilo.enofilos[7]),
                new Siguiendo(new DateTime(2020, 1, 20), new DateTime(2023, 12, 2), objsBodega.lista[0]),
                new Siguiendo(new DateTime(2021, 3, 5), new DateTime(2024, 3, 18), objsBodega.lista[1]),
                new Siguiendo(new DateTime(2022, 9, 8), new DateTime(2025, 11, 14), objsBodega.lista[2]),
                new Siguiendo(new DateTime(2020, 7, 16), new DateTime(2024, 6, 27), objsBodega.lista[3]),
                new Siguiendo(new DateTime(2021, 8, 25), new DateTime(2023, 4, 3), objsBodega.lista[4]),
                new Siguiendo(new DateTime(2020, 12, 1), new DateTime(2024, 10, 1), objsBodega.lista[5]),
                new Siguiendo(new DateTime(2022, 2, 21), new DateTime(2025, 3, 24), objsBodega.lista[6]),
                new Siguiendo(new DateTime(2020, 10, 10), new DateTime(2023, 7, 15), objsBodega.lista[0])
            };

            return lista;
        }
        

    }
}