using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yrokk_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee.AddEmployee(new Employee("Петр Федоров Николаевич", 1, 10000));
            Employee.AddEmployee(new Employee("Алексей Киселев Валерьевич", 2, 20030));
            Employee.AddEmployee(new Employee("Никита Крючков Сергеевич", 3, 30200));
            Employee.AddEmployee(new Employee("Павел Поперечный Васильевич", 4, 40100));
            Employee.AddEmployee(new Employee("Андрей масло подсолнечное", 5, 12000));

            Employee.PrintAllEmployees();
            Console.WriteLine("Total Salary: {0}", Employee.GetTotalSalary());
            Console.
WriteLine("Employee with Min Salary: {0}", Employee.GetEmployeeWithMinSalary().FullName);
            Console.WriteLine("Employee with Max Salary: {0}", Employee.GetEmployeeWithMaxSalary().FullName);
            Console.WriteLine("Average Salary: {0}", Employee.GetAvgSalary());
            Console.WriteLine("Number of Employees: {0}", Employee.GetNumOfEmployees());


            Console.WriteLine("Все ФИО:");
            Employee.PrintAllFullNames();


            Console.ReadKey();
        }
    }

}
    













