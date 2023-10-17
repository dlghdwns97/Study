using System;

public class Solution {
    public int[] solution(int brown, int yellow) {
        int[] answer = new int[2];
        int x = 0;
        int y = 0;
        int sum = brown + yellow;
        int temp = 0;

        for (int i = 1; i <= sum; i++)
        {
            x = i;
            y = sum / x;
            if (x > y || x == y)
            {
                temp = sum - ((x * 2) + (y * 2) - 4);
                if (yellow == temp)
                {
                    answer[0] = x;
                    answer[1] = y;
                    break;
                }
            }
        }

        return answer;
    }
}