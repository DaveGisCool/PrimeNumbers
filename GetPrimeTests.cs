using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PrimeNumbers.Tests
{
    public class GetPrimeTests
    {
        [Theory]
        [InlineData(7, 17)]
        [InlineData(12, 37)]
        [InlineData(27, 103)]
        [InlineData(191, 1153)]
        [InlineData(1039, 8287)]


        public void TestAll(int userNum, int expected)
        {
            PrimeNumbers primeNum = new PrimeNumbers();
            int final = primeNum.GetPrime(userNum);

            Assert.Equal(expected, final);
        }
    }
}
