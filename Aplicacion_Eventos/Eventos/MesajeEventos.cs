using Aplicacion_Eventos.DTO;
using System;
using System.Collections.Generic;

namespace Aplicacion_Eventos.Eventos
{
    public class MesajeEventos
    {
        public List<string> Mensaje(List<EventosDTO> lstEventos)
        {
            List<string> lstMensajesEventos= new List<string>();

            foreach (var oEvento in lstEventos)
            {
                TimeSpan dtCompararTiempo = oEvento.dtTiempoEvento.Subtract(DateTime.Now);
                int tiempo = dtCompararTiempo.Days;
                var tiempoAbs = Math.Abs(tiempo);
                string cTipoMensaje = tiempo >= 0 ?  "ocurrirá dentro de": "ocurrió hace";
                string cMensaje;

                cMensaje = $"{oEvento.cNombreEvento} {cTipoMensaje} {FormatoTiempo.FormarTiempo(oEvento.dtTiempoEvento)}";

                lstMensajesEventos.Add(cMensaje);
            }

            return lstMensajesEventos;
        }
    }
}
