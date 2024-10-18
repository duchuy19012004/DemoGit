using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen a: ");
             int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so nguyen b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap so nguyen c: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine($"Before swapping,\na = {a} , b = {b} , c = {c}");
            // Hoán đổi để a, b, c có giá trị tăng dần
            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }

            if (a > c)
            {
                int temp = a;
                a = c;
                c = temp;
            }

            if (b > c)
            {
                int temp = b;
                b = c;
                c = temp;
            }

            // In giá trị sau khi hoán đổi
            Console.WriteLine("\nAfter swapping:");
            Console.WriteLine($"a = {a}, b = {b}, c = {c}");
        }
    }
}
