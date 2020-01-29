using Dominio.Interfaces.CalcularTiempo;
using Dominio.Interfaces.Fabrica;

namespace Infrastructure.Fabrica
{
    public class CreadorInstancia: ICreadorInstancia
    {
        public ICalcularTiempos CrearInstancia(int iTipoInstancia)
        {
            ICalcularTiempos calcularTiempos = null;
            switch (iTipoInstancia)
            {
                case 1:
                    calcularTiempos = new CalculadorMes();
                    break;
                case 2:
                    calcularTiempos = new CalculadorDias();
                    break;
                case 3:
                    calcularTiempos = new CalculadorHoras();
                    break;
                case 4:
                    calcularTiempos = new CalculadorMinutos();
                    break;
            }

            return calcularTiempos;
        }
    }
}
