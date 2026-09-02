public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        // Железное правило: первый массив должен быть меньше или равен второму
        if (nums1.Length > nums2.Length) {
            return FindMedianSortedArrays(nums2, nums1);
        }

        int m = nums1.Length;
        int n = nums2.Length;
        
        int left1 = 0;
        int right1 = m; // Ищем до полной длины массива включительно

        while (left1 <= right1) {
            int mid = left1 + (right1 - left1) / 2;
            // Используем формулу с (+1), чтобы при нечетном количестве 
            // медиана гарантированно оставалась в левой части
            int j = (m + n + 1) / 2 - mid;

            // Затыкаем дыры бесконечностями, если разрез ушел в край
            int l1 = (mid == 0) ? int.MinValue : nums1[mid - 1];
            int r1 = (mid == m) ? int.MaxValue : nums1[mid];

            int l2 = (j == 0) ? int.MinValue : nums2[j - 1];
            int r2 = (j == n) ? int.MaxValue : nums2[j];

            // Проверка крест-накрест
            if (l1 <= r2 && l2 <= r1) {
                // Если общее количество элементов ЧЁТНОЕ
                if ((m + n) % 2 == 0) {
                    return (Math.Max(l1, l2) + Math.Min(r1, r2)) / 2.0;
                } 
                // Если НЕЧЁТНОЕ (медиана слева, так как в формуле j есть +1)
                else {
                    return Math.Max(l1, l2);
                }
            } 
            // Взяли слишком много из первого массива — двигаем right влево
            else if (l1 > r2) {
                right1 = mid - 1;
            } 
            // Взяли слишком мало из первого массива — двигаем left вправо
            else {
                left1 = mid + 1;
            }
        }

        return 0.0;
    }
}
