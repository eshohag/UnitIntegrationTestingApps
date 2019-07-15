using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitIntegrationTestingApps.BLL;
using UnitIntegrationTestingApps.Controllers;

namespace ProjectName.UnitTest.Controllers
{
    [TestClass]
    public class StudentControllerTests
    {
        [TestMethod]
        public void GetStudentTest()
        {
            // Arrange
            //var controller = new StudentController();

            // Act
            var result = Repository.GetStudentById(1);

            // Assert
            //Assert.AreEqual(result.FirstName, "Hassan");
            //Assert.AreNotSame(result, new Student());
            Assert.AreEqual(result.Department, "CSE");
        }
    }
}