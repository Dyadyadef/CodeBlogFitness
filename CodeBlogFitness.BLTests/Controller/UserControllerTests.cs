using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeBlogFitness.BL.Controller;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeBlogFitness.BL.Controller.Tests
{
    [TestClass()]
    public class UserControllerTests
    {
        [TestMethod()]
        public void SetNewUserDataTest()
        {
            // Arrange
            var userName = Guid.NewGuid().ToString();
            var gender = "man";
            var birthdate = DateTime.Now.AddYears(-18);
            var weight = 90;
            var height = 190;
            var controller = new UserController(userName);

            // Act
            controller.SetNewUserData(gender, birthdate, weight, height);
            var controller2 = new UserController(userName);

            // Assert
            Assert.AreEqual(userName, controller2.CurrentUser.Name);
            Assert.AreEqual(gender, controller2.CurrentUser.Gender.Name);
            Assert.AreEqual(birthdate, controller2.CurrentUser.BirthDate);
            Assert.AreEqual(weight, controller2.CurrentUser.Weight);
            Assert.AreEqual(height, controller2.CurrentUser.Height);
        }

        [TestMethod()]
        public void SaveTest()
        {
            // Arrange  - даные на вход
            var userName = Guid.NewGuid().ToString();

            // Act - вызов
            var controller = new UserController(userName);

            // Asserts - ожидание проверка
            Assert.AreEqual(userName, controller.CurrentUser.Name);
        }
    }
}

namespace CodeBlogFitness.BLTests.Controller
{
    class UserControllerTests
    {
    }
}
