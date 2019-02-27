using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    //the good design
    //make the employee class as abase abstract class and create child class for the new functionality
   public abstract class NewEmployee
   {
        public int Id { get; set; }
        public string Name { get; set; }

        public NewEmployee() { }

        public NewEmployee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public abstract decimal CalculateBonus(decimal salary);

        public override string ToString()
        {
            return string.Format("Id: {0} - Name: {1}", Id, Name);
        }
   }

    // creat new child class will be temp
    public class TempEmployee : NewEmployee
    {
        public string EmpType { get; set; }

        // the base here means that we assigning the id and name using the base class
        public TempEmployee(int id, string name, string type) :base(id,name)
        {
            Id = id;
            Name = name;
            EmpType = type;
        }

        public TempEmployee() { }

        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .3m;
        }
    }

    // creat another new child class will be temp
    public class PerEmployee : NewEmployee
    {
        public string EmpType { get; set; }

        public PerEmployee() { }

        public PerEmployee(int id, string name, string type) : base(id, name)
        {
            Id = id;
            Name = name;
            EmpType = type;
        }

        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .1m;
        }
    }

}
