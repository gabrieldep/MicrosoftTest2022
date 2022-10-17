using System;
using System.Collections.Generic;
using System.Linq;

namespace MicrosoftTest
{
    public class Program
    {
        public static void Main()
        {
        }

        internal static int Solution1(int N)
        {
            int sum = GetSum(N) * 2;
            for (int i = N + 1; i < int.MaxValue; i++)
                if (GetSum(i) == sum)
                    return i;
            return 0;
        }

        internal static int GetSum(int N)
        {
            int sum = 0;
            while (N > 0)
            {
                sum += N % 10;
                N /= 10;
            }
            return sum;
        }

        internal static int[] Solution2(string[] cars)
        {
            int[] arrInt = new int[cars.Length];
            for (int i = 0; i < cars.Length; i++)
            {
                for (int j = i; j < cars.Length; j++)
                {
                    if (i != j && IsEquals(cars[i], cars[j]))
                    {
                        arrInt[i]++;
                        arrInt[j]++;
                    }
                }
            }
            return arrInt;
        }

        internal static bool IsEquals(string a, string b)
        {
            int diff = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                    diff++;
                if (diff > 1)
                    return false;
            }
            return true;
        }

        internal static int Solution3(string S)
        {
            string sortedWord = string.Concat(S.OrderBy(c => c));
            int remotions = 0;
            int countLetter = 1;
            for (int i = 1; i < sortedWord.Length; i++)
            {
                if (sortedWord[i] == sortedWord[i - 1])
                    countLetter++;
                else if (countLetter % 2 != 0)
                {
                    remotions++;
                    countLetter = 1;
                }
            }
            return countLetter % 2 != 0 ? ++remotions : remotions;
        }
    }
}