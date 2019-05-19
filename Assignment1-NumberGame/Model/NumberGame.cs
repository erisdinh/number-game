using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_NumberGame.Model {
    public class NumberGame {
        int _round;
        int[] _roundScore;
        int _totalScore;
        Range _range;
        NumberList _numberList;
        GameResult _gameResult;

        public NumberGame() { }

        public NumberGame(int lBound, int uBound) {
            _round = 0;
            _roundScore = new int[5];
            _totalScore = 0;
            _range = new Range(lBound, uBound);
            _numberList = new NumberList(_range);
            _gameResult = new GameResult();
        }

        public int GetRound() {
            return _round;
        }

        public int[] GetRoundScore() {
            return _roundScore;
        }

        public int GetTotalScore() {
            return _totalScore;
        }

        public void StartNewGame() {
            _round = 0;
            _roundScore = new int[5];
            _totalScore = 0;
            _numberList = new NumberList(_range);
            _gameResult = new GameResult();
        }

        public int[] PlayRound() {
            int[] numbers = _numberList.Fill();
            CalculateRoundScore();
            return numbers;
        }

        public void CalculateRoundScore() {
            int roundScore = 0;
            int[] frequency = _numberList.CalculateFrequency();

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

            _roundScore[_round] = roundScore;
            _totalScore += roundScore;
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
            if (_round == 4) {
                return true;
            } else {
                _round++;
                return false;
            }
        }
    }
}
