﻿namespace WhilePractice
{
    public static class Task5
    {
        /// <summary>
        /// Calculate the following product
        /// (1 + 1/(1 * 1)) * (1 + 1/(2 * 2)) * (1 + 1/(3 * 3)) * ... * (1 + 1/(n * n)), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Product of elements.</returns>
        public static double GetSequenceProduct(int n)
        {
            double result = 1;
            double i = 1;
            double term;

            while (i <= n)
            {
                term = 1 + (1 / (i * i));
                i++;
                result *= term;
            }

            return result;
        }
    }
}
