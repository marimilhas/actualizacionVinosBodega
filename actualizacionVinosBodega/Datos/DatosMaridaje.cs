using System.Collections.Generic;
using actualizacionVinosBodega.Entidades;

namespace Datos
{
    // Simulación de extracción de datos de maridajes en BD
    class DatosMaridaje
    {
        public List<Maridaje> maridajes = new List<Maridaje>
        {
            new Maridaje { nombre = "Carne Asada", descripcion = "Perfecto para carnes rojas a la parrilla." },
            new Maridaje { nombre = "Pescado Blanco", descripcion = "Ideal para acompañar pescados blancos." },
            new Maridaje { nombre = "Quesos Maduros", descripcion = "Marida bien con quesos maduros y curados." },
            new Maridaje { nombre = "Chocolate Amargo", descripcion = "Excelente con postres de chocolate amargo." },
            new Maridaje { nombre = "Sushi", descripcion = "Complementa sabores frescos y delicados del sushi." },
            new Maridaje { nombre = "Ensaladas Frescas", descripcion = "Ideal para ensaladas frescas y livianas." },
            new Maridaje { nombre = "Tacos de Pescado", descripcion = "Perfecto para tacos de pescado fresco." }
        };
    }
}

