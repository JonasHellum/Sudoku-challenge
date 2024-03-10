using System.Text;

namespace SudokuChallenge;

class Program
{
    static void Main(string[] args)
    {
        char[][] board = 
            
            [['5','3','.','.','7','.','.','.','.']
            ,['6','.','.','1','9','5','.','.','.']
            ,['.','9','8','.','.','.','.','6','.']
            ,['8','.','.','.','6','.','.','.','3']
            ,['4','.','.','8','.','3','.','.','1']
            ,['7','.','.','.','2','.','.','.','6']
            ,['.','6','.','.','.','.','2','8','.']
            ,['.','.','.','4','1','9','.','.','5']
            ,['.','.','.','.','8','.','.','7','9']];
        
        bool isValid = IsValidSudoku(board);
        Console.WriteLine("Valid: " + isValid);
    }
    
    static bool IsValidSudoku(char[][] board)
    {
        HashSet<string> letter = new HashSet<string>();

        for (int row = 0; row < 9; row++)
        {
            for (int col = 0; col < 9; col++)
            {
                if (board[row][col] != '.')
                {
                    string cellRow = "Row: " + row + ", number: " + board[row][col];
                    string cellCol = "Column: " + col + ", number: " + board[row][col];
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