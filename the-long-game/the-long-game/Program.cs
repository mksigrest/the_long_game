using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace the_long_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            int score = 0;
            ConsoleKeyInfo cki;

            Console.WriteLine("Your current score is " + score);
            Console.WriteLine("Enter a key to add to your score!");

            while (true)
            {
                cki = Console.ReadKey();

                if (cki.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("Exit");
                    break;
                }

                else
                {
                    score++;
                    Console.WriteLine("Your current score is: " + score);
                }

                Console.WriteLine("Enter another key to add to your score!");
            }
        }
    }
}
