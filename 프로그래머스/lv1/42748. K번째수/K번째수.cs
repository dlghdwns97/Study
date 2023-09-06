using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        List<int> answer = new List<int>();
        
        for (int i = 0; i < commands.GetLength(0); i++)
        {
            int[] newarray = array.Skip(commands[i, 0] - 1).Take(commands[i, 1] - commands[i, 0] + 1).ToArray();
            Array.Sort(newarray);
            answer.Add(newarray[commands[i, 2] - 1]);
        }
        
        return answer.ToArray();
    }
}