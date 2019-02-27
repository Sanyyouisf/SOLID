using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_L
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee empSany = new PerEmp(1, "Sany",2000);
            Employee empJhon = new TempEmp(2, "John",3000);

            Console.WriteLine(string.Format("{0} - Min salary {1} - Bounus {2}",
                              empSany.ToString(),
                              empSany.GetMinSalary(),
                              empSany.GetBonus().ToString()));

            Console.WriteLine(string.Format("{0} - Min salary {1} - Bounus {2}",
                              empJhon.ToString(),
                              empJhon.GetMinSalary(),
                              empJhon.GetBonus().ToString()));
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine();

            IEmployee contEmp = new ContractEmp(3, "Sam",2500);
            Console.WriteLine(string.Format("{0} - Min Salary {1}",
                              contEmp.ToString(),
                              contEmp.GetMinSalary()));

            Console.WriteLine();
            Console.WriteLine("========================================");
            Console.WriteLine("Employee List");     
            Console.WriteLine();

            List<IEmployee> empList = new List<IEmployee>();

            empList.Add(new PerEmp(1, "Sany",2000));
            empList.Add(new TempEmp(2, "John",3000));
            empList.Add(new ContractEmp(3, "Sam",2500));

            foreach (IEmployee emp in empList)
            {
                Console.WriteLine(string.Format("{0} - Min salary {1} ",
                                  emp.ToString(),
                                  emp.GetMinSalary()));
            }
            Console.WriteLine();
            Console.WriteLine("====================");
            Console.WriteLine("Employee List with Bonus eleigability only");
            Console.WriteLine();

            List<Employee> empListBonus = new List<Employee>();

            empListBonus.Add(new PerEmp(1, "Sany", 2000));
            empListBonus.Add(new TempEmp(2, "John",3000));

            foreach (Employee emp in empListBonus)
            {
                Console.WriteLine(string.Format("{0} - Min salary {1} - Bonus {2}",
                                  emp.ToString(),
                                  emp.GetMinSalary(),
                                  emp.GetBonus()));
            }

            Console.ReadLine();

        }
    }
}
