using Dominio.Entidades;
using System.Collections.Generic;

namespace Dominio.Interfaces.Repositorio
{
    public interface IEventosRepository
    {
        List<EventosEntidad> ListarEventos(string[] lstEventos);
    }
}
