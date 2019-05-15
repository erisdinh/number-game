using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_NumberGame.Model {
    class NumberGame {
        NumberList _numberList;
        int _round;
        GameResult _gameResult;
        Range _range;

        public NumberGame() {
            _range = new Range(0,9);
            _round = 1;
            _numberList = new NumberList(_range);
            _gameResult = new GameResult();
        }

        public int GetRound() {
            return _round;
        }

        public void StartNewGame() {
            _round = 0;
            _gameResult = new GameResult();
        }

        public int[] PlayRound() {
            _round += 1;
            int[] numbers = _numberList.Fill();
            return numbers;
        }

        public int CalculateRoundScore() {
            int roundScore = 0;
            int[] frequency = _numberList.calculateFrequency();

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
                _gameResult = GameResult.PLAYER_WON;
            } else if (totalScore < 100) {
                _gameResult = GameResult.PLAYER_LOST;
            } else {
                _gameResult = GameResult.GAME_DRAW;
            }
            return _gameResult;
        }

        public bool IsGameOver() {
            if (_round == 5) {
                return true;
            } else {
                return false;
            }
        }
    }
}
