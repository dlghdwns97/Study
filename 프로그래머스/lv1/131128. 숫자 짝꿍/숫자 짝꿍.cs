using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution {
    public string solution(string X, string Y) {
        string answer = "";
        
        int[] x = new int[10];
        int[] y = new int[10];

        for(int i = 0; i < X.Length; i++)
        {
            x[(int)(X[i] - 48)]++;
        }
        for(int i = 0; i < Y.Length; i++)
        {
            y[(int)(Y[i] - 48)]++;
        }
        StringBuilder xy = new StringBuilder();

        for(int i = 9; i >= 0; i--)
        {
            while(x[i] > 0 && y[i] > 0){
                xy.Append(i);
                x[i]--;
                y[i]--;
            }
        }
        
        if ("".Equals(xy.ToString()))
        {
            answer = "-1";
        }
        else if ("0".Equals(xy.ToString().Substring(0, 1)))
        {
            answer = "0";
        }
        else
        {
            answer = xy.ToString();
        }
        
        return answer;
    }
}