using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
   {
    static void Main(string[] args)
    {
            int temp = 0;
            Random ran = new Random();
            int n = ran.Next(10, 21);
            int[] data = new int[n];

for (int i = 0; i < data.Length; i++)
                data[i] = ran.Next(-50, 51);


            Console.WriteLine("雞尾酒演算法");
        Console.WriteLine("排序前的資料:");
        for (int i = 0; i < data.Length; i++)
            Console.Write("{0}", data[i]);
        Console.WriteLine("\n");

        int start = 0;
        int end = data.Length;

        for (int i = start; i < end - 1; i++)
        {
            for (int j = start; j < end - 1; j++)
            {
                if (data[j] > data[j + 1])
                {
                    temp = data[j];
                    data[j] = data[j + 1];
                    data[j + 1] = temp;
                }
            }
            end = end - 1;
            for (int j = end; j > start; j--)
            {
                if (data[j] > data[j - 1])
                {
                    temp = data[j];
                    data[j] = data[j - 1];
                    data[j - 1] = temp;
                }
            }
            start = start + 1;
            Console.Write("第{0}回合排序\t", i + 1);
            for (int k = 0; k < data.Length; k++)
                Console.Write("{0}", data[k].ToString().PadLeft(3));
            Console.WriteLine();
        }

            Console.WriteLine("\n最後排序的資料:");
            for (int i = 0; i < data.Length; i++)
                Console.Write("{0}", data[i]);
            Console.WriteLine("\nPress any key to continue.....");
            Console.ReadKey();
        }
           
        }
    }
