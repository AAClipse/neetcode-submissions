class Solution:
    def searchMatrix(self, matrix: List[List[int]], target: int) -> bool:
        left = 0
        right = len(matrix) * len(matrix[0]) - 1
        while left <= right:
            mid = left + (int)((right - left) / 2)
            row = (int)(mid / len(matrix[0]))
            col = (int)(mid % len(matrix[0]))
            if matrix[row][col] == target:
                return True
            elif  matrix[row][col] < target:
                left = mid + 1
            else:
                right = mid - 1
        return False

            
        