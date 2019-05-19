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
    public partial class ResultForm : Form {

        NumberGame game = new NumberGame();
        public ResultForm(NumberGame game) {
            InitializeComponent();
            this.game = game;
        }

        private void ResultForm_Load(object sender, EventArgs e) {

            int[] roundScore = game.GetRoundScore();

            for(int i = 0; i < panelRoundScore.Controls.Count; i++) {
                panelRoundScore.Controls[i].Text = roundScore[i].ToString();
            }

            labelTotalScore.Text = game.GetTotalScore().ToString();

            GameResult gameResult = game.GenerateGameResult(game.GetTotalScore());

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
        }

        private void ButtonOK_Click(object sender, EventArgs e) {
            this.Hide();
        }
    }
}
