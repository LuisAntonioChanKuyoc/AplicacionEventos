using Dominio.Interfaces.Repositorio;
using System;
using System.Collections.Generic;

namespace Aplicacion_Eventos.Eventos
{
    public class EventosUI
    {
        private readonly ILecturaAchivoRepositorio _lecturaAchivoRepositorio;
        private readonly IMensajeRepositorio _mensajeRepositorio;
        private readonly IEventosRepository _eventosRepository;
        private readonly string _cRuta;

        public EventosUI(ILecturaAchivoRepositorio lecturaAchivoRepositorio, IMensajeRepositorio mensajeRepositorio, IEventosRepository eventosRepository, string cRuta)
        {
            _lecturaAchivoRepositorio = lecturaAchivoRepositorio ?? throw new ArgumentNullException(nameof(lecturaAchivoRepositorio));
            _mensajeRepositorio = mensajeRepositorio ?? throw new ArgumentNullException(nameof(mensajeRepositorio)); 
            _eventosRepository = eventosRepository ?? throw new ArgumentNullException(nameof(eventosRepository)); 
            _cRuta = cRuta;
        }

        public void VisualizarEventos()
        {
            string[] lineaEventos = _lecturaAchivoRepositorio.LeerAchivo(_cRuta);

            var lstEventos = _eventosRepository.ListarEventos(lineaEventos);

            List<string> lstMensajeEvento = _mensajeRepositorio.CrearListaDeMensaje(lstEventos);

            foreach (var oEvento in lstMensajeEvento)
            {
                Console.WriteLine(oEvento);
            }

            Console.ReadLine();
        }
    }
}
