using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 10)
            {
                Console.WriteLine("error");
            }
            else
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine("error");
                }
                else
                {
                    int[,] X = new int[n, n];
                    int A = 0, B = n / 2;
                    X[A, B] = 1;
                    for (int i = 2; i <= n * n; i++)
                    {
                        A = (A - 1 + n) % n; B = (B - 1 + n) % n;
                        if (X[A, B] != 0)
                        {
                            A = (A + 2) % n; B = (B + 1) % n;
                        }
                        X[A, B] = i;
                    }
                    for (int j = 0; j < n; j++)
                    {
                        for (int k = 0; k < n; k++)
                        {
                            Console.Write("{0, 4}", X[j, k]);
                        }
                        Console.WriteLine();
                    }
                    Console.ReadKey();
                }
            }
        }
    }
}
