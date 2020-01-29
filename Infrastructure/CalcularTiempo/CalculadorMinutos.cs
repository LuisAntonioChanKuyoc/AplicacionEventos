using System;

namespace Dominio.Interfaces.CalcularTiempo
{
    public class CalculadorMinutos : ICalcularTiempos
    {
        public string CalcularTiempo(TimeSpan dtCompararTiempo)
        {
            int iMinutos = Math.Abs(dtCompararTiempo.Minutes);

            string cMinutos = iMinutos> 1 ? $"{iMinutos} minutos" :  $"{iMinutos} minuto" ;
            return cMinutos;
        }
    }
}