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
            Assert.AreEqual("Entry Successful", result);
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
            Assert.AreEqual("Entry Unsuccessful", result);
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
            Assert.AreEqual("Entry Successful", result);
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
            Assert.AreEqual("Entry Unsuccessful", result);
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
            Assert.AreEqual("Entry Successful", result);
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
            Assert.AreEqual("Entry Unsuccessful", result);
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
            Assert.AreEqual("Entry Successful", result);
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
            Assert.AreEqual("Entry Unsuccessful", result);
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
            Assert.AreEqual("Entry Successful", result);
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
            Assert.AreEqual("Entry Unsuccessful", result);
        }
        [TestMethod]
        public void TestMethod11()
        {
            //Arrange
            UserRegister userRegister = new UserRegister();
            //Act
            var result = userRegister.MultipleEmails("abc@edu.co.in", "abc+100@gmail.com");
            //Assert
            Assert.AreEqual("Entry Successful", result);
        }
        [TestMethod]
        [DataRow("1Daneesh")]
        public void TestMethod12(string fname)
        {
            try
            {
                //Arrange
                UserRegister userRegister = new UserRegister();
                //Act
                userRegister.CheckFirstName(fname);
            }
            catch (UserRegistrationException e)
            {
                //Assert
                Assert.AreEqual("First Name is Invalid !!", e.Message);
            }
        }
        [TestMethod]
        [DataRow("2Sheikh")]
        public void TestMethod13(string lname)
        {
            try
            {
                //Arrange
                UserRegister userRegister = new UserRegister();
                //Act
                userRegister.CheckLastName(lname);
            }
            catch (UserRegistrationException e)
            {
                //Assert
                Assert.AreEqual("Last Name is Invalid !!", e.Message);
            }
        }
        [TestMethod]
        [DataRow("ads100@gmail.co.in.uk")]
        public void TestMethod14(string email)
        {
            try
            {
                //Arrange
                UserRegister userRegister = new UserRegister();
                //Act
                userRegister.CheckEmail(email);
            }
            catch (UserRegistrationException e)
            {
                //Assert
                Assert.AreEqual("Email is Invalid !!", e.Message);
            }
        }
        [TestMethod]
        [DataRow("91 95ab131bj1")]
        public void TestMethod15(string mobNumber)
        {
            try
            {
                //Arrange
                UserRegister userRegister = new UserRegister();
                //Act
                userRegister.CheckMobile(mobNumber);
            }
            catch (UserRegistrationException e)
            {
                //Assert
                Assert.AreEqual("Mobile number is Invalid !!", e.Message);
            }
        }
        [TestMethod]
        [DataRow("svfd122dd")]
        public void TestMethod16(string password)
        {
            try
            {
                //Arrange
                UserRegister userRegister = new UserRegister();
                //Act
                userRegister.CheckPassword(password);
            }
            catch (UserRegistrationException e)
            {
                //Assert
                Assert.AreEqual("Password is Invalid !!", e.Message);
            }
        }
    }
}
