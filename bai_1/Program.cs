using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String hoTen;
            float diemVan;
            float diemToan;
            Console.WriteLine("Nhap ho ten");
            hoTen = Console.ReadLine();

            Console.WriteLine("Moi nhap diem van");
            diemVan = float.Parse(Console.ReadLine());

            Console.WriteLine("Moi nhap diem Toan");
            diemToan = float.Parse(Console.ReadLine());
            

            Console.WriteLine("Ho va ten {0} diem toan {1} diem van{2} ", hoTen, diemToan, diemVan);
            Console.ReadLine();
Console.ReadKey();




        }
    }
}
