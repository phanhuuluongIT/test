using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập n: ");
            int n = int.Parse(Console.ReadLine());

            int[] fibonacci = new int[n]; 

            fibonacci[0] = 1;
            fibonacci[1] = 1;

            for (int i = 2; i < n; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }

            Console.WriteLine("Dãy Fibonacci:");

            for (int i = 0; i < n; i++)
            {
                Console.Write(" "+fibonacci[i]);
            }

            Console.ReadLine();
        }
    }
}
