using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Model {

    /// <summary>
    /// Result Set of Number Game
    /// </summary>
    public enum GameResult {

        /// <summary>
        /// Player won the game
        /// </summary>
        PLAYER_WON,

        /// <summary>
        /// Player lost the game
        /// </summary>
        PLAYER_LOST,

        /// <summary>
        /// The game was a draw
        /// </summary>
        GAME_DRAW
    }
}
