public class Solution {
    public bool solution(int x) {
        bool answer = true;
        int a = 0;
        int temp = 0;
        int y = x;
        
        while (y > 0)
        {
            temp = y % 10;
            y = y / 10;
            a += temp;
        }
        
        if (x % a != 0)
        {
            answer = false;
        }
        else {}
        
        return answer;
    }
}