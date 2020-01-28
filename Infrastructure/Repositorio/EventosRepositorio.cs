using Dominio.Entidades;
using Dominio.Interfaces.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Repositorio
{
    public class EventosRepositorio : IEventosRepository
    {
        public List<EventosEntidad> ListarEventos(string[] lstEventos)
        {
            List<EventosEntidad> lstEventosEntidad = (from evento in lstEventos
                                                      select new EventosEntidad
                                                      {
                                                          cNombreEvento = evento.Split(',')[0],
                                                          dtTiempoEvento = Convert.ToDateTime(evento.Split(',')[1])
                                                      }).ToList();

            return lstEventosEntidad;
        }
    }
}
