using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5
{
    internal class ptbac2
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so a (a khac 0): ");
             int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
             int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap so c: ");
             int c = int.Parse(Console.ReadLine());
            if (a == 0)
            {
            Console.WriteLine("Vui long nhap lai 1 so khac 0");
            }
            else
            {
            double delta = b*b - 4 * a * c;
                if (delta > 0)
                {
                    double x1 = (-b + Math.Sqrt(delta)) / 2 * a;
                    double x2 = (-b - Math.Sqrt(delta)) / 2 * a;
                    Console.WriteLine($"PT co 2 nghiem phan biet: \nx1 = {x1}\nx2 = {x2}");
                }
                else if (delta == 0)
                {
                    double x = -b / 2 * a;
                Console.WriteLine($"Pt co nghiem kep: \nx = {x}");
                }
                else
                {
                    Console.WriteLine("PTVN");
                }
            }
        }
    }
}
