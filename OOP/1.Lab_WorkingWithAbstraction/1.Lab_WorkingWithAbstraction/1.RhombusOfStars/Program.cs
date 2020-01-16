using System;
using System.Text;

namespace _1.RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= n; i++)
            {
                sb.Append(new string(' ', n - i));
                DrawTopLine(sb, i);
            }
            for (int i = n - 1; i >= 1; i--)
            {
                sb.Append(new string(' ', n - i));
                DrawTopLine(sb, i);
            }
            Console.WriteLine(sb);
        }

        public static void DrawTopLine(StringBuilder sb, int numberOfStars)
        {
            for (int j = 0; j < numberOfStars; j++)
            {
                sb.Append("*");
                if (j < numberOfStars - 1)
                {
                    sb.Append(" ");
                }
            }
            sb.AppendLine();
        }
    }
}
