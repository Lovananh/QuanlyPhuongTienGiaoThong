using System;
using QuanlyPhuongTienGiaoThong;
public class Program
{
    public static void Main(string[] args)
    {
        List<PhuongTien> danhSachPhuongTien = new List<PhuongTien>();

        Console.WriteLine("Nhap so luong xe hoi:");
        int soLuongXeHoi = int.Parse(Console.ReadLine());

        for (int i = 0; i < soLuongXeHoi; i++)
        {
            Console.WriteLine("Nhap ten xe hoi:");
            string tenPhuongTien = Console.ReadLine();

            Console.WriteLine("Nhap loai nhien lieu:");
            string loaiNhienLieu = Console.ReadLine();

            danhSachPhuongTien.Add(new XeHoi(tenPhuongTien, loaiNhienLieu));
        }

        Console.WriteLine("Nhap so luong xe dap:");
        int soLuongXeDap = int.Parse(Console.ReadLine());

        for (int i = 0; i < soLuongXeDap; i++)
        {
            Console.WriteLine("Nhap ten xe dap:");
            string tenPhuongTien = Console.ReadLine();

            danhSachPhuongTien.Add(new XeDap(tenPhuongTien));
        }
        foreach (var phuongTien in danhSachPhuongTien)
        {
            phuongTien.DiChuyen();
            if (phuongTien is IThongTinThem thongTinThem)
            {
                Console.WriteLine($"Toc do toi da: {thongTinThem.TocDoToiDa()} km/h");
                try
                {
                    Console.WriteLine($"Muc tieu thu nang luong: {thongTinThem.MucTieuThuNhienLieu()} lit/100km");
                }
                catch (NotImplementedException)
                {
                    Console.WriteLine("Xe dap khong su dung nang luong.");
                }
            }
            Console.WriteLine();
        }
    }
}