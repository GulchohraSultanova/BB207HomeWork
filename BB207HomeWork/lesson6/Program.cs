using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB207HomeWork.lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            Department department = new Department();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("-----------Welcome my EmployeeApp-----------");
                Console.WriteLine();
                Console.WriteLine("Menu:");
                Console.WriteLine("1.Added Employee in Department!");
                Console.WriteLine("2.Show Employees in Department!");
                Console.WriteLine("3.Show Employees by Salary Range in Department!");
                Console.WriteLine("0.Exit EmployeeApp....");
                Console.WriteLine();
                int choice;
                Console.Write("Enter your choice: ");
                while (!int.TryParse(Console.ReadLine(), out choice ) )
                {
                    Console.WriteLine("Please enter correct choice!");
                    Console.Write("Enter your choice: ");
                }
                string name, surname, departmentName;
                byte age;
                int salary, minSalary, maxSalary;
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter employee name: ");

                        while (true)
                        {
                            name = Console.ReadLine();

                            if (!string.IsNullOrEmpty(name))
                            {
                                break;
                            }
                        }

                        Console.Write("Enter employee surname: ");
                        while (true)
                        {
                            surname = Console.ReadLine();


                            if (!string.IsNullOrEmpty(surname))
                            {
                                break;
                            }
                        }
                        Console.Write("Enter employee age: ");
                        while (!byte.TryParse(Console.ReadLine(), out age) || age <= 0)
                        {
                            Console.WriteLine("Please enter corret choice!");
                            Console.Write("Enter employee choice: ");
                        }

                        Console.Write("Enter employee department name: ");
                        while (true)
                        {
                            departmentName = Console.ReadLine();


                            if (!string.IsNullOrEmpty(departmentName))
                            {
                                break;
                            }
                        }
                        Console.Write("Enter employee salary: ");

                        while (!int.TryParse(Console.ReadLine(), out salary) || salary <= 0)
                        {
                            Console.WriteLine("Please enter correct salary!");
                            Console.Write("Enter employee salary: ");
                        }
                        Employee newEmployee = new Employee(name, surname, age, departmentName, salary);
                        department.AddEmployee(newEmployee);
                        break;
                    case 2:
                        {
                            department.ShowEmployeeInfo();
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Enter minimum salary: ");
                            while (!int.TryParse(Console.ReadLine(), out minSalary) || minSalary <= 0)
                            {
                                Console.WriteLine("Please enter correct minumum salary!");
                                Console.Write("Enter minimum salary: ");
                            }

                            Console.Write("Enter maximum salary: ");
                            while (!int.TryParse(Console.ReadLine(), out maxSalary) || maxSalary <= 0 || maxSalary < minSalary)
                            {
                                Console.WriteLine("Please enter correct maximum salary!");
                                Console.Write("Enter maximum salary: ");
                            }
                            Employee[] employyeSalary = department.GetAllEmployeesBySalary(minSalary, maxSalary);
                           
                            foreach (Employee emp in employyeSalary)
                            {
                                Console.WriteLine(emp.toString());
                            }
                            break;

                        }
                    case 0:
                        {
                            Console.WriteLine("Exit to EmployeeApp...!");
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        Console.WriteLine("Please enter correct choice!");
                        break;
                }
            }
        }
    }
}

