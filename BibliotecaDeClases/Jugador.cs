using System;
namespace BibliotecaDeClases
{
    public class Jugador
    {
        private static int UltimoId { get; set; } = 1;
        public int Id { get; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NumCamiseta { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Altura { get; set; }
        public string PeHabil { get; set; }
        public double ValorMercado { get; set; }
        public string Puesto { get; set; }
        public Pais Pais { get; set; }

        public Jugador(string nombre, string apellido, string numCamiseta, DateTime fechaNacimiento, string altura, string peHabil, double valorMercado, string puesto, Pais pais)
        {
            Id = UltimoId++;
            Nombre = nombre;
            Apellido = apellido;
            NumCamiseta = numCamiseta;
            FechaNacimiento = fechaNacimiento;
            Altura = altura;
            PeHabil = peHabil;
            ValorMercado = valorMercado;
            Puesto = puesto;
            Pais = pais;
        }
    }
}
