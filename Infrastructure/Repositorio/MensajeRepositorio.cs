using Dominio.Entidades;
using Dominio.Extension;
using Dominio.Interfaces.Repositorio;
using System;
using System.Collections.Generic;

namespace Infrastructure.Repositorio
{
    public class MensajeRepositorio : IMensajeRepositorio
    {
        public List<string> CrearListaDeMensaje(List<EventosEntidad> lstEventos)
        {
            List<string> lstMensajesEventos = new List<string>();

            foreach (var oEvento in lstEventos)
            {
                TimeSpan dtCompararTiempo = oEvento.dtTiempoEvento.Subtract(DateTime.Now);
                int tiempo = dtCompararTiempo.Days;
                string cTipoMensaje = tiempo >= 0 ? "ocurrirá dentro de" : "ocurrió hace";
                string cMensaje;

                cMensaje = $"{oEvento.cNombreEvento} {cTipoMensaje} {oEvento.dtTiempoEvento.FormartoTiempo()}";

                lstMensajesEventos.Add(cMensaje);
            }

            return lstMensajesEventos;
        }
    }
}
