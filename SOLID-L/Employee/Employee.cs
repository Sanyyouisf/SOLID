using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_L
{
    public abstract class Employee : IEmployee , IEmployeeBonus
    {
        public int Id { get; set ;}
        public string Name { get; set; }
        public decimal Salary { get ; set ; }

        public Employee() { }

        public Employee(int id, string name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public abstract decimal GetBonus();

        public abstract decimal GetMinSalary();

        public override string ToString()
        {
            return string.Format("Id: {0} - Name: {1}", Id, Name);
        }

    }
}
