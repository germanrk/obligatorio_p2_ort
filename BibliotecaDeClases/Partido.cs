using System;
namespace BibliotecaDeClases
{
    public class Partido
    {
        private static int UltimoId { get; set; } = 1;
        public int Id { get; }
        //public enum ListaSelecciones { get; set; }
        public DateTime FechaYHora { get; set; }
        public bool EstaTerminado { get; set; }
        //public enum ListaIncidencias { get; set; }
        public string Resultado { get; set; } = "Pendiente";
    }
}