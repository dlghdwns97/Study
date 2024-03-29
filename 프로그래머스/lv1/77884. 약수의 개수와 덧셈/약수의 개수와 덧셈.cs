using System;

public class Solution {
    public int solution(int left, int right) {
        int answer = 0;
        
        for (int i = left; i < right + 1; i++)
        {
            if (Math.Sqrt(i) % 1 == 0)
            {
                answer -= i;
            }
            else
            {
                answer += i;
            }
        }
        
        return answer;
    }
}