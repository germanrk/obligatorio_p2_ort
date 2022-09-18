using System;
using System.Collections.Generic;

namespace BibliotecaDeClases
{
    public class Partido
    {
        public int Id { get; }
        private static int UltimoId { get; set; } = 1;

        public List<Seleccion> SeleccionesEnfrantantes { get; set; }
        public DateTime FechaYHora { get; set; } = DateTime.Now;
        public bool Finalizado { get; set; }
        public List<Incidencias> Incidencias { get; set; }
        public string Resultado { get; set; } = "Pendiente";

        public Partido(List<Seleccion> seleccionesEnfrantantes)
        {
            Id = UltimoId++;
            SeleccionesEnfrantantes = seleccionesEnfrantantes;
        }
    }
}