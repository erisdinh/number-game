using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary.Model;

namespace NumberGame_ConsoleApp {
    class Program {
        static void Main(string[] args) {

            NumberGame game = new NumberGame(0, 9);

            bool isContinue = true;

            do {
                Console.WriteLine("----------------------------------------------------------------------------------");
                Console.WriteLine("");
                Console.WriteLine("NUMBER GAME");
                Console.WriteLine("");
                Console.WriteLine("----------------------------------------------------------------------------------");
                Console.WriteLine();

                do {
                    Console.WriteLine("\nPress 'Enter' to play new game ....");
                } while (Console.ReadKey().Key != ConsoleKey.Enter);


                PlayGame(game);
                PrintResult(game);

                string answer;
                do {
                    Console.Write("Do you want to play a new game? (Y/N): ");
                    answer = Console.ReadLine().ToLower();
                } while (!(answer.Equals("n") || answer.Equals("no") || answer.Equals("y") || answer.Equals("yes")));

                Console.WriteLine();
                if (answer.ToLower().Equals("no") || answer.ToLower().Equals("n")) {
                    isContinue = false;
                }

            } while (isContinue == true);

        }

        static void PlayGame(NumberGame game) {
            game.StartNewGame();

            do {
                game.PlayRound();
                PrintRoundInfo(game);
                if(game.IsGameOver() == false) {
                    do {
                        Console.WriteLine("\nPress 'Enter' to play new round ....");
                    } while (Console.ReadKey().Key != ConsoleKey.Enter);
                }

            } while (game.IsGameOver() == false);
        }

        static void PrintRoundInfo(NumberGame game) {
            Console.WriteLine($"\nRound: {game.Round}");
            Console.Write("Number List: ");

            NumberList numberList = game.NumberList;
            for (int i = 0; i < numberList.Numbers.Length; i++) {
                Console.Write($"{numberList.Numbers[i]}    ");
            }

            Console.WriteLine($"\nRound Score: {game.RoundScore[game.Round-1]}");
            Console.WriteLine($"Total Score: {(int) game.TotalScore}");
        }

        static void PrintResult(NumberGame game) {
            game.GenerateGameResult();
            GameResult result = new GameResult();
            result = game.Result;

            Console.WriteLine("\n----------------------------------------------------------------------------------");
            Console.WriteLine("RESULT");

            if (result == GameResult.GAME_DRAW) {
                Console.WriteLine("THIS GAME WAS A DRAW");
            } else if (result == GameResult.PLAYER_LOST) {
                Console.WriteLine("Awwwww. YOU LOSE!!!");
            } else {
                Console.WriteLine("Congrats! YOU WON!!!");
            }

            Console.WriteLine();
        }
    }
}
