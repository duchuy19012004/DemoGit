using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap mot so nguyen: ");
        int n = int.Parse(Console.ReadLine());

        if (n > 0)
        {
            Console.WriteLine($"{n} la so duong");
        }
        else 
        { 
                Console.WriteLine($"{n} la so am");
        }
            if (n % 2 == 0)
            {
            Console.WriteLine($"{n} la so chan");
            }
        else
        {
            Console.WriteLine($"{n} la so le");
        }
    }
}


