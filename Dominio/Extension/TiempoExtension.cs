using System;

namespace Dominio.Extension
{
    public static class TiempoExtension
    {
        public static string FormartoTiempo(this DateTime dtFecha)
        {
            TimeSpan dtCompararTiempo = dtFecha.Subtract(DateTime.Now);

            int tiempo = dtCompararTiempo.Days;

            double meses = (double)tiempo / 30;

            int iDias = Math.Abs((int)meses) > 0 ? TimeSpan.FromDays(tiempo % 30).Days : dtCompararTiempo.Days;
            int iHoras = dtCompararTiempo.Hours;
            int iMinutos = dtCompararTiempo.Minutes;

            string cMes = Math.Abs((int)meses) == 1 ? $"{Math.Abs((int)meses)} mes" : Math.Abs((int)meses) > 0 ? $"{Math.Abs((int)meses)} meses" : "";

            string cDias = Math.Abs(iDias) == 1 ? $"{ Math.Abs(iDias)} día" : Math.Abs(iDias) > 1 ? $"{ Math.Abs(iDias)} días" : "";
            string cHoras = Math.Abs(iHoras) == 1 ? $"{Math.Abs(iHoras)} hora" : Math.Abs(iHoras) > 1 ? $"{Math.Abs(iHoras)} horas" : "";
            string cMinutos = Math.Abs(iMinutos) == 1 ? $"{Math.Abs(iMinutos)} minuto" : Math.Abs(iMinutos) > 1 ? $"{Math.Abs(iMinutos)} minutos" : "";

            string cTiempo = $"{cMes} {cDias} {cHoras} {cMinutos}";

            return cTiempo.Trim();
        }
    }
}
