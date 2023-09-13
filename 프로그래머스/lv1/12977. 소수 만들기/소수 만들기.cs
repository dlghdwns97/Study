using System;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;
        int temp = 0;
        bool isRight = true;

        for (int i = 0; i < nums.Length - 2; i++)
        {
            for (int j = i + 1; j < nums.Length - 1; j++)
            {
                for (int k = j + 1; k < nums.Length; k++)
                {
                    temp = nums[i] + nums[j] + nums[k];
                    isRight = true;
                    for (int x = 2; x < temp; x++)
                    {
                        if (temp % x == 0)
                        {
                            isRight = false;
                            break;
                        }
                        else {}
                    }
                    if (isRight == true)
                    {
                        answer++;
                    }
                    temp = 0;
                }
            }
        }

        return answer;
    }
}