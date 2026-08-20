public class Solution {
    public int MaxProfit(int[] prices) 
    {
        if (prices.Length == 0)
        {
            return 0;
        }
        else
        {
            int left = 0;
            int right = 1;
            int max = 0;
            while (right < prices.Length && left < prices.Length - 1)
            {
                if (prices[left] > prices[right])
                {
                    left = right;
                    right++;
                }
                else
                {
                    int profit = prices[right] - prices[left];
                    if (profit > max) max = profit;
                    right++;
                }
            }
            return max;
        }
    }
}
