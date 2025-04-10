namespace LeetCode01TwoSum;

using Xunit;

public class SolutionTest
{
    [Fact]
    public void TwoSum()
    {
        Assert.Equal([0, 1], new Solution().TwoSum([2, 7, 11, 15], 9));
    }

    [Fact]
    public void TwoSum2()
    {
        Assert.Equal([1, 2], new Solution().TwoSum([3, 2, 4], 6));
    }

    [Fact]
    public void TwoSum3()
    {
        Assert.Equal([0, 1], new Solution().TwoSum([3, 3], 6));
    }

    [Fact]
    public void TwoSum4()
    {
        Assert.Equal([-1, -1], new Solution().TwoSum([3, 3], 7));
    }
}