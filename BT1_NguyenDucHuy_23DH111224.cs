using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1_23DH111224
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input string: ");
            string stringNumber = Console.ReadLine();
            int intNumber = int.Parse(stringNumber);
            Console.WriteLine($"\"stringNumber\" value & type: {stringNumber}\n\"intNumber value\" & type: {intNumber.GetType()}");
        }
    }
}
