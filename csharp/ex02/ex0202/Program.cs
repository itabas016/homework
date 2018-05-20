using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ex0202
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program is abount Triangle, Rectangle and Circle.");

            Console.WriteLine("请输入一个三角形的三条边，3 4 5");

            Thread.Sleep(2000);
            var s1 = new Triangle(3, 4, 5);
            Console.WriteLine(s1.description());

            Console.WriteLine("请输入一个矩形的长和宽，8 10");
            Thread.Sleep(2000);
            var s2 = new Rectangle(8, 10);
            Console.WriteLine(s2.description());

            Console.WriteLine("请输入一个圆的半径，6");

            Thread.Sleep(2000);
            var s3 = new Circle(6);
            Console.WriteLine(s3.description());

            Console.ReadLine();
        }
    }
}
