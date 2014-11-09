using System;
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

        [TestMethod]
        public void Can_Return_Capitalized_Word()
        {
            //Arrange
            var primer = "california";
            var expected = "California";
            //Act
            var actual = primer.Capitalize();
            //Assert
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void Can_Return_Titleized_String()
        {
            //'lorem ipsum dolor'); // => Lorem Ipsum Dolor
            //Arrange
            var primer = "lorem ipsum dolor";
            var expected = "Lorem Ipsum Dolor";
            //Act
            var actual = primer.Titleize();
            //Assert
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void Can_Return_Words()
        {
            //Arrange
            var primer = "lorem ipsum dolor";
            var expected = new string[] { "lorem", "ipsum", "dolor" };
            //Act
            var actual = primer.Words();
            //Assert
            Assert.AreEqual(expected[0],actual[0]);
            Assert.AreEqual(expected[1], actual[1]);
            Assert.AreEqual(expected[2], actual[2]);
        }

    }
}
