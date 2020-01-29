using Dominio.Entidades;
using Dominio.EventosUI;
using Dominio.Interfaces.Repositorio;
using System;
using System.Collections.Generic;

namespace Aplicacion_Eventos
{
    public class EventosUI
    {
        private readonly ILecturaAchivoRepositorio _lecturaAchivoRepositorio;
        private readonly IMensajeRepositorio _mensajeRepositorio;
        private readonly IEventosRepository _eventosRepository;
        private readonly IVisualizadorEventos _visualizadorEventos;
        private readonly string _cRuta;

        public EventosUI(ILecturaAchivoRepositorio lecturaAchivoRepositorio, IMensajeRepositorio mensajeRepositorio, IEventosRepository eventosRepository, IVisualizadorEventos visualizadorEventos, string cRuta)
        {
            if (string.IsNullOrEmpty(cRuta)) throw new ArgumentNullException(nameof(cRuta));

            _lecturaAchivoRepositorio = lecturaAchivoRepositorio ?? throw new ArgumentNullException(nameof(lecturaAchivoRepositorio));
            _mensajeRepositorio = mensajeRepositorio ?? throw new ArgumentNullException(nameof(mensajeRepositorio)); 
            _eventosRepository = eventosRepository ?? throw new ArgumentNullException(nameof(eventosRepository));
            _visualizadorEventos = visualizadorEventos ?? throw new ArgumentNullException(nameof(visualizadorEventos));
            _cRuta = cRuta;
        }

        public void VisualizarEventos()
        {
            string[] lineaEventos = _lecturaAchivoRepositorio.LeerAchivo(_cRuta);

            List<EventosEntidad> lstEventos = _eventosRepository.ListarEventos(lineaEventos);

            List<string> lstMensajeEventos = _mensajeRepositorio.CrearListaDeMensaje(lstEventos);

            _visualizadorEventos.VisualizarEventos(lstMensajeEventos);

        }
    }
}
