using System;

namespace Dominio.Interfaces.CalcularTiempo
{
    public class CalculadorMes : ICalcularTiempos
    {
        public string CalcularTiempo(TimeSpan dtCompararTiempo)
        {
            int tiempo = dtCompararTiempo.Days;

            double meses = (double)tiempo / 30;

            string cMes = Math.Abs((int)meses) > 1 ? $"{Math.Abs((int)meses)} meses" : $"{Math.Abs((int)meses)} mes" ;
           
            return cMes;
        }
    }
}
