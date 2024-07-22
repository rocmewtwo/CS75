// 15. 3Sum
// url: https://leetcode.com/problems/3sum/
// difficulty: medium

// var s = new _15_3Sum();
// var r = s.ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 });
// print list of list
// foreach (var item in r)
// {
//     Console.WriteLine(string.Join(",", item));
// }


public class _15_3Sum
{
    // time: O(n^2)
    // space: O(n)
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        var result = new List<IList<int>>();

        // i from 0 to nums.Length - 2, because we need at least 3 elements
        for (int i = 0; i < nums.Length - 2; i++)
        {
            // Skip duplicates
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }

            // to find the other two elements, start two pointers from the two ends
            int left = i + 1;
            int right = nums.Length - 1;
            while (left < right)
            {
                var sum = nums[i] + nums[left] + nums[right];
                if (sum == 0)
                {
                    result.Add([nums[i], nums[left], nums[right]]);
                    left++;

                    // Skip duplicates
                    while (left < right && nums[left] == nums[left - 1])
                    {
                        left++;
                    }
                }
                else if (sum < 0) // move left pointer to increase sum
                {
                    left++;
                }
                else  // move right pointer to decrease sum
                {
                    right--;
                }
            }
        }
        return result;
    }
}