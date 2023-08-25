public class Solution {
    public long solution(int a, int b) {
        long answer = 0;
        long middle = 0;
        int temp = 0;
        
        if (a > b)
        {
            temp = a;
            a = b;
            b = temp;
        }
        
        if (a == b)
        {
            answer = a;
        }
        else if (b - a == 1)
        {
            answer = a + b;
        }
        else
        {
            for (int i = a + 1; i < b; i++)
            {
                middle += i;
            }
            answer = a + middle + b;
        }
        
        return answer;
    }
}