public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) 
    {
        if (position.Length == 0) return 0;
        int[] sortedPositions = (int[])position.Clone();
        int[] sortedSpeeds = (int[])speed.Clone(); 

        Array.Sort(sortedPositions, sortedSpeeds);
        Array.Reverse(sortedPositions);
        Array.Reverse(sortedSpeeds);

        double slowest = (target - sortedPositions[0]) / (double)sortedSpeeds[0];
        int fleets = 1;

        for (int i = 1; i < position.Length; i++)
        {
            if ((target - sortedPositions[i]) / (double)sortedSpeeds[i] > slowest)
            {
                fleets++;
                slowest = (target - sortedPositions[i]) / (double)sortedSpeeds[i];
            }
        }
        return fleets;
    }
}
