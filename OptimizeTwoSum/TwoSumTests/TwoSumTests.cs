using Xunit;
using TwoSumProject; // Namespace of your Solution class

public class TwoSumTests
{
    [Fact]
    public void NormalCase()
    {
        var solution = new Solution();
        int[] result = solution.TwoSum(new[] { 2, 7, 11, 15 }, 9);
        Assert.Equal(new[] { 0, 1 }, result);
    }

    [Fact]
    public void EdgeCase_EmptyArray()
    {
        var solution = new Solution();
        int[] result = solution.TwoSum(Array.Empty<int>(), 5);
        Assert.Empty(result);
    }

    [Fact]
    public void DuplicateNumbers()
    {
        var solution = new Solution();
        int[] result = solution.TwoSum(new[] { 3, 3 }, 6);
        Assert.Equal(new[] { 0, 1 }, result);
    }

    [Fact]
    public void NoSolution()
    {
        var solution = new Solution();
        int[] result = solution.TwoSum(new[] { 1, 2, 3 }, 7);
        Assert.Empty(result);
    }
}
