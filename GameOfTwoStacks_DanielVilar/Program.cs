using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfTwoStacks_DanielVilar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of games: ");
            int numberOfGames = 0;

            bool convertionSuccess = Int32.TryParse(Console.ReadLine(), out numberOfGames);

            while (!convertionSuccess)
            {
                Console.WriteLine("Plase, enter just non-negative integers");

                Console.Write("Number of games: ");

                convertionSuccess = Int32.TryParse(Console.ReadLine(), out numberOfGames);
            }

            for (int i = 0; i < numberOfGames; i++)
            {
                new ProcessInput();

                Console.WriteLine("\nScore: {0}", new Game().GameOfTwoStacks(ProcessInput.maxScore, ProcessInput.stackA, ProcessInput.stackB));

                Console.ReadKey();

                Console.Clear();
            }

        }
    }
}
