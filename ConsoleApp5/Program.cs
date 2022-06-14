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
                Console.WriteLine("-----------");
                Console.WriteLine($"{gameboard[0, 0]}|{gameboard[0, 1]}|{gameboard[0, 2]}\n" +
                        $"------\n" +
                        $"{gameboard[1, 0]}|{gameboard[1, 1]}|{gameboard[1, 2]}\n" +
                        $"------\n" +
                        $"{gameboard[2, 0]}|{gameboard[2, 1]}|{gameboard[2, 2]}");
                Console.WriteLine("-----------");
            }

            Console.WriteLine("Game Rules \n" +
                "----------\n" +
                "Choose a coordinate for where you want to mark your move.\n" +
                "Type in the first number(from 0-2), press Enter, then type in your second number(from 0-2)");

            while (gameboard[0, 0] == 0 || gameboard[0, 1] == 0 || gameboard[0, 2] == 0 ||
                gameboard[1, 0] == 0 || gameboard[1, 1] == 0 || gameboard[1, 2] == 0 ||
                gameboard[2, 0] == 0 || gameboard[2, 1] == 0 || gameboard[2, 2] == 0)
            {
                Console.WriteLine("Player 1's turn");
                ShowGameBoard();


                int Player1FirstNumber = int.Parse(Console.ReadLine());
                int Player1SecondNumber = int.Parse(Console.ReadLine());

                while (Player1FirstNumber > 2 || Player1FirstNumber < 0 || Player1SecondNumber > 2 || Player1SecondNumber < 0)
                {
                    Console.WriteLine("Enter a valid coordinate");
                    Player1FirstNumber = int.Parse(Console.ReadLine());
                    Player1SecondNumber = int.Parse(Console.ReadLine());
                }

                gameboard[Player1FirstNumber, Player1SecondNumber] = 1;


                Console.WriteLine("Player 2's turn");
                ShowGameBoard();


                int Player2FirstNumber = int.Parse(Console.ReadLine());
                int Player2SecondNumber = int.Parse(Console.ReadLine());

                while (Player2FirstNumber > 2 || Player2FirstNumber < 0 || Player2SecondNumber > 2 || Player2SecondNumber < 0)
                {
                    Console.WriteLine("Enter a valid coordinate");
                    Player2FirstNumber = int.Parse(Console.ReadLine());
                    Player2SecondNumber = int.Parse(Console.ReadLine());
                }

                gameboard[Player2FirstNumber, Player2SecondNumber] = 2;
                ShowGameBoard();


                if (gameboard[0, 0] != 0 && gameboard[0, 1] != 0 && gameboard[0, 2] != 0 &&
                gameboard[1, 0] != 0 && gameboard[1, 1] != 0 && gameboard[1, 2] != 0 &&
                gameboard[2, 0] != 0 && gameboard[2, 1] != 0 && gameboard[2, 2] != 0)
                {
                    break;
                }
            }
        }

    }
}
