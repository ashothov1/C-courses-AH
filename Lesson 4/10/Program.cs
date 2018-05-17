using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ex = new Random();
            const int n = 5;
            const int k = 5;
            int[,] matr = new int[n, k];
            Console.WriteLine("Двумерный массив " + n + "x" + k);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    matr[i, j] = ex.Next(1, 50);
                    Console.Write(matr[i,j]+" ");
                }
                Console.WriteLine();
            }
            int[] MaxMas = new int[n];
            Console.WriteLine("Массив максимальных элементов каждой строки");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    if (MaxMas[i] < matr[i, j])
                        MaxMas[i] = matr[i, j];
                }
                Console.Write(MaxMas[i] + " ");
            }
            Console.WriteLine();
            int min = MaxMas[0];
            for (int i = 0; i < n; i++)
            {
                if (min > MaxMas[i])
                    min = MaxMas[i];
            }
            Console.WriteLine("Минимальное значение среди максимальных элементов каждой строки ="+min);
            Console.ReadLine();
        }
    }
}
