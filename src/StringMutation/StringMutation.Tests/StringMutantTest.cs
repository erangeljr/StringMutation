using System;
using System.Security.Cryptography.X509Certificates;
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

        [TestMethod]
        public void Can_Return_Characters()
        {
            //Arrange
            var primer = "lorem";
            var expected = new char[] {'l', 'o', 'r', 'e', 'm'};
            //Act
            var actual = primer.Characters();
            //Assert
            Assert.AreEqual(expected[0],actual[0]);
            Assert.AreEqual(expected[1],actual[1]);
            Assert.AreEqual(expected[2],actual[2]);
            Assert.AreEqual(expected[3],actual[3]);
            Assert.AreEqual(expected[4],actual[4]);
        }

        [TestMethod]
        public void Can_Return_Chop()
        {
            //Arrange
            var primer = "lorem ipsum dolor";
            var expected = new string[] {"lore", "m ip", "sum ", "dolo", "r"};
            //Act
            var actual = primer.Chop(4);
            //Assert
            Assert.AreEqual(expected[0], actual);
            //Assert.AreEqual(expected[1], actual[1]);
            //Assert.AreEqual(expected[2], actual[2]);
            //Assert.AreEqual(expected[3], actual[3]);
            //Assert.AreEqual(expected[4], actual[4]);
        }

        [TestMethod]
        public void Can_Return_Number_Of_Lines()
        {
            //Arrange
            var primer = "This is one line.\nThis is two lines.\nThis is line three.";
            var expected = 3;
            //Act
            var actual = primer.CountLines();
            //Assert
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void Can_Return_String_in_Reverse()
        {
            //Arrange
            var primer = "lorem ipsum dolor";
            var expected = "rolod muspi merol";
            //Act
            var actual = primer.Reverse();
            //Assert
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void Can_Return_Number_Of_Characters()
        {
            //Arrange
            var primer = "lorem ipsum dolor";
            var expected = 17;
            //Act
            var actual = primer.CountCharacters();

            //Assert
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void Can_Return_LeftTrim()
        {
            //Arrange
            var primer = " lorem ";
            var expected = "lorem ";
            //Act
            var actual = primer.LeftTrim();
            //Assert
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void Can_Return_RightTrim()
        {
            //Arrange
            var primer = " lorem ";
            var expected = " lorem";
            //Act
            var actual = primer.RightTrim();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
