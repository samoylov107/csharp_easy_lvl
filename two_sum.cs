/* https://leetcode.com/problems/two-sum/ */ 

public class Solution 
{
    public int[] TwoSum(int[] nums = {2,7,11,15}, int target = 9) 
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] != target)
                    continue;
                else 
                    break;
                Console.Write($"{nums[i, j]}");
            }
            Console.WriteLine();
        }
    }
}
