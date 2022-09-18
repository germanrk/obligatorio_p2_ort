`using System;
namespace BibliotecaDeClases
{
    public class Jugador
    {
        public int Id { get; }
        private static int UltimoId { get; set; } = 1;
        public string NombreCompleto { get; set; }
        public string NumeroCamiseta { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public double Altura { get; set; }
        public string PeHabil { get; set; }
        public double ValorMercado { get; set; }
        public Pais Pais { get; set; }
        public TipoPuesto Puesto { get; set; }

        public string Categoria { get; set; }
        public double MontoReferencia { get; set; } = 200000;

        public Jugador(string nombreCompleto, string numeroCamiseta, DateTime fechaNacimiento, double altura, string peHabil, double valorMercado, Pais pais, TipoPuesto puesto, string categoria)
        {
            Id = UltimoId++;
            NombreCompleto = nombreCompleto;
            NumeroCamiseta = numeroCamiseta;
            FechaNacimiento = fechaNacimiento;
            Altura = altura;
            PeHabil = peHabil;
            ValorMercado = valorMercado;
            Pais = pais;
            Puesto = puesto;
            Categoria = categoria;
        }
    }
}
