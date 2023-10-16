using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[2];
        int count = 0;
        int removed = 0;
        
        while(s != "1")
        {
            string replaceS = s.Replace("0", string.Empty);
            removed += s.Length - replaceS.Length;
            count++;
            s = Convert.ToString(replaceS.Length, 2);
        }
        
        answer[0] = count;
        answer[1] = removed;
        return answer;
    }
}