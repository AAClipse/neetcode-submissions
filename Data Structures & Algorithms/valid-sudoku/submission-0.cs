public class Solution {
    public bool IsValidSudoku(char[][] board) 
    {
        bool[,] rows = new bool[9, 10];
        bool[,] cols = new bool[9, 10];
        bool[,] boxes = new bool[9, 10];

        for(int r = 0; r < 9; r++)
        {
            for (int c = 0; c < 9; c++)
            {
                if (board[r][c] == '.') continue;

                int current = board[r][c] - '0';
                int boxNum = (r / 3) * 3 + (c / 3);

                if (rows[r, current] || cols[c, current] || boxes[boxNum, current]) return false;

                rows[r, current] = true;
                cols[c, current] = true;
                boxes[boxNum, current] = true;
            }
        }
        return true;
    }
}
