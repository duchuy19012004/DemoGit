using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1_23DH111224_NguyenDucHuy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen thu nhat: ");
             int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so nguyen thu hai: ");
            int b = int.Parse(Console.ReadLine());
            if (a>b)
            {
                Console.WriteLine($"{a} la so lon nhat giua hai so");
            }
            else
            {
                Console.WriteLine($"{b} la so lon nhat giua hai so");
            }
        }
    }
}
