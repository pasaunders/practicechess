using System;

namespace board
{
    class Board
    {
        public 
        public void show_board() {

            Console.WriteLine("   a b c d e f g h");
            Console.WriteLine("  -----------------");
            for (int i = 8; i > 0; i--)
            {
                Console.WriteLine($"{i} | | | | | | | | |");
                Console.WriteLine("  -----------------");
            }
        }
    }
}