using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(string[] id_list, string[] report, int k) {
        
        Dictionary<string, int> mailedCount = new Dictionary<string, int>();
        Dictionary<string, int> reportedCount = new Dictionary<string, int>();
        Dictionary<string, List<string>> reportId = new Dictionary<string, List<string>>();
        
        for (int i = 0; i < id_list.Length; i++)
        {
            mailedCount.Add(id_list[i], 0);
            reportedCount.Add(id_list[i], 0);
            reportId.Add(id_list[i], new List<string>());
        }

        for(int i = 0; i < report.Length; i++)
        {
            string[] splitReport = report[i].Split(' ');

            if (!reportId[splitReport[1]].Contains(splitReport[0]))
            {
                reportId[splitReport[1]].Add(splitReport[0]);
                reportedCount[splitReport[1]]++;
            }
        }
        
        foreach (KeyValuePair<string, int> item in reportedCount)
        {
            if (item.Value >= k)
            {
                for(int j = 0; j < reportId[item.Key].Count; j++)
                {
                    mailedCount[reportId[item.Key][j]]++;
                }
            }
        }            
            
        /* if (reportedCount[splitReport[1]] == k)
            {
                for(int j = 0; j < reportId[splitReport[1]].Count; j++)
                {
                    mailedCount[reportId[splitReport[1]][j]]++;
                }
            } */
        
        return mailedCount.Values.ToArray();
    }
}