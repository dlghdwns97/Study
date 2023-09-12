using System;

public class Solution {
    public int solution(int k, int m, int[] score) {
        int answer = 0;
        int temp = 0;
        Array.Sort(score);
        Array.Reverse(score);
        
        for (int i = 0; i < (score.Length / m); i++)
        {
            temp = score[(i * m) + (m - 1)] * m;
            answer += temp;
        }
        
        return answer;
    }
}