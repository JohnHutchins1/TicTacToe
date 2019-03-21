/*
 * @Author: John Hutchins
 * Last Edit: 2-14-19
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    /// <summary>
    /// this class handles all of the row and winning calculations and form1 Handles UI.
    /// </summary>
    class clsTicTacToe
    {
        /// <summary>
        /// Boolean used to check what player turn it is. True = player 1, False = Player 2
        /// </summary>
        private bool playerTurn;
        /// <summary>
        /// Reference to the game board object in form1
        /// </summary>
        public string[,] saBoard;
        /// <summary>
        /// Counts the number player 1 has won.
        /// </summary>
        private int iPlayer1Wins;
        /// <summary>
        /// Counts the numcer player 2 has won
        /// </summary>
        private int iPlayer2Wins;
        /// <summary>
        /// Hold the number of ties.
        /// </summary>
        private int iTies;
        /// <summary>
        /// String that holds a value the tells what winning move was made.
        /// 'Row1', 'Row2', 'Row3', 'Col1', 'Col2', 'Col3', 'Diag1', and 'Diag2'
        /// These values are thrown through a switch statement to highlight correct tiles.
        /// </summary>
        private string winningMove;
        
        /// <summary>
        /// constructor
        /// </summary>
        public clsTicTacToe()
        {
           
        }

        /// <summary>
        /// Changes the player turn by flipping the boolean.
        /// </summary>
        public void ChangeTurns()
        {
            //if it's true (player 1's turn) then change it to false (player 2's turn)
            if (playerTurn)
            {
                playerTurn = false;
            }
            else
            {
                playerTurn = true;
            }
        }

        /// <summary>
        /// checks if there is a diagonal, vertical, or horizontal winning move made -- returns false if not.
        /// </summary>
        /// <returns>false if no winning move has been made, true of a player just made a winning move.</returns>
        public bool IsWinningMove()
        {
            if (IsDiagonalWin())
            {
                return true;
            }
            else if (IsVertWin())
            {
                return true;
            }
            else if (IsHorzWin())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// checks the indexes of saBoard for all possible diagonal wins and if it has succeeded,
        /// It then will check which player won and adds 1 to their score -- returns false of unsuccesful.
        /// </summary>
        /// <returns>false if no diagonal win, true if a diagonal win occured</returns>
        private bool IsDiagonalWin()
        {
            if ((saBoard[0, 0] == "X" && saBoard[1, 1] == "X" && saBoard[2, 2] == "X") || (saBoard[0, 0] == "O" && saBoard[1, 1] == "O" && saBoard[2, 2] == "O"))
            {
                if (saBoard[0, 0] == "X")
                {
                    iPlayer1Wins++;
                }
                else
                {
                    iPlayer2Wins++;
                }
                winningMove = "Diag1";
                return true;

            }
            else if ((saBoard[0, 2] == "X" && saBoard[1, 1] == "X" && saBoard[2, 0] == "X") || (saBoard[0, 2] == "O" && saBoard[1, 1] == "O" && saBoard[2, 0] == "O"))
            {
                if (saBoard[0, 2] == "X")
                {
                    iPlayer1Wins++;
                }
                else
                {
                    iPlayer2Wins++;
                }
                winningMove = "Diag2";
                return true;

            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// checks the indexes of saBoard for all possible vertical wins and if it has succeeded,
        /// It then will check which player won and adds 1 to their score -- returns false of unsuccesful.
        /// </summary>
        /// <returns>false if no vertical win, true if a vertical win occured</returns>
        private bool IsVertWin()
        {
            if ((saBoard[0, 0] == "X" && saBoard[1, 0] == "X" && saBoard[2, 0] == "X") || (saBoard[0, 0] == "O" && saBoard[1, 0] == "O" && saBoard[2, 0] == "O"))
            {
                if (saBoard[0, 0] == "X")
                {
                    iPlayer1Wins++;
                }
                else
                {
                    iPlayer2Wins++;
                }
                winningMove = "Col1";
                return true;

            }
            else if ((saBoard[0, 1] == "X" && saBoard[1, 1] == "X" && saBoard[2, 1] == "X") || (saBoard[0, 1] == "O" && saBoard[1, 1] == "O" && saBoard[2, 1] == "O"))
            {
                if (saBoard[0, 1] == "X")
                {
                    iPlayer1Wins++;
                }
                else
                {
                    iPlayer2Wins++;
                }
                winningMove = "Col2";
                return true;

            }
            else if ((saBoard[0, 2] == "X" && saBoard[1, 2] == "X" && saBoard[2, 2] == "X") || (saBoard[0, 2] == "O" && saBoard[1, 2] == "O" && saBoard[2, 2] == "O"))
            {
                if (saBoard[0, 2] == "X")
                {
                    iPlayer1Wins++;
                }
                else
                {
                    iPlayer2Wins++;
                }
                winningMove = "Col3";
                return true;

            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// checks the indexes of saBoard for all possible horizontal wins and if it has succeeded,
        /// It then will check which player won and adds 1 to their score -- returns false of unsuccesful.
        /// </summary>
        /// <returns>false if no horizontal win, true if a horizontal win occured</returns>
        private bool IsHorzWin()
        {
            if ((saBoard[0, 0] == "X" && saBoard[0, 1] == "X" && saBoard[0, 2] == "X") || (saBoard[0, 0] == "O" && saBoard[0, 1] == "O" && saBoard[0, 2] == "O"))
            {
                if (saBoard[0, 0] == "X")
                {
                    iPlayer1Wins++;
                }
                else
                {
                    iPlayer2Wins++;
                }
                winningMove = "Row1";
                return true;

            }
            else if ((saBoard[1, 0] == "X" && saBoard[1, 1] == "X" && saBoard[1, 2] == "X") || (saBoard[1, 0] == "O" && saBoard[1, 1] == "O" && saBoard[1, 2] == "O"))
            {
                if (saBoard[1, 0] == "X")
                {
                    iPlayer1Wins++;
                }
                else
                {
                    iPlayer2Wins++;
                }
                winningMove = "Row2";
                return true;

            }
            else if ((saBoard[2, 0] == "X" && saBoard[2, 1] == "X" && saBoard[2, 2] == "X") || (saBoard[2, 0] == "O" && saBoard[2, 1] == "O" && saBoard[2, 2] == "O"))
            {
                if (saBoard[2, 0] == "X")
                {
                    iPlayer1Wins++;
                }
                else
                {
                    iPlayer2Wins++;
                }
                winningMove = "Row3";
                return true;

            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// loops through the saBoard to see if the array has any empty positions, 
        /// sets the fillArray boolean to false if a "" is found.
        /// </summary>
        /// <returns>false if not a tie, true if a tie has occured</returns>
        public bool IsTie()
        {
            /// <summary>
            /// Used to check if the array isn't fully filled up.
            /// </summary>
            bool fullArray = true;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (saBoard[i, j] == "")
                    {
                        fullArray = false;

                    }

                }
            }
            //if the array is full (true), then it was a tie and returns true
            if (fullArray)
            {
                iTies++;
                return true;
                
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// As X always goes first in TicTacToe, this resets the first player as X.
        /// </summary>
        public void SetPlayerTurn()
        {
            playerTurn = true;
        }

        /// <summary>
        /// This will get the players turn -- true = player 1, false =  player 2
        /// </summary>
        /// <returns> players 1 or 2's turn</returns>
        public bool GetPlayerTurn()
        {
            return playerTurn;
        }

        /// <summary>
        /// Getter used to get value of p1's turn
        /// </summary>
        /// <returns>Num of player 1's wins</returns>
        public int GetPlayer1Wins()
        {
            return iPlayer1Wins;
        }

        /// <summary>
        /// Getter used to get value of p2's turn
        /// </summary>
        /// <returns>Num of player 2's wins</returns>
        public int GetPlayer2Wins()
        {
            return iPlayer2Wins;
        }

        /// <summary>
        /// Getter used to get number of ties
        /// </summary>
        /// <returns>Number of ties</returns>
        public int GetTies()
        {
            return iTies;
        }
        
        /// <summary>
        /// Getter that returns the winning move which is used to highlight winners labels
        /// </summary>
        /// <returns>String that contains the winning move</returns>
        public string GetWinningMove()
        {
            return winningMove;
        }
    }
}