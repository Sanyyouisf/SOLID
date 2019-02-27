using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    //To demonistrate Open Close Principle
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //default constractor 
        public Employee() { }

        //custome constractor
        public Employee(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public decimal CalculateBonus(decimal salary)
        {
            return salary * .03M;

        }

        //public override string ToString()
        //{
        //    //return base.ToString();
        //    return string.Format("Id: {0} - Name {1} "+ Id, Name);
        //}

    }
}
