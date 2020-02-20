using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfTwoStacks_DanielVilar
{
    public class ProcessInput
    {
        public static int maxScore { get; set; }

        private static int[] validMaxScoreAndLengths { get; set; }

        public static int[] stackA { get; set; }

        public static int[] stackB { get; set; }

        public ProcessInput()
        {
            try
            {
                bool validNumbers = true;

                while (validNumbers)
                {
                    Console.Write("Please, input space-separated integers for Stack A and Stack B length, also Max Score: ");

                    validMaxScoreAndLengths = convertInputToArray(Console.ReadLine());

                    getMaxScoreAndStacksLength(validMaxScoreAndLengths);

                    Console.Write("\nPlease, input space-separated integers for stack A, following by stack B:\n");

                    stackA = convertInputToArray(Console.ReadLine());

                    stackB = convertInputToArray(Console.ReadLine());

                    if ((stackA.Any(n => n < 0)) && (stackB.Any(n => n < 0)) && (validMaxScoreAndLengths.Any(n => n < 0)))
                    {
                        Console.WriteLine("\nPlase, enter just non-negative integers");
                        continue;
                    }
                    else validNumbers = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
                Console.ReadKey();
                System.Environment.Exit(0);
            }

        }

        public static void getMaxScoreAndStacksLength(int[] values)
        {
            try
            {
                maxScore = values[2];

                stackA = new int[values[0]];

                stackB = new int[values[1]];
            }
            catch (Exception ex)
            {
                Console.Write("Error: {0}", ex.Message);
                Console.ReadKey();
                System.Environment.Exit(0);
            }
        }

        public static int[] convertInputToArray(string stack)
        {
            return Array.ConvertAll(stack.Split(' '), aTemp => Convert.ToInt32(aTemp));
        }
    }
}
