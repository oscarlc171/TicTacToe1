using System;

namespace ConsoleApp5
{
    class TicTacToe
    {
        static void Main(string[] args)
        {
            int[,] gameboard = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };


            void ShowGameBoard()
            {
                Console.WriteLine("-------------------");
                Console.WriteLine($"{gameboard[0, 0]}|{gameboard[0, 1]}|{gameboard[0, 2]}\n" +
                        $"------\n" +
                        $"{gameboard[1, 0]}|{gameboard[1, 1]}|{gameboard[1, 2]}\n" +
                        $"------\n" +
                        $"{gameboard[2, 0]}|{gameboard[2, 1]}|{gameboard[2, 2]}");
                Console.WriteLine("-------------------");
            }

            Console.WriteLine("Game Rules \n" +
                "----------\n" +
                "Choose a coordinate for where you want to mark your move.\n" +
                "Type in the first number for Column(from 1-3), press Enter, then type in your second number for Row(from 1-3) and press Enter again");

            Console.WriteLine("-------------------");
            Console.WriteLine("Columns\n" +
                "1 2 3\n" +
                "| | |\n" +
                "v v v");
            Console.WriteLine($"{gameboard[0, 0]}|{gameboard[0, 1]}|{gameboard[0, 2]} <---1\n" +
                    $"------\n" +
                    $"{gameboard[1, 0]}|{gameboard[1, 1]}|{gameboard[1, 2]} <---2 Rows\n" +
                    $"------\n" +
                    $"{gameboard[2, 0]}|{gameboard[2, 1]}|{gameboard[2, 2]} <---3");
            Console.WriteLine("-------------------");

            while (gameboard[0, 0] == 0 || gameboard[0, 1] == 0 || gameboard[0, 2] == 0 ||
                gameboard[1, 0] == 0 || gameboard[1, 1] == 0 || gameboard[1, 2] == 0 ||
                gameboard[2, 0] == 0 || gameboard[2, 1] == 0 || gameboard[2, 2] == 0)
            {
                Console.WriteLine("Player 1's turn");


                int Player1FirstNumber = int.Parse(Console.ReadLine());
                int Player1SecondNumber = int.Parse(Console.ReadLine());

                while (Player1FirstNumber > 3 || Player1FirstNumber < 1 || Player1SecondNumber > 3 || Player1SecondNumber < 1)
                {
                    Console.Clear();
                    Console.WriteLine("Enter a valid coordinate");
                    ShowGameBoard();
                    Player1FirstNumber = int.Parse(Console.ReadLine());
                    Player1SecondNumber = int.Parse(Console.ReadLine());
                }

                while (gameboard[Player1SecondNumber - 1, Player1FirstNumber - 1] != 0)
                {
                    Console.Clear();
                    Console.WriteLine("You can't make a move here. You must choose an empty space.");
                    ShowGameBoard();
                    Player1FirstNumber = int.Parse(Console.ReadLine());
                    Player1SecondNumber = int.Parse(Console.ReadLine());
                }

                gameboard[Player1SecondNumber - 1, Player1FirstNumber - 1] = 1;

                if ((gameboard[0,0] == 1 && gameboard[0,1] == 1 && gameboard[0,2] == 1) || (gameboard[1,0] == 1 &&
                    gameboard[1,1] == 1 && gameboard[1,2] == 1) || (gameboard[2,0] == 1 && gameboard[2,1] == 1 &&
                    gameboard[2,2] == 1) || (gameboard[0,0] == 1 && gameboard[1,0] == 1 && gameboard[2,0] == 1) ||
                    (gameboard[0,1] == 1 && gameboard[1,1] == 1 && gameboard[2,1] == 1) || (gameboard[0,2] == 1 &&
                    gameboard[1,2] == 1 && gameboard[2,2] == 1) || (gameboard[0,0] == 1 && gameboard[1,1] == 1 &&
                    gameboard[2,2] == 1) || (gameboard[0,2] == 1 && gameboard[1,1] == 1 && gameboard[2,0] == 1))
                {
                    Console.Clear();
                    ShowGameBoard();
                    Console.WriteLine("Player 1 wins");
                    break;
                }

                if (gameboard[0, 0] != 0 && gameboard[0, 1] != 0 && gameboard[0, 2] != 0 &&
                gameboard[1, 0] != 0 && gameboard[1, 1] != 0 && gameboard[1, 2] != 0 &&
                gameboard[2, 0] != 0 && gameboard[2, 1] != 0 && gameboard[2, 2] != 0)
                {
                    Console.WriteLine("Draw");
                    break;
                }

                Console.Clear();

                Console.WriteLine("Player 2's turn");
                ShowGameBoard();


                int Player2FirstNumber = int.Parse(Console.ReadLine());
                int Player2SecondNumber = int.Parse(Console.ReadLine());

                while (Player2FirstNumber > 3 || Player2FirstNumber < 1 || Player2SecondNumber > 3 || Player2SecondNumber < 1)
                {
                    Console.Clear();
                    Console.WriteLine("Enter a valid coordinate");
                    ShowGameBoard();
                    Player1FirstNumber = int.Parse(Console.ReadLine());
                    Player1SecondNumber = int.Parse(Console.ReadLine());
                }

                while (gameboard[Player2SecondNumber - 1, Player2FirstNumber - 1] != 0)
                {
                    Console.Clear();
                    Console.WriteLine("You can't make a move here. You must choose an empty space.");
                    ShowGameBoard();
                    Player2FirstNumber = int.Parse(Console.ReadLine());
                    Player2SecondNumber = int.Parse(Console.ReadLine());
                }

                gameboard[Player2SecondNumber - 1, Player2FirstNumber - 1] = 2;

                Console.Clear();

                ShowGameBoard();

                if ((gameboard[0, 0] == 2 && gameboard[0, 1] == 2 && gameboard[0, 2] == 2) || (gameboard[1, 0] == 2 &&
                    gameboard[1, 1] == 2 && gameboard[1, 2] == 2) || (gameboard[2, 0] == 2 && gameboard[2, 1] == 2 &&
                    gameboard[2, 2] == 2) || (gameboard[0, 0] == 2 && gameboard[1, 0] == 2 && gameboard[2, 0] == 2) ||
                    (gameboard[0, 1] == 2 && gameboard[1, 1] == 2 && gameboard[2, 1] == 2) || (gameboard[0, 2] == 2 &&
                    gameboard[1, 2] == 2 && gameboard[2, 2] == 2) || (gameboard[0, 0] == 2 && gameboard[1, 1] == 2 &&
                    gameboard[2, 2] == 2) || (gameboard[0, 2] == 2 && gameboard[1, 1] == 2 && gameboard[2, 0] == 2))
                {
                    Console.Clear();
                    ShowGameBoard();
                    Console.WriteLine("Player 2 wins");
                    break;
                }


                if (gameboard[0, 0] != 0 && gameboard[0, 1] != 0 && gameboard[0, 2] != 0 &&
                gameboard[1, 0] != 0 && gameboard[1, 1] != 0 && gameboard[1, 2] != 0 &&
                gameboard[2, 0] != 0 && gameboard[2, 1] != 0 && gameboard[2, 2] != 0)
                {
                    Console.WriteLine("Draw");
                    break;
                }
            }
        }

    }
}
