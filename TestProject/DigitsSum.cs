using MicrosoftTest;
using Xunit;

namespace TestProject
{
    public class DigitsSum
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            var n = 765;
            var expectedResult = 9999;

            //Act
            var result = Program.DigitsSum(n);

            //Assert
            Assert.Equal(result, expectedResult);
        }

        [Fact]
        public void Test2()
        {
            //Arrange
            var n = 14;
            var expectedResult = 19;

            //Act
            var result = Program.DigitsSum(n);

            //Assert
            Assert.Equal(result, expectedResult);
        }

        [Fact]
        public void Test3()
        {
            //Arrange
            var n = 99;
            var expectedResult = 9999;

            //Act
            var result = Program.DigitsSum(n);

            //Assert
            Assert.Equal(result, expectedResult);
        }

        [Fact]
        public void Test4()
        {
            //Arrange
            var n = 10;
            var expectedResult = 11;

            //Act
            var result = Program.DigitsSum(n);

            //Assert
            Assert.Equal(result, expectedResult);
        }
    }
}