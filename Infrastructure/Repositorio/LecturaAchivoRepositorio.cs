using Dominio.Interfaces.Repositorio;
using System.IO;

namespace Infrastructure.Repositorio
{
    public class LecturaAchivoRepositorio : ILecturaAchivoRepositorio
    {
        public string[] LeerAchivo(string cPath)
        {
            string[] eventos = File.ReadAllLines(cPath);

            return eventos;
        }
    }
}
