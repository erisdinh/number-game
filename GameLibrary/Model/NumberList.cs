using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Model {

    /// <summary>
    /// The NumberList structure that contains the list of 5 random numbers and their frequencies
    /// </summary>
    public struct NumberList {

        private NumberRange _range;
        private int[] _numbers;
        private int[] _frequency;

        /// <summary>
        /// Constructor of Number List that gets NumberRange as number range to generate new 5 random numbers
        /// </summary>
        /// <param name="range">Serves as number range of Number Game</param>
        public NumberList(NumberRange range) {
            this._range = range;
            _numbers = new int[5];
            _frequency = new int[10];
        }

        /// <summary>
        /// A list of 5 random numbers
        /// </summary>
        public int[] Numbers {
            get {
                return _numbers;
            }
        }

        /// <summary>
        /// Frequency of 5 generated numbers
        /// </summary>
        public int[] Frequency {
            get {
                return _frequency;
            }
        }

        /// <summary>
        /// Generate 5 random numbers in number range
        /// Fill into Numbers array
        /// </summary>
        public void Fill() {
            Random random = new Random();
            for (int i = 0; i < _numbers.Length; i++) {
                _numbers[i] = random.Next(_range.GetLowerBound(), _range.GetUpperBound() + 1);
            }
        }

        /// <summary>
        /// Calculate the frequency of 5 generated numbers
        /// </summary>
        public void CalculateFrequency() {
            _frequency = new int[10];
            for (int i = 0; i < _numbers.Length; i++) {
                _frequency[_numbers[i]]++;
            }
        }
    }
}
