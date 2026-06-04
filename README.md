##Jump Game

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

https://leetcode.com/problems/jump-game/
