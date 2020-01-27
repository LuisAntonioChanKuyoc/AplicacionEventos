using Aplicacion_Eventos.Eventos;
using System;

namespace Aplicacion_Eventos
{
    public class Program
    {
        static void Main(string[] args)
        {
            TiempoEvento evento = new TiempoEvento();
            evento.TiempoOcurridoEvento();
            Console.ReadLine();
        }
    }
}
