using System;
namespace proj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("g = green, b = blue, w = white, r = red, c = cyan , m = magenta : ");
            int x = Console.Read();
            char userInput = Convert.ToChar(x);
            while (userInput != 'x')
            {

                switch (Convert.ToChar(x))
                {
                    case 'g':
                        Console.BackgroundColor = ConsoleColor.Green;
                        System.Console.WriteLine("You clicked green");
                        break;
                    case 'c':
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        System.Console.WriteLine("You clicked cyan");
                        break;
                    case 'b':
                        Console.BackgroundColor = ConsoleColor.Blue;
                        System.Console.WriteLine("You clicked blue");
                        break;
                    case 'm':
                        Console.BackgroundColor = ConsoleColor.Magenta;
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
                Console.Clear();
                Console.WriteLine("g = green, b = blue, w = white, r = red, c = cyan , m = magenta : ");

                x = Console.Read();


            }
        }
    }
}