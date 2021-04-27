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
            Assert.Equal(3, Calculator.AddTwoNumbers(1, 2));
        }
    }
}
