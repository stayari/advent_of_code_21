using System;

namespace Advent2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            FileReader fr = new FileReader();

            Day2 puzzle = new Day2(fr.GetLines());
            
            Console.WriteLine("Todays answer is: " + puzzle.GetAns());
        }
    }
}
