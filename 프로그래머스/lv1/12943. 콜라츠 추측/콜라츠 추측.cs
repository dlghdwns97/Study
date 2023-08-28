public class Solution {
    public int solution(int num) {
        int answer = 0;
        long temp = num;
        for(int i = 0; i <= 500; i++)
        {
            if(temp == 1)
            {
                return i;
            }
            if(temp % 2 == 0)
            {
                temp = temp / 2;
            }
            else
            {
                temp = temp * 3 + 1;
            }
        }
        answer = -1;
        return answer;
    }
}