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
            List<Employee> employee = new List<Employee>()  
            {
                new("Петр Федоров Николаевич", 1, 10000),
                new("Алексей Киселев Валерьевич", 2, 20030),
                new("Никита Крючков Сергеевич", 3, 30200),
                new("Павел Поперечный Васильевич", 4, 40100),
                new("Андрей масло подсолнечное", 5, 12000)
            };

            int count = 0;
            double avgsalary = 0;

            PrintAllEmployees();
            GetTotalSalary();
            GetEmployeeWithMinSalary();
            GetEmployeeWithMaxSalary();
            GetAvgSalary();
            GetNumOfEmployees();
            IncreaseSalary();


            Console.WriteLine("Все ФИО:");
            PrintAllFullNames();


            Console.ReadKey();
            
             void PrintAllEmployees()
            {
                foreach (Employee emp in employee)
                {
                    if (employee != null)
                    {
                        Console.WriteLine("Employee ID: {0}", emp._id);
                        Console.WriteLine("Full Name: {0}", emp.FullName);
                        Console.WriteLine("Department: {0}", emp.Department);
                        Console.WriteLine("Salary: {0}", emp.Salary);
                        Console.WriteLine();
                    }
                }
            }
             void GetTotalSalary()
            {
                double totalSalary = 0;

                foreach (Employee emp in employee)
                {
                    if (emp != null)
                    {
                        totalSalary += emp.Salary;
                    }
                }

                Console.WriteLine( totalSalary );
            }

            void GetEmployeeWithMinSalary()
            {
                Console.WriteLine($" Минимальная зарплата {employee.Min(e => e.Salary)}");
            }

           void GetEmployeeWithMaxSalary()
            {
                Console.WriteLine($" Минимальная зарплата {employee.Max(e => e.Salary)}");
            }
            void GetAvgSalary()
            {
               foreach (var emp in employee)
                {
                    count++;
                    avgsalary += emp.Salary;

                }
               avgsalary /= count;
                Console.WriteLine( avgsalary );
            }

           void GetNumOfEmployees()
            {
                int count = 0;

                foreach (Employee emp in employee)
                {
                    if (emp != null)
                    {
                        count++;
                    }
                }

                Console.WriteLine(count);
            }

             void PrintAllFullNames()
            {
                foreach (Employee emp in employee)
                {
                    if (employee != null)
                    {
                        Console.WriteLine(emp.FullName);
                    }
                }
            }
             void IncreaseSalary()
            {
                Console.WriteLine("На сколько процентов вы хотите увеличить зарплаты?");
                int percentage = int.Parse(Console.ReadLine());
                foreach(var emp in employee)
                {
                   emp.Salary += emp.Salary * percentage / 100;
                }
                PrintAllEmployees();
            }
        }
        //Индексация зарплаты на определенный процент
        static void IndexSalary(Employee[] employees,int departament,double percent)
        {
            foreach (Employee employee in employees)
            {
                if (employee.Department == departament)
                {
                    employee.Salary *= (1 + percent / 100);
                }
            }
        }
    }

}
    













