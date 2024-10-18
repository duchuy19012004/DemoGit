using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen thu nhat: ");
             int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so nguyen thu hai: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap so nguyen thu ba: ");
            int c = int.Parse(Console.ReadLine());
           int max = a; //Gan a la so lon nhat
            if (b > max) 
            {
            max = b; 
            }
            if (c > max)
            {
            max = c;
            }
            Console.WriteLine($"So lon nhat giua 3 so nguyen la: {max}");
        }
    }
}
