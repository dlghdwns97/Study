using System;
using System.Linq;

public class Solution {
    public int solution(string[] babbling) {
        int answer = 0;
        string[] baby = new string[4] {"aya", "ye", "woo", "ma"};
        string temp = "";
        
        for (int i = 0; i < babbling.Length; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                temp = baby[j] + baby[j];
                babbling[i] = babbling[i].Replace(temp, "no");
                babbling[i] = babbling[i].Replace(baby[j], " ");
            }
            if (babbling[i].Trim().Length == 0)
            {
                answer++;
            }
        }
        
        return answer;
    }
}