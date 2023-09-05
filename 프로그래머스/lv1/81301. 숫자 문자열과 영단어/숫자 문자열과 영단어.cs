using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        char[] s_array = s.ToCharArray();
        string temp = "";
        string digit = "";
        int i = 0;
        
        while (i < s.Length)
        {
            bool isDigit = Char.IsNumber(s, i);
            if (isDigit == true)
            {
                temp = "";
                digit += s_array[i];
                i++;
            }
            else
            {
                temp += s_array[i];
                i++;
            }
            
            if (temp.Length == 3)
            {
                switch (temp)
                {
                    case "zer":
                        digit += "0";
                        i++;
                        break;
                    case "one":
                        digit += "1";
                        break;
                    case "two":
                        digit += "2";
                        break;
                    case "thr":
                        digit += "3";
                        i += 2;
                        break;
                    case "fou":
                        digit += "4";
                        i++;
                        break;
                    case "fiv":
                        digit += "5";
                        i++;
                        break;
                    case "six":
                        digit += "6";
                        break;
                    case "sev":
                        digit += "7";
                        i += 2;
                        break;
                    case "eig":
                        digit += "8";
                        i += 2;
                        break;
                    case "nin":
                        digit += "9";
                        i++;
                        break;
                }
                temp = "";
            }
        }
        answer = Int32.Parse(digit);
        return answer;
    }
}