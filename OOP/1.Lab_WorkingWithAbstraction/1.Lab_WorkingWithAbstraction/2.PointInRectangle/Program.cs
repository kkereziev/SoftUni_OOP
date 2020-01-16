using System;
using System.Linq;

namespace _2.PointInRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rectangleCoordinates = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();
            int topLeftX = rectangleCoordinates[0];
            int topLeftY = rectangleCoordinates[1];
            int bottomRightX = rectangleCoordinates[2];
            int bottomRightY = rectangleCoordinates[3];
            Rectangle rectangle = new Rectangle(topLeftX, topLeftY, bottomRightX, bottomRightY);
            int numberOfPoints = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfPoints; i++)
            {
                int[] point = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                int X = point[0];
                int Y = point[1];
                Console.WriteLine(rectangle.Contains(new Point(X, Y)));
            }
        }
    }
}
