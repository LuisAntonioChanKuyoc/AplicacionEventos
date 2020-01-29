using Dominio.Entidades;
using System;
using System.Collections.Generic;

namespace Dominio.Interfaces.Repositorio
{
    public interface IMensajeRepositorio
    {
        Func<DateTime> Obtenerfecha { get; set; }

        List<string> CrearListaDeMensaje(List<EventosEntidad> lstEventos);
    }
}
