
//https://leetcode.com/contest/biweekly-contest-156/problems/find-most-frequent-vowel-and-consonant/

public class Solution
{
    public int MaxFreqSum(string s)
    {
        int maxFreqVowel = 0;
        int maxFreqConsontant = 0;
        int[] arr = new int[26];
        for (int i = 0; i < s.Length; i++)
            arr[s[i] - 97]++;

        int[] vovelFreq = new int[5];
        vovelFreq[0] = arr[(int)'a' - 97];
        vovelFreq[1] = arr[(int)'e' - 97];
        vovelFreq[2] = arr[(int)'i' - 97];
        vovelFreq[3] = arr[(int)'o' - 97];
        vovelFreq[4] = arr[(int)'u' - 97];

        arr[(int)'a' - 97] = arr[(int)'e' - 97] = arr[(int)'i' - 97] = arr[(int)'o' - 97] = arr[(int)'u' - 97] = 0;


        maxFreqConsontant = arr.Max();
        maxFreqVowel = vovelFreq.Max();

        return maxFreqVowel + maxFreqConsontant;
    }
}©leetcode