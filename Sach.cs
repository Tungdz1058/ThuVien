
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ThuVien.Interfaces;

namespace ThuVien
{
    public class Sach : TaiLieu, Save, Sua, Read, Find, Giaima, Mahoa
    {
        public Sach(string ten_tai_lieu, string tac_gia, string noi_dung, string ngay_sx) : base(ten_tai_lieu, tac_gia, noi_dung, ngay_sx)
        {
        }

        public void find()
        {
            Console.WriteLine($"da tim thay sach {ten_tai_lieu}");
        }

        public void giaima()
        {
            Console.WriteLine($"thuc hien giai ma sach boi tac gia {tac_gia}");
        }

        public void mahoa()
        {
            Console.WriteLine($"thuc hien ma hoa sach boi tac gia {tac_gia}");
        }

        public void read()
        {
            Console.WriteLine($"sach noi ve {noi_dung}");
        }

        public void Save()
        {
            Console.WriteLine($"thuc hien luu sach boi tac gia {ten_tai_lieu}");
        }

        public void sua()
        {
            
            Console.WriteLine("vui long nhap ten sach moi : ");
            string name = Console.ReadLine();
            Console.WriteLine("vui long nhap ten tac gia moi : ");
            string tacgia = Console.ReadLine();
            Console.WriteLine("vui long nhap noi dung sach moi : ");
            string content = Console.ReadLine();
            Console.WriteLine("vui long nhap ngay san xuat sach moi : ");
            string date = Console.ReadLine();

            this.ten_tai_lieu = name;
            this.tac_gia = tacgia;
            this.noi_dung = content;
            this.ngay_sx = date;
        }

        public override void inthongtin()
        {
            base.inthongtin();
        }

    }

}
