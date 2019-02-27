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
            Employee empSany = new Employee(1, "Sany");
            Employee empJhon = new Employee(2, "John");

            Console.WriteLine(string.Format("{0} - Bounus {1}", 
                              empSany.ToString(), 
                              empSany.CalculateBonus(50000).ToString()));

            Console.WriteLine(string.Format("{0} - Bounus {1}", 
                              empJhon.ToString(), 
                              empJhon.CalculateBonus(150000).ToString()));
            Console.WriteLine();
            Console.WriteLine();

            // after changing the emp design by adding the type bad design
            NewEmployee empWithTypeSany = new PerEmployee(1, "Sany", "permanent");
            NewEmployee empWithTypeJhon = new TempEmployee(2, "John", "temp");

            Console.WriteLine(string.Format("{0} - {1} - Bounus {2}",
                              empWithTypeSany.ToString(),
                              empWithTypeSany.EmpType,
                              empWithTypeSany.CalculateBonus(50000).ToString()));

            Console.WriteLine(string.Format("{0} - {1} - Bounus {2}",
                              empWithTypeJhon.ToString(),
                              empWithTypeJhon.EmpType,
                              empWithTypeJhon.CalculateBonus(150000).ToString()));
            Console.WriteLine();
            Console.WriteLine();


            //the new employee classwith good design    
            TempEmployee empTempSany = new TempEmployee(1,"Sany","Temp"); 
            PerEmployee empPerJhon = new PerEmployee(2,"Jhon","Per");

            Console.WriteLine(string.Format("tempropy Employee: {0} - {1} - Bonus: {2} ",
                              empTempSany.ToString(),
                              empTempSany.EmpType,
                              empTempSany.CalculateBonus(40000).ToString()));

            Console.WriteLine(string.Format("Permanent Employee: {0} - {1} - Bonus: {2} ",
                  empPerJhon.ToString(),
                  empPerJhon.EmpType,
                  empPerJhon.CalculateBonus(60000).ToString()));

            Console.ReadLine();
        }
    }
}
