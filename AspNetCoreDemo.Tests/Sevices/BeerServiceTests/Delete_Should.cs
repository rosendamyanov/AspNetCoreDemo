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
    public class Delete_Should
    {
        private Mock<IBeersRepository> _mockRepository;
        private BeersService _sut;


        [TestInitialize]
        public void Setup()
        {
            var mockExamples = new MockBeersRepository();
            this._mockRepository = mockExamples.GetMockRepository();

        }

        [TestMethod]
        public void DeleteBeer_When_ValidParameters()
        {


        }
    }
}
