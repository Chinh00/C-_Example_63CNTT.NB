

namespace BTTH2
{
    public class TamGiac
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        
        public double ChuVi { get {
                return (a + b + c);
            } 
        }

        public double DienTich { get {
                return Math.Sqrt((this.ChuVi / 2) * ((this.ChuVi / 2) - a) * ((this.ChuVi / 2) - b) * ((this.ChuVi / 2) - c));
            } 
        }

        public string KieuTamGiac() {
            var res = "TAM GIAC ";
            if (a * a + b * b == c * c || a * a == b * b + c * c || b * b == a * a + c * c) {  res += "VUONG"; }
            if (a == b && a == c) { res += "DEU"; }
            else if (a == b || b == c || c == a) { res += "CAN";  }
            return res;
        }

        public TamGiac(double a, double b, double c)
        {
            this.a = a; this.b = b; this.c = c;
        }
        public TamGiac() {}
        

    }
}
