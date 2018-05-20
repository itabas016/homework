using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex0102
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program can show students grade in class.");
            Console.WriteLine("First input students number in class:");

            var count = Int32.Parse(Console.ReadLine());

            int i = 1;
            int s1 = 0;
            int s2 = 0;
            int s3 = 0;
            int s4 = 0;
            int s5 = 0;

            do
            {
                Console.WriteLine("Please input the student grade:");

                var grade = Int32.Parse(Console.ReadLine());
                if (grade > 0 && grade < 60)
                {
                    s1++;
                    Console.WriteLine("不及格");
                }
                if (grade >= 60 && grade < 70)
                {
                    s2++;
                    Console.WriteLine("及格");
                }
                if (grade >= 70 && grade < 80)
                {
                    s3++;
                    Console.WriteLine("中等");
                }
                if (grade >= 80 && grade < 90)
                {
                    s4++;
                    Console.WriteLine("良好");
                }
                if (grade >= 90 && grade <= 100)
                {
                    s5++;
                    Console.WriteLine("优秀");
                }

                i++;
            } while (i <= count);

            Console.WriteLine(string.Format("优秀人数为：{0}，占总人数比例为：{1}%", s5, ((double)s5 / (double)count * 100)));
            Console.WriteLine(string.Format("良好人数为：{0}，占总人数比例为：{1}%", s4, ((double)s4 / (double)count * 100)));
            Console.WriteLine(string.Format("中等人数为：{0}，占总人数比例为：{1}%", s3, ((double)s3 / (double)count * 100)));
            Console.WriteLine(string.Format("及格人数为：{0}，占总人数比例为：{1}%", s2, ((double)s2 / (double)count * 100)));
            Console.WriteLine(string.Format("不及格人数为：{0}，占总人数比例为：{1}%", s1, ((double)s1 / (double)count * 100)));

            Console.ReadLine();
        }
    }
}
