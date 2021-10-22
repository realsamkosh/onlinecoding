public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {      
       int i = 0; int j= nums.Length - 1;
        
       while(i < j)
       {
           int sum = nums[i] + nums[j];
           
           if(sum == target)
               return new int[] {i,j};
           
           if(i==j || ((i + 1) == j))
           {
               i++;
               j  = nums.Length - 1;
           }
           else
           {
               j--;
           }
       }
        return new int[] {-1,-1};
    }
}