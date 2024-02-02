using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuaBai_Lab5_SD19303
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            int luaChon = -1;
            QLDongVatHoangDa qLDongVatHoangDa = new QLDongVatHoangDa();
            do
            {
                Console.WriteLine("Quan Ly Dong Vat Hoang Da");
                Console.WriteLine("1. Nhap 1 hoac nhieu dong vat");
                Console.WriteLine("2. Xuat danh sach dong vat");
                Console.WriteLine("3. Xuat danh sach dong vat theo loai");
                Console.WriteLine("4. Tim dong vat theo ID");
                Console.WriteLine("5. Ke thua");
                Console.WriteLine("0. Thoat");
                Console.Write("Xin moi lua chon: ");
                luaChon = int.Parse(Console.ReadLine());

                switch (luaChon)
                {
                    case 1:
                        qLDongVatHoangDa.ThemDongVat();
                        break;
                    case 2:
                        qLDongVatHoangDa.XuatDSDongVat();
                        break;
                    case 3:
                        qLDongVatHoangDa.XuatDSDongVatTheoLoai();
                        break;
                    case 4:
                        qLDongVatHoangDa.TimDongVatTheoID();
                        break;
                    case 5:
                        ChucNang5();
                        break;
                    default:
                        Console.WriteLine("Chi nhap tu 0-4.");
                        break;
                }
            } while (luaChon != 0);
        }

        static void ChucNang5()
        {
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Ten: ");
            string ten = Console.ReadLine();
            Console.Write("Loai: ");
            string loai = Console.ReadLine();
            Console.Write("Muc Nguy Cap: ");
            string mucNguyCap = Console.ReadLine();

            DongVatnguyCap dongVatnguyCap = new DongVatnguyCap(id, ten, loai, mucNguyCap);
            dongVatnguyCap.InThongTin();
        }
    }
}
