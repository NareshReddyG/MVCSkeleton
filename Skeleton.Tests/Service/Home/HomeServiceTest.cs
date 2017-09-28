using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Skeleton.Repository;
using Skeleton.Service;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Skeleton.Models.DTO;

namespace Skeleton.Tests.Service.Home
{
    [TestClass]
    public class HomeServiceTest
    {
        private IHomeService _homeService;
        private Mock<IHomeRepository> _homeRepository;

        [TestInitialize]
        public void Intantiaion()
        {

            _homeRepository = new Mock<IHomeRepository>();
            _homeService = new HomeService(_homeRepository.Object);
        }

        [TestCleanup]
        public void CleanUp()
        {
            _homeRepository = null;
            _homeService = null;
        }

        [TestMethod]
        public void GetData_WhenSuccess_CheckTheData()
        {
            var expectedResult = new HomeServiceTestData().GetAllTestData().Select(HomeViewModel.ToViewModel).ToList();

            _homeRepository.Setup(s => s.GetData()).Returns(new HomeServiceTestData().GetAllTestData());
            var actualResult = _homeService.GetData().ToList();

            //Not null
            Assert.IsNotNull(actualResult);

            //Check the expected data and actual data
            Assert.AreEqual(expectedResult[0].HomeId, actualResult[0].HomeId);
            Assert.AreEqual(actualResult[0].HomeText, actualResult[0].HomeText);           
            
        }

    }
}
