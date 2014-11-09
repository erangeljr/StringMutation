using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringMutation.Extension;

namespace StringMutation.Tests
{
    [TestClass]
    public class StringMutantTest
    {
        [TestMethod]
        public void Can_Return_String()
        {

            //Arrange
            string expected = "A Test String";
            //Act
            var actual = expected.StringExtension();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Can_Return_Lines()
        {
            //Arrange
            string expected = "This is one line.\nThis is two lines.";
            string[] result = expected.Lines();

            //Act
            var actual = result[0] + "\n" + result[1];
            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
