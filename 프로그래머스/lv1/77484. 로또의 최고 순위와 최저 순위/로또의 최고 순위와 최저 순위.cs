using System;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int[] answer = new int[2];
        int temp = 0;
        int zerotemp = 0;
        
        for (int i = 0; i < 6; i++)
        {
            bool isIn = Array.Exists(lottos, n => n == win_nums[i]);
            if (isIn == true)
            {
                temp++;
            }
            if (lottos[i] == 0)
            {
                zerotemp++;
            }
        }
        answer[0] = 7 - temp - zerotemp;
        answer[1] = 7 - temp;
        if (answer[0] == 7) answer[0] = 6;
        if (answer[1] == 7) answer[1] = 6;
        return answer;
    }
}