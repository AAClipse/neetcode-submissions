public class Solution {
    public int[] TopKFrequent(int[] nums, int k) 
    {
        Span<int> faced = stackalloc int[2001];

        for (int i = 0; i < nums.Length; i++)
        {
            faced[nums[i] + 1000]++; // подсчет каждой цифры в стеке
        }

        List<int>[] bucket = new List<int>[nums.Length + 1]; // создаем массив листов чтобы по колличеству каждой цифры из faced загружать в этот индекс числа в лист который там лежит

        for (int i = 0; i < faced.Length; i++) // проходим по массиву с подсчитанным колличеством
        {   
            if (faced[i] > 0) // если есть хотяб одно число
            {
                if (bucket[faced[i]] == null) bucket[faced[i]] = new List<int>(); // проверка на инициализированный лист

                bucket[faced[i]].Add(i - 1000);
            }
        }

        int[] answer = new int[k];
        int counter = 0;

        for (int i = bucket.Length - 1; i > 0; i--)
        {
            if (bucket[i] != null)
            {
                foreach (int num in bucket[i])
                {
                    answer[counter] = num;
                    counter++;

                    if (counter == k) return answer;
                }
            }
        }
        return answer;

    }
}
