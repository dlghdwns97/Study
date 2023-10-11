using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string s) {
        string answer = "";
        string[] splitString = s.Split(' ');
        int[] s_int = Array.ConvertAll(splitString, x => int.Parse(x));
        answer = s_int.Min().ToString() + ' ' + s_int.Max().ToString();
        
        return answer;
    }
}