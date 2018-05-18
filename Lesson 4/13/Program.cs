using System;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 6;
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
            Console.WriteLine("Введите номер удаляемой строки:");
            int i1 = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine("Введите номер удаляемого столбца:");
            int j1 = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine("Новая матрица");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i != i1) && (j != j1))
                        Console.Write(Array[i, j] + " ");
                }
                if (i != i1)
                    Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}