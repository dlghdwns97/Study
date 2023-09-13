using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] answers) {
        int[] answer = new int[] {};
        int[] first = new int[5] {1, 2, 3, 4, 5};
        int[] second = new int[8] {2, 1, 2, 3, 2, 4, 2, 5};
        int[] third = new int[10] {3, 3, 1, 1, 2, 2, 4, 4, 5, 5};
        int[] score = new int[3] {0, 0, 0};
        int max = 0;
        List<int> student = new List<int>();
        
        for (int i = 0; i < answers.Length; i++)
        {
            if (first[i % 5] == answers[i])
            {
                score[0]++;
            }
            if (second[i % 8] == answers[i])
            {
                score[1]++;
            }
            if (third[i % 10] == answers[i])
            {
                score[2]++;
            }
        }
        
        for (int i = 0; i < 3; i++)
        {
            if (max < score[i])
            {
                max = score[i];
            }
        }
        
        for (int i = 0; i < 3; i++)
        {
            if (max == score[i])
            {
                student.Add(i + 1);
            }
        }
        answer = student.ToArray();
        return answer;
    }
}