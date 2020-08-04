using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeNumbers
{
    public enum Prime
    {
        PRIME,
        NOTPRIME
    }

    public class PrimeNumbers
    {
        public int GetPrime(int userNum)
        {
            int lastNum = 0;
            int lastPrime = 3;
            int primeCount = 2;

            for (int index = 3; primeCount < userNum; index++)
            {
                if (index % 2 == 0)
                {
                    lastNum = index;
                }
                else if (index % 3 == 0)
                {
                    lastNum = index;
                }
                else if ((index / (Math.Truncate(Math.Sqrt(index)))) % 1 == 0)
                {
                    lastNum = index;
                }
                else
                {
                    lastPrime = index;
                    primeCount++;
                }
            }
            lastNum += 1;
            return lastNum;
        }
    }
}
