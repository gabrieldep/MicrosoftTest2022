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

        #region DigitsSum
        public static int DigitsSum(int N)
        {
            int sum = GetSum(N) * 2;
            for (int i = N; i < int.MaxValue; GetNextCompare(ref i))
                if (GetSum(i) == sum)
                    return i;
            return -1;
        }

        private static void GetNextCompare(ref int N)
        {
            var digits = N.ToString().Select(c => c - '0').ToList();
            if (digits.All(d => d == 9))
            {
                N += (int)Math.Pow(10, digits.Count);
                return;
            }
            var i = digits.LastIndexOf(digits.Last(a => a != 9));
            digits[i] = digits[i] + 1;
            int result = 0;
            for (int j = 0; j < digits.Count; j++)
                result = result * 10 + digits[j];
            N = result;
        }

        private static int GetSum(int N)
        {
            int sum = 0;
            while (N > 0)
            {
                sum += N % 10;
                N /= 10;
            }
            return sum;
        }
        #endregion

        #region EqualCars
        public static int[] EqualCars(string[] cars)
        {
            int[] arrInt = new int[cars.Length];
            for (int i = 0; i < cars.Length; i++)
                for (int j = i + 1; j < cars.Length; j++)
                    if (i != j && IsEquals(cars[i], cars[j]))
                    {
                        arrInt[i]++;
                        arrInt[j]++;
                    }
            return arrInt;
        }

        private static bool IsEquals(string a, string b)
        {
            if (a.Equals(b))
                return true;

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
        #endregion

        #region EvenWord
        public static int EvenWord(string S)
        {
            int remotions = 0;
            var arrInt = new int[26];
            for (int i = 0; i < S.Length; i++)
                arrInt[S[i] - 97]++;

            for (int i = 0; i < 26; i++)
                if (arrInt[i] % 2 == 1)
                    remotions++;
            return remotions;
        }
        #endregion
    }
}