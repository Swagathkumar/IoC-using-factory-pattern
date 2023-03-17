using IoC_DIP_DI_Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   
        class Program
        {
            static void Main(string[] args)
            {
                EmployeeBusinessLogic BL = new EmployeeBusinessLogic();
                Employee employeeDetails = BL.GetEmployeeDetails(1);
                Console.WriteLine();
                Console.WriteLine("Employee Details:");
                Console.WriteLine("ID : {0}, Name : {1}, Department : {2}, Salary : {3}",
                                    employeeDetails.ID, employeeDetails.Name, employeeDetails.Department,
                                    employeeDetails.Salary);
                Console.ReadKey();
            }
        }
}
