using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDanhSachHinh.Models; // Chu y: Bo sung menh de using nay!

namespace QuanLyDanhSachHinh.DAO
{
    public class HinhDAO
    {
        private const String LoaiHinh_Tron = "T";
        private const String LoaiHinh_HinhChuNhat = "HCN";

        private String FilePath;

        public HinhDAO(String filePath)
        {
            this.FilePath = filePath;
        }

        public List<Hinh> DocHinhTuFile()
        {
            var lstHinh = new List<Hinh>();

            foreach (var line in File.ReadLines(FilePath))
            {
                var parts = line.Split('|');
                if (parts.Length < 4) continue;

                var id = int.Parse(parts[0].Trim());
                var loaiHinh = parts[1].Trim();
                var vatLieu = parts[2].Trim();

                Hinh hinh = null;

                if (loaiHinh.Equals(LoaiHinh_Tron, StringComparison.OrdinalIgnoreCase))
                {
                    var banKinh = double.Parse(parts[3].Trim());
                    hinh = new HinhTron { ID = id, VatLieu = vatLieu, BanKinh = banKinh };
                    //hinh = new HinhTron();
                    //hinh.ID = id;
                    //hinh.VatLieu = vatLieu;
                }
                else if (loaiHinh.Equals(LoaiHinh_HinhChuNhat, StringComparison.OrdinalIgnoreCase))
                {
                    var chieuDai = double.Parse(parts[3].Trim());
                    var chieuRong = double.Parse(parts[4].Trim());
                    hinh = new HinhChuNhat { ID = id, VatLieu = vatLieu, ChieuDai = chieuDai, ChieuRong = chieuRong };
                }

                if (hinh != null)
                {
                    lstHinh.Add(hinh);
                }
            }

            return lstHinh;
        }

        public void LuuHinhVaoFile(List<Hinh> danhSachHinh)
        {
            using (var writer = new StreamWriter(this.FilePath))
            {
                foreach (var hinh in danhSachHinh)
                {
                    if (hinh is HinhTron hinhTron)
                    {
                        writer.WriteLine($"{hinh.ID}|{LoaiHinh_Tron}|{hinh.VatLieu}|{hinhTron.BanKinh}");
                    }
                    else if (hinh is HinhChuNhat hinhChuNhat)
                    {
                        writer.WriteLine($"{hinh.ID}|{LoaiHinh_HinhChuNhat}|{hinh.VatLieu}|{hinhChuNhat.ChieuDai}|{hinhChuNhat.ChieuRong}");
                    }
                }
            }
        }
    }
}