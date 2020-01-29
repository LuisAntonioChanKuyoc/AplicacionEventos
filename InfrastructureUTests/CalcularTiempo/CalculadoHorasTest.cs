using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio.Interfaces.CalcularTiempo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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