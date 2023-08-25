using System;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        double a = Math.Sqrt(n);
        
        if (a % 1 == 0)
        {
            answer = (long)(a + 1) * (long)(a + 1);
        }
        else
        {
            answer = -1;
        }
         
        return answer;
    }
}