using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Model {

    /// <summary>
    /// The Range structure is used in order to define the upper and lower bounds for numbers
    /// </summary>
    public struct NumberRange {
        private int _lowerBound, _upperBound;

        /// <summary>
        /// The constructor for the Range structure
        /// that takes two bounds as parameters
        /// </summary>
        /// <param name="lBound">Serves as the lower bound</param>
        /// <param name="uBound">Serves as the upper bound</param>
        public NumberRange(int lBound, int uBound) {
            _lowerBound = lBound;
            _upperBound = uBound;
        }

        public int GetLowerBound() {
            return _lowerBound;
        }

        public int GetUpperBound() {
            return _upperBound;
        }
    }
}
