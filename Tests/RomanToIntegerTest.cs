using Problems.RomanToInteger;
using Xunit;

namespace Tests;

public class RomanToIntegerTest
{
[Theory]
[InlineData("III", 3)]
[InlineData("LVIII", 58)]
[InlineData("MCMXCIV", 1994)]
public void ReturnsCorrectInteger(string romanNumeral, int expectedNumber)
{
    int number = RomanToIntegerSolution.Solution(romanNumeral);
    Assert.Equal(expectedNumber, number);
}
}