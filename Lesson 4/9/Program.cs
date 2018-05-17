using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program

    {
        static void Main(string[] args)
        {
            int[,] matr = { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };
            int n = (int)(Math.Sqrt(matr.Length)) ;
            int k = 0;
            int i1 = 0;
            for (int j = 0; j < n; j++)
            {
                if (matr[i1, j] != matr[0, 0])
                {
                    Console.WriteLine("Матрица не является произведением единичной матрицы на число.");
                    Console.ReadLine();
                    return;
                }
                i1++;
            }
            for (int i = 0; i < n; i++)
                for (int j=0; j<n; j++)
                    if (i!=j)
                        if (matr[i,j]!=0)
                        {
                            Console.WriteLine("Матрица не является произведением единичной матрицы на число.");
                            Console.ReadLine();
                            return;
                        }
                Console.WriteLine("Матрица является произведением единичной матрицы на число.");
            Console.ReadLine();
        }
    }
}