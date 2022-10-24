using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work
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
            for (int i = 0; i < data.Length-1; i++) 
            for (int j = 0; j < data.Length-1-i; j++) 
            {
                if(data[j] > data[j+1])
                {
                    temp = data[j];
                    data[j] = data[j + 1];
                    data[j + 1] = temp;

                }
            }
            Console.WriteLine("總共{0}筆資料", n);
            Console.WriteLine("排序後的順序:\n");
            for (int i = 0; i < data.Length; i++)
                Console.Write("{0}", data[i]);
            Console.WriteLine("\nPress any key to continue.....");
            Console.ReadKey();


        }
    }
}
