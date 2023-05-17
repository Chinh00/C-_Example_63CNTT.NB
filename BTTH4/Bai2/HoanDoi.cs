using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class HoanDoi
    {
        public int a { get; set; }
        public int b { get; set; }

        public HoanDoi(int a, int b) {
            this.a = a; this.b = b; 
        }

        public void HoanVi() {
            int c = this.a;
            this.a = this.b;
            this.b = c;
        }


    }
}
