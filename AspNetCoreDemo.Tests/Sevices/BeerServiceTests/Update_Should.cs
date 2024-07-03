using AspNetCoreDemo.Exceptions;
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
    public class Update_Should
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
        public void UpdateBeer_When_ValidParameters()
        {
            var expected = _mockRepository.Object.Update(1, TestHelper.GetTestBeer());

            var actual = _sut.GetById(1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ThrowException_When_UserIsNotAuthorized()
        {
            Assert.ThrowsException<UnauthorizedOperationException>(() => _sut.Update(1, TestHelper.GetTestBeer(), TestHelper.GetTestUser()));
        }

    }
}
