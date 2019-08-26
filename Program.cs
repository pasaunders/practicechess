using System;
using board;

namespace practicechess
{
    class Program
    {
        static void Main(string[] args)
        {
            Board play_board = new Board();
            Console.WriteLine("Hello World!");
            play_board.show_board();
        }
    }
}
