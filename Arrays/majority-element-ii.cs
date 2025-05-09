//https://leetcode.com/problems/majority-element-ii

public class Solution
{
    public IList<int> MajorityElement(int[] nums)
    {
        int min = (nums.Length / 3) + 1;
        var result = new List<int>();
        int counter1 = 0, counter2 = 0;
        int ele1 = int.MinValue, ele2 = int.MinValue;
        for (int i = 0; i < nums.Length; i++)
        {
            if (counter1 == 0 && nums[i] != ele2)
            {
                counter1++;
                ele1 = nums[i];
            }
            else if (counter2 == 0 && nums[i] != ele1)
            {
                counter2++;
                ele2 = nums[i];
            }
            else
            {
                if (ele1 == nums[i]) counter1++;
                else if (ele2 == nums[i]) counter2++;
                else
                {
                    counter1--;
                    counter2--;
                }
            }
        }

        counter1 = 0;
        counter2 = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == ele1) counter1++;
            if (nums[i] == ele2) counter2++;
        }

        if (counter1 >= min)
            result.Add(ele1);
        if (counter2 >= min)
            result.Add(ele2);

        result.Sort();

        return result;
    }
}