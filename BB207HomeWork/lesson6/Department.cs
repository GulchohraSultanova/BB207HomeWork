using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB207HomeWork.lesson6
{
     class Department
    {
        public Employee[] Employees = new Employee[0];


        //Bu metodla  Employees classina Employee elave edirik.
        public void AddEmployee(Employee employee)
        {
            Array.Resize(ref Employees, Employees.Length + 1);
            Employees[Employees.Length - 1] = employee;
            Console.WriteLine("Employee added!");
        }
        // Bu metodla Employees leri cixardiriq.
        public void ShowEmployeeInfo()
        {
            
            if(Employees.Length > 0 )
            {
                Console.WriteLine("Employees:");
                foreach (Employee employee in Employees)
                {

                    Console.WriteLine(employee.toString());
                }
            }
            else {
                Console.WriteLine("Employees is empty!");
                }

        }
        // Bu metodla Employeesleri qaytaririq.
        public Employee[] GetAllEmployees()
        {
            return Employees;
        }
        //Bu metod minSalary və int maxSalary qəbul edir,
        //bu maaş aralığındakı işçiləri geri qaytarır
        public Employee[] GetAllEmployeesBySalary(int minSalary, int maxSalary)
        {
            bool flag=false;

            Employee[] salaryEmployee = new Employee[0];
            foreach (Employee employee in Employees)
            {
                if (employee.Salary >= minSalary && employee.Salary <= maxSalary)
                {
                    flag = true;
                    Array.Resize(ref salaryEmployee, salaryEmployee.Length + 1);
                    salaryEmployee[salaryEmployee.Length - 1] = employee;
                }
               
            }
            if(flag)
            {
                Console.WriteLine("Employees of department in this salary range:");
               
            }
            else
            {
                Console.WriteLine("No employee in this salary range.");
            }
            return salaryEmployee;


        }
    }
}
