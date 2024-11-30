/*
45. Jump Game II
Solved
Medium
Topics
Companies
You are given a 0-indexed array of integers nums of length n. You are initially positioned at nums[0].

Each element nums[i] represents the maximum length of a forward jump from index i. In other words, if you are at nums[i], you can jump to any nums[i + j] where:

0 <= j <= nums[i] and
i + j < n
Return the minimum number of jumps to reach nums[n - 1]. The test cases are generated such that you can reach nums[n - 1].

 

Example 1:

Input: nums = [2,3,1,1,4]
Output: 2
Explanation: The minimum number of jumps to reach the last index is 2. Jump 1 step from index 0 to 1, then 3 steps to the last index.
Example 2:

Input: nums = [2,3,0,1,4]
Output: 2
 

Constraints:

1 <= nums.length <= 104
0 <= nums[i] <= 1000
It's guaranteed that you can reach nums[n - 1].
*/
/**
<remarks>
Time 16:38
</remarks>
*/
public class JumpGameII {
    public int Jump(int[] nums) {
        // now we are trying to minimize the number of jumps to reach the end
        // first check for length 1 and 2
        if(nums.Length == 1) return 0;
        if(nums.Length == 2) return 1;
        int jumps = 0;
        int at = nums.Length-1;
		// Find the biggest jumps we can make by starting
		// at the end and working backwards looking for the longest
		// possible jump
        while(at > 0)
        {
            int min = at-1;
            for(int j = at-1; j >= 0 && at - j <= 1000; j--)
            {
                if(j + nums[j] >= at)
                {
                    min = j;
                }
            }
            jumps++;
            at = min;
        }
        return jumps;
    }
}