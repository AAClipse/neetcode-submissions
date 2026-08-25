public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) 
    {
        var max = new int[nums.Length - k + 1];
        var heap = new PriorityQueue<int, int>();
        for (int i = 0; i < k; i++)
        {
            heap.Enqueue(i, -nums[i]);
        }
        max[0] = nums[heap.Peek()];


        for (int right = k; right < nums.Length; right++)
        {  
            heap.Enqueue(right, -nums[right]);
            while (heap.Peek() < right - k + 1)
            {
                heap.Dequeue();
            }
            max[right - k + 1] = nums[heap.Peek()];
        }
        return max;
    }
}
