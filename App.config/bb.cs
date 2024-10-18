using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sử dụng phương pháp hoán đổi thủ công (giống phương pháp "Bubble Sort")
            Console.Write("Nhap so nguyen a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so nguyen b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap so nguyen c: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine($"Before swapping,\na = {a} , b = {b} , c = {c}");
            /// Hoán đổi theo phương pháp thủ công
            for (int i = 0; i < 2; i++)  // Lặp 2 lần để đảm bảo các số được sắp xếp
            {
                if (a > b)
                {
                    int temp = a;
                    a = b;
                    b = temp;
                }
                if (b > c)
                {
                    int temp = b;
                    b = c;
                    c = temp;
                }
            }

            // In giá trị sau khi hoán đổi
            Console.WriteLine("\nAfter swapping:");
            Console.WriteLine($"a = {a}, b = {b}, c = {c}");
        }
    }
}
