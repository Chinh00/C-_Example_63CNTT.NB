using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH2
{
    public class HinhTron
    {
        public double BanKinh { get; set;}
        public double DuongKinh { get; set; }
        public double DienTich {
            get { return BanKinh * BanKinh * Math.PI;
            }
        }



    }
    public class HinhCau : HinhTron {

        new public double DienTich { 
            get {
                return 4 * Math.PI * BanKinh * BanKinh;
            } 
        }
        public double TheTich {
            get {
                return 4 / 3 * Math.PI * Math.Pow(BanKinh, 3);
            }
        }

        /*public static void Main(string[] args) {
            HinhTron hinhTron = new HinhTron();
            hinhTron.BanKinh = 10;
            Console.WriteLine(hinhTron.DienTich);
            HinhCau hinhCau = new HinhCau();
            hinhCau.BanKinh = 10;
            Console.WriteLine(hinhCau.DienTich);
            Console.WriteLine(hinhCau.TheTich);

        }*/

    }

}
