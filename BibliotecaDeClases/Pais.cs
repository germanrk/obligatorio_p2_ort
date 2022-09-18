using System;
namespace BibliotecaDeClases
{
    public class Pais
    {
        private static int UltimoId { get; set; } = 1;
        public int Id { get; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }

        public Pais(string nombre, string codigo)
        {
            Id = UltimoId++;
            Nombre = nombre;
            Codigo = codigo;
        }
    }
}
