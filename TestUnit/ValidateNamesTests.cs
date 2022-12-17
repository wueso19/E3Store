using NUnit.Framework;
using ValidateNames;

namespace TestUnit
{
    [TestFixture]
    public class ValidateNamesTests
    {
        [TestCase("E. Poe", true)]        
        [TestCase("E. A. Poe", true)]
        [TestCase("Edgard Allan Poe", true)]
        [TestCase("Edgard A. Poe", true)]
        public void TestNameValid(string name, bool isValid)
        {
            //Arrange
            //Act
            //Assert
            Assert.AreEqual(isValid, Program.IsValidName(name));
        }

        [TestCase("Edgard", false)]
        [TestCase("e. Poe", false)]
        [TestCase("E. poe", false)]
        [TestCase("e. a. Poe", false)]
        [TestCase("E. A. P.", false)]
        [TestCase("E Poe", false)]
        [TestCase("E. A Poe", false)]        
        [TestCase("E. Allan Poe", false)]
        [TestCase("E. Allan P.", false)]
        [TestCase("Edg. A. Poe", false)]       
        [TestCase("Edg. Allan Poe", false)]       
        public void TestNameInvalid(string name, bool isValid)
        {
            //Arrange
            //Act
            //Assert
            Assert.AreEqual(isValid, Program.IsValidName(name));
        }
    }
}