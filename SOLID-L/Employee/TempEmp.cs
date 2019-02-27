using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_L
{
    public class TempEmp : Employee
    {
        public TempEmp() { }

        public TempEmp(int id, string name, decimal salary) : base(id, name, salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public override decimal GetBonus()
        {
          return Salary*.6m;
        }

        public override decimal GetMinSalary()
        {
            return Salary;
        }
    }
}
