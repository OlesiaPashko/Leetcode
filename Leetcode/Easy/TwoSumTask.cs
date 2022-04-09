namespace Leetcode.Easy
{
    using System;
    using System.Collections.Generic;
    //TASK
    //Figure out what two numbers from array sum up to target value.
    //Output - indexes of these numbers in array

    //EXAMPLE

    //INPUT
    //int[] nums = new int[]{3,2,4};
    //int target = 6;

    //OUTPUT
    //[1,2]
    public class TwoSumTask
    {
        //Space complexity 0, time complexity O(n^2)
        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new[] {i, j};
                    }
                }
            }

            throw new Exception("There is no valid answer");
        }

        //Space complexity O(n), time complexity O(n)
        public static int[] TwoSumWithDictionary(int[] nums, int target)
        {
            var dictionary = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var currentNumber = nums[i];
                if (dictionary.ContainsKey(target - currentNumber))
                {
                    return new[] {dictionary[target - currentNumber], i};
                }

                if (!dictionary.ContainsKey(currentNumber))
                {
                    dictionary.Add(currentNumber, i);
                }
            }

            throw new Exception("There is no valid answer");
        }
    }
}