using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThuVien.Interfaces;

namespace ThuVien
{

    public class Program
    {
        static void them(List<List<TaiLieu>> n)
        {
            Console.WriteLine("vui long nhap ten sach moi : ");
            string name = Console.ReadLine();
            Console.WriteLine("vui long nhap ten tac gia moi : ");
            string tacgia = Console.ReadLine();
            Console.WriteLine("vui long nhap noi dung sach moi : ");
            string content = Console.ReadLine();
            Console.WriteLine("vui long nhap ngay san xuat sach moi : ");
            string date = Console.ReadLine();

            n[0].Add(new Sach(name, tacgia, content, date));
        }
        static void Main(string[] args)
        {
            List<List<TaiLieu>> n = new List<List<TaiLieu>>();
            n.Add(new List<TaiLieu> { new Sach("sach lich su", "le dinh tung", "lich su Viet Nam", "5/9/2025")});
            n.Add(new List<TaiLieu> { new Sach("sach toan", "le dinh lam", "toan cao cap a3", "5/9/2026") });
            n[0][0].inthongtin();
            Console.WriteLine();
            n[1][0].inthongtin();
        }
    }
}
