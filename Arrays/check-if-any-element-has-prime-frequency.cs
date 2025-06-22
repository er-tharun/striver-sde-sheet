//https://leetcode.com/contest/weekly-contest-455/problems/check-if-any-element-has-prime-frequency/

public class Solution {
    public bool CheckPrimeFrequency(int[] nums) {
        IDictionary<int, int> freqMap = new Dictionary<int, int>();

        foreach(int num in nums)
        {
            if(!freqMap.ContainsKey(num))
                freqMap.Add(num, 1);
            else
                freqMap[num]++;
        }

        foreach(var data in freqMap)
        {
            var result = IsPrime(data.Value);
            if(result == true)
                return result;
        }
        return false;
    }

    public static bool IsPrime(int n)
    {
        if(n == 1)
            return false;
        for(int i=2; i<n;i++)
        {
            if(n%i == 0)
                return false;
        }
        return true;
    }
}