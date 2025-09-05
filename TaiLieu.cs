using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ThuVien
{
    public class TaiLieu
    {
        protected string ten_tai_lieu { get; set; }
        protected string tac_gia { get; set; }
        protected string noi_dung { get; set; }
        protected string ngay_sx { get; set; }

        public TaiLieu(string ten_tai_lieu,string tac_gia,string noi_dung,string ngay_sx)
        {
            this.ten_tai_lieu = ten_tai_lieu;
            this.tac_gia = tac_gia;
            this.noi_dung = noi_dung;
            this.ngay_sx = ngay_sx;

        }

        public virtual void inthongtin()
        {
            Console.WriteLine($"tai lieu ten la: {ten_tai_lieu}");
            Console.WriteLine($"tac gia cua tai lieu la: {tac_gia}");
            Console.WriteLine($"noi dung cua tai lieu la: {noi_dung}");
            Console.WriteLine($"ngay san xuat la: {ngay_sx}");
        }
    }
}
