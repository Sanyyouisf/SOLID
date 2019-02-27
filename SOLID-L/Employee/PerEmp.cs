using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_L
{
    public class PerEmp : Employee
    {
        public PerEmp() { }

        public PerEmp(int id, string name, decimal salary) : base(id, name, salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public override decimal GetMinSalary()
        {
            return Salary;
        }

        public override decimal GetBonus()
        {
            return Salary* .5M;
        }
    }
}
