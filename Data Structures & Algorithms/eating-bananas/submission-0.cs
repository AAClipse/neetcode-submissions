public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int left = 1;
        int right = 1000000000;
        while (left < right){
            int mid = left + (right - left) / 2;
            long sum = 0;
            for (int i = 0; i < piles.Length; i++)
            {
                if (piles[i] % mid != 0) sum += piles[i] / mid + 1;
                else sum += piles[i] / mid;
            }
            if (sum <= h) right = mid;
            else left = mid + 1;
        }
        return left;
    }
}
