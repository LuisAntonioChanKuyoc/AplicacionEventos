using System;
using System.Collections.Generic;
using Dominio.Entidades;
using Dominio.Interfaces.CalcularTiempo;
using Dominio.Interfaces.Fabrica;
using Infrastructure.Fabrica;
using Infrastructure.Repositorio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace InfrastructureUTests.Repositorio
{
    [TestClass]
    public class MensajeRepositorioTest
    {
        [TestMethod]
        public void CrearListaDeMensaje_LLenarListaDeMes_VerificarLista()
        {
            ICalcularTiempos _creadorInstancia = new CalculadorMes();

            Mock<ICreadorInstancia> creadorInstancia = new Mock<ICreadorInstancia>();
            creadorInstancia.Setup(x => x.CrearInstancia(It.IsAny<int>())).Returns( _creadorInstancia);
            
            MensajeRepositorio mensajeRepositorio = new MensajeRepositorio(creadorInstancia.Object)
            {
                Obtenerfecha = () => new DateTime(1, 2, 12,12,12,12)
            };

            List<EventosEntidad> lstEventos = new List<EventosEntidad>
            {
                new EventosEntidad{cNombreEvento="Dia bot",dtTiempoEvento=new DateTime(1, 1, 12,12,12,12)}
            };

            var lstMensajesEventos = mensajeRepositorio.CrearListaDeMensaje(lstEventos);

            Assert.AreEqual("Dia bot ocurrió hace 1 mes", lstMensajesEventos[0]);
        }

        [TestMethod]
        public void CrearListaDeMensaje_LLenarListaDeDias_VerificarLista()
        {
            ICalcularTiempos _creadorInstancia = new CalculadorDias();

            Mock<ICreadorInstancia> creadorInstancia = new Mock<ICreadorInstancia>();
            creadorInstancia.Setup(x => x.CrearInstancia(It.IsAny<int>())).Returns(_creadorInstancia);

            MensajeRepositorio mensajeRepositorio = new MensajeRepositorio(creadorInstancia.Object)
            {
                Obtenerfecha = () => new DateTime(1, 2, 12, 12, 12, 12)
            };

            List<EventosEntidad> lstEventos = new List<EventosEntidad>
            {
                new EventosEntidad{cNombreEvento="Dia bot",dtTiempoEvento=new DateTime(1, 1, 12,12,12,12)}
            };

            var lstMensajesEventos = mensajeRepositorio.CrearListaDeMensaje(lstEventos);

            Assert.AreEqual("Dia bot ocurrió hace 1 día", lstMensajesEventos[0]);
        }

        [TestMethod]
        public void CrearListaDeMensaje_LLenarListaDeHora_VerificarLista()
        {
            ICalcularTiempos _creadorInstancia = new CalculadorHoras();

            Mock<ICreadorInstancia> creadorInstancia = new Mock<ICreadorInstancia>();
            creadorInstancia.Setup(x => x.CrearInstancia(It.IsAny<int>())).Returns(_creadorInstancia);

            MensajeRepositorio mensajeRepositorio = new MensajeRepositorio(creadorInstancia.Object)
            {
                Obtenerfecha = () => new DateTime(1, 2, 12, 12, 12, 12)
            };

            List<EventosEntidad> lstEventos = new List<EventosEntidad>
            {
                new EventosEntidad{cNombreEvento="Dia bot",dtTiempoEvento=new DateTime(1, 2, 12,11,12,12)}
            };

            var lstMensajesEventos = mensajeRepositorio.CrearListaDeMensaje(lstEventos);

            Assert.AreEqual("Dia bot ocurrió hace 1 hora", lstMensajesEventos[0]);
        }

        [TestMethod]
        public void CrearListaDeMensaje_LLenarListaDeMinuto_VerificarLista()
        {
            ICalcularTiempos _creadorInstancia = new CalculadorMinutos();

            Mock<ICreadorInstancia> creadorInstancia = new Mock<ICreadorInstancia>();
            creadorInstancia.Setup(x => x.CrearInstancia(It.IsAny<int>())).Returns(_creadorInstancia);

            MensajeRepositorio mensajeRepositorio = new MensajeRepositorio(creadorInstancia.Object)
            {
                Obtenerfecha = () => new DateTime(1, 2, 12, 12, 12, 12)
            };

            List<EventosEntidad> lstEventos = new List<EventosEntidad>
            {
                new EventosEntidad{cNombreEvento="Dia bot",dtTiempoEvento=new DateTime(1, 2, 12,12,13,12)}
            };

            var lstMensajesEventos = mensajeRepositorio.CrearListaDeMensaje(lstEventos);

            Assert.AreEqual("Dia bot ocurrió hace 1 minuto", lstMensajesEventos[0]);
        }
    }
}
