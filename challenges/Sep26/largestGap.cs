using System;
// Given an array of integers, return the largest gap between the sorted elements of the array
//largestGap([9, 4, 26, 26, 0, 0, 5, 20, 6, 25, 5]) ➞ 11

// After sorting: [0, 0, 4, 5, 5, 6, 9, 20, 25, 26, 26]

// Largest gap between 9 and 20 is 11
namespace staging_challenges
{
    public class LargestGap
    {
        public int Solution(int[] nums)
        {
            int largestGap = 0;

            Array.Sort(nums);

            for(int i = 1; i < nums.Length; i++)
            {
                if (nums[i] - nums[i - 1] > largestGap)
                {
                    largestGap = nums[i] - nums[i - 1];
                }
            }

            Console.WriteLine(largestGap);
            return largestGap;
        }
    }
}

