using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;
using FluentAssertions;
using Problems.TwoSum;

namespace Tests;

public class TwoSumTest
{
    [Fact]
    public void TestON2Solution()
    {
        List<int> numbers = new List<int>() { 2, 7, 11, 15 };
        int target = 9;
        List<int> expectedIndexes = new List<int>() { 0, 1 };
        List<int> indexes = TwoSumSolution.Solution1(numbers, target);
        indexes.Should().BeEquivalentTo(expectedIndexes);
    }

    [Fact]
    public void TestONSolution()
    {
        List<int> numbers = new List<int>() { 2, 7, 11, 15 };
        int target = 9;
        List<int> expectedIndexes = new List<int>() { 0, 1 };
        List<int> indexes = TwoSumSolution.Solution2(numbers, target);
        indexes.Should().BeEquivalentTo(expectedIndexes);
    }
}