using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[] { 23, 98, 41, -2, 69, 123,77,88,22,777};

            Console.WriteLine("原始資料");
            for (int j = 0; j < data.Length; j++)
                Console.WriteLine("{0}", data[j].ToString().PadLeft(4));
            Console.WriteLine("\n");

            int min_pos, temp;

            min_pos = temp = 0;

            for (int i = 0; i < data.Length - 1; i++)
            {
                min_pos = i;
                for (int j = i + 1; j < data.Length; j++)
                {
                    if (data[j] < data[min_pos])
                        min_pos = j;

                }
                temp = data[i];
                data[i] = data[min_pos];
                data[min_pos] = temp;

                Console.WriteLine("第{0}回合排序結果",i+1);
                for (int j = 0; j < data.Length; j++)
                    Console.WriteLine("{0}", data[j].ToString().PadLeft(4));
                Console.WriteLine();
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
