using Dominio.Interfaces.CalcularTiempo;

namespace Dominio.Interfaces.Fabrica
{
    public interface ICreadorInstancia
    {
        ICalcularTiempos CrearInstancia(int iTipoInstancia);
    }
}
