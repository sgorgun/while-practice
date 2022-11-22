namespace WhilePractice
{
    public static class Task6
    {
        /// <summary>
        /// Calculate the following sum
        /// -1/3 + 1/5 - 1/7 + ... + (-1)^n / (2 * n + 1), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double SumSequenceElements(int n)
        {
            double result = 0;
            double i = 1;
            double term;
            double one = -1;
            double minus = 1;

            while (i <= n)
            {
                minus *= one;
                term = minus / ((2 * i) + 1);
                i++;
                result += term;
            }

            return result;
        }
    }
}
