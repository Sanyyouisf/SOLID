using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    //another good design
    //make the employee class as abase abstract class and create child class for the new functionality
    public abstract class NewEmployee2
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public NewEmployee2() { }

        public NewEmployee2(int id, string name)
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
    public class TempEmployee2 : NewEmployee2
    {
        // the base here means that we assigning the id and name using the base class
        public TempEmployee2(int id, string name) : base(id, name)
        {
            Id = id;
            Name = name;
        }

        public TempEmployee2() { }

        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .3m;
        }
    }

    // creat another new child class will be temp
    public class PerEmployee2 : NewEmployee2
    {
        public PerEmployee2() { }

        // the base here means that we assigning the id and name using the base class
        public PerEmployee2(int id, string name) : base(id, name)
        {
            Id = id;
            Name = name;
        }

        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .1m;
        }
    }
}
