using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVien
{
    public class Program
    {
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
