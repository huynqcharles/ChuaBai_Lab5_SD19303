using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuaBai_Lab5_SD19303
{
    internal class DongVatHoangDa
    {
        private int ID { get; set; }
        private string Ten { get; set; }
        private string Loai { get; set; }

        public DongVatHoangDa()
        {
            
        }

        public DongVatHoangDa(int iD, string ten, string loai)
        {
            ID = iD;
            Ten = ten;
            Loai = loai;
        }

        public virtual void InThongTin()
        {
            Console.WriteLine($"ID: {this.ID} - Ten: {this.Ten} - Loai: {this.Loai}");
        }

        public string GetLoai()
        {
            return this.Loai;
        }

        public int GetID()
        {
            return this.ID;
        }
    }
}
