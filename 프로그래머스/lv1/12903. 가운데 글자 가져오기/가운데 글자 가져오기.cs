public class Solution {
    public string solution(string s) {
        string answer = "";
        int len = s.Length;
        
        if (len % 2 == 1)
        {
            int middle = len / 2;
            string s2 = s.Substring(middle, 1);
            answer = s2;
        }
        else
        {
            int middle = (len / 2) - 1;
            string s2 = s.Substring(middle, 2);
            answer = s2;
        }
        
        return answer;
    }
}