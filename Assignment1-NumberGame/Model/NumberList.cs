using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_NumberGame.Model {
    struct NumberList {

        Range range;
        private int[] numbers;

        public NumberList(Range range) {
            this.range = range;
            numbers = new int[5];
        }

        public int[] Fill() {
            Random random = new Random();
            for (int i = 0; i < numbers.Length; i++) {
                numbers[i] = random.Next(range.GetLowerBound(), range.GetUpperBound() + 1);
            }
            return numbers;
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
