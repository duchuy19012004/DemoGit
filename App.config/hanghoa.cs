using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT7
{
    internal class hanghoa
    {
        static void Main(string[] args)
        {
            // Danh sách sản phẩm với mã sản phẩm và giá
            string[] productNames = { "Cochorro Quente", "X-Salada", "X-Bacon", "Torrada simples", "Refrigerante" };
            double[] productPrices = { 4.00, 4.50, 5.00, 2.00, 1.00 };

            // Nhập mã sản phẩm và số lượng
            Console.Write("Nhập mã sản phẩm (1-5): ");
            int code = int.Parse(Console.ReadLine());

            Console.Write("Nhập số lượng: ");
            int quantity = int.Parse(Console.ReadLine());

            // Tính tổng giá
            string productName = productNames[code - 1]; // Do mảng bắt đầu từ 0 nên cần trừ 1
            double price = productPrices[code - 1];
            double total = price * quantity;

            // Hiển thị kết quả với định dạng yêu cầu
            Console.WriteLine();
            Console.WriteLine("{0,-20} | {1,12} | {2,12} | {3,12}", "PRODUCT NAME", "PRICE", "QUANTITY", "TOTAL(R$)");
            Console.WriteLine("{0,-20} | {1,12:F2} | {2,12} | {3,12:F2}", productName, price, quantity, total);
        }
    }
}
