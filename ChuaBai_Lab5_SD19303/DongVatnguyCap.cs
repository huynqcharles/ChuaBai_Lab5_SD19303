using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuaBai_Lab5_SD19303
{
    internal class DongVatnguyCap : DongVatHoangDa
    {
        private string MucNguyCap { get; set; }

        public DongVatnguyCap()
        {

        }

        public DongVatnguyCap(int iD, string ten, string loai, string mucNguyCap) : base(iD, ten, loai)
        {
            MucNguyCap = mucNguyCap;
        }

        public override void InThongTin()
        {
            base.InThongTin();
            Console.WriteLine("Muc nguy cap: " + this.MucNguyCap);
        }
    }
}
