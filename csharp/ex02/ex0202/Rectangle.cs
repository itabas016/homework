using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex0202
{
    public class Rectangle : Sharp
    {
        public int Height { get; set; }

        public int Width { get; set; }

        public Rectangle(int height, int width)
        {
            this.Height = height;
            this.Width = width;
        }

        public override double calculateArea()
        {
            return Height * Width;
        }

        public override string description()
        {
            return string.Format("矩形，长和宽分别是{0}, {1}, 此矩形面积是{2}", Height, Width, calculateArea());
        }
    }
}
