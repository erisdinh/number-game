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

        public NumberGameForm() {
            InitializeComponent();
            game = new NumberGame(0,9);

        }

        private void ButtonPlay_Click(object sender, EventArgs e) {
            if (buttonPlay.Text.Equals("New Game")) {
                game.StartNewGame();
            }

            int[] numbers = game.PlayRound();
            labelRound.Text = (game.GetRound()+1).ToString();

            for (int i = 0; i < numbers.Length; i++) {
                groupLabelNumber.Controls[i].Text = numbers[i].ToString();
            }

            int roundScore = game.GetRoundScore()[game.GetRound()];
            labelRoundScore.Text = roundScore.ToString();

            labelTotalScore.Text = game.GetTotalScore().ToString();

            bool gameOver = game.IsGameOver();

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
