﻿using System;
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
    public partial class ResultForm : Form {

        NumberGame game = new NumberGame();
        public ResultForm(NumberGame game) {
            InitializeComponent();
            this.game = game;
        }

        private void ResultForm_Load(object sender, EventArgs e) {

            // Get and show round and total scores on the ResultForm
            int[] roundScore = game.RoundScore;

            for(int i = 0; i < panelRoundScore.Controls.Count; i++) {
                panelRoundScore.Controls[i].Text = roundScore[i].ToString();
            }

            labelTotalScore.Text = game.TotalScore.ToString();

            // Generate the game result
            game.GenerateGameResult();

            GameResult gameResult = game.Result;

            // Decide the result statement
            switch (gameResult) {
                case GameResult.PLAYER_WON:
                    labelResult.Text = "Congratulation! You won!";
                    break;
                case GameResult.PLAYER_LOST:
                    labelResult.Text = "You lose!!!!";
                    break;
                case GameResult.GAME_DRAW:
                    labelResult.Text = "This game is a draw";
                    break;
            }
        }

        private void ButtonOK_Click(object sender, EventArgs e) {
            this.Hide();
        }
    }
}
