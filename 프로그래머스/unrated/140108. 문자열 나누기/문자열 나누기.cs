using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        int same = 0;
        int diff = 0;
        char temp = ' ';
        
        for (int i = 0; i < s.Length; i++)
        {
            if (temp == ' ')
            {
                temp = s[i];
            }
            if (temp == s[i])
            {
                same++;
            }
            else
            {
                diff++;
            }
            if (same == diff && i != s.Length - 1)
            {
                answer++;
                same = 0;
                diff = 0;
                temp = ' ';
            }
        }
        answer++;
        return answer;
    }
}