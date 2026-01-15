namespace SumOfTwoValue;

using System.Collections.Generic;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (map.ContainsKey(complement))
            {
                return new int[] { map[complement], i };
            }

            // Store current number and its index
            map[nums[i]] = i;
        }

        // This line will never be reached because exactly one solution exists
        return new int[0];
    }
}