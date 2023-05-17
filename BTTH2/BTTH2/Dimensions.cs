using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH2
{
    public interface IDimensions
    {
        long width { get; set; }
        long height { get; set; }
        double Area();
        double Circumference();
        int Sides();
    }
    internal class Rectangle : IDimensions
    {
        public long _width { get; set; }
        public long width {
            get
            {
                return _width;
            }
            set {
                _width = value; 
            } 
        }
        public long _height { get; set; }
        public long height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }


        public double Area()
        {
            return width * height;
        }

        public double Circumference()
        {
            return (width + height) * 2; 
        }

        public int Sides()
        {
            throw new NotImplementedException();
        }

        /*public static void Main(string[] args) {
            Rectangle rectangle = new Rectangle();  
            rectangle.width = 100;
            rectangle.height = 100;
            Console.WriteLine(rectangle.Circumference());
        }*/
    }
    

}
