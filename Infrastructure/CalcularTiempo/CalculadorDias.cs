using System;

namespace Dominio.Interfaces.CalcularTiempo
{
    public class CalculadorDias : ICalcularTiempos
    {
        public string CalcularTiempo(TimeSpan dtCompararTiempo)
        {
            int tiempo = dtCompararTiempo.Days;

            double meses = (double)tiempo / 30;

            int iDias = Math.Abs((int)meses) > 0 ? Math.Abs(TimeSpan.FromDays(tiempo % 30).Days) : Math.Abs(dtCompararTiempo.Days);

            string cDias = iDias > 1 ? $"{ Math.Abs(iDias)} días" :  $"{ iDias} día" ;
            return cDias;
        }
    }
}
