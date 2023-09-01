using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
        string[] temp = s.Split();
        
        for(int i = 0; i < temp.Length; i++)
        {
            for (int j = 0; j < temp[i].Length; j++)
            {
                if (j % 2 == 0)
                {
                    answer += Char.ToUpper(temp[i][j]);
                }
                else
                {
                    answer += Char.ToLower(temp[i][j]);
                }
            }
            if(i < temp.Length - 1)
            {
                            answer += " ";
            }
        }
        return answer;
    }
}