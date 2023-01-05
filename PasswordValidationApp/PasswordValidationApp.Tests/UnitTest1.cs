using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordValidationApp;

namespace PasswordValidationApp.Tests
{
    [TestClass]
    public class ValidatorClassTest
    {
        ValidatorClass validator = new ValidatorClass();
        
        [TestMethod]
        public void TestLargerLenthNotNullUpperCases()
        {
            //Arrange
            string strPasswordRead = "abcdef";
            PasswordValidator pValid = new PasswordValidator();
            pValid.Password = strPasswordRead;

            //Actual
            string actual;
            //Act  
            actual = validator.LengthValidator();

            //Assert  
            Assert.AreEqual("Entered password is of less characters. Please enter minimum 8 characters as password.",
                        actual);


        }
    }
}
