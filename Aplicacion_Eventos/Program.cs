using Aplicacion_Eventos.Eventos;
using Dominio.Interfaces.Repositorio;
using Infrastructure.Repositorio;
using System;

namespace Aplicacion_Eventos
{
    public class Program
    {
        static void Main(string[] args)
        {
            string cRuta = @"C:\BLUE_OCEAN\Capacitacion\AplicacionEventos\Eventos.txt";

            IEventosRepository eventosRepository = new EventosRepositorio();
            ILecturaAchivoRepositorio lecturaAchivoRepositorio = new LecturaAchivoRepositorio();
            IMensajeRepositorio mensajeRepositorio = new MensajeRepositorio();

            EventosUI eventosUI = new EventosUI(lecturaAchivoRepositorio, mensajeRepositorio, eventosRepository, cRuta);
            eventosUI.VisualizarEventos();

            Console.ReadLine();
        }
    }
}
