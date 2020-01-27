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

            double fTiempo = (double)tiempo / 30;

            cFormatoTiempo = $"{Math.Truncate(fTiempo)}";

            //DateTime dt = Convert.ToDateTime(Math.Abs(fTiempo).ToString());
            var le = Math.Abs(fTiempo).ToString();

            string b = le;
            double d = double.Parse(b);

            DateTime dt = DateTime.FromOADate(d);

            //DateTime.TryParse(le, out DateTime dt);

            //string cMes = Math.Abs((int)fTiempo) == 1 ? $"{Math.Abs((int)fTiempo)} mes" : Math.Abs((int)fTiempo) > 0 ? $"{Math.Abs((int)fTiempo)} meses" : "";
            string cDias = "";
            string cMinutos = "";
            string cHoras = "";
            string cMes = "";
            if (Math.Abs(fTiempo) > 0)
            {
                cDias = Math.Abs(dt.Day) == 1 ? $"{ Math.Abs(dt.Day)} día" : Math.Abs(dt.Day) > 1 ? $"{ Math.Abs(dt.Day)} días" : "";
                cMinutos = Math.Abs(dt.Minute) == 1 ? $"{Math.Abs(dt.Minute)} minuto" : Math.Abs(dt.Minute) > 1 ? $"{Math.Abs(dt.Minute)} minutos" : "";
                cHoras = Math.Abs(dt.Hour) == 1 ? $"{Math.Abs(dt.Hour)} hora" : Math.Abs(dt.Hour) > 1 ? $"{Math.Abs(dt.Hour)} horas" : "";

            }
            else
            {

            }







            ////////////////////////////////////////

            //double meses = dtCompararTiempo.TotalDays;
            double meses = (double)tiempo / 30;


            TimeSpan day = TimeSpan.FromDays(meses);
            int iDias = day.Days;
            int iHoras = day.Hours;
            int iMinutos = day.Minutes;
            ///////////////////////////////////////

            cMes = Math.Abs((int)meses) == 1 ? $"{Math.Abs((int)meses)} mes" : Math.Abs((int)meses) > 0 ? $"{Math.Abs((int)meses)} meses" : "";

            cDias = Math.Abs(iDias) == 1 ? $"{ Math.Abs(iDias)} día" : Math.Abs(iDias) > 1 ? $"{ Math.Abs(iDias)} días" : "";
            cHoras = Math.Abs(iHoras) == 1 ? $"{Math.Abs(iHoras)} hora" : Math.Abs(iHoras) > 1 ? $"{Math.Abs(iHoras)} horas" : "";
            cMinutos = Math.Abs(iMinutos) == 1 ? $"{Math.Abs(iMinutos)} minuto" : Math.Abs(iMinutos) > 1 ? $"{Math.Abs(iMinutos)} minutos" : "";


            string cTiempo;
            //if (dtFecha.Hour > 0)
            //{
            //    cTiempo = $"{cMes} {cDias} {cHoras} {cMinutos}";
            //}
            //else
            //{
            //    cTiempo = $"{cMes} {cDias} ";

            //}
            cTiempo = $"{cMes} {cDias} {cHoras} {cMinutos}";

            return cTiempo.Trim();
        }
    }
}
