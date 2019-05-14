using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_NumberGame.Model {
    struct NumberList {

        Range range;
        private int[] numbers;

        public NumberList(int[] numbers, Range range) {
            this.numbers = numbers;
            this.range = range;
        }

        public void Fill() {
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++) {
                numbers[i] = random.Next(range.GetLowerBound(), range.GetUpperBound() + 1);
            }
        }

        public int[] calculateFrequency() {
            int[] frequency = new int[10];

            for (int i = 0; i < numbers.Length; i++) {
                frequency[numbers[i]]++;
            }

            return frequency;
        }
     }
}
