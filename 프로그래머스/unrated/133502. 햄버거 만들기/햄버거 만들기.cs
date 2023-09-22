/* using System;

public class Solution {
    public int solution(int[] ingredient) {
        int answer = 0;
        int temp = 0;
        string ingredi = String.Join(String.Empty, ingredient);
        
        while (temp >= 0)
        {
            temp = ingredi.IndexOf("1231", 0, ingredi.Length);
            if (temp != -1)
            {
                ingredi = ingredi.Remove(temp, 4);
                answer++;
            }
            else
            {
                break;
            }
        }
        
        return answer;
    }
} */
using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] ingredient) {
        int answer = 0;
        List<int> list = new List<int>();
        
        foreach(int burger in ingredient)
        {
            list.Add(burger);
            
            if(list.Count >= 4)
            {           
                if(list[list.Count - 4] == 1 && list[list.Count - 3] == 2 && list[list.Count - 2] == 3 && list[list.Count - 1] == 1)
                {
                    answer++;
                    list.RemoveRange(list.Count - 4, 4);
                }
            }
        }
        return answer;
    }
}