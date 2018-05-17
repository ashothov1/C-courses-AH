using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            double[] Array = new double [n];
            double[] ArifArray = new double[n];
            Random ex = new Random();
            Console.WriteLine("Исходный массив");
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = ex.Next(1,40);
                Console.Write(Array[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Новый массив");
            ArifArray[n-1] = ((Array[0] + Array[n-1]) / 2);
            for (int i = 0; i < Array.Length-1; i++)
            {
                ArifArray[i] = ((Array[i]+Array[i+1])/2);
            }
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write(ArifArray[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
