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
    public class CalculadorMesTests
    {
        [DataRow("0:1:45", "1 minuto")]
        [DataRow("0:3:45", "3 minutos")]
        [TestMethod()]
        public void CalculadorMes_LlamarMetodoDeUnMes_VerificarMensaje(string cTiempo, string cResultado)
        {
            CalculadorMinutos calculadorMinuto = new CalculadorMinutos();

            string result = calculadorMinuto.CalcularTiempo(TimeSpan.Parse(cTiempo));

            Assert.AreEqual(result, cResultado);
        }
    }
}