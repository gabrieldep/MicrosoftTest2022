using MicrosoftTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestProject
{
    public class EqualCars
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            var cars = new string[] { "100", "110", "010", "011", "100" };
            var expectedResult = new int[] { 2, 3, 2, 1, 2 };

            //Act
            var result = Program.EqualCars(cars);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
