using AspNetCoreDemo.Exceptions;
using AspNetCoreDemo.Models;
using AspNetCoreDemo.Repositories;
using AspNetCoreDemo.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreDemo.Tests.Sevices.BeerServiceTests
{
    [TestClass]
    public class GetAll_Should
    {
        private Mock<IBeersRepository> _mockRepository;
        private BeersService _sut;

        [TestInitialize]
        public void Setup()
        {
            var mockExamples = new MockBeersRepository();
            this._mockRepository = mockExamples.GetMockRepository();
            this._sut = new BeersService(this._mockRepository.Object);
        }

        [TestMethod]
        public void ReturnCorrectBeers_When_ValidParameters()
        {
            //Arrange
            var expectedBeers = _mockRepository.Object.GetAll();

            //Act
            var actualBeers = this._sut.GetAll();

            //Assert
            Assert.AreEqual(expectedBeers, actualBeers);
        }

    }
}
