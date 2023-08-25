using System;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        string temp = n.ToString();
        int[] x = new int[temp.Length];
        string temp2 = "";
        
        for (int i = 0; i < temp.Length; i++)
        {
            x[i] = int.Parse(temp[i].ToString());
        }
        
        Array.Sort(x);
        Array.Reverse(x);
        
        for (int i = 0; i < temp.Length; i++)
        {
            temp2 += x[i].ToString();
        }
        
        answer = long.Parse(temp2.ToString());
        
        return answer;
    }
}