using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Skeleton;
using Skeleton.Controllers;
using Skeleton.Service;
using Skeleton.Repository;
using Moq;

namespace Skeleton.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        private Mock<IHomeService> _homeService;
        private Mock<IHomeRepository> _homeRepository;

        [TestInitialize]
        public void Intantiaion()
        {
            _homeService = new Mock<IHomeService>();
            _homeRepository = new Mock<IHomeRepository>();
        }

        [TestCleanup]
        public void CleanUp()
        {
            _homeRepository = null;
            _homeService = null;
        }

        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController(_homeService.Object);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            //// Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController(_homeService.Object);

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController(_homeService.Object);

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
