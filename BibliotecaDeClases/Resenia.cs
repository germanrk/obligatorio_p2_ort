using System;
namespace BibliotecaDeClases
{
    public class Resenia
    {
        private static int UltimoId { get; set; } = 1;
        public int Id { get; }
        public string Titulo { get; set; }
        public string Contenido { get; set; }
        public DateTime FechaResenia { get; set; } = new DateTime();
        public Partido Partido { get; set; }
        public Periodista Periodista { get; set; }

        public Resenia(string titulo, string contenido, Partido partido, Periodista periodista)
        {
            Id = UltimoId++;
            Titulo = titulo;
            Contenido = contenido;
            Partido = partido;
            Periodista = periodista;
        }
    }
}
