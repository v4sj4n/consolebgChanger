using System;
namespace proj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("g = green, b = blue, w = white, r = red : ");
            int x = Console.Read();
            switch (Convert.ToChar(x))
            {
                case 'g':
                    Console.BackgroundColor = ConsoleColor.Green;
                    System.Console.WriteLine("You clicked green");
                    break;
                case 'b':
                    Console.BackgroundColor = ConsoleColor.Blue;
                    System.Console.WriteLine("You clicked blue");
                    break;
                case 'w':
                    Console.BackgroundColor = ConsoleColor.White;
                    System.Console.WriteLine("You clicked white");
                    break;
                case 'r':
                    Console.BackgroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("You clicked white");
                    break;
                default:
                    break;
            }
        }
    }
}