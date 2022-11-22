namespace WhilePractice
{
    public static class Task3
    {
        /// <summary>
        /// Calculate the following sum
        /// 1/1^5 + 1/2^5 + 1/3^5 + ... + 1/n^5, where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double SumSequenceElements(int n)
        {
            double result = 0;
            double i = 1;
            double term;

            while (i <= n)
            {
                term = 1 / (i * i * i * i * i);
                i++;
                result += term;
            }

            return result;
        }
    }
}
