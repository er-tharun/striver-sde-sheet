//https://leetcode.com/contest/weekly-contest-459/problems/check-divisibility-by-digit-sum-and-product

public class Solution {
    public bool CheckDivisibility(int n) {
        long sum = 0;
        long pdt = 1;
        int originalnum = n;
        while(n>0) {
            int temp = n%10;
            sum += temp;
            pdt *= temp;
            n=n/10;
        }
        return originalnum%(sum+pdt)==0 ? true : false;
    }
}