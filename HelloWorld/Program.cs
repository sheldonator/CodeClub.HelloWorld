using System;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWhat is your name? ");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"\nHello, {name}, on {date:d} at {date:t}!");

            //get name as list of letters
            var letters = name.ToCharArray();

            //write them
            foreach(var c in letters)
            {
                Console.WriteLine($"\n{c}");
            }

            //order them
            foreach(var c in letters.OrderBy(c => c )) 
            {
                Console.WriteLine($"\n{c}");
            }

            //change colour
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nThis is in a different colour");
            Console.ResetColor();

            Console.WriteLine("\nWhat colour would you like?");
            var color = Console.ReadLine();
            var consoleColor = GetColor(color);

            if (!consoleColor.HasValue)
            {
                Console.WriteLine("\nRequested colour is unavailable");

            } else {
            Console.ForegroundColor = consoleColor.Value;
            Console.WriteLine("\nThis is the colour you like");
            Console.ResetColor();
            }

            //print letters

            const string world = "Hello World!";
            for ( int i = 0; i < world.Length; i++)
                {
                    Console.WriteLine(world[i]);
                }

            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);
        }

        private static ConsoleColor? GetColor(string color)
        {
            color = color.Replace(" ", "");

            if(Enum.TryParse<ConsoleColor>(color, out var consoleColor))
            {
                return consoleColor;
            }

            return null;
        }
    }
}
