// url: https://leetcode.com/problems/two-sum
// level: Easy

namespace LeetCode01TwoSum;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var mapping = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (mapping.TryGetValue(complement, out int value))
            {
                return [value, i];
            }
            else
            {
                mapping[nums[i]] = i;
            }
        }

        return [-1, -1];
    }
}