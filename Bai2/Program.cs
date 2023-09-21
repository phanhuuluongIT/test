using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Cách 1 ");
            Console.Write("Nhập a : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhập b : ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhập c : ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Nhập d : ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Nhập e : ");
            int e = int.Parse(Console.ReadLine());

            int max = a;

            if(b> max)
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }
            if (d > max)
            {
                max = d;
            }
            if (e > max)
            {
                max = e;
            }

            Console.WriteLine("Số lớn nhất trong 5 số {0},{1},{2},{3},{4} là : {5}",a,b,c,d,e,max);

            Console.WriteLine("Cách 2 ");

            int[] numbers  = new int[5];

            for(int i= 0; i<5; i++)
            {
                Console.Write("Nhập số thứ " + (i + 1) + " là : ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int max2 = numbers[0];

            for(int i = 1; i<5; i++)
            {
                if (numbers[i]> max2)
                {
                    max2 = numbers[i];
                }
            }

            Console.WriteLine("Số lớn nhất trong 5 số là: " + max2);
            Console.ReadLine();
        }
    }
}
