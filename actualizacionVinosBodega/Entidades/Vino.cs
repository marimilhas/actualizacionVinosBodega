using actualizacionVinosBodega.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actualizacionVinosBodega.Entidades
{
    class Vino
    {
        public string nombre { get; set; }
        public int añada { get; set; }
        public string notaDeCataBodega { get; set; }
        public decimal precioArs { get; set; }
        public DateTime? fechaActualizacion { get; set; } 
        public string imagenEtiqueta { get; set; } 
        public List<Varietal> varietal { get; set; } //Uno a muchos 
        public List<Maridaje> maridaje { get; set; } //Cero a muchos
        public Bodega bodega { get; set; }

        public Vino() // para DatosVino
        {

        }

        public Vino(string nombre, string notaCata, decimal precio, string img) // api actualizados
        {
            this.nombre = nombre;
            this.notaDeCataBodega = notaCata;
            this.precioArs = precio;
            this.imagenEtiqueta = img;
        }

        public Vino(string nombre, int añada, string notaDeCataBodega, decimal precioArs,
            string imagenEtiqueta, List<Varietal> varietal, List<Maridaje> maridaje, Bodega bodega) // api nuevos
        {
            this.nombre = nombre;
            this.añada = añada;
            this.notaDeCataBodega = notaDeCataBodega;
            this.precioArs = precioArs;
            this.imagenEtiqueta = imagenEtiqueta;
            this.varietal = varietal;
            this.maridaje = maridaje;
            this.bodega = bodega;
        }

        public bool sosEsteVino(Vino vino)
        {
            return this.nombre == vino.nombre;
        }
    }
}

