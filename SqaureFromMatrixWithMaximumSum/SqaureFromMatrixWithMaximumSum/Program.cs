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
            int bestSum = int.MinValue;
            int selectedRow = 0;
            int selectedCol = 0;
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
                        selectedRow = row;
                        selectedCol = col;
                    }
                }
            }
            Console.WriteLine($"{array[selectedRow,selectedCol]} {array[selectedRow, selectedCol+1]}");
            Console.WriteLine($"{array[selectedRow+1, selectedCol]} {array[selectedRow+1, selectedCol+1]}");
            Console.WriteLine(bestSum);
        }
    }
}
