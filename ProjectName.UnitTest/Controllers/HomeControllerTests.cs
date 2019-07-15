using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitIntegrationTestingApps.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using UnitIntegrationTestingApps.BLL;

namespace UnitIntegrationTestingApps.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        [TestMethod()]
        public void IndexTest()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Index() as ViewResult;

            // Assert
            Assert.AreSame(result.ViewName, "");
        }

        [TestMethod()]
        public void AboutTest()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Index() as ViewResult;

            // Assert
            Assert.AreSame(result.ViewName, "");
        }

        [TestMethod()]
        public void ContactTest()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Index() as ViewResult;

            // Assert
            Assert.AreSame(result.ViewName, "");
        }
    }
}