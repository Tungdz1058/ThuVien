using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThuVien.document;
using ThuVien.Interfaces;
namespace ThuVien.People
{
    public class DocGia
    {
        private string ten_doc_gia { get; set; }
        private bool reader { get; set; }

        public DocGia(string ten_doc_gia, bool reader)
        {
            this.ten_doc_gia = ten_doc_gia;
            this.reader = reader;
        }
        public void read(Read sach)
        {
            sach.read(reader, ten_doc_gia);
        }
        public void save(Save sach)
        {
            sach.save(reader, ten_doc_gia);
        }
        public void find(Find sach)
        {
            sach.find();
        }
        public void giaima(Giaima sach)
        {
            sach.giaima();
        }

        public void Mahoa(Mahoa sach)
        {
            sach.mahoa();
        }
        public void xemthongtin(TaiLieu sach)
        {
            sach.inthongtin();
        }
    }
}
