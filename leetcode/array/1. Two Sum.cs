// var s = new _1_Two_Sum();
// var result = s.TwoSum([2, 7, 11, 15], 9);
// Console.WriteLine($"{result[0]} {result[1]}");

public class _1_Two_Sum {
    public int[] TwoSum(int[] nums, int target) {
        var mapping = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];
            if (mapping.ContainsKey(complement)) {
                return [mapping[complement], i];
            } else {
                mapping[nums[i]] = i;
            }
        }

        return []; // Return an empty array if no solution is found
    }
}