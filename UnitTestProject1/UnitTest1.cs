using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using _21._102_Zotochkina_02;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNewStr_WithLeadingAndTrailingSpaces()
        {
            // Arrange
            string input = "    Hello, World!    ";

            // Act
            string result = Program.NewStr(input);

            // Assert
            Assert.AreEqual("Hello, World!", result); // Предполагаем, что начальные и конечные пробелы будут удалены
        }

        [TestMethod]
        public void TestNewStr_WithoutLeadingAndTrailingSpaces()
        {
            // Arrange
            string input = "Hello, World!";

            // Act
            string result = Program.NewStr(input);

            // Assert
            Assert.AreEqual("Hello, World!", result); // Предполагаем, что результат останется тем же, так как пробелов в начале и в конце нет
        }

        [TestMethod]
        public void TestNewStr_WithOnlySpaces()
        {
            // Arrange
            string input = "     ";

            // Act
            string result = Program.NewStr(input);

            // Assert
            Assert.AreEqual("", result); // Предполагаем, что все пробелы будут удалены, и результат будет пустой строкой
        }
    }
}
