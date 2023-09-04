using System;

public class Solution {
    public int solution(int[,] sizes) {
        int answer = 0;
        int x = 0;
        int y = 0;
        
        for (int i = 0; i < sizes.GetLength(0); i++)
        {
            int w = sizes[i, 0];
            int h = sizes[i, 1];
            
            if (w < h)
            {
                h = sizes[i, 0];
                w = sizes[i, 1];
            }
            if (w > x)
            {
                x = w;
            }
            if (h > y)
            {
                y = h;
            }
        }
        answer = x * y;
        return answer;
    }
}