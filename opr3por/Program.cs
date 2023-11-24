using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using opr3;

namespace opr3por
{
    class Program
    {
        static void Main(string[] args)
        {
            matrix3 fnc = new matrix3();
            int[,] mtr = new int[3,3];
            Console.WriteLine("Введите элементы матрицы :");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    
                    mtr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Console.WriteLine("Матрица");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{mtr[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Определитель этой матрицы равен :");
            Console.WriteLine(fnc.opred3por(mtr));
            Console.ReadKey();

        }
    }
}
