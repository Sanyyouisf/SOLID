using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    //Bad Design 
    //change the Employee class to add the type 
    public class EmpWithType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmpType { get; set; }

        //default constractor 
        public EmpWithType() { }

        //custom constractor
        public EmpWithType(int id, string name, string empType)
        {
            Id = id;
            Name = name;
            EmpType = empType;
        }

        public decimal CalculateBonus(decimal salary)
        {
            if (EmpType == "permanent")
            {
                return salary * .1M;
            }
            else
            {
                return salary * .3M;
            }

        }

        public override string ToString()
        {
            //return base.ToString();
            return string.Format("Id: {0} - Name: {1}", Id, Name);
        }

    }
}
