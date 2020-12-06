using FluentAssertions;
using Moq;
using NUnit.Framework;
using PS.Template.AccessData.Repositories;
using PS.Template.Application.Services;
using PS.Template.Domain.Commands;
using PS.Template.Domain.DTO;
using PS.Template.Domain.Entities;
using PS.Template.Domain.Interfaces.Queries;
using System;
using TP2.REST.Domain.DTO;

namespace PS.BranchOffices.UnitTest
{
    public class TestsDireccion
    {
        private Mock<IDireccionQuery> _query;
        protected Mock<IDireccionRepository> _repository;

        [SetUp]
        public void Setup()
        {
            _query = new Mock<IDireccionQuery>();
            _repository = new Mock<IDireccionRepository>();
        }

        [Test]
        public void GetByIdInvalido()
        {
            //Arrange
            int id = 0;
            DireccionService service = new DireccionService(_repository.Object, _query.Object);

            //Act
            var result = service.GetByID(id);

            //Assert
            Assert.IsNull(result);
            //result.Should().BeNull();
        }

        [Test]
        public void GetByIdValido()
        {
            //Arrange
            int id = new Random().Next(1,100);
            _query.Setup(_ => _.GetByID(id)).Returns(new ResponseGetDireccion() { Calle = "Alguna calle" });
            DireccionService service = new DireccionService(_repository.Object, _query.Object);

            //Act
            var result = service.GetByID(id);

            //Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void DireccionValida()
        {
            //Arrange
            DireccionDTO direccion = new DireccionDTO();
            direccion.Altura = 123;
            direccion.Calle = "Alguna calle";
            direccion.Latitud = 3.12;
            direccion.Longitud = 3.14;
            direccion.IdLocalidad = 1;


            _query.Setup(_ => _.ExisteLocalidad(It.IsAny<int>())).Returns(true);
            DireccionService service = new DireccionService(_repository.Object, _query.Object);

            //Act
            var result = service.ValidarDireccion(direccion);

            //Assert
            Assert.IsNull(result);
        }

        [Test]
        public void DireccionCalleInvalida()
        {
            //Arrange
            DireccionDTO direccion = new DireccionDTO();
            direccion.Altura = 123;
            direccion.Calle = "Alguna calle invalida <|!";
            direccion.Latitud = 3.12;
            direccion.Longitud = 3.14;
            direccion.IdLocalidad = 1;


            _query.Setup(_ => _.ExisteLocalidad(It.IsAny<int>())).Returns(true);
            DireccionService service = new DireccionService(_repository.Object, _query.Object);

            //Act
            var result = service.ValidarDireccion(direccion);

            //Assert
            Assert.IsNotNull(result);
        }
        [Test]
        public void DireccionAlturaInvalida()
        {
            //Arrange
            DireccionDTO direccion = new DireccionDTO();
            direccion.Altura = -123;
            direccion.Calle = "Alguna calle válida";
            direccion.Latitud = 3.12;
            direccion.Longitud = 3.14;
            direccion.IdLocalidad = 1;


            _query.Setup(_ => _.ExisteLocalidad(It.IsAny<int>())).Returns(true);
            DireccionService service = new DireccionService(_repository.Object, _query.Object);

            //Act
            var result = service.ValidarDireccion(direccion);

            //Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void DireccionIdLocalidadInvalido()
        {
            //Arrange
            DireccionDTO direccion = new DireccionDTO();
            direccion.Altura = 123;
            direccion.Calle = "Alguna calle válida";
            direccion.Latitud = 3.12;
            direccion.Longitud = 3.14;
            direccion.IdLocalidad = 0;


            _query.Setup(_ => _.ExisteLocalidad(It.IsAny<int>())).Returns(false);
            DireccionService service = new DireccionService(_repository.Object, _query.Object);

            //Act
            var result = service.ValidarDireccion(direccion);

            //Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void DeleteDireccionValido()
        {
            //Arrange
            int idDireccion = new Random().Next(1, 100);

            _repository.Setup(_ => _.FindById(It.IsAny<int>())).Returns(new Direccion());
            DireccionService service = new DireccionService(_repository.Object, _query.Object);

            //Act
            var result = service.DeleteDireccion(idDireccion);

            //Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void DeleteDireccionInvalido()
        {
            //Arrange
            int idDireccion = 0;

            DireccionService service = new DireccionService(_repository.Object, _query.Object);

            //Act
            var result = service.DeleteDireccion(idDireccion);

            //Assert
            Assert.IsNull(result);
        }
    }
}