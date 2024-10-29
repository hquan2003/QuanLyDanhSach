using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDanhSachHinh.Models
{
    public class HinhTron : Hinh
    {
        public double BanKinh { get; set; }

        public override double DienTich => Math.PI * BanKinh * BanKinh;

        public override double ChuVi => 2 * Math.PI * BanKinh;

        public override String ThongTin => $"Hình tròn bán kính {BanKinh} - CV {ChuVi:F2}";

        public override string ToString()
        {
            return $"Hình tròn - ID {ID}, Vật liệu {VatLieu}, Bán kính {BanKinh}, Diện tích {DienTich:F2}, Chu vi {ChuVi:F2}";
        }
    }
}