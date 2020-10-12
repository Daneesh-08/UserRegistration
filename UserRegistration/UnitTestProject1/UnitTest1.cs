using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("Happy")]
        public void TestMethod1(string message)
        {
            //Arrange
            UserRegister userRegister = new UserRegister(message);
            //Act
            var result = userRegister.FirstName();
            //Assert
            Assert.AreEqual("Entry Successfull", result);
        }
        [TestMethod]
        [DataRow("Sad")]
        public void TestMethod2(string message)
        {
            //Arrange
            UserRegister userRegister = new UserRegister(message);
            //Act
            var result = userRegister.FirstName();
            //Assert
            Assert.AreEqual("Entry UnSuccessfull", result);
        }
        [TestMethod]
        [DataRow("Happy")]
        public void TestMethod3(string message)
        {
            //Arrange
            UserRegister userRegister = new UserRegister(message);
            //Act
            var result = userRegister.LastName();
            //Assert
            Assert.AreEqual("Entry Successfull", result);
        }
        [TestMethod]
        [DataRow("Sad")]
        public void TestMethod4(string message)
        {
            //Arrange
            UserRegister userRegister = new UserRegister(message);
            //Act
            var result = userRegister.LastName();
            //Assert
            Assert.AreEqual("Entry UnSuccessfull", result);
        }
        [TestMethod]
        [DataRow("Happy")]
        public void TestMethod5(string message)
        {
            //Arrange
            UserRegister userRegister = new UserRegister(message);
            //Act
            var result = userRegister.Email();
            //Assert
            Assert.AreEqual("Entry Successfull", result);
        }
        [TestMethod]
        [DataRow("Sad")]
        public void TestMethod6(string message)
        {
            //Arrange
            UserRegister userRegister = new UserRegister(message);
            //Act
            var result = userRegister.Email();
            //Assert
            Assert.AreEqual("Entry UnSuccessfull", result);
        }
        [TestMethod]
        [DataRow("Happy")]
        public void TestMethod7(string message)
        {
            //Arrange
            UserRegister userRegister = new UserRegister(message);
            //Act
            var result = userRegister.MobileNumber();
            //Assert
            Assert.AreEqual("Entry Successfull", result);
        }
        [TestMethod]
        [DataRow("Sad")]
        public void TestMethod8(string message)
        {
            //Arrange
            UserRegister userRegister = new UserRegister(message);
            //Act
            var result = userRegister.MobileNumber();
            //Assert
            Assert.AreEqual("Entry UnSuccessfull", result);
        }
        [TestMethod]
        [DataRow("Happy")]
        public void TestMethod9(string message)
        {
            //Arrange
            UserRegister userRegister = new UserRegister(message);
            //Act
            var result = userRegister.Password();
            //Assert
            Assert.AreEqual("Entry Successfull", result);
        }
        [TestMethod]
        [DataRow("Sad")]
        public void TestMethod10(string message)
        {
            //Arrange
            UserRegister userRegister = new UserRegister(message);
            //Act
            var result = userRegister.Password();
            //Assert
            Assert.AreEqual("Entry UnSuccessfull", result);
        }
    }
}
