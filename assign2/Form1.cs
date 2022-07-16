using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Need to include to use threading
using System.Threading;

namespace assign2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Attributes

        /// <summary>
        /// Needed for games, wins, and losses
        /// </summary>
        public int iNumOfGames = 0;
        public int iNumOfWins = 0;
        public int iNumOfLoss = 0;

        /// <summary>
        /// the amount of frequency each number shows up
        /// </summary>
        private int iFrequency1 = 0;
        private int iFrequency2 = 0;
        private int iFrequency3 = 0;
        private int iFrequency4 = 0;
        private int iFrequency5 = 0;
        private int iFrequency6 = 0;

        /// <summary>
        /// the percentage for each number
        /// </summary>
        private double dPercentage1 = 0; 
        private double dPercentage2 = 0; 
        private double dPercentage3 = 0; 
        private double dPercentage4 = 0; 
        private double dPercentage5 = 0; 
        private double dPercentage6 = 0;

        /// <summary>
        /// the total amount of guesses for each number
        /// </summary>
        private int iTotalGuess1 = 0;
        private int iTotalGuess2 = 0;
        private int iTotalGuess3 = 0;
        private int iTotalGuess4 = 0;
        private int iTotalGuess5 = 0;
        private int iTotalGuess6 = 0;

        private int iRandomNum;

        #endregion


        /// <summary>
        /// the guess the user input
        /// </summary>
        private int iUserNumGuess;

        ///
        ///Create a random number object
        ///
        Random rndNumber = new Random();
        

        /// <summary>
        /// This method resets all the values back to 0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetButton_Click(object sender, EventArgs e)
        {
            iNumOfGames = 0;
            iNumOfWins = 0;
            iNumOfLoss = 0;

            iFrequency1 = 0;
            iFrequency2 = 0;
            iFrequency3 = 0;
            iFrequency4 = 0;
            iFrequency5 = 0;
            iFrequency6 = 0;

            iTotalGuess1 = 0;
            iTotalGuess2 = 0;
            iTotalGuess3 = 0;
            iTotalGuess4 = 0;
            iTotalGuess5 = 0;
            iTotalGuess6 = 0;

            dPercentage1 = 0;
            dPercentage2 = 0;
            dPercentage3 = 0;
            dPercentage4 = 0;
            dPercentage5 = 0;
            dPercentage6 = 0;

            lblWon.Text = "Number of Times Won: " + iNumOfWins.ToString();
            lblLoss.Text = "Number of Times Lost: " + iNumOfLoss.ToString();
            lblPlayed.Text = "Number of Times Played: " + iNumOfGames.ToString();
            ResultsOfDice.Text = "Face\t" + "Freq\t" + "Percemt\t" + "Number of Guesses\n"
                                + "  1\t  " + iFrequency1 + "  \t  " + dPercentage1 + "%\t\t" + iTotalGuess1 + "\n"
                                + "  2\t  " + iFrequency2 + "  \t  " + dPercentage2 + "%\t\t" + iTotalGuess2 + "\n"
                                + "  3\t  " + iFrequency3 + "  \t  " + dPercentage3 + "%\t\t" + iTotalGuess3 + "\n"
                                + "  4\t  " + iFrequency4 + "  \t  " + dPercentage4 + "%\t\t" + iTotalGuess4 + "\n"
                                + "  5\t  " + iFrequency5 + "  \t  " + dPercentage5 + "%\t\t" + iTotalGuess5 + "\n"
                                + "  6\t  " + iFrequency6 + "  \t  " + dPercentage6 + "%\t\t" + iTotalGuess6;
        }

        /// <summary>
        /// This method creates a random number and checks if it matches the user guess
        /// it checks to make sure the number inputted is 1-6
        /// tallys the number of guess, frequency, and percentage
        /// also display the picture of a dice roll
        /// </summary>
        private void rollButton_Click(object sender, EventArgs e)
        {
            //Using the random number object create two random numbers between 1 and 6
            iRandomNum = rndNumber.Next(1, 7);

            iUserNumGuess = Int32.Parse(numGuessed.Text);

            /// <summary>
            /// if the user guess anything other than 1-6 the game closes
            /// </summary>
            //if(iUserNumGuess > 6 || iUserNumGuess < 1)
            //{
            //    lblGuessEnter.Text = "Enter your guess (1-6): " + iNumOfGames.ToString() + "Please enter (1-6) only";
            //    iRandomNum = rndNumber.Next(1, 7);

            //    iUserNumGuess = Int32.Parse(numGuessed.Text);
            //}


            /// <summary>
            /// Checks if the random number matches the user guess
            /// if so the number of wins and number of games increments by 1
            /// it also displays the number of wins and number of games in the text box
            /// if the random number does not match the user guess
            /// the number of losses and number of games increment by 1
            /// then displays the the number of losses and games in the text box
            /// </summary>
            if (iRandomNum == iUserNumGuess)
            {
                ++iNumOfWins;
                ++iNumOfGames;
                lblPlayed.Text = "Number of Times Played: " + iNumOfGames.ToString();
                lblWon.Text = "Number of Times Won: " + iNumOfWins.ToString();
            }
            else
            {
                ++iNumOfLoss;
                ++iNumOfGames;
                lblPlayed.Text = "Number of Times Played: " + iNumOfGames.ToString();
                lblLoss.Text = "Number of Times Lost: " + iNumOfLoss.ToString();
            }

            /// <summary>
            /// Using the user guess,
            /// this tallys the amount of total guess for each number
            /// e.g. user guesses 1, the total guess for totalguess1 goes up 1 
            /// </summary>
            switch (iUserNumGuess)
            {
                case 1:
                    ++iTotalGuess1;
                    break;
                case 2:
                    ++iTotalGuess2;
                    break;
                case 3:
                    ++iTotalGuess3;
                    break;
                case 4:
                    ++iTotalGuess4;
                    break;
                case 5:
                    ++iTotalGuess5;
                    break;
                case 6:
                    ++iTotalGuess6;
                    break;
            }

            /// <summary>
            /// increasing the amount of the frequency when its the result of the random number
            /// </summary>
            switch (iRandomNum)
            {
                case 1:
                    ++iFrequency1;
                    break;
                case 2:
                    ++iFrequency2;
                    break;
                case 3:
                    ++iFrequency3;
                    break;
                case 4:
                    ++iFrequency4;
                    break;
                case 5:
                    ++iFrequency5;
                    break;
                case 6:
                    ++iFrequency6;
                    break;
            }

            /// <summary>
            /// Calculating the percentage of each frequency
            /// </summary>
            dPercentage1 = Math.Round((double) iFrequency1 / iNumOfGames * 100, 2);
            dPercentage2 = Math.Round((double) iFrequency2 / iNumOfGames * 100, 2);
            dPercentage3 = Math.Round((double) iFrequency3 / iNumOfGames * 100, 2);
            dPercentage4 = Math.Round((double) iFrequency4 / iNumOfGames * 100, 2);
            dPercentage5 = Math.Round((double) iFrequency5 / iNumOfGames * 100, 2);
            dPercentage6 = Math.Round((double) iFrequency6 / iNumOfGames * 100, 2);

            /// <summary>
            /// The results of frequency, percentage, and total games shown
            /// </summary>
            ResultsOfDice.Text = "Face\t" + "Freq\t" + "Percemt\t" + "Number of Guesses\n"
                                + "  1\t  " + iFrequency1 + "  \t  " + dPercentage1 + "%\t\t" + iTotalGuess1 + "\n"
                                + "  2\t  " + iFrequency2 + "  \t  " + dPercentage2 + "%\t\t" + iTotalGuess2 + "\n"
                                + "  3\t  " + iFrequency3 + "  \t  " + dPercentage3 + "%\t\t" + iTotalGuess3 + "\n"
                                + "  4\t  " + iFrequency4 + "  \t  " + dPercentage4 + "%\t\t" + iTotalGuess4 + "\n"
                                + "  5\t  " + iFrequency5 + "  \t  " + dPercentage5 + "%\t\t" + iTotalGuess5 + "\n"
                                + "  6\t  " + iFrequency6 + "  \t  " + dPercentage6 + "%\t\t" + iTotalGuess6;

            //Randomly change the dice picture
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            for (int i = 1; i < 7; i++)
                {
                    int j = rndNumber.Next(1,7);
                    pbImage.Image = Image.FromFile("die" + j.ToString() + ".gif");
                    pbImage.Refresh();
                    Thread.Sleep(300);
                }
        }

    }
}
