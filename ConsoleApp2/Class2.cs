using IoC_DIP_DI_Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
        public class EmployeeBusinessLogic
        {
            EmployeeDataAccess _EmployeeDataAccess;
            public EmployeeBusinessLogic()
            {
                _EmployeeDataAccess = new EmployeeDataAccess();
            }
            public Employee GetEmployeeDetails(int id)
            {
                return _EmployeeDataAccess.GetEmployeeDetails(id);
            }
        }
}
