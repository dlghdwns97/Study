using System.Linq;

public class Solution {
    public int[] solution(long n) {
        int[] answer = new int[] {};
        
        answer = n.ToString().Select(x => int.Parse(x.ToString())).Reverse().ToArray();
        
        return answer;
    }
}