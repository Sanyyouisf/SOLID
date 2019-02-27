using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            // to display the bonus
            Employee EmpSany = new Employee(1, "Sany", "permanent");
            Console.WriteLine(string.Format("{0} - {1} - Bounus {2}" ,EmpSany.ToString(),EmpSany.EmpType ,EmpSany.CalculateBonus(50000).ToString()));


            Console.ReadLine();
        }
    }
}
