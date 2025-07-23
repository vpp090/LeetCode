using System;

namespace MyApp
{
    internal class Program
    {
        public int MaxProfit(int[] prices)
        {
            int currentMin = prices[0];
            int maxProfit = 0;

            for(int i =0;  i < prices.Length; i++)
            {
                if(prices[i] < currentMin)
                {
                    currentMin = prices[i];
                }
                else if(prices[i] - currentMin > maxProfit)
                {
                    maxProfit = prices[i] - currentMin;
                }
            }

            return maxProfit;
        }

        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}