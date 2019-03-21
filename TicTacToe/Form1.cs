/*
 * @author: John Hutchins
 * Last Edit: 2-14-2019
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// References our class that does all of the calulations for winning
        /// </summary>
        clsTicTacToe clsTicTac;
        /// <summary>
        /// Controls when a user can click on our label through the submit button
        /// </summary>
        bool bIsGameStarted;
        /// <summary>
        /// this is our game board which is a 3x3 multidimensional represents a real-life tictactoe board.
        /// </summary>
        private string[,] saBoard;

        /// <summary>
        /// initializes form, instantiates a new TicTacToe board, and intializes bIsGameStarted to false
        /// </summary>
        public Form1()
        {   
            InitializeComponent();
            clsTicTac = new clsTicTacToe();
            bIsGameStarted = false;
        }

        /// <summary>
        /// When clicked, allows for the game board to be clicked.
        /// Instanciates a new object for our game board when Start game is clicked and initialized with ""
        /// Calls methods to reset the colors and labels and then disables the start game button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartGameButton_Click(object sender, EventArgs e)
        {
            //starting game
            bIsGameStarted = true;
            clsTicTac.SetPlayerTurn();
            ClearLabels();
            ResetColors();

            //I instantiate a new game board so that the garbage collector will take all old game board objects
            //We create a new object each time we start a new game. Make resetting board a whole lot easier.
            saBoard = new string[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    saBoard[i, j] = "";
                }
            }

            //clsTicTac is set to reference the newly created game board object above. Important they are the same object.
            clsTicTac.saBoard = saBoard;
            StartGameButton.Enabled = false;
        }
        
        /// <summary>
        /// All 9 square are controlled from this method!! When clicked, it will pass the label object to this method
        /// to be marked. Also updates the rich text box on turns. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Space_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// This is a generic label variable. This could be any of the 9 labels clicked on and passed through.
            /// </summary>
            Label MyLabel = (Label)sender;
            if (bIsGameStarted && MyLabel.Text == "")
            {
                if (clsTicTac.GetPlayerTurn()) //If this is true, then its player 1's turn.
                {
                    //changes the 'x' to red and and makes the given label then updates the rich text box
                    MyLabel.ForeColor = System.Drawing.Color.Red;
                    MyLabel.Text = "X";
                    //Parses the tag to get the index of the array
                    TagToIndexConvertor(MyLabel.Tag.ToString(), "X");
                    gameStatusRTB.Text = "Player 2's turn";
                }
                else
                {
                    //changes the 'o' to blue and and makes the given label then updates the rich text box
                    MyLabel.ForeColor = System.Drawing.Color.Blue;
                    MyLabel.Text = "O";
                    //Parses the tag to get the index of the array
                    TagToIndexConvertor(MyLabel.Tag.ToString(), "O");
                    gameStatusRTB.Text = "Player 1's turn";
                }

                //checks if a winning move has been made
                if (clsTicTac.IsWinningMove() )
                {
                    DisplayScores();
                    HighlightWinningMove(clsTicTac.GetWinningMove());
                    bIsGameStarted = false;
                    StartGameButton.Enabled = true; 
                    if (clsTicTac.GetPlayerTurn())
                    {
                        gameStatusRTB.Text = "Player 1 won!";
                    }else
                    {
                        gameStatusRTB.Text = "Player 2 won!";
                    }
                //checks if a tie has been made then updates accordingly
                }else if (clsTicTac.IsTie())
                {
                    DisplayScores();
                    StartGameButton.Enabled = true;
                    gameStatusRTB.Text = "Player 1 and Player 2 tie!";
                }
                //changes turns if nothing of significance has happened.
                clsTicTac.ChangeTurns();
            }
        }

        /// <summary>
        /// Updates the Game scores
        /// </summary>
        private void DisplayScores()
        {
            numOfP1WinsLbl.Text = "" + clsTicTac.GetPlayer1Wins();
            numOfP2WinsLbl.Text = "" + clsTicTac.GetPlayer2Wins();
            numOfCatsLbl.Text = "" + clsTicTac.GetTies();
        }

        /// <summary>
        /// uses a switch to update all of the colors of the winning move.
        /// The winning move value is called in space_click and passed here and is only reference.
        /// </summary>
        /// <param name="highlightMove"></param>
        private void HighlightWinningMove(string highlightMove)
        {
            switch (highlightMove)
            {
                case "Row1":
                    topLeftLbl.BackColor = Color.Gold;
                    topMiddleLbl.BackColor = Color.Gold;
                    topRightLbl.BackColor = Color.Gold;
                    break;
                case "Row2":
                    middleLeftLbl.BackColor = Color.Gold;
                    middleMiddleLbl.BackColor = Color.Gold;
                    middleRightLbl.BackColor = Color.Gold;
                    break;
                case "Row3":
                    bottomLeftLbl.BackColor = Color.Gold;
                    bottonMiddleLbl.BackColor = Color.Gold;
                    bottomRightLbl.BackColor = Color.Gold;
                    break;
                case "Col1":
                    topLeftLbl.BackColor = Color.Gold;
                    middleLeftLbl.BackColor = Color.Gold;
                    bottomLeftLbl.BackColor = Color.Gold;
                    break;
                case "Col2":
                    topMiddleLbl.BackColor = Color.Gold;
                    middleMiddleLbl.BackColor = Color.Gold;
                    bottonMiddleLbl.BackColor = Color.Gold;
                    break;
                case "Col3":
                    topRightLbl.BackColor = Color.Gold;
                    middleRightLbl.BackColor = Color.Gold;
                    bottomRightLbl.BackColor = Color.Gold;
                    break;
                case "Diag1":
                    topLeftLbl.BackColor = Color.Gold;
                    middleMiddleLbl.BackColor = Color.Gold;
                    bottomRightLbl.BackColor = Color.Gold;
                    break;
                case "Diag2":
                    topRightLbl.BackColor = Color.Gold;
                    middleMiddleLbl.BackColor = Color.Gold;
                    bottomLeftLbl.BackColor = Color.Gold;
                    break;
                default:
                    //could also call this on a cat and default could turn all tiles red?
                    break;
            }
            
        }

        /// <summary>
        /// resets all of the label -- i.e clears all of the player marks
        /// </summary>
        private void ClearLabels()
        {
            topLeftLbl.Text = "";
            topMiddleLbl.Text = "";
            topRightLbl.Text = "";

            middleLeftLbl.Text = "";
            middleMiddleLbl.Text = "";
            middleRightLbl.Text = "";

            bottomLeftLbl.Text = "";
            bottonMiddleLbl.Text = "";
            bottomRightLbl.Text = "";

            gameStatusRTB.Text = "Player 1's turn";
        }

        /// <summary>
        /// resets all of the background colors (Colors.Gold) from the win highlight to Color.Gray
        /// </summary>
        private void ResetColors()
        {
            topLeftLbl.BackColor = Color.Gray;
            topMiddleLbl.BackColor = Color.Gray;
            topRightLbl.BackColor = Color.Gray;

            middleLeftLbl.BackColor = Color.Gray;
            middleMiddleLbl.BackColor = Color.Gray;
            middleRightLbl.BackColor = Color.Gray;

            bottomLeftLbl.BackColor = Color.Gray;
            bottonMiddleLbl.BackColor = Color.Gray;
            bottomRightLbl.BackColor = Color.Gray;
        }

        /// <summary>
        /// Uses an Int32.TryParse to parse the tag value of the labels.
        /// Implements the Substring to get the indexes for the multiD Array
        /// Places the marker in the game board array.
        /// </summary>
        /// <param name="labelTag"></param>
        /// <param name="marker"></param>
        private void TagToIndexConvertor(string labelTag, string marker)
        {
            Int32.TryParse(labelTag.Substring(0, 1), out int i);
            Int32.TryParse(labelTag.Substring(1, 1), out int j);

            saBoard[i, j] = marker;
        }
    }
}

