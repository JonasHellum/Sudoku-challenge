﻿using System.Text;

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
        
        Sudoku sudoku = new Sudoku();
        bool isValid = sudoku.IsValidSudoku(board);
        Console.WriteLine("Valid: " + isValid);
    }
    
    
}