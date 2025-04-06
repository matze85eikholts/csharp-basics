

using CSharpLearnProject;
using System;

namespace CSharpLearnProject.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Sum_TwoNumbers_ReturnsCorrectResult()
        {
            // Arrange
            var person = new Person();
            int a = 5;
            int b = 10;

            // Act
            int result = person.Sum(a, b);

            // Assert
            Assert.Equal(15, result);
        }

    }
}
