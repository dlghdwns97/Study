using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string s, string skip, int index) {
        string answer = "";
        string alp = "abcdefghijklmnopqrstuvwxyz";
        List<char> charsToRemove = skip.ToCharArray().ToList();
        int temp = 0;
        
        foreach (char c in charsToRemove) {
            alp = alp.Replace(c.ToString(), String.Empty);
        }
        
        for (int i = 0; i < s.Length; i++)
        {
            temp = alp.IndexOf(s[i], 0, alp.Length);
            temp += index;
            if (temp >= alp.Length)
            {
                temp = temp % alp.Length;
            }
            answer += alp[temp];
        }
        
        return answer;
    }
}