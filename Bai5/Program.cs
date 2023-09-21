using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập chiều cao: ");
            int height = int.Parse(Console.ReadLine());

            for (int i = height; i >= 1; i--)
            { 
                for (int j = 1; j <= i; j++)
                { 
                    Console.Write("* "); 
                }
                Console.WriteLine(); 
            }
            Console.ReadLine();
        }

    }
}
