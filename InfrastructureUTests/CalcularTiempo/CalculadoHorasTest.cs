using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dominio.Interfaces.CalcularTiempo.Tests
{
    [TestClass()]
    public class CalculadorHorasTests
    {
        [DataRow("1:14:45", "1 hora")]
        [DataRow("3:14:45", "3 horas")]
        [TestMethod()]
        public void CalculadorHoras_LlamarMetodoDeHoras_VerificarMensaje(string cTiempo, string cResultado)
        {
            CalculadorHoras calculadorHoras = new CalculadorHoras();

            string result = calculadorHoras.CalcularTiempo(TimeSpan.Parse(cTiempo));

            Assert.AreEqual(result, cResultado);
        }
    }
}