using System;
using System.Linq;

namespace _03.JediGalaxy
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] dimestions = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int x = dimestions[0];
            int y = dimestions[1];

            int[,] matrix = new int[x, y];
            FillMatrix(x, y, matrix);

            string command = Console.ReadLine();
            long sum = 0;
            while (command != "Let the Force be with you")
            {
                int[] ivoStartingLocation = command.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int[] evilStarStartingLocation = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int evilStarX = evilStarStartingLocation[0];
                int evilStarY = evilStarStartingLocation[1];

                while (evilStarX >= 0 && evilStarY >= 0)
                {
                    if (evilStarX >= 0 && evilStarX < matrix.GetLength(0) && evilStarY >= 0 && evilStarY < matrix.GetLength(1))
                    {
                        matrix[evilStarX, evilStarY] = 0;
                    }
                    evilStarX--;
                    evilStarY--;
                }

                int ivoX = ivoStartingLocation[0];
                int ivoY = ivoStartingLocation[1];

                while (ivoX >= 0 && ivoY < matrix.GetLength(1))
                {
                    if (ivoX >= 0 && ivoX < matrix.GetLength(0) && ivoY >= 0 && ivoY < matrix.GetLength(1))
                    {
                        sum += matrix[ivoX, ivoY];
                    }

                    ivoY++;
                    ivoX--;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(sum);
        }

        private static void FillMatrix(int x, int y, int[,] matrix)
        {
            int value = 0;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    matrix[i, j] = value++;
                }
            }
        }
    }
}
