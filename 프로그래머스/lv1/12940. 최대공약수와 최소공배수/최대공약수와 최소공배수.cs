using System;

public class Solution {
    public int[] solution(int n, int m) {
        int[] answer = new int[2];
        int temp = 0;
        int min = 0;
        int max = 0;
        if (n > m)
        {
            temp = n;
            n = m;
            m = temp;
        }
        else {}

        min = cal(n, m);
        max = (n * m) / cal(n, m);
        
        answer[0] = min;
        answer[1] = max;
        return answer;
    }
    
    public int cal (int a, int b)
    {
        if (b % a == 0)
        {
            return a;
        }
        else
        {
            return cal(b % a, a);
        }
    }
}