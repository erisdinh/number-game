using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment1_NumberGame.Model;

namespace Assignment1_NumberGame {
    public partial class NumberGameForm : Form {

        NumberGame game;
        int totalScore;

        public NumberGameForm() {
            InitializeComponent();
            game = new NumberGame();

        }

        private void ButtonPlay_Click(object sender, EventArgs e) {
            if (buttonPlay.Text.Equals("New Game")) {
                game.StartNewGame();
                totalScore = 0;
                labelRound.Text = game.GetRound().ToString();
                labelRoundScore.Text = "";
                labelResult.Text = "";
                labelTotalScore.Text = totalScore.ToString();
            }

            int[] numbers = game.PlayRound();
            labelRound.Text = game.GetRound().ToString();

            for (int i = 0; i < numbers.Length; i++) {
                groupLabelNumber.Controls[i].Text = numbers[i].ToString();
            }

            int roundScore = game.CalculateRoundScore();
            labelRoundScore.Text = roundScore.ToString();

            totalScore += roundScore;
            labelTotalScore.Text = totalScore.ToString();

            bool gameOver = game.IsGameOver();

            if (gameOver) {
                GameResult gameResult = game.GenerateGameResult(totalScore);

                switch (gameResult) {
                    case GameResult.PLAYER_WON:
                        labelResult.Text = "Congratulation! You won!";
                        break;
                    case GameResult.PLAYER_LOST:
                        labelResult.Text = "You lose!!!!";
                        break;
                    case GameResult.GAME_DRAW:
                        labelResult.Text = "Congratulation! You got DRAWWWW!!!";
                        break;
                }

                buttonPlay.Text = "New Game";
                game.StartNewGame();
            } else {
                buttonPlay.Text = "New Round";
            }

        }
    }
}
