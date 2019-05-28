using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Model {

    /// <summary>
    /// The Number Game object
    /// </summary>
    public class NumberGame {
        int _round;
        int[] _roundScore;
        int _totalScore;
        NumberRange _range;
        NumberList _numberList;
        GameResult _result;

        /// <summary>
        /// Blank constructor of Number Game
        /// </summary>
        public NumberGame() { }

        /// <summary>
        /// Constructor of Number Game
        /// Contains 2 parameters as 2 bounds of number range for the game
        /// </summary>
        /// <param name="lBound">Serves as the lower bound of number range</param>
        /// <param name="uBound">Serves as the upper bound of number range</param>
        public NumberGame(int lBound, int uBound) {
            _round = 0;
            _roundScore = new int[5];
            _totalScore = 0;
            _range = new NumberRange(lBound, uBound);
            _numberList = new NumberList(_range);
            _result = new GameResult();
        }

        /// <summary>
        /// Current round of number game
        /// </summary>
        public int Round {
            get {
                return _round;
            }
        }

        /// <summary>
        /// Round Scores of 5 rounds in a Number Game
        /// </summary>
        public int[] RoundScore {
            get {
                return _roundScore;
            }
        }

        /// <summary>
        /// Total Score of a Number Gamae
        /// </summary>
        public int TotalScore {
            get {
                return _totalScore;
            }
        }

        /// <summary>
        /// Number List contains 5 random numbers and their frequencies in one round
        /// </summary>
        public NumberList NumberList {
            get {
                return _numberList;
            }
        }

        /// <summary>
        /// Game Result
        /// </summary>
        public GameResult Result {
            get {
                return _result;
            }
        }

        // Set up variables and objects as a new game
        /// <summary>
        /// Set up new Number Game
        /// </summary>
        public void StartNewGame() {
            _round = 0;
            _roundScore = new int[5];
            _totalScore = 0;
            _numberList = new NumberList(_range);
            _result = new GameResult();
        }

        /// <summary>
        /// Play new round of Number Game 
        /// Calculate round score
        /// </summary>
        public void PlayRound() {
            _numberList.Fill();
            CalculateRoundScore();
        }

        /// <summary>
        /// Calculate current round score and cummulative total score
        /// </summary>
        public void CalculateRoundScore() {
            int roundScore = 0;
            _numberList.CalculateFrequency();
            int[] frequency = _numberList.Frequency;

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
            _round++;
        }

        /// <summary>
        /// Generate Number Game result
        /// </summary>
        public void GenerateGameResult() {
            if (_totalScore > 100) {
                _result = GameResult.PLAYER_WON;
            } else if (_totalScore < 100) {
                _result = GameResult.PLAYER_LOST;
            } else {
                _result = GameResult.GAME_DRAW;
            }
        }

        /// <summary>
        /// Check if the current game play is over
        /// </summary>
        /// <returns></returns>
        public bool IsGameOver() {
            if (_round == 5) {
                return true;
            } else {
                return false;
            }
        }
    }
}
