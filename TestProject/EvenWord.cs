using MicrosoftTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestProject
{
    public class EvenWord
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            var word = "acbcbba";
            var expectedResult = 1;

            //Act
            var result = Program.EvenWord(word);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Test2()
        {
            //Arrange
            var word = "axxaxa";
            var expectedResult = 2;

            //Act
            var result = Program.EvenWord(word);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Test3()
        {
            //Arrange
            var word = "aaaa";
            var expectedResult = 0;

            //Act
            var result = Program.EvenWord(word);

            //Assert
            Assert.Equal(expectedResult, result);
        }

    }
}
