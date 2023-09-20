using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
        int[] answer = new int[targets.Length];
        List<int> answerList = new List<int>();

        for (int i = 0; i < targets.Length; i++)
        {
            char[] targetsArray = targets[i].ToCharArray();
            int temp = 0;
            int push = 0;
            int sum = 0;

            for (int j = 0; j < targetsArray.Length; j++)
            {
                push = 101;
                for (int k = 0; k < keymap.Length; k++)
                {
                    if (keymap[k].Contains(targetsArray[j])) 
                    {
                        temp = keymap[k].IndexOf(targetsArray[j]);
                        if (push > temp)
                        {
                            push = temp + 1;
                        }
                    }
                }
                sum += push;
                if (push == 101)
                {
                    sum = -1;
                    break;
                }
            }
            answerList.Add(sum);
        }
        answer = answerList.ToArray();
        return answer;
    }
}