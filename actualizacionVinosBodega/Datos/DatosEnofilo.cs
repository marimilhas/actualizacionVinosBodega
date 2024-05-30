using actualizacionVinosBodega.Entidades;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace actualizacionVinosBodega.Datos
{
    class DatosEnofilo
    {
        private DatosSiguiendo objsSiguiendo = new DatosSiguiendo();
        public List<Enofilo> enofilos;
        public List<Enofilo> listar()
        {
            List<Siguiendo> siguiendo = objsSiguiendo.lista;
            List<Enofilo> enofilos = new List<Enofilo>
            {
                new Enofilo{
                    nombre = "Juan", 
                    apellido = "Pérez", 
                    imagenPerfil = "juan.png", 
                    usuario = new Usuario("juanperez"), 
                    seguido = new List<Siguiendo> { objsSiguiendo.lista[0] } },
                new Enofilo{
                    nombre = "Ana",
                    apellido = "García",
                    imagenPerfil = "ana.png",
                    usuario = new Usuario("anagarcia"),
                    seguido = new List<Siguiendo> { objsSiguiendo.lista[1], objsSiguiendo.lista[14] } },
                new Enofilo{
                    nombre = "Pablo",
                    apellido = "Smidth",
                    imagenPerfil = "pablo.png",
                    usuario = new Usuario("pabloschmi"),
                    seguido = new List<Siguiendo> { objsSiguiendo.lista[2], objsSiguiendo.lista[13] } },
                new Enofilo{
                    nombre = "Mariana",
                    apellido = "Milhas",
                    imagenPerfil = "mari.png",
                    usuario = new Usuario("marimilhas"),
                    seguido = new List<Siguiendo> { objsSiguiendo.lista[3], objsSiguiendo.lista[12] } },
                new Enofilo{
                    nombre = "Fabrizio",
                    apellido = "Petri",
                    imagenPerfil = "fabri.png",
                    usuario = new Usuario("fabripetri"),
                    seguido = new List<Siguiendo> { objsSiguiendo.lista[4], objsSiguiendo.lista[11] } },
                new Enofilo{
                    nombre = "Joaquín",
                    apellido = "Gonzales",
                    imagenPerfil = "pachi.png",
                    usuario = new Usuario("pachigonz"),
                    seguido = new List<Siguiendo> { objsSiguiendo.lista[5], objsSiguiendo.lista[10] } },
                new Enofilo{
                    nombre = "Luana",
                    apellido = "Navarro",
                    imagenPerfil = "luana.png",
                    usuario = new Usuario("luananavarro"),
                    seguido = new List<Siguiendo> { objsSiguiendo.lista[6], objsSiguiendo.lista[9] } },
                new Enofilo{
                    nombre = "Tommas",
                    apellido = "Eggel",
                    imagenPerfil = "tomas.png",
                    usuario = new Usuario("tomaseggel"),
                    seguido = new List<Siguiendo> { objsSiguiendo.lista[7], objsSiguiendo.lista[8] } },
            };
            return enofilos;
        }
    }
}