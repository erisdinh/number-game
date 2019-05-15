using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_NumberGame.Model {
    class NumberGame {
        NumberList numberList;
        int round;
        GameResult gameResult;
        Range range;

        public NumberGame() {
            range = new Range(0,9);
            round = 1;
            numberList = new NumberList(range);
            gameResult = new GameResult();
        }

        public int GetRound() {
            return round;
        }

        public void StartNewGame() {
            round = 0;
            gameResult = new GameResult();
        }

        public int[] PlayRound() {
            round += 1;
            int[] numbers = numberList.Fill();
            return numbers;
        }

        public int CalculateRoundScore() {
            int roundScore = 0;
            int[] frequency = numberList.calculateFrequency();

            for (int i = 0; i < frequency.Length; i++) {
                switch (frequency[i]) {
                    case 2:
                        roundScore += 10;
                        break;
                    case 3:
                        roundScore += 20;
                        break;
                    case 4:
                        roundScore += 30;
                        break;
                    case 5:
                        roundScore += 40;
                        break;
                }
            }
            return roundScore;
        }

        public GameResult GenerateGameResult(int totalScore) {
            if (totalScore > 100) {
                gameResult = GameResult.PLAYER_WON;
            } else if (totalScore < 100) {
                gameResult = GameResult.PLAYER_LOST;
            } else {
                gameResult = GameResult.GAME_DRAW;
            }
            return gameResult;
        }

        public bool IsGameOver() {
            if (round == 5) {
                return true;
            } else {
                return false;
            }
        }
    }
}
