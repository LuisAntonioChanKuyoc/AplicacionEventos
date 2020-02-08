using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dominio.Interfaces.CalcularTiempo.Tests
{
    [TestClass()]
    public class CalculadorMesTest
    {
        [DataRow("32.12:14:45", "1 mes")]
        [DataRow("92.12:14:45", "3 meses")]
        [TestMethod()]
        public void CalculadorMes_LlamarMetodoDeMes_VerificarMensaje(string cTiempo, string cResultado)
        {
            CalculadorMes calculadorMes = new CalculadorMes();

            string result = calculadorMes.CalcularTiempo(TimeSpan.Parse(cTiempo));

            Assert.AreEqual(result, cResultado);
        }
    }
}