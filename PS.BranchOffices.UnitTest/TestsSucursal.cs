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
    class TestsSucursal
    {
        private Mock<ISucursalQuery> _query;
        protected Mock<ISucursalRepository> _repository;

        [SetUp]
        public void Setup()
        {
            _query = new Mock<ISucursalQuery>();
            _repository = new Mock<ISucursalRepository>();
        }

        [Test]
        public void GetByIdSucursalValido()
        {
            //Arrange
            int idSucursal = 1;
            int idEstado = 0;
            _query.Setup(_ => _.GetSucursal(idSucursal, idEstado)).Returns(new List<ResponseGetSucursal>());
            SucursalService service = new SucursalService(_repository.Object, _query.Object);

            //Act
            var result = service.GetSucursal(idSucursal, idEstado);

            //Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void GetByIdEstadoValido()
        {
            //Arrange
            int idSucursal = 0;
            int idEstado = 1;
            _query.Setup(_ => _.GetSucursal(idSucursal, idEstado)).Returns(new List<ResponseGetSucursal>());
            SucursalService service = new SucursalService(_repository.Object, _query.Object);

            //Act
            var result = service.GetSucursal(idSucursal, idEstado);

            //Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void GetSucursalInvalido()
        {
            //Arrange
            int idSucursal = 0;
            int idEstado = 0;
            SucursalService service = new SucursalService(_repository.Object, _query.Object);

            //Act
            var result = service.GetSucursal(idSucursal, idEstado);

            //Assert
            Assert.IsNull(result);
        }

        [Test]
        public void ModifySucursalValido()
        {
            //Arrange
            int idSucursal = 1;
            _query.Setup(_ => _.ExisteSucursal(idSucursal)).Returns(true);
            SucursalService service = new SucursalService(_repository.Object, _query.Object);

            //Act
            var result = service.ValidarModify(idSucursal);

            //Assert
            Assert.IsNull(result);
        }

        [Test]
        public void ModifySucursalInvalido()
        {
            //Arrange
            int idSucursal = 0;
            SucursalService service = new SucursalService(_repository.Object, _query.Object);

            //Act
            var result = service.ValidarModify(idSucursal);

            //Assert
            Assert.IsNotNull(result);
        }
    }
}
