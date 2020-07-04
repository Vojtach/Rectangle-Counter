using System;

namespace Squareapp
{
    class Program
    {
        static int countSquares(int x, int y)
        {

            // If x < y, swap x and y  
            if (y < x)
            {
                int temp = x;
                x = y;
                y = temp;
            }
            // X is bigger then y now
            // do the math formula
            return y * (y + 1) * (3 * x - y + 1) / 6;
        }
        static void Main()
        {
            int x;
            int y;
            Console.WriteLine("I will calculate how many 1x1 squares are in your shape! Example of a 3 by 2 dot shape");
            Console.WriteLine(@"---------------------------------------------------------------------------------------
                               O-------O-------O
                               |               |
                               O-------O-------O
---------------------------------------------------------------------------------------");
            Console.WriteLine("Enter the size of your rectangle/square in dots\n X:");
            int.TryParse(Console.ReadLine(), out x);
            Console.WriteLine("Y:");
            int.TryParse(Console.ReadLine(), out y);
            Console.Write("Count of squares is " + countSquares(x, y));
            Console.ReadLine();
        }
    }
}