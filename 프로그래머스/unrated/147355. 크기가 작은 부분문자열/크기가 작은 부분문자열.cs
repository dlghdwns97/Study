using System;

public class Solution {
    public int solution(string t, string p) {
        int answer = 0;
        long y = long.Parse(p);
        
        for (int i = 0; i < t.Length - p.Length + 1; i++)
        {
            string s = t.Substring(i, p.Length);

            
            long x = long.Parse(s);
            
            if (x <= y)
            {
                answer++;
            }
        }
    
        return answer;
    }
}