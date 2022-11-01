/* https://leetcode.com/problems/two-sum/ */ 

public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
    {   
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                   Console.Write($"{i}{j}");
            }
            Console.WriteLine();
        }
    }
}
