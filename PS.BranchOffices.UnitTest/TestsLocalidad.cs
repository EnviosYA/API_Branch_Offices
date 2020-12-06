using Moq;
using NUnit.Framework;
using PS.Template.AccessData.Repositories;
using PS.Template.Application.Services;
using PS.Template.Domain.DTO;
using PS.Template.Domain.Interfaces.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.BranchOffices.UnitTest
{
    class TestsLocalidad
    {
        private Mock<ILocalidadQuery> _query;
        protected Mock<ILocalidadRepository> _repository;

        [SetUp]
        public void Setup()
        {
            _query = new Mock<ILocalidadQuery>();
            _repository = new Mock<ILocalidadRepository>();
        }

        [Test]
        public void GetLocalidadesValido()
        {
            //Arrange
            _query.Setup(_ => _.GetAllLocalidad()).Returns(new List<ResponseGetLocalidad>());
            LocalidadService service = new LocalidadService(_repository.Object, _query.Object);

            //Act
            var result = service.GetLocalidad();

            //Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void GetLocalidadesInvalido()
        {
            //Arrange
            LocalidadService service = new LocalidadService(_repository.Object, _query.Object);

            //Act
            var result = service.GetLocalidad();

            //Assert
            Assert.IsNull(result);
        }        
    }
}
