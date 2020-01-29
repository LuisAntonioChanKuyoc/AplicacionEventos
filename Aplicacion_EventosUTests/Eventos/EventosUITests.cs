using Dominio.Entidades;
using Dominio.EventosUI;
using Dominio.Interfaces.Repositorio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;

namespace Aplicacion_Eventos.Eventos.Tests
{
    [TestClass()]
    public class EventosUITests
    {
        [TestMethod()]
        public void VisualizarEventos_ILecturaAchivoRepositorioNulo_Excepcion()
        {
            // Arrange
            Mock<IMensajeRepositorio> DOCmensajeRepositorio = new Mock<IMensajeRepositorio>();
            Mock<IEventosRepository> DOCeventosRepository = new Mock<IEventosRepository>();
            Mock<IVisualizadorEventos> DOCvisualizadorEventos = new Mock<IVisualizadorEventos>();

            // Assert
            Assert.ThrowsException<ArgumentNullException>(() => 
            new EventosUI(null, DOCmensajeRepositorio.Object, DOCeventosRepository.Object, DOCvisualizadorEventos.Object, "Ruta"));
        }

        [TestMethod()]
        public void VisualizarEventos_IMensajeRepositorioNulo_Excepcion()
        {
            // Arrange
            Mock<ILecturaAchivoRepositorio> DOClecturaAchivoRepositorio = new Mock<ILecturaAchivoRepositorio>();
            Mock<IEventosRepository> DOCeventosRepository = new Mock<IEventosRepository>();
            Mock<IVisualizadorEventos> DOCvisualizadorEventos = new Mock<IVisualizadorEventos>();

            // Assert
            Assert.ThrowsException<ArgumentNullException>(() =>
            new EventosUI(DOClecturaAchivoRepositorio.Object,null, DOCeventosRepository.Object, DOCvisualizadorEventos.Object, "Ruta"));
        }

        [TestMethod()]
        public void VisualizarEventos_IEventosRepositoryNulo_Excepcion()
        {
            // Arrange
            Mock<ILecturaAchivoRepositorio> DOClecturaAchivoRepositorio = new Mock<ILecturaAchivoRepositorio>();
            Mock<IMensajeRepositorio> DOCmensajeRepositorio = new Mock<IMensajeRepositorio>();
            Mock<IVisualizadorEventos> DOCvisualizadorEventos = new Mock<IVisualizadorEventos>();

            // Assert
            Assert.ThrowsException<ArgumentNullException>(() =>
            new EventosUI(DOClecturaAchivoRepositorio.Object, DOCmensajeRepositorio.Object, null, DOCvisualizadorEventos.Object, "Ruta"));
        }

        [TestMethod()]
        public void VisualizarEventos_IVisualizadorEventosNulo_Excepcion()
        {
            // Arrange
            Mock<ILecturaAchivoRepositorio> DOClecturaAchivoRepositorio = new Mock<ILecturaAchivoRepositorio>();
            Mock<IMensajeRepositorio> DOCmensajeRepositorio = new Mock<IMensajeRepositorio>();
            Mock<IEventosRepository> DOCeventosRepository = new Mock<IEventosRepository>();

            // Assert
            Assert.ThrowsException<ArgumentNullException>(() =>
            new EventosUI(DOClecturaAchivoRepositorio.Object, DOCmensajeRepositorio.Object, DOCeventosRepository.Object, null, "Ruta"));
        }

        [TestMethod()]
        public void VisualizarEventos_RutaVacio_Excepcion()
        {
            // Arrange
            Mock<ILecturaAchivoRepositorio> DOClecturaAchivoRepositorio = new Mock<ILecturaAchivoRepositorio>();
            Mock<IMensajeRepositorio> DOCmensajeRepositorio = new Mock<IMensajeRepositorio>();
            Mock<IEventosRepository> DOCeventosRepository = new Mock<IEventosRepository>();
            Mock<IVisualizadorEventos> DOCvisualizadorEventos = new Mock<IVisualizadorEventos>();

            // Assert
            Assert.ThrowsException<ArgumentNullException>(() =>
            new EventosUI(DOClecturaAchivoRepositorio.Object, DOCmensajeRepositorio.Object, DOCeventosRepository.Object, DOCvisualizadorEventos.Object, ""));
        }

        [TestMethod()]
        public void VisualizarEventos_LecturaAchivoRepositorio_VerificarMetodo()
        {
            Mock<ILecturaAchivoRepositorio> DOClecturaAchivoRepositorio = new Mock<ILecturaAchivoRepositorio>();
            Mock<IMensajeRepositorio> DOCmensajeRepositorio = new Mock<IMensajeRepositorio>();
            Mock<IEventosRepository> DOCeventosRepository = new Mock<IEventosRepository>();
            Mock<IVisualizadorEventos> DOCvisualizadorEventos = new Mock<IVisualizadorEventos>();

            EventosUI SUI = new EventosUI(DOClecturaAchivoRepositorio.Object, DOCmensajeRepositorio.Object, DOCeventosRepository.Object, DOCvisualizadorEventos.Object, "Ruta");
            SUI.VisualizarEventos();

            DOClecturaAchivoRepositorio.Verify(x => x.LeerAchivo(It.IsAny<string>()), Times.Once);
        }

        [TestMethod()]
        public void VisualizarEventos_MensajeRepositorio_VerificarMetodo()
        {
            Mock<ILecturaAchivoRepositorio> DOClecturaAchivoRepositorio = new Mock<ILecturaAchivoRepositorio>();
            Mock<IMensajeRepositorio> DOCmensajeRepositorio = new Mock<IMensajeRepositorio>();
            Mock<IEventosRepository> DOCeventosRepository = new Mock<IEventosRepository>();
            Mock<IVisualizadorEventos> DOCvisualizadorEventos = new Mock<IVisualizadorEventos>();

            EventosUI SUI = new EventosUI(DOClecturaAchivoRepositorio.Object, DOCmensajeRepositorio.Object, DOCeventosRepository.Object, DOCvisualizadorEventos.Object, "Ruta");
            SUI.VisualizarEventos();

            DOCmensajeRepositorio.Verify(x => x.CrearListaDeMensaje(It.IsAny<List<EventosEntidad>>()), Times.Once);
        }

        [TestMethod()]
        public void VisualizarEventos_EventosRepository_VerificarMetodo()
        {
            Mock<ILecturaAchivoRepositorio> DOClecturaAchivoRepositorio = new Mock<ILecturaAchivoRepositorio>();
            Mock<IMensajeRepositorio> DOCmensajeRepositorio = new Mock<IMensajeRepositorio>();
            Mock<IEventosRepository> DOCeventosRepository = new Mock<IEventosRepository>();
            Mock<IVisualizadorEventos> DOCvisualizadorEventos = new Mock<IVisualizadorEventos>();

            EventosUI SUI = new EventosUI(DOClecturaAchivoRepositorio.Object, DOCmensajeRepositorio.Object, DOCeventosRepository.Object, DOCvisualizadorEventos.Object, "Ruta");
            SUI.VisualizarEventos();

            DOCeventosRepository.Verify(x => x.ListarEventos(It.IsAny<string[]>()), Times.Once);
        }

        [TestMethod()]
        public void VisualizarEventos_visualizadorEventos_VerificarMetodo()
        {
            Mock<ILecturaAchivoRepositorio> DOClecturaAchivoRepositorio = new Mock<ILecturaAchivoRepositorio>();
            Mock<IMensajeRepositorio> DOCmensajeRepositorio = new Mock<IMensajeRepositorio>();
            Mock<IEventosRepository> DOCeventosRepository = new Mock<IEventosRepository>();
            Mock<IVisualizadorEventos> DOCvisualizadorEventos = new Mock<IVisualizadorEventos>();

            EventosUI SUI = new EventosUI(DOClecturaAchivoRepositorio.Object, DOCmensajeRepositorio.Object, DOCeventosRepository.Object, DOCvisualizadorEventos.Object, "Ruta");
            SUI.VisualizarEventos();

            DOCvisualizadorEventos.Verify(x => x.VisualizarEventos(It.IsAny<List<string>>()),Times.Once);
        }
    }
}