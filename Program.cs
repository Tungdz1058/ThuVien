using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThuVien.document;
using ThuVien.Interfaces;
using ThuVien.People;

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
            n.Add(new List<TaiLieu> { new Sach("sach lich su", "Tran Ngo Anh Tu", "lich su Viet Nam", "5/9/2025")});
            n.Add(new List<TaiLieu> { new TieuThuyet("Doraemon", "le dinh lam", "tap phim nhan doi cap so nhan", "5/9/2026") });
            Console.WriteLine("ban la ai : 1_Thu Thu || 2_Doc Gia");
            int val = int.Parse(Console.ReadLine());
            if(val == 1)
            {
                ThuThu a = new ThuThu("Le Dinh Tung", false);
                Console.WriteLine("ban muon thuc hien thao tac nao:");
                Console.WriteLine("1_Doc sach:");
                Console.WriteLine("2_Luu sach:");
                Console.WriteLine("3_Them sach:");
                Console.WriteLine("4_Giai ma sach:");
                Console.WriteLine("5_Ma hoa sach:");
                Console.WriteLine("6_Chinh sua sach:");
                Console.WriteLine("7_xem thong tin cua sach:");
                int val1 = int.Parse(Console.ReadLine());
                switch (val1)
                {
                    case 1:
                        if (n[0][0] is Read r)
                        {
                            a.read(r);
                        }
                        break;
                    case 2:
                        if (n[0][0] is Save s)
                        {
                            a.save(s);
                        }
                        break;
                }

            }
        }
    }
}
