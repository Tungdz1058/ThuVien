using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThuVien.Interfaces;

namespace ThuVien.document
{
    public class TieuThuyet : TaiLieu, Find, Mahoa, Read, Save, Giaima, Sua
    {
        public TieuThuyet(string ten_tai_lieu, string tac_gia, string noi_dung, string ngay_sx) : base(ten_tai_lieu, tac_gia, noi_dung, ngay_sx)
        {
        }

        public void find()
        {
            Console.WriteLine($"da tim thay tieu thuyet {ten_tai_lieu}");
        }

        public void giaima()
        {
            Console.WriteLine($"thuc hien giai ma tieu thuyet boi tac gia {tac_gia}");
        }

        public void mahoa()
        {
            Console.WriteLine($"thuc hien ma hoa tieu thuyet boi tac gia {tac_gia}");
        }

        public void read(bool reader, string user_name)
        {
            if (reader)
            {
                Console.WriteLine($"doc gia {user_name} thuc hien doc: ");
                Console.WriteLine($"sach noi ve {noi_dung}");
            }
            else
            {
                Console.WriteLine($"thu thu {user_name} thuc hien doc: ");
                Console.WriteLine($"sach noi ve {noi_dung}");
            }
        }

        public void save(bool reader, string user_name)
        {
            if (reader) Console.WriteLine($"doc gia {user_name} da thuc hien luu tieu thuyet boi tac gia {ten_tai_lieu}");
            else Console.WriteLine($"thu thu {user_name} da thuc hien luu tieu thuyet boi tac gia {ten_tai_lieu}");
        }

        public void sua()
        {

            Console.WriteLine("vui long nhap ten tieu thuyet moi : ");
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
