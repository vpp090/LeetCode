using System;

namespace MyApp
{
    internal class Program
    {
        public int Search(int[] nums, int target)
        {
            int low = 0;
            int high = nums.Length - 1;

            return BinarySearch(nums, low, high, target);

        }

        public int BinarySearch(int[] nums, int low, int high, int target)
        {
            if (low > high)
                return -1;

            int mid = low + (high - low) / 2;


            if (nums[mid] == target)
                return mid;
            else if (target > nums[mid])
            {
                mid = BinarySearch(nums, mid + 1, high, target);
            }
            else
            {
                mid = BinarySearch(nums, low, mid - 1, target);
            }

            return mid;
        }
            static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}