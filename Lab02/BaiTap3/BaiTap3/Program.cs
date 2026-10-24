using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap3
{
    struct MatHang
    {
        public int MaMH;
        public string TenMH;
        public int SoLuong;
        public float DonGia;
        public MatHang(int MaMH, string TenMH, int SoLuong, float DonGia)
        {
            this.MaMH = MaMH;
            this.TenMH = TenMH;
            this.SoLuong = SoLuong;
            this.DonGia = DonGia;
        }

        public float ThanhTien()
        {
            return SoLuong * DonGia;
        }
    }

    internal class Program
    {
        // Ham them mat hang
        static void ThemMatHang(Hashtable danhsach, MatHang m)
        {
            danhsach.Add(m.MaMH, m);
        }

        // Ham tim mot mat hang
        static bool TimMatHang(Hashtable danhsach, int MaMH)
        {
            return danhsach.ContainsKey(MaMH);
        }

        // Ham xoa mat hang
        static void XoaMatHang(Hashtable danhsach, int MaMH)
        {
            if (TimMatHang(danhsach, MaMH))
                danhsach.Remove(MaMH);
        }
        // Ham xuat danh sach mat hang

        static void XuatDanhSach(Hashtable danhsach)
        {
            if (danhsach.Count == 0)
            {
                Console.WriteLine("Danh sach mat hang rong.");
                return;
            }

            foreach (DictionaryEntry item in danhsach)
            {
                MatHang m = (MatHang)item.Value;

                Console.WriteLine(
                    "Ma MH: " + m.MaMH +
                    ", Ten MH: " + m.TenMH +
                    ", So luong: " + m.SoLuong +
                    ", Don gia: " + m.DonGia +
                    ", Thanh tien: " + m.ThanhTien());
            }
        }

        static void Main(string[] args)
        {
            Hashtable danhsach = new Hashtable();
            string tieptuc;

            // Nhap danh sach mat hang
            do
            {
                Console.Write("Nhap ma mat hang: ");
                int MaMH = int.Parse(Console.ReadLine());

                Console.Write("Nhap ten mat hang: ");
                string TenMH = Console.ReadLine();

                Console.Write("Nhap so luong: ");
                int SoLuong = int.Parse(Console.ReadLine());

                Console.Write("Nhap don gia: ");
                float DonGia = float.Parse(Console.ReadLine());

                MatHang m = new MatHang(MaMH, TenMH, SoLuong, DonGia);

                if (!TimMatHang(danhsach, MaMH))
                {
                    ThemMatHang(danhsach, m);
                    Console.WriteLine("Them mat hang thanh cong.");
                }
                else
                {
                    Console.WriteLine("Ma mat hang da ton tai.");
                }

                Console.Write("Ban co muon nhap tiep khong? (c/k): ");
                tieptuc = Console.ReadLine().ToLower();

            } while (tieptuc == "c");

            // Xuat danh sach
            Console.WriteLine("\nDanh sach mat hang:");
            XuatDanhSach(danhsach);

            // Tim va xoa mat hang
            Console.Write("\nNhap ma mat hang can tim va xoa: ");
            int maCanXoa = int.Parse(Console.ReadLine());

            if (TimMatHang(danhsach, maCanXoa))
            {
                XoaMatHang(danhsach, maCanXoa);

                Console.WriteLine("Da xoa mat hang.");
                Console.WriteLine("\nDanh sach sau khi xoa:");
                XuatDanhSach(danhsach);
            }
            else
            {
                Console.WriteLine("Khong tim thay mat hang.");
            }
        }
    }
}
