using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string today, string[] terms, string[] privacies) {
        string[] today2 = today.Split('.');
        int year = Int32.Parse(today2[0]);
        int month = Int32.Parse(today2[1]);
        int day = Int32.Parse(today2[2]);

        int total = (year * 12 * 28) + (month * 28) + day;

        List<int> answer = new List<int>();

        for (int i = 0; i < privacies.Length; i++)
        {
            string[] splitPrivacies = privacies[i].Split(' ');

            int temp = 0;
            for (int j = 0; j < terms.Length; j++)
            {
                string[] splitTerm = terms[j].Split(' ');

                if (splitPrivacies[1].Equals(splitTerm[0]))
                    temp = Int32.Parse(splitTerm[1]);
            }

            string[] splitDate = splitPrivacies[0].Split('.');
            int year2 = Int32.Parse(splitDate[0]);
            int month2 = Int32.Parse(splitDate[1]);
            int day2 = Int32.Parse(splitDate[2]);

            month2 += temp;

            int total2 = (year2 * 12 * 28) + (month2 * 28) + day2;

            if (total >= total2)
            {
                answer.Add(i + 1);
            }
        }

        return answer.ToArray();
    }
}