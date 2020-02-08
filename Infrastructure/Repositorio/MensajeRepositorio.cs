using Dominio.Entidades;
using Dominio.Interfaces.CalcularTiempo;
using Dominio.Interfaces.Fabrica;
using Dominio.Interfaces.Repositorio;
using System;
using System.Collections.Generic;

namespace Infrastructure.Repositorio
{
    public class MensajeRepositorio : IMensajeRepositorio
    {
        public Func<DateTime> Obtenerfecha { get; set; }
        private readonly ICreadorInstancia _creadorInstancia;

        public MensajeRepositorio(ICreadorInstancia creadorInstancia)
        {
            _creadorInstancia = creadorInstancia;
            Obtenerfecha = () => DateTime.Now;
        }

        public List<string> CrearListaDeMensaje(List<EventosEntidad> lstEventos)
        {
            List<string> lstMensajesEventos = new List<string>();

            foreach (EventosEntidad oEvento in lstEventos)
            {
                string cMensaje = CrearMensajeEvento(oEvento);

                lstMensajesEventos.Add(cMensaje);
            }

            return lstMensajesEventos;
        }

        private string CrearMensajeEvento(EventosEntidad oEvento)
        {
            TimeSpan dtCompararTiempo = oEvento.dtTiempoEvento.Subtract(Obtenerfecha());
            int tiempo = dtCompararTiempo.Days;

            string cTipoMensaje = tiempo >= 0 && dtCompararTiempo.Hours > 0 ? "ocurrirá dentro de" : "ocurrió hace";

            ICalcularTiempos CalculadorTiempo = ObtenerTipoDeTiempoDeEvento(dtCompararTiempo);

            string cMensaje = $"{oEvento.cNombreEvento} {cTipoMensaje} {CalculadorTiempo.CalcularTiempo(dtCompararTiempo)}";

            return cMensaje;
        }

        private ICalcularTiempos ObtenerTipoDeTiempoDeEvento(TimeSpan dtCompararTiempo)
        {
            int TipoCalculadorTiempo = DeterminarTipoInstancia(dtCompararTiempo);

            ICalcularTiempos CalculadorTiempo = _creadorInstancia.CrearInstancia(TipoCalculadorTiempo);

            return CalculadorTiempo;
        }

        private int DeterminarTipoInstancia(TimeSpan dtCompararTiempo)
        {
            int iTipoInstancia;
            int iHoras = Math.Abs(dtCompararTiempo.Hours);

            if (Math.Abs(dtCompararTiempo.Days) > 30)
            {
                iTipoInstancia = 1;
            }
            else if (Math.Abs(dtCompararTiempo.Days) > 0)
            {
                iTipoInstancia = 2;
            }
            else if (iHoras > 0)
            {
                iTipoInstancia = 3;
            }
            else
            {
                iTipoInstancia = 4;
            }

            return iTipoInstancia;
        }
    }
}
