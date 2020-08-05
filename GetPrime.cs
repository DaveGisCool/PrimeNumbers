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
            List<int> primeList = new List<int>();
            primeList.Add(2);
            primeList.Add(3);
            Prime primey;
            int index;

            for (index = 4; primeList.Count < userNum; index++)
            {
                int primeCount = primeList.Count;
                for (int index2 = 0; index2 < primeCount; index2++)
                {
                    if (index % primeList[index2] == 0)
                    {
                        break;
                    }
                    else if (index2 == primeCount - 1)
                    {
                        primeList.Add(index);
                    }
                }
            }

            int userPrime = primeList[userNum - 1];

            if (primeList.Contains(userPrime))
            {
                primey = Prime.PRIME;
            }
            else
            {
                primey = Prime.NOTPRIME;
            }

            return primeList[userNum - 1];
        }
    }
}
