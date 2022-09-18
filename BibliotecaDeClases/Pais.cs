using System;
namespace BibliotecaDeClases
{
    public class Pais
    {
        public int Id { get; }
        private static int UltimoId { get; set; } = 1;
        public string Nombre { get; set; }
        public TipoCodigo Codigo { get; set; }

        public Pais(string nombre, TipoCodigo codigo)
        {
            Id = UltimoId++;
            Nombre = nombre;
            Codigo = codigo;
        }
    }
}
