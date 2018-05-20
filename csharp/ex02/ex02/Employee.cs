using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex02
{
    /// <summary>
    /// 员工类
    /// </summary>
    public class Employee
    {
        private int workNum;
        private string name;
        private double basicSalary;
        private double rewards;
        private double totalSalary;
        public static int totalNum;

        public int WorkNum { get { return workNum; } set { workNum = value; } }
        public string Name { get { return name; } set { name = value; } }
        public double BasicSalary { get { return basicSalary; } set { basicSalary = value; } }
        public double Rewards { get { return rewards; } set { rewards = value; } }
        public double Salary { get { return CalTotalSalary(); } }

        public Employee(string name, int workNum)
        {
            this.name = name;
            this.workNum = workNum;
            this.basicSalary = 2000;
            totalNum++;
        }

        public Employee(string name, int workNum, double basicSalary)
        {
            this.name = name;
            this.workNum = workNum;
            this.basicSalary = basicSalary;
            totalNum++;
        }

        ~Employee()
        {
            totalNum--;
        }


        /// <summary>
        /// 计算应发工资，基本工资+奖金
        /// </summary>
        public virtual double CalTotalSalary()
        {
            return this.basicSalary + this.rewards;
        }

        /// <summary>
        /// 显示员工当前信息
        /// </summary>
        public virtual string DisplayEmployeeInfo()
        {
            return string.Format("Employee Info: \r\nName - {0}\r\nWorkNum - {1}\r\nBaseSalary - {2}", this.name, this.workNum, this.Salary);
        }

        /// <summary>
        /// 显示总员工人数
        /// </summary>
        public int DisplayTotalNumber()
        {
            return totalNum;
        }
    }
}
