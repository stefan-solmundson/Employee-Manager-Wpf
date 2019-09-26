using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagerCSharp
{
    class Manager : Employee
    {
        private List<Employee> employees = new List<Employee>();

        public Manager(int employeeNum, string name) : base(employeeNum, name)
        {
        }

        public void AddEmployee(Employee empNew)
        {
            employees.Add(empNew);
        }

        public void RemoveEmployee(Employee existingEmp)
        {
            employees.Remove(existingEmp);
        }

        public override string PrintDetails()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(EmployeeNum + " ");
            sb.Append(name + " " + "\n");
            foreach (Employee e in employees)
            {
                sb.Append("Employee: " + e.name + "\n");
            }
            return sb.ToString();
        }
    }
}
