using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_NumberGame.Model {
    struct Range {
        private int lowerBound, upperBound;

        public Range(int lBound, int uBound) {
            lowerBound = lBound;
            upperBound = uBound;
        }

        public int GetLowerBound() {
            return lowerBound;
        }

        public int GetUpperBound() {
            return upperBound;
        }
    }
}
