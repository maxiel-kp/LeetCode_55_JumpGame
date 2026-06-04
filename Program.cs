using System;

public class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 2, 3, 1, 1, 4 };

        var solution = new Solution();
        bool result = solution.CanJump(nums);
        Console.WriteLine($"nums : [{string.Join(", ", nums)}]");
        Console.WriteLine($"Can jump : {result}");

        Console.ReadLine();
    }
}

public class Solution
{
    public bool CanJump(int[] nums)
    {
        int maxReach = 0;
        int lastIndex = nums.Length - 1;

        for (int i = 0; i < nums.Length; i++)
        {
            if (i > maxReach)
            {
                return false;
            }

            maxReach = Math.Max(maxReach, i + nums[i]);

            if (maxReach >= lastIndex)
            {
                return true;
            }
        }

        return true;
    }
}