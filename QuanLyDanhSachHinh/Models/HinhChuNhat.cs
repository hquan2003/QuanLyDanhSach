using QuanLyDanhSachHinh.Models;
using System.ComponentModel;

public class HinhChuNhat : Hinh
{
    [DisplayName("Chiều Dài")]
    [Description("Thông số chiều dài của hình chữ nhật")]
    public double ChieuDai { get; set; }

    [DisplayName("Chiều Rộng")]
    public double ChieuRong { get; set; }

    public override double DienTich => ChieuDai * ChieuRong;

    public override double ChuVi => 2 * (ChieuDai + ChieuRong);

    public override string ToString()
    {
        return $"Hình Chữ Nhật ID {ID}, Vật liệu {VatLieu}, Chiều dài {ChieuDai}, Chiều rộng {ChieuRong}, Diện tích {DienTich:F2}, Chu vi {ChuVi:F2}";
    }

    public override String ThongTin => $"Hình chữ nhật {ChieuDai:F2}x{ChieuRong:F2} - CV {ChuVi:F2}";
}