namespace Problems.TwoSum;
/// <summary>
/// 2 sum problem
/// Reference: https://leetcode.com/problems/two-sum/
/// </summary>
public static class TwoSumSolution
{

    /// <summary>
    /// O(N^2) solution
    /// </summary>
    /// <param name="numbers"> A list of numbers to search in </param>
    /// <param name="target"> A number a pare must sum up to </param>
    /// <returns> A pare of indexes indecating 2 numbers in the list which sum up to the target </returns>
    public static List<int> Solution1(List<int> numbers, int target)
    {
        List<int> indexes = new List<int>();
        for (int i = 0; i < numbers.Count; i++)
        {
            for (int j = i + 1; j < numbers.Count; j++)
            {
                if (target - numbers[j] == numbers[i])
                {
                    indexes.Add(i);
                    indexes.Add(j);
                    return indexes;
                }
            }
        }
        return indexes;
    }

    /// <summary>
    /// O(N) solution
    /// </summary>
    /// <param name="numbers"> A list of numbers to search in </param>
    /// <param name="target"> A number a pare must sum up to </param>
    /// <returns> A pare of indexes indecating 2 numbers in the list which sum up to the target </returns>
    public static List<int> Solution2(List<int> numbers, int target)
    {
        List<int> indexes = new List<int>();
        Dictionary<int, int> firstNumberTable = new Dictionary<int, int>();
        for (int i = 0; i < numbers.Count; i++)
        {
            int num = target - numbers[i];
            if (firstNumberTable.ContainsKey(num))
            {
                indexes.Add(i);
                indexes.Add(firstNumberTable[num]);
                break;
            }
            firstNumberTable.Add(numbers[i], i);
        }
        return indexes;
    }
}
