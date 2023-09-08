using System;

public class Solution {
    public int solution(int a, int b, int n) {
        int answer = 0;
        int temp = 0;
        
        while(n >= a)
        {
            temp = 0;
            temp += (n / a) * b;
            answer += temp;
            n -= (temp / b) * a;
            n += temp;
        }
        
        return answer;
    }
}