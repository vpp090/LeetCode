using System;

namespace MyApp
{
    internal class Program
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for(int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if(map.ContainsKey(complement))
                {
                    return [map[complement], i]; 
                }
                else
                {
                    map[nums[i]] = i;
                }
            }

            throw new ArgumentException();
        }
       
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}