using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long n = 0;
        for (int i = 0; i < count + 1; i++)
        {
            n += i;
        }
        long sum = price * n;
        if (money - sum < 0)
        {
            return (sum - money);
        }
        else return 0;
    }
}