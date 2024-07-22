// 55. Jump Game
// url: https://leetcode.com/problems/jump-game/
// Difficulty: Medium

// var s = new _55_Jump_Game();
// Console.WriteLine(s.CanJump([2, 3, 1, 1, 4])); // true
// Console.WriteLine(s.CanJump([3, 2, 1, 0, 4])); // false
// Console.WriteLine(s.CanJump([0])); // true

public class _55_Jump_Game
{
    public bool CanJump(int[] nums)
    {
        var goal = nums.Length - 1;

        for (int i = nums.Length - 2; i >= 0; i--)
        {
            // If we can reach the goal from the current index, update the goal
            if (i + nums[i] >= goal)
            {
                goal = i;
            }
        }

        return goal == 0;
    }
}