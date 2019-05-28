using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameLibrary.Model;

namespace NumberGame_WindowForm {
    public partial class NumberGameForm : Form {

        NumberGame game;
        NumberList numberList;

        public NumberGameForm() {
            InitializeComponent();
            game = new NumberGame(0,9);
            numberList = new NumberList();
        }

        private void ButtonPlay_Click(object sender, EventArgs e) {

            // Check the text in buttonPlay
            // If it is "New Game", set up a new game for the player
            if (buttonPlay.Text.Equals("New Game")) {
                game.StartNewGame();
            }

            // Play new round
            game.PlayRound();

            // Update the round label in NumberGameForm
            labelRound.Text = (game.Round).ToString();

            // Retrieve number list
            numberList = game.NumberList;
            int[] numbers = numberList.Numbers;

            // Show number list on NumberGameForm
            for (int i = 0; i < numberList.Numbers.Length; i++) {
                groupLabelNumber.Controls[i].Text = numbers[i].ToString();
            }

            // Get the current round and total score
            int roundScore = game.RoundScore[game.Round-1];
            labelRoundScore.Text = roundScore.ToString();
            labelTotalScore.Text = game.TotalScore.ToString();

            // Check whether the game is over (after 5 rounds)
            bool gameOver = game.IsGameOver();

            // If the game is over, change the text of buttonPlay to "New Game" and show the ResultForm
            // Otherwise, change buttonPlay to "New Round" as play a new round
            if (gameOver) {
                buttonPlay.Text = "New Game";

                ResultForm resultForm = new ResultForm(game);
                resultForm.Show();
            } else {
                buttonPlay.Text = "New Round";
            }

        }
    }
}
