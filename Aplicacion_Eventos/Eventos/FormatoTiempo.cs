using System;

namespace Aplicacion_Eventos.Eventos
{
    public static class FormatoTiempo
    {
        public static string FormarTiempo(DateTime dtFecha)
        {
            var tiem = dtFecha.Hour;

            TimeSpan dtCompararTiempo = dtFecha.Subtract(DateTime.Now);

            int tiempo = dtCompararTiempo.Days;
            string cFormatoTiempo = "";

            double fTiempo =(double) tiempo / 30;

            cFormatoTiempo = $"{Math.Truncate(fTiempo)}";

            string cMes = Math.Abs((int)fTiempo) == 1 ? $"{Math.Abs((int)fTiempo)} mes" : Math.Abs((int)fTiempo) > 0 ? $"{Math.Abs((int)fTiempo)} meses" : "";

            string cDias = Math.Abs(dtCompararTiempo.Days) == 1 ? $"{ Math.Abs(dtCompararTiempo.Days)} día" : Math.Abs(dtCompararTiempo.Days) > 1 ? $"{ Math.Abs(dtCompararTiempo.Days)} días" : "";
            string cMinutos = Math.Abs(dtCompararTiempo.Minutes) == 1 ? $"{Math.Abs(dtCompararTiempo.Minutes)} minuto" : Math.Abs(dtCompararTiempo.Minutes) > 1 ? $"{Math.Abs(dtCompararTiempo.Minutes)} minutos" : "";
            string cHoras = Math.Abs(dtCompararTiempo.Hours) == 1 ? $"{Math.Abs(dtCompararTiempo.Hours)} hora" : Math.Abs(dtCompararTiempo.Hours) > 1 ? $"{Math.Abs(dtCompararTiempo.Hours)} horas" : "";

            string cTiempo;
            if (dtFecha.Hour > 0)
            {
                cTiempo = $"{cMes} {cDias} {cHoras} {cMinutos}";
            }
            else
            {
                cTiempo = $"{cMes} {cDias} ";

            }

            return cTiempo.Trim();
        }
    }
}
