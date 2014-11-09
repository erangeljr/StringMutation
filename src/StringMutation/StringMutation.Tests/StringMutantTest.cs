using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringMutation;
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
            string tester = "A Test String";
            //Act
            tester.StringExtension();
            //Assert
            Assert.AreEqual(tester,tester.StringExtension());
        }
    }
}
