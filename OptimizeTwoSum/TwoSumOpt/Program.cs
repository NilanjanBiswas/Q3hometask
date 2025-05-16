using System;
using System.Collections.Generic;

namespace TwoSumProject
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.TryGetValue(complement, out int index))
                {
                    return new[] { index, i };
                }
                map[nums[i]] = i;
            }
            return Array.Empty<int>();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;

            int[] result = solution.TwoSum(nums, target);

            if (result.Length == 0)
            {
                Console.WriteLine("No solution found.");
            }
            else
            {
                Console.WriteLine($"Indices: {result[0]}, {result[1]}");
            }
        }
    }
}
