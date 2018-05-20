using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex0202
{
    public class Circle : Sharp
    {
        public double R { get; set; }

        public Circle(double r)
        {
            R = r;
        }

        public override double calculateArea()
        {
            return Math.PI * R * R;
        }

        public override string description()
        {
            return string.Format("圆，半径是{0}, 此圆的面积是{1}", R, calculateArea());
        }
    }
}
