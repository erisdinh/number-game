using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_NumberGame.Model {
    struct NumberList {

        private Range _range;
        private int[] _numbers;

        public NumberList(Range range) {
            this._range = range;
            _numbers = new int[5];
        }

        public int[] Fill() {
            Random random = new Random();
            for (int i = 0; i < _numbers.Length; i++) {
                _numbers[i] = random.Next(_range.GetLowerBound(), _range.GetUpperBound() + 1);
            }
            return _numbers;
        }

        public int[] CalculateFrequency() {
            int[] frequency = new int[10];

            for (int i = 0; i < _numbers.Length; i++) {
                frequency[_numbers[i]]++;
            }

            return frequency;
        }
     }
}
