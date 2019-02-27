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
            Employee EmpJhon = new Employee(2, "John", "temp");
            Console.WriteLine(string.Format("{0} - {1} - Bounus {2}" , EmpSany.ToString(), EmpSany.EmpType, EmpSany.CalculateBonus(50000).ToString()));
            Console.WriteLine(string.Format("{0} - {1} - Bounus {2}" , EmpJhon.ToString(), EmpJhon.EmpType, EmpJhon.CalculateBonus(150000).ToString()));


            Console.ReadLine();
        }
    }
}
