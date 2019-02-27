using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_L
{
    public class ContractEmp : IEmployee
    {
        public int Id { get ; set; }
        public string Name { get ; set ; }
        public decimal Salary { get; set; }

        public ContractEmp() { }

        public ContractEmp(int id, string name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public decimal GetMinSalary()
        {
            return Salary;
        }

        public override string ToString()
        {
            return string.Format("Contract - Id: {0} - Name: {1}",Id, Name);
        }
    }
}
