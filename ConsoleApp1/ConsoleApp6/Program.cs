using System;

namespace MyApp
{
    internal class Program
    {
        public int ClimbStairs(int n)
        {
            if (n <= 2) return n;

            int oneStepBefore = 2;
            int twoStepBefore = 1;
            int allWays = 0;

            for(int i = 3; i <= n; i++)
            {
                allWays = oneStepBefore + twoStepBefore;
                twoStepBefore = oneStepBefore;
                oneStepBefore = allWays;
            }

            return allWays;
        }

        // 1, 2 = 1 + 1 / 2, 3 = (2) + (1)
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}