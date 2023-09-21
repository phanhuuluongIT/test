using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            
            Console.WriteLine("Nhập ký tự thường : ");
            char lowerCase = Console.ReadLine()[0];

            char upperCase = Char.ToUpper(lowerCase);

            Console.WriteLine("Ký tự in hoa : "+upperCase);
            Console.ReadLine();
        }
    }
}
