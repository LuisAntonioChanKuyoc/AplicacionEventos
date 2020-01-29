using Dominio.EventosUI;
using Dominio.Interfaces.Fabrica;
using Dominio.Interfaces.Repositorio;
using EventosUI.Eventos;
using Infrastructure.Fabrica;
using Infrastructure.Repositorio;
using System;

namespace Aplicacion_Eventos
{
    public class Program
    {
        static void Main(string[] args)
        {
            string cRuta = @"C:\BLUE_OCEAN\Capacitacion\AplicacionEventos\Eventos.txt";

            IEventosRepository eventosRepository = ObtenerIEventosRepository();
            ILecturaAchivoRepositorio lecturaAchivoRepositorio = ObtenerILecturaAchivoRepositorio();
            IMensajeRepositorio mensajeRepositorio = ObtenerIMensajeRepositorio();
            IVisualizadorEventos visualizadorEventos = ObtenerIVisualizadorEventos();

            EventosUI eventosUI = new EventosUI(lecturaAchivoRepositorio, mensajeRepositorio, eventosRepository, visualizadorEventos, cRuta);
            eventosUI.VisualizarEventos();

            Console.ReadLine();
        }

        private static IVisualizadorEventos ObtenerIVisualizadorEventos()
        {
            return new VisualizadorEventos();
        }

        private static ILecturaAchivoRepositorio ObtenerILecturaAchivoRepositorio()
        {
            return new LecturaAchivoRepositorio();

        }

        private static IMensajeRepositorio ObtenerIMensajeRepositorio()
        {
            ICreadorInstancia creadorInstancia = new CreadorInstancia();
            return new MensajeRepositorio(creadorInstancia);
        }

        private static IEventosRepository ObtenerIEventosRepository()
        {
            return new EventosRepositorio();
        }


    }
}
