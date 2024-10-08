using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyPhuongTienGiaoThong
{
    public abstract class  PhuongTien
    {
        public string TenPhuongTien {  get; set; }
        public string LoaiNhienLieu { get; set; }
        public PhuongTien(string TenPhuongTien, string LoaiNhienLieu)
        {
            this.TenPhuongTien = TenPhuongTien;
            this.LoaiNhienLieu = LoaiNhienLieu;
        }
        public abstract void DiChuyen();
        
    }
    interface IThongTinThem
    {
        int TocDoToiDa();
        double MucTieuThuNhienLieu();
    }
    class XeHoi : PhuongTien, IThongTinThem
    {
        public XeHoi(string TenPhuongTien, string LoaiNhienLieu): base(TenPhuongTien, LoaiNhienLieu)
        {

        }
        public override void DiChuyen()
        {
            Console.WriteLine($"{TenPhuongTien} dang di chuyen bang nhien lieu {LoaiNhienLieu}");
        }
        public int TocDoToiDa()
        {
           
            return 200;
        }
        public double MucTieuThuNhienLieu()
        {
            return 8;
        }
    }
    class XeDap : PhuongTien , IThongTinThem
    {
        public XeDap(string TenPhuongTien) : base(TenPhuongTien,"khong su dung nang luong")
        {

        }
        public override void DiChuyen()
        {
            Console.WriteLine($"{TenPhuongTien} dang di chuyen bang suc nguoi");
        }
        public int TocDoToiDa()
        {
            return 25;// toc do tai da  
        }
        public double MucTieuThuNhienLieu()
        {
            throw new NotImplementedException();
        }
    }
}
