using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace EmployeeSystem
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public double Salary { get; set; }

        public void Raise (double percentage)
        {
            Salary = Salary + Salary * percentage / 100.0;
        }

        public override string ToString()
        {
            return Id + ", " + Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
