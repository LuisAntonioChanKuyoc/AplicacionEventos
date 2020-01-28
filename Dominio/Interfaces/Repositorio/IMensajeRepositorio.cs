using Dominio.Entidades;
using System.Collections.Generic;

namespace Dominio.Interfaces.Repositorio
{
    public interface IMensajeRepositorio
    {
        List<string> CrearListaDeMensaje(List<EventosEntidad> lstEventos);
    }
}
