using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*Determine if a 9 x 9 Sudoku board is valid. Only the filled cells need to be validated according to the following rules:

Each row must contain the digits 1-9 without repetition.
Each column must contain the digits 1-9 without repetition.
Each of the nine 3 x 3 sub-boxes of the grid must contain the digits 1-9 without repetition.
Note:

A Sudoku board (partially filled) could be valid but is not necessarily solvable.
Only the filled cells need to be validated according to the mentioned rules.
 

Example 1:


Input: board = 
[["5","3",".",".","7",".",".",".","."]
,["6",".",".","1","9","5",".",".","."]
,[".","9","8",".",".",".",".","6","."]
,["8",".",".",".","6",".",".",".","3"]
,["4",".",".","8",".","3",".",".","1"]
,["7",".",".",".","2",".",".",".","6"]
,[".","6",".",".",".",".","2","8","."]
,[".",".",".","4","1","9",".",".","5"]
,[".",".",".",".","8",".",".","7","9"]]
Output: true
Example 2:

Input: board = 
[["8","3",".",".","7",".",".",".","."]
,["6",".",".","1","9","5",".",".","."]
,[".","9","8",".",".",".",".","6","."]
,["8",".",".",".","6",".",".",".","3"]
,["4",".",".","8",".","3",".",".","1"]
,["7",".",".",".","2",".",".",".","6"]
,[".","6",".",".",".",".","2","8","."]
,[".",".",".","4","1","9",".",".","5"]
,[".",".",".",".","8",".",".","7","9"]]
Output: false
Explanation: Same as Example 1, except with the 5 in the top left corner being modified to 8. Since there are two 8's in the top left 3x3 sub-box, it is invalid.
 

Constraints:

board.length == 9
board[i].length == 9
board[i][j] is a digit 1-9 or '.'.*/
namespace HashTable
{
    public class ValidSudoku
    {
        public bool IsValidSudoku(char[][] board)
        {
            Dictionary<string, IList<char>> dict = new Dictionary<string, IList<char>>();
            int count = 0;
            for (int i = 0; i < board.Length; i++)
            {
                if (i >= 0 && i < 3)
                {
                    count = 0;

                }
                else if (i > 2 && i < 6)
                {
                    count = 3;
                }
                else if (i > 6)
                {
                    count = 6;
                }
                dict["vertical"] = new List<char>();
                dict["horizontal"] = new List<char>();
                for (int j = 0; j < board.Length; j++)
                {
                    if (j % 3 == 0)
                    {
                        count++;
                    }
                    if (dict["vertical"].Contains(board[j][i]) && board[j][i] != '.')
                    {
                        return false;
                    }
                    if (dict["horizontal"].Contains(board[i][j]) && board[i][j] != '.')
                    {
                        return false;
                    }
                    dict["vertical"].Add(board[j][i]);
                    dict["horizontal"].Add(board[i][j]);
                    if (!dict.ContainsKey("group" + count))
                    {
                        dict["group" + count] = new List<char>();
                    }

                    if (dict["group" + count].Contains(board[i][j]) && board[i][j] != '.')
                    {

                        return false;
                    }

                    dict["group" + count].Add(board[i][j]);
                }

            }

            return true;
        }

        /*Improve Time and Space by Brad AI
public class Solution {
    public bool IsValidSudoku(char[][] board) {
        // Check the validity of each row.
        for (int i = 0; i < 9; i++)
        {
            List<char> row = new List<char>();
            for (int j = 0; j < 9; j++)
            {
                if (board[i][j] != '.')
                {
                    if (row.Contains(board[i][j]))
                    {
                        return false;
                    }
                    else
                    {
                        row.Add(board[i][j]);
                    }
                }
            }
        }

        // Check the validity of each column.
        for (int i = 0; i < 9; i++)
        {
            List<char> column = new List<char>();
            for (int j = 0; j < 9; j++)
            {
                if (board[j][i] != '.')
                {
                    if (column.Contains(board[j][i]))
                    {
                        return false;
                    }
                    else
                    {
                        column.Add(board[j][i]);
                    }
                }
            }
        }

        // Check the validity of each 3x3 sub-box.
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                List<char> subBox = new List<char>();
                for (int k = 0; k < 3; k++)
                {
                    for (int l = 0; l < 3; l++)
                    {
                        if (board[i * 3 + k][j * 3 + l] != '.')
                        {
                            if (subBox.Contains(board[i * 3 + k][j * 3 + l]))
                            {
                                return false;
                            }
                            else
                            {
                                subBox.Add(board[i * 3 + k][j * 3 + l]);
                            }
                        }
                    }
                }
            }
        }

        return true;
    }
}*/


    }
}