using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfTwoStacks_DanielVilar
{
    public class Game
    {
        public int GameOfTwoStacks(int maxScore, int[] stackA, int[] stackB)
        {
            int score = 0;
            int totalSum = 0;

            try
            {
                while (totalSum <= maxScore)
                {
                    int topA = stackA.First();
                    int topB = stackB.First();

                    if (topA < topB && (totalSum + topA <= maxScore))
                    {
                        totalSum += topA;

                        stackA = stackA.Where(val => val != topA).ToArray();
                    }
                    else if (topB < topA && (totalSum + topB <= maxScore))
                    {
                        totalSum += topB;

                        stackB = stackB.Where(val => val != topB).ToArray();
                    }
                    else if (topB == topA && (totalSum + topB <= maxScore))
                    {
                        totalSum += topB;

                        stackB = stackB.Where(val => val != topB).ToArray();
                    }
                    else
                    {
                        break;
                    }

                    score++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
                Console.ReadKey();
                System.Environment.Exit(0);
            }
            return score;
        }
    }
}
