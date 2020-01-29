using System;
using Dominio.Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DominioUTests.Entidades
{
    [TestClass]
    public class EventosEntidadTest
    {
        [TestMethod]
        public void EventosEntidad_AtributocNombreEvento_ComprobarValor()
        {
            EventosEntidad eventosEntidad = new EventosEntidad();
            eventosEntidad.cNombreEvento = "Dia bot";

            Assert.AreEqual("Dia bot", eventosEntidad.cNombreEvento);
        }

        [TestMethod]
        public void EventosEntidad_AtributodtTiempoEvento_ComprobarValor()
        {
            EventosEntidad eventosEntidad = new EventosEntidad();
            eventosEntidad.dtTiempoEvento = new DateTime(1, 1, 12);

            Assert.AreEqual(new DateTime(1, 1, 12), eventosEntidad.dtTiempoEvento);
        }
    }
}
