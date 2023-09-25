using System;

public class Solution {
    public string solution(string[] survey, int[] choices) {
        string answer = "";
        int RT = 0;
        int CF = 0;
        int JM = 0;
        int AN = 0;
        int temp = 0;
        
        for (int i = 0; i < choices.Length; i++)
        {
            temp = choices[i] - 4;
            switch (survey[i])
            {
                case "RT":
                    RT += temp;
                    break;
                case "TR":
                    RT -= temp;
                    break;
                case "CF":
                    CF += temp;
                    break;
                case "FC":
                    CF -= temp;
                    break;
                case "JM":
                    JM += temp;
                    break;
                case "MJ":
                    JM -= temp;
                    break;
                case "AN":
                    AN += temp;
                    break;
                case "NA":
                    AN -= temp;
                    break;
            }
            temp = 0;
        }
        
        if (RT > 0) answer += "T";
        else answer += "R";
        
        if (CF > 0) answer += "F";
        else answer += "C";
        
        if (JM > 0) answer += "M";
        else answer += "J";
        
        if (AN > 0) answer += "N";
        else answer += "A";
        
        return answer;
    }
}