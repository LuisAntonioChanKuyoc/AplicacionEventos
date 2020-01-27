using System.IO;

namespace Aplicacion_Eventos.Eventos
{
    public class LecturaEventos
    {
        public string[] LecturaAchivo(string cPath)
        {
            string[] eventos = File.ReadAllLines(cPath);

            return eventos;
        }
    }
}
