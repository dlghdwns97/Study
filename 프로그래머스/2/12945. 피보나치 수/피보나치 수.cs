public class Solution {
    public int solution(int n) {
        int answer = 0;
        int temp1 = 0;
        int temp2 = 1;
        
        for (int i = 1; i < n; i++)
        {
            answer = (temp1 + temp2) % 1234567;
            temp1 = temp2 % 1234567;
            temp2 = answer;
        }
        
        answer %= 1234567;
        return answer;
    }
}