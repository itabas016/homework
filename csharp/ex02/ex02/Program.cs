using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This console program is simple employee system.");

            Thread.Sleep(1000);
            Console.WriteLine("Add a new employee: 小明， 工号101，起薪2k");
            Employee e1 = new Employee("小明", 101);
            Console.WriteLine("显示小明的员工信息：");
            Console.WriteLine(e1.DisplayEmployeeInfo());

            Thread.Sleep(1000);
            Console.WriteLine("Add a new employee: 小李， 工号102，起薪2.5k");
            Employee e2 = new Employee("小李", 102, 2500);
            Console.WriteLine("显示小李的员工信息：");
            Console.WriteLine(e2.DisplayEmployeeInfo());

            Thread.Sleep(1000);
            Console.WriteLine("Add a new employee: 小王， 工号103，起薪5k");
            Employee e3 = new Employee("小王", 103, 5000);
            Console.WriteLine("显示小王的员工信息：");
            Console.WriteLine(e3.DisplayEmployeeInfo());

            Console.WriteLine("当前员工总数： " + Employee.totalNum);

            Thread.Sleep(3000);
            Console.WriteLine("一个月之后...");

            Thread.Sleep(5000);
            Console.WriteLine("公司效益不错，发奖金，小明 - 2w, 小李 - 1.5w, 小王 - 3w");

            e1.Rewards = 20000;
            e2.Rewards = 15000;
            e3.Rewards = 30000;

            Thread.Sleep(2000);
            Console.WriteLine("显示每个人的总收入：");
            Console.WriteLine("小明本月的总收入: " + e1.CalTotalSalary());
            Console.WriteLine("小李本月的总收入: " + e2.CalTotalSalary());
            Console.WriteLine("小王本月的总收入: " + e3.CalTotalSalary());

            Thread.Sleep(2000);
            Console.WriteLine("公司业务扩大，需要招纳新人。");

            Thread.Sleep(1000);
            Console.WriteLine("Add a new employee: 小张， 工号104，起薪3k");
            Employee e4 = new Employee("小张", 104, 3000);
            Console.WriteLine("显示小张的员工信息：");
            Console.WriteLine(e4.DisplayEmployeeInfo());

            Thread.Sleep(1000);
            Console.WriteLine("Add a new employee: 小吴， 工号105，起薪3k");
            Employee e5 = new Employee("小吴", 105, 3000);
            Console.WriteLine("显示小吴的员工信息：");
            Console.WriteLine(e5.DisplayEmployeeInfo());

            Thread.Sleep(2000);
            Console.WriteLine("当前员工总数： " + Employee.totalNum);

            Thread.Sleep(3000);
            Console.WriteLine("公司成立新部门 - 海外事业部， 小王担任部门经理");

            Thread.Sleep(1000);
            DepartManager m1 = new DepartManager(e3, "海外事业部");
            Console.WriteLine("显示此时小王的员工信息");
            Console.WriteLine(m1.DisplayEmployeeInfo());

            Thread.Sleep(2000);
            Console.WriteLine("为海外事业部小王增加部门经理绩效1w");
            m1.PerformanceSalary = 10000;

            Thread.Sleep(5000);
            Console.WriteLine("又过一个月之后...");

            Thread.Sleep(3000);
            Console.WriteLine("公司效益一般，发奖金，小明 - 1w, 小李 - 0.5w, 小王 - 2w， 小张 - 1w, 小吴 - 0.5w");

            e1.Rewards = 10000;
            e2.Rewards = 5000;
            m1.Rewards = 20000;
            e4.Rewards = 10000;
            e5.Rewards = 5000;

            Thread.Sleep(2000);
            Console.WriteLine("显示每个人的总收入：");
            Console.WriteLine("小明本月的总收入: " + e1.CalTotalSalary());
            Console.WriteLine("小李本月的总收入: " + e2.CalTotalSalary());
            Console.WriteLine("小王本月的总收入: " + m1.CalTotalSalary());
            Console.WriteLine("小张本月的总收入: " + e4.CalTotalSalary());
            Console.WriteLine("小吴本月的总收入: " + e5.CalTotalSalary());

            Thread.Sleep(3000);
            Console.WriteLine("十天后, 小吴离职...");
            e5 = null;

            Thread.Sleep(2000);
            Console.WriteLine("当前员工总数： " + Employee.totalNum);

            Console.ReadLine();
        }
    }
}
