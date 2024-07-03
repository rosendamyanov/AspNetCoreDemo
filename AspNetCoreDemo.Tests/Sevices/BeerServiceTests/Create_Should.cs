using AspNetCoreDemo.Exceptions;
using AspNetCoreDemo.Models;
using AspNetCoreDemo.Repositories;
using AspNetCoreDemo.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCoreDemo.Tests.Sevices.BeerServiceTests
{
    [TestClass]
    public class Create_Should
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
        public void CreateBeer_When_ValidParameters()
        {
            var expected = _mockRepository.Object.Create(TestHelper.GetCreateTestBeer());

            var actual = _sut.GetById(expected.Id);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ThrowException_When_BeerAlreadyExists()
        {
            Assert.ThrowsException<DuplicateEntityException>(() => _sut.Create(TestHelper.GetTestBeer(), TestHelper.GetTestUser()));
        }
    }
}
