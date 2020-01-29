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
    public class CalculadorDiasTests
    {
        [DataRow("1.12:14:45", "1 día")]
        [DataRow("3.12:14:45", "3 días")]
        [DataRow("0.12:14:45", "0 día")]
        [TestMethod()]
        public void CalculadorDias_LlamarMetodoDeDias_VerificarMensaje(string cTiempo, string cResultado)
        {
            CalculadorDias calculadorDias = new CalculadorDias();

            string result = calculadorDias.CalcularTiempo(TimeSpan.Parse(cTiempo));

            Assert.AreEqual(result, cResultado);
        }
    }
}