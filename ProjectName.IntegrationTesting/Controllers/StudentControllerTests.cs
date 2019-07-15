using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitIntegrationTestingApps.BLL;
using UnitIntegrationTestingApps.Controllers;
using UnitIntegrationTestingApps.Models;

namespace ProjectName.IntegrationTesting.Controllers
{
    [TestClass()]
    public class StudentControllerTests
    {
        [TestMethod()]
        public void GetStudentTest()
        {
            // Arrange
            //var controller = new StudentController();

            // Act
            var result = Repository.GetStudent();

            // Assert
            //Assert.AreEqual(result, new object());
            //Assert.AreNotSame(result, new Student());
            Assert.AreEqual(result.Department, "CSE");
        }

        [TestMethod]
        public void GetStudentListTest()
        {
            // Arrange
            //var controller = new StudentController();

            // Act
            var result = Repository.GetStudentList();

            //Assert
            Assert.AreEqual(result.Count, 2);
        }

        [TestMethod]
        public void CreateTest()
        {
            var aStudent = new Student() { FirstName = "Abu", LastName = "Sayed", Department = "CSE,JU" };
            // Arrange
            //var controller = new StudentController();

            // Act
            var result = Repository.Create(aStudent);
            //Assert
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void IndexTest()
        {
            // Arrange
            var controller = new StudentController();

            // Act
            var result = controller.Index() as ViewResult;

            //Assert.IsNotNull(result);
            // Assert.AreNotEqual(result.ViewName, "Index");
            Assert.AreEqual(result.ViewEngineCollection.Count, 2);
        }
    }
}