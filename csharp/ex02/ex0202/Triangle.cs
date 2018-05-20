using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex0202
{
    public class Triangle : Sharp
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public Triangle(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;

            if (!IsValidTriangle(a, b, c))
            {
                throw new Exception("输入的三条边不能构成三角形。");
            }
        }


        public override double calculateArea()
        {
            double p = (A + B +C ) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public override string description()
        {
            return string.Format("三角形，三条边分别是{0}, {1}, {2}, 此三角形面积是{3}", A, B, C, calculateArea());
        }

        private static bool IsValidTriangle(int a, int b, int c)
        {
            return (a + b > c && a + c > b && b + c > a);
        }
    }
}
