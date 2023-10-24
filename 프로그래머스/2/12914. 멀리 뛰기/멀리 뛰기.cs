public class Solution {
    public long solution(int n) {
        long answer = 0;
        long x = 1;
        long y = 1;
	    long temp = 0;
        
	    if (n == 1) answer = 1;
        else
        {
            for (int i = 2; i <= n; i++)
            {
		        temp = (x + y) % 1234567;
		        x = y;
		        y = temp;
	        }	   
        }
        
	    return answer = y % 1234567;
    }
}