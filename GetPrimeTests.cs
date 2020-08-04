using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PrimeNumbers.Tests
{
    public class GetPrimeTests
    {
        [Theory]
        [InlineData(7, Prime.PRIME)]
        [InlineData(12, Prime.NOTPRIME)]
        [InlineData(27, Prime.NOTPRIME)]
        [InlineData(191, Prime.PRIME)]
        [InlineData(1039, Prime.PRIME)]


        public void TestAll(int userNum, Prime expected)
        {
            PrimeNumbers primeNum = new PrimeNumbers();
            Prime final = (Prime)primeNum.GetPrime(userNum);

            Assert.Equal(expected, final);
        }
    }
}
