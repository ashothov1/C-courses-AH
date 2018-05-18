using System;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            int[,] Array = new int[n, n];

            Random ex = new Random();
            Console.WriteLine("Исходная матрица");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Array[i, j] = ex.Next(1, 10);
                    Console.Write(Array[i, j] + " ");
                }
                Console.WriteLine();
            }
            int i1 = 0;
            int j1 = 0;
            Console.WriteLine("Новая матрица");
            while (i1 != n)
            {
                Console.Write(Array[i1, j1] + " ");
                i1++;
                j1++;
            }
            Console.WriteLine();
            int otstup = 0;
            for (int i = 0; i < n; i++)
            {
                if (otstup % 2 == 0)
                    Console.Write(" ");
                for (int j = 0; j < n; j++)
                {
                    if (i != j)
                        Console.Write(Array[i, j] + " ");
                }
                otstup++;
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}