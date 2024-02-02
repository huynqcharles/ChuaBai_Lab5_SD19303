using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuaBai_Lab5_SD19303
{
    internal class QLDongVatHoangDa
    {
        public List<DongVatHoangDa> DanhSachDVHD { get; set; } 

        public QLDongVatHoangDa()
        {
            DanhSachDVHD = new List<DongVatHoangDa>();
        }

        public void ThemDongVat()
        {
            int tiepTuc = -1;
            do
            {
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Ten: ");
                string ten = Console.ReadLine();
                Console.Write("Loai: ");
                string loai = Console.ReadLine();

                DongVatHoangDa dongVatHoangDa = new DongVatHoangDa(id, ten, loai);
                this.DanhSachDVHD.Add(dongVatHoangDa);

                Console.Write("Ban co muon tiep tuc khong (1-co/2-khong): ");
                tiepTuc = int.Parse(Console.ReadLine());
            } while (tiepTuc == 1);
        }

        public void XuatDSDongVat()
        {
            foreach (DongVatHoangDa dvhd in this.DanhSachDVHD)
            {
                dvhd.InThongTin();
            }
        }

        public void XuatDSDongVatTheoLoai()
        {
            Console.Write("Nhap vao loai muon xuat: ");
            string loai = Console.ReadLine();
            foreach (DongVatHoangDa dvhd in this.DanhSachDVHD)
            {
                if (dvhd.GetLoai().Equals(loai))
                {
                    dvhd.InThongTin();
                }
            }
        }

        public void TimDongVatTheoID()
        {
            Console.Write("Nhap vao ID muon tim: ");
            int id = int.Parse(Console.ReadLine());
            foreach (DongVatHoangDa dvhd in this.DanhSachDVHD)
            {
                if (dvhd.GetID().Equals(id))
                {
                    dvhd.InThongTin();
                }
            }
        }
    }
}
