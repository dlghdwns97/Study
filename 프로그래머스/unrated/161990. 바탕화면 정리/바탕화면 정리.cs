using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(string[] wallpaper) {
        int[] answer = new int[4];
        List<int> x = new List<int>();
        List<int> y = new List<int>();
        
        for (int i = 0; i < wallpaper.Length; i++)
        {
            for (int j = 0; j < wallpaper[i].Length; j++)
            {
                if (wallpaper[i][j].Equals('#'))
                {
                    x.Add(i);
                    y.Add(j);
                }
            }
        }
        
        answer[0] = x.Min();
        answer[1] = y.Min();
        answer[2] = x.Max() + 1;
        answer[3] = y.Max() + 1;
            
        return answer;
    }
}