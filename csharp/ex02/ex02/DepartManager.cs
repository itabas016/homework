using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex02
{
    /// <summary>
    /// 部门经理类
    /// </summary>
    public class DepartManager : Employee
    {
        private Employee employee;
        private string nameDepart;
        private double performanceSalary;

        public Employee Employee { get { return employee; } set { employee = value; } }

        public string NameDeapart { get { return nameDepart; } }

        public double PerformanceSalary { get { return performanceSalary; } set { performanceSalary =value; } }

        public DepartManager(Employee employee, string nameDepart) : base(employee.Name, employee.WorkNum)
        {
            this.employee = employee;
            this.nameDepart = nameDepart;
            Employee.totalNum--;
        }

        ~DepartManager()
        {
            Console.WriteLine("离职: " + DateTime.Now);
        }

        public override double CalTotalSalary()
        {
            return base.CalTotalSalary() + performanceSalary;
        }

        public override string DisplayEmployeeInfo()
        {
            string info = base.DisplayEmployeeInfo();

            return string.Format("{0}\r\nDepartName - {1}", info, nameDepart);
        }

    }
}
