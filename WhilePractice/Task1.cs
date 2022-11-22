using System;

namespace WhilePractice
{
    public static class Task1
    {
        /// <summary>
        /// Calculate the following sum 1/1 + 1/2 + 1/3 + ... + 1/n, where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double SumSequenceElements(int n)
        {
            double sum = 0;
            double i = 1;
            double k = n;
            double term;

            while (i <= k)
            {
                term = 1 / k;
                k--;
                sum += term;
            }

            return sum;
        }
    }
}
