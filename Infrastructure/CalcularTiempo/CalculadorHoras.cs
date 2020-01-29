using System;

namespace Dominio.Interfaces.CalcularTiempo
{
    public class CalculadorHoras : ICalcularTiempos
    {
        public string CalcularTiempo(TimeSpan dtCompararTiempo)
        {
            int iHoras = Math.Abs(dtCompararTiempo.Hours);

            string cHoras = iHoras > 1 ? $"{iHoras} horas" : $"{iHoras} hora";
            return cHoras;
        }
    }
}
