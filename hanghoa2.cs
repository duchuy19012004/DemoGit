using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace BT7
{
    internal class hanghoa1
    {
        static void Main(string[] args)
        {
            // Nhap ma san pham va so luong
            Console.Write("Nhap ma san pham (1-5): ");
            int ma = int.Parse(Console.ReadLine());

            // Kiem tra ma san pham hop le
            if (ma < 1 || ma > 5)
            {
                Console.WriteLine("Ma san pham khong hop le.");
                return;
            }

            Console.Write("Nhap so luong: ");
            int soLuong = int.Parse(Console.ReadLine());

            string tenSanPham; // Khong can khoi tao gia tri ban dau
            double gia;        // Khong can khoi tao gia tri ban dau

            // Su dung switch de lua chon san pham va gia
            switch (ma)
            {
                case 1:
                    tenSanPham = "Cochorro Quente";
                    gia = 4.00;
                    break;
                case 2:
                    tenSanPham = "X-Salada";
                    gia = 4.50;
                    break;
                case 3:
                    tenSanPham = "X-Bacon";
                    gia = 5.00;
                    break;
                case 4:
                    tenSanPham = "Torrada simples";
                    gia = 2.00;
                    break;
                case 5:
                    tenSanPham = "Refrigerante";
                    gia = 1.00;
                    break;
                default:
                    return; // Khong can thiet nhung du phong
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
       
  
