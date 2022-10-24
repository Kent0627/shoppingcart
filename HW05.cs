using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[] { 3, 4, 1, 7, 8 ,37,98,75,66,77};
            Console.WriteLine("排序前原始資料");
            for (int i = 0; i < data.Length; i++)
                Console.WriteLine("{0}", data[i].ToString().PadLeft(3));
            Console.WriteLine();

            int temp = 0;
            for(int i=1;i<data.Length;i++)
            {
                temp = data[i];
                for(int j = i-1;j>=0;j--)
                {
                    if(data[j]>temp)
                    {
                        data[j + 1] = data[j];
                        if (j == 0) data[j] = temp;

                    }
                    else
                    {
                        data[j + 1] = temp;
                        break;
                    }
                }
                Console.WriteLine("第{0}回合排序",i);
                for (int j = 0; j < data.Length; j++)
                    Console.WriteLine("{0}", data[j].ToString().PadLeft(3));
                Console.WriteLine();
            }










            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();        }
    }
}
