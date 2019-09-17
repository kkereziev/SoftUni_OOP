using System;
using System.Linq;
using System.Collections.Generic;

namespace MultidimensionalArrays
{
    class Program
    {
        static void Main()
        {
            int countOfRowsAndCols = int.Parse(Console.ReadLine());
            int[,] array = new int[countOfRowsAndCols, countOfRowsAndCols];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int[] tokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = tokens[j];

                }
            }
            int bestSum = 0;
            int[,] bestNums = new int[2, 2];
            for (int row = 0; row < array.GetLength(0)-1; row++)
            {
                int sum = 0;
                for (int col = 0; col < array.GetLength(1)-1; col++)
                {
                    int firstNum = array[row, col];
                    int secondNum = array[row, col + 1];
                    int thirdNum = array[row + 1, col];
                    int fourthNum = array[row + 1, col + 1];
                    sum = firstNum + secondNum + thirdNum + fourthNum;
                    if (bestSum < sum)
                    {
                        bestSum = sum;
                        bestNums[0, 0] = firstNum;
                        bestNums[0, 1] = secondNum;
                        bestNums[1, 0] = thirdNum;
                        bestNums[1, 1] = fourthNum;
                    }
                }
            }
            for (int row = 0; row < bestNums.GetLength(0); row++)
            {
                for (int col = 0; col < bestNums.GetLength(1); col++)
                {
                    Console.Write($"{bestNums[row, col]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(bestSum);
        }
    }
}
