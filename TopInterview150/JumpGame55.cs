/*
55. Jump Game
Solved
Medium
Topics
Companies
You are given an integer array nums. You are initially positioned at the array's first index, and each element in the array represents your maximum jump length at that position.

Return true if you can reach the last index, or false otherwise.

 

Example 1:

Input: nums = [2,3,1,1,4]
Output: true
Explanation: Jump 1 step from index 0 to 1, then 3 steps to the last index.
Example 2:

Input: nums = [3,2,1,0,4]
Output: false
Explanation: You will always arrive at index 3 no matter what. Its maximum jump length is 0, which makes it impossible to reach the last index.
*/
public class JumpGame {
    public bool CanJump(int[] nums) {
      if(nums.Length < 2) return true;
      int end = nums.Length-1;
      // essentially we need to look for any
      // zeros and make sure we can get past tthem
	  for(int i = 0; i < nums.Length; i++)
      {
        if(i == end) return true;
        if(nums[i] == 0)
        {
          bool jumpPast = false;
          // search backwards until number at nums[j] + j > i
          for(int j = i-1; j >= 0; j--)
          {
            if(nums[j] + j > i)
            {
              jumpPast = true;
              break;
            }
          }
          if(!jumpPast) return false;
        }
      }
      return true;
    }
}