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
    public class FilterBy_Should
    {
        private Mock<IBeersRepository> _mockRepository;
        private BeersService _sut;
        private BeerQueryParameters _queryParams;

        [TestInitialize]
        public void Setup()
        {
            var mockExamples = new MockBeersRepository();
            this._mockRepository = mockExamples.GetMockRepository();
            this._sut = new BeersService(this._mockRepository.Object);
            this._queryParams = new BeerQueryParameters() { Name = "Beer", Style = "IPA", MaxAbv = 10.0, MinAbv = 2.0 };
        }
        [TestMethod]
        public void ReturnsCorrectResults_When_ValidParameters()
        {
            var expected = _mockRepository.Object.FilterBy(_queryParams);

            var actualBeer = _sut.FilterBy(_queryParams);

            CollectionAssert.AreEqual(expected, actualBeer);
        }

        [TestMethod]

        public void ReturnsEmptyList_When_NoBeerMatched()
        {
            var invalidQuery = new BeerQueryParameters() { Name = "NotExistingBeer"}; 

            var actualBeer = this._sut.FilterBy(invalidQuery);

            Assert.AreEqual(actualBeer.Count, 0);
        }
    }
}
