namespace Problems.RomanToInteger;
/// <summary>
/// Roman to Integer problem
/// Reference: https://leetcode.com/problems/roman-to-integer/
/// </summary>
public static class RomanToIntegerSolution
{

    /// <summary>
    /// O(N) solution
    /// </summary>
    /// <param name="romanNumeral"> A Roman numeral </param>
    /// <returns> An integer representation of a Roman numeral </returns>
    public static int Solution(string romanNumeral)
    {
        Dictionary<char, int> romanToIntegerMapping = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
 {'C', 100},
 {'D', 500},
 {'M', 1000}
        };
        int result = 0;
        for (int i = 0; i < romanNumeral.Length; i++)
        {
            if (i + 1 < romanNumeral.Length && romanToIntegerMapping[romanNumeral[i]] < romanToIntegerMapping[romanNumeral[i + 1]])
                result -= romanToIntegerMapping[romanNumeral[i]];
            else
                result += romanToIntegerMapping[romanNumeral[i]];
        }
        return result;
    }

}