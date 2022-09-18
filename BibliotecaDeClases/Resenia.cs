using System;
namespace BibliotecaDeClases
{
    public class Resenia
    {
        //private static int UltimoId { get; set; } = 1;
        //public int Id { get; }
        public Periodista Periodista { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
        public Partido Partido { get; set; }
        public string Titulo { get; set; }
        public string Contenido { get; set; }

        public Resenia(string titulo, string contenido, Partido partido, Periodista periodista)
        {
            //Id = UltimoId++;
            Titulo = titulo;
            Contenido = contenido;
            Partido = partido;
            Periodista = periodista;
        }
    }
}
