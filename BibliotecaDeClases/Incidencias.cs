using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaDeClases
{
    public class Incidencias
    {
    public Jugador Jugador { get; set; }
    public TipoIncidencia TipoIncidencia { get; set; }
    public int Minuto { get; set; } = 1;

        public Incidencias(Jugador jugador, TipoIncidencia tipoIncidencia, int minuto)
        {
            Jugador = jugador;
            TipoIncidencia = tipoIncidencia;
            Minuto = minuto;
        }
    }
}
