using System;

public class Solution {
    public string solution(string[] seoul) {
        string answer = "";
        
        int indexKim = Array.IndexOf(seoul, "Kim");
        
        answer = "김서방은 " + indexKim + "에 있다";
        
        return answer;
    }
}