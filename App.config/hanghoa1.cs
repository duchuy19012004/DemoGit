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
            string tenSanPham = "";
            double gia = 0.0;

            // Nhap ma san pham va so luong
            Console.Write("Nhap ma san pham (1-5): ");
            int ma = int.Parse(Console.ReadLine());

            Console.Write("Nhap so luong: ");
            int soLuong = int.Parse(Console.ReadLine());

            // Cau truc lua chon if-else de chon san pham va gia
            if (ma == 1)
            {
                tenSanPham = "Cochorro Quente";
                gia = 4.00;
            }
            else if (ma == 2)
            {
                tenSanPham = "X-Salada";
                gia = 4.50;
            }
            else if (ma == 3)
            {
                tenSanPham = "X-Bacon";
                gia = 5.00;
            }
            else if (ma == 4)
            {
                tenSanPham = "Torrada simples";
                gia = 2.00;
            }
            else if (ma == 5)
            {
                tenSanPham = "Refrigerante";
                gia = 1.00;
            }
            else
            {
                Console.WriteLine("Ma san pham khong hop le.");
                return; // Ket thuc chuong trinh neu ma khong hop le
            }

            // Tinh tong gia
            double tong = gia * soLuong;

            // Hien thi ket qua voi dinh dang yeu cau
            Console.WriteLine();
            Console.WriteLine("{0,-20} | {1,12} | {2,12} | {3,12}", "PRODUCT NAME", "PRICE", "QUANTITY", "TOTAL(R$)");
            Console.WriteLine("{0,-20} | {1,12:F2} | {2,12} | {3,12:F2}", tenSanPham, gia, soLuong, tong);
        }
    }
}
