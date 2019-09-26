using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagerWpf
{
    class Employee
    {
        private int employeeNum;

        public int EmployeeNum
        {
            get { return employeeNum; }
            set { employeeNum = value; }
        }

        public string name { get; set; }

        // CONSTRUCTOR
        public Employee(int employeeNum, string name)
        {
            this.employeeNum = employeeNum;
            this.name = name;
        }

        public virtual string PrintDetails()
        {
            return employeeNum + " " + name;
        }
    }
}
