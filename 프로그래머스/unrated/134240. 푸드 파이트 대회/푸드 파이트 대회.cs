using System;

public class Solution {
    public string solution(int[] food) {
        string answer = "";
        string half = "";
        int foodcount = 0;
            
        for (int i = 1; i < food.Length; i++)
        {
            foodcount = food[i] / 2;
            if (foodcount == 0) {}
            else
            {
                for (int j = 0; j < foodcount; j++)
                {
                    half += i.ToString();
                }
            }
        }
        char[] charhalf = half.ToCharArray();
        Array.Reverse(charhalf);
        string reversehalf = new string(charhalf);
        
        answer = half + "0" + reversehalf;
        return answer;
    }
}