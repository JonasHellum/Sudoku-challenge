namespace SudokuChallenge;

public class Sudoku
{
    public bool IsValidSudoku(char[][] board)
    {
        HashSet<string> letter = new HashSet<string>();

        for (int row = 0; row < 9; row++)
        {
            for (int col = 0; col < 9; col++)
            {
                if (board[row][col] != '.')
                {
                    string cellRow = "Row: " + (row + 1) + ", number: " + board[row][col];
                    string cellCol = "Column: " + (col + 1) + ", number: " + board[row][col];
                    string cellBox = "Box: " + (row/3 + 1) + "," + (col/3 + 1) + ", number: " + board[row][col];
                    
                    /*
                    Console.WriteLine(cellRow);
                    Console.WriteLine(cellCol);
                    Console.WriteLine(cellBox);
                    Console.WriteLine();
                    */
                    
                    
                    if (!letter.Add(cellRow) ||
                        !letter.Add(cellCol) ||
                        !letter.Add(cellBox))
                    {
                        return false;
                    }
                }
            }
        }

        return true;
    }
}