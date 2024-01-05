using System;

namespace PrintCustomTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            PrintCustomTriangle(N);
        }

        static void PrintCustomTriangle(int N)
        {
            // Upper part of the triangle
            for (int row = 1; row <= N; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }

            // Lower part of the triangle
            for (int row = N - 1; row >= 1; row--)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
