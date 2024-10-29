using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDanhSachHinh.Models
{
    public class Hinh
    {
        public int ID { get; set; }
        public string VatLieu { get; set; }

        public virtual double DienTich { get; }
        public virtual double ChuVi { get; }

        public virtual String ThongTin { get; }
    }
}