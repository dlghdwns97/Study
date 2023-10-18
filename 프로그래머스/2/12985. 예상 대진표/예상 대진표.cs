using System;

class Solution
{
    public int solution(int n, int a, int b)
    {
        int answer = 0;
        int temp = 0;
        
        if (b > a)
        {
            temp = a;
            a = b;
            b = temp;
        }
        
        for (int i = 0; i < (n / 2); i++)
        {
            if ((a - b) == 1 && (a + b) % 4 == 3)
                break;
            a = (a / 2) + (a % 2);
            b = (b / 2) + (b % 2);
            answer++;
        }
        
        answer++;
        return answer;
    }
}