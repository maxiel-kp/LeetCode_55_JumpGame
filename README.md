# Jump Game

LeetCode Problem: [55. Jump Game](https://leetcode.com/problems/jump-game/)

## Problem Summary

Given an integer array `nums`, each element represents the maximum jump length from that position.

You start at index `0`.

Return `true` if you can reach the last index, otherwise return `false`.

## Example 1

```text
Input: nums = [2,3,1,1,4]
Output: true
```

Explanation:

From index `0`, jump to index `1`.

From index `1`, jump `3` steps to reach the last index.

## Example 2

```text
Input: nums = [3,2,1,0,4]
Output: false
```

Explanation:

You can reach index `3`, but `nums[3] = 0`, so you cannot move forward to the last index.

## Approach: Greedy

We keep track of the farthest index we can reach so far using `maxReach`.

While iterating through the array:

- If the current index `i` is greater than `maxReach`, it means this index cannot be reached, so return `false`.
- Otherwise, update `maxReach` with the farthest position reachable from the current index.
- If `maxReach` reaches or passes the last index, return `true`.

## C# Solution

```csharp
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
```

## Complexity

| Type | Complexity |
|---|---|
| Time | `O(n)` |
| Space | `O(1)` |

## Key Idea

The problem does not require finding the exact jump path.

We only need to know the farthest index that can be reached at any point.

If we can keep extending `maxReach` until it reaches the last index, the answer is `true`.
