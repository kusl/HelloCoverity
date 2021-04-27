using CoverityConsole;
using System;
using Xunit;

namespace CoverityConsoleTests
{
    public class CalculatorTests
    {
        [Fact]
        public void TestAddTwoNumbers()
        {
            int first = 1;
            int second = 2;
            int expected = 3;
            int actual = Calculator.AddTwoNumbers(first, second);
            Assert.Equal(expected, actual);
        }
    }
}
